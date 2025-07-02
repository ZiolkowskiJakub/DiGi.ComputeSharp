using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static List<int> Inside(this GraphicsDevice graphicDevice, IEnumerable<Coordinate3> points, ReadOnlyBuffer<Triangle3> triangles, double tolerance)
        {
            if (points == null || triangles == null || triangles.Length == 0 || graphicDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Coordinate3> points_Temp = graphicDevice.AllocateReadOnlyBuffer(points.ToArray());
            ReadWriteBuffer<int> result = graphicDevice.AllocateReadWriteBuffer<int>(points_Temp.Length);

            graphicDevice.For(points_Temp.Length, new Coordinate3InsideComputeShader(points_Temp, triangles, result));

            return Core.Create.List(result);
        }

        public static int Inside(this GraphicsDevice graphicDevice, Coordinate3 point, ReadOnlyBuffer<Triangle3> triangles, double tolerance)
        {
            List<int> result = Inside(graphicDevice, [point], triangles, tolerance);
            if(result == null || result.Count == 0)
            {
                return -1;
            }

            return result[0];
        }

        public static List<int> Inside(IEnumerable<Coordinate3> points, IEnumerable<Triangle3> triangles, double tolerance)
        {
            if(points == null || triangles == null)
            {
                return null;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if(graphicDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Triangle3> triangle3s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangles.ToArray());

            return Inside(graphicDevice, points, triangle3s_Temp, tolerance);
        }

        public static int Inside(Coordinate3 point, IEnumerable<Triangle3> triangles, double tolerance)
        {
            if (point.IsNaN() || triangles == null)
            {
                return -1;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return -1;
            }

            ReadOnlyBuffer<Triangle3> triangle3s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangles.ToArray());

            return Inside(graphicDevice, point, triangle3s_Temp, tolerance);
        }
    }

}

