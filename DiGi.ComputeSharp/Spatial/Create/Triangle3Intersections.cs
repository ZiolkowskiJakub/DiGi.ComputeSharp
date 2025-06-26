using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {

        public static IEnumerable<Triangle3Intersection> Triangle3Intersections(Triangle3 triangle, IEnumerable<Triangle3> triangles, float tolerance)
        {
            if (triangle.IsNaN() || triangles == null || triangles.Count() == 0)
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            int threadsCount = 1024;

            Triangle3IntersectionComputeShader triangle3IntersectionComputeShader = new Triangle3IntersectionComputeShader(graphicsDevice, triangle, triangles, tolerance, threadsCount);

            graphicsDevice.For(threadsCount, triangle3IntersectionComputeShader);

            return Core.Create.List(triangle3IntersectionComputeShader.TriangleIntersections, x => !x.IsNaN());

        }

        public static IEnumerable<Triangle3Intersection> Triangle3Intersections(IEnumerable<Triangle3> triangles_1, IEnumerable<Triangle3> triangles_2, float tolerance)
        {
            if (triangles_1 == null || triangles_1.Count() == 0 || triangles_2 == null || triangles_2.Count() == 0)
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Triangle3> triangles_2_Temp = graphicsDevice.AllocateReadOnlyBuffer(triangles_2.ToArray());

            ReadWriteBuffer<Triangle3Intersection> triangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles_2.Count()]);

            int threadsCount = 1024;

            List<Triangle3Intersection> result = new List<Triangle3Intersection>();
            foreach (Triangle3 triangle in triangles_1)
            {
                Triangle3IntersectionComputeShader triangle3IntersectionComputeShader = new Triangle3IntersectionComputeShader(triangle, triangles_2_Temp, triangleIntersections, tolerance, threadsCount);
                graphicsDevice.For(threadsCount, triangle3IntersectionComputeShader);

                List<Triangle3Intersection> triangle3Intersections_Temp = Core.Create.List(triangle3IntersectionComputeShader.TriangleIntersections, x => !x.IsNaN());
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
