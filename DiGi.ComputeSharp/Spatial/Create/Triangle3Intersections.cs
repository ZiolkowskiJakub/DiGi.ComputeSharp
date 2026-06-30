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
        /// <returns>A collection of <see cref="Classes.Triangle3Intersection"/> results, or <c>null</c> if the input is invalid or no graphics device is available.</returns>
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

            using ReadOnlyBuffer<Triangle3> trianglesBuffer = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            using ReadWriteBuffer<Triangle3Intersection> intersectionsBuffer = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[trianglesBuffer.Length]);

            Triangle3IntersectionComputeShader triangle3IntersectionComputeShader = new(triangle, trianglesBuffer, intersectionsBuffer, tolerance);

            graphicsDevice.For(trianglesBuffer.Length, triangle3IntersectionComputeShader);

            return Core.Create.List(intersectionsBuffer, x => x is Triangle3Intersection triangle3Intersection && !triangle3Intersection.IsNaN());
        }

        /// <summary>
        /// Calculates the intersections between two collections of triangles using GPU acceleration.
        /// </summary>
        /// <param name="triangles_1">The first collection of triangles.</param>
        /// <param name="triangles_2">The second collection of triangles.</param>
        /// <param name="tolerance">The numerical tolerance used for intersection calculations.</param>
        /// <returns>A collection of <see cref="Classes.Triangle3Intersection"/> results, or <c>null</c> if either input collection is null or empty, or no graphics device is available.</returns>
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

            using ReadOnlyBuffer<Triangle3> triangles_2_Temp = graphicsDevice.AllocateReadOnlyBuffer(triangles_2.ToArray());

            return Triangle3Intersections(graphicsDevice, triangles_1, triangles_2_Temp, tolerance);
        }

        /// <summary>
        /// Calculates the intersections between a collection of triangles and a GPU read-only buffer of triangles.
        /// </summary>
        /// <param name="graphicsDevice">The <see cref="GraphicsDevice"/> to be used for the computation.</param>
        /// <param name="triangles_1">The first collection of triangles.</param>
        /// <param name="triangles_2">A read-only buffer containing the second collection of triangles.</param>
        /// <param name="tolerance">The numerical tolerance used for intersection calculations.</param>
        /// <returns>A collection of <see cref="Classes.Triangle3Intersection"/> results, or <c>null</c> if any input parameters are null.</returns>
        public static IEnumerable<Triangle3Intersection>? Triangle3Intersections(this GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles_1, ReadOnlyBuffer<Triangle3> triangles_2, double tolerance)
        {
            if (graphicsDevice == null || triangles_1 == null || triangles_2 == null)
            {
                return null;
            }

            Triangle3[] triangles_1_Temp = triangles_1 as Triangle3[] ?? triangles_1.ToArray();

            int count_1 = triangles_1_Temp.Length;
            int count_2 = triangles_2.Length;
            if (count_1 == 0 || count_2 == 0)
            {
                return [];
            }

            // Single 2D dispatch over the full triangles_1 x triangles_2 grid (one kernel launch, one read-back),
            // replacing the previous per-triangle dispatch + full buffer read-back loop. The output is laid out
            // row-major (row = triangles_1 index, column = triangles_2 index), so filtering the read-back in
            // buffer order yields the same row-major, non-NaN ordering as the previous implementation.
            using ReadOnlyBuffer<Triangle3> triangles_1_Buffer = graphicsDevice.AllocateReadOnlyBuffer(triangles_1_Temp);
            using ReadWriteBuffer<Triangle3Intersection> triangleIntersections = graphicsDevice.AllocateReadWriteBuffer<Triangle3Intersection>(count_1 * count_2);

            graphicsDevice.For(count_1, count_2, new Triangle3IntersectionsComputeShader(triangles_1_Buffer, triangles_2, triangleIntersections, tolerance));

            return Core.Create.List(triangleIntersections, x => x is Triangle3Intersection triangle3Intersection && !triangle3Intersection.IsNaN());
        }
    }
}