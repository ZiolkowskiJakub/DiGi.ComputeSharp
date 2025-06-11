using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {

        public static IEnumerable<Line3Intersection> Line3Intersections(Line3 line, IEnumerable<Line3> lines, float tolerance)
        {
            if (line.IsNaN() || lines == null || lines.Count() == 0)
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            int threadsCount = 1024;

            Line3IntersectionComputeShader line3IntersectionComputeShader = new Line3IntersectionComputeShader(graphicsDevice, line, lines, tolerance, threadsCount);

            graphicsDevice.For(threadsCount, line3IntersectionComputeShader);


            return Core.Create.List(line3IntersectionComputeShader.LineIntersections, x => !x.IsNaN());

        }
    }
}
