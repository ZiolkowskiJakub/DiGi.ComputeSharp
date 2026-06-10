using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the intersections between a single triangle and a collection of triangles using GPU acceleration.
        /// </summary>
        /// <param name="triangle">The source triangle to check for intersections.</param>
        /// <param name="triangles">The collection of triangles to intersect against.</param>
        /// <param name="tolerance">The numerical tolerance used for intersection calculations.</param>
        /// <returns>A collection of <see cref="Triangle3Intersection"/> results, or <c>null</c> if the input is invalid or no graphics device is available.</returns>
        public static IEnumerable<Triangle3Intersection>? Triangle3Intersections(this Triangle3 triangle, IEnumerable<Triangle3> triangles, double tolerance)
        {
            if (triangle.IsNaN() || triangles == null || !triangles.Any())
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            int threadsCount = 1024;

            Triangle3IntersectionComputeShader triangle3IntersectionComputeShader = new(graphicsDevice, triangle, triangles, tolerance, threadsCount);

            graphicsDevice.For(threadsCount, triangle3IntersectionComputeShader);

            return Core.Create.List(triangle3IntersectionComputeShader.TriangleIntersections, x => x is Triangle3Intersection triangle3Intersection && !triangle3Intersection.IsNaN());
        }

        /// <summary>
        /// Calculates the intersections between two collections of triangles using GPU acceleration.
        /// </summary>
        /// <param name="triangles_1">The first collection of triangles.</param>
        /// <param name="triangles_2">The second collection of triangles.</param>
        /// <param name="tolerance">The numerical tolerance used for intersection calculations.</param>
        /// <returns>A collection of <see cref="Triangle3Intersection"/> results, or <c>null</c> if either input collection is null or empty, or no graphics device is available.</returns>
        public static IEnumerable<Triangle3Intersection>? Triangle3Intersections(this IEnumerable<Triangle3> triangles_1, IEnumerable<Triangle3> triangles_2, double tolerance)
        {
            if (triangles_1 == null || !triangles_1.Any() || triangles_2 == null || !triangles_2.Any())
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Triangle3> triangles_2_Temp = graphicsDevice.AllocateReadOnlyBuffer(triangles_2.ToArray());

            return Triangle3Intersections(graphicsDevice, triangles_1, triangles_2_Temp, tolerance);
        }

        /// <summary>
        /// Calculates the intersections between a collection of triangles and a GPU read-only buffer of triangles.
        /// </summary>
        /// <param name="graphicsDevice">The <see cref="GraphicsDevice"/> to be used for the computation.</param>
        /// <param name="triangles_1">The first collection of triangles.</param>
        /// <param name="triangles_2">A read-only buffer containing the second collection of triangles.</param>
        /// <param name="tolerance">The numerical tolerance used for intersection calculations.</param>
        /// <returns>A collection of <see cref="Triangle3Intersection"/> results, or <c>null</c> if any input parameters are null.</returns>
        public static IEnumerable<Triangle3Intersection>? Triangle3Intersections(this GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles_1, ReadOnlyBuffer<Triangle3> triangles_2, double tolerance)
        {
            if (graphicsDevice == null || triangles_1 == null || triangles_2 == null)
            {
                return null;
            }

            ReadWriteBuffer<Triangle3Intersection> triangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles_2.Length]);

            int threadsCount = 1024;

            List<Triangle3Intersection> result = [];
            foreach (Triangle3 triangle in triangles_1)
            {
                Triangle3IntersectionComputeShader triangle3IntersectionComputeShader = new(triangle, triangles_2, triangleIntersections, tolerance, threadsCount);
                graphicsDevice.For(threadsCount, triangle3IntersectionComputeShader);

                List<Triangle3Intersection>? triangle3Intersections_Temp = Core.Create.List(triangle3IntersectionComputeShader.TriangleIntersections, x => x is Triangle3Intersection triangle3Intersection && !triangle3Intersection.IsNaN());
                if (triangle3Intersections_Temp == null)
                {
                    continue;
                }

                result.AddRange(triangle3Intersections_Temp);
            }

            return result;
        }
    }
}