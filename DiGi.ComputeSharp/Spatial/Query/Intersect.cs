using ComputeSharp;
using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static List<bool> Intersect(this GraphicsDevice graphicDevice, IEnumerable<Line3> line3s, ReadOnlyBuffer<Triangle3> triangle3s, double tolerance)
        {
            if (line3s == null || triangle3s == null || triangle3s.Length == 0 || graphicDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Line3> line3s_Temp = graphicDevice.AllocateReadOnlyBuffer(line3s.ToArray());
            ReadWriteBuffer<float> result = graphicDevice.AllocateReadWriteBuffer<float>(line3s_Temp.Length);

            graphicDevice.For(line3s_Temp.Length, new Line3IntersectComputeShader(line3s_Temp, triangle3s, result));

            return Core.Create.List(result).ConvertAll(x => x == 1.0f);
        }

        public static bool Intersect(this GraphicsDevice graphicDevice, Line3 line3, ReadOnlyBuffer<Triangle3> triangle3s, double tolerance)
        {
            List<bool> result = Intersect(graphicDevice, [line3], triangle3s, tolerance);
            if(result == null || result.Count == 0)
            {
                return false;
            }

            return result[0];
        }

        public static List<bool> Intersect(IEnumerable<Line3> line3s, IEnumerable<Triangle3> triangle3s, double tolerance)
        {
            if(line3s == null || triangle3s == null)
            {
                return null;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if(graphicDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Triangle3> triangle3s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());

            return Intersect(graphicDevice, line3s, triangle3s_Temp, tolerance);
        }

        public static bool Intersect(Line3 line3, IEnumerable<Triangle3> triangle3s, double tolerance)
        {
            if (line3.IsNaN() || triangle3s == null)
            {
                return false;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return false;
            }

            ReadOnlyBuffer<Triangle3> triangle3s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());

            return Intersect(graphicDevice, line3, triangle3s_Temp, tolerance);
        }
    }

}

