using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        public static IEnumerable<Line3Intersection>? Line3Intersections(Line3 line, IEnumerable<Line3>? lines, double tolerance)
        {
            if (line.IsNaN() || lines == null || !lines.Any())
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            int threadsCount = 1024;

            Line3IntersectionComputeShader line3IntersectionComputeShader = new(graphicsDevice, line, lines, tolerance, threadsCount);

            graphicsDevice.For(threadsCount, line3IntersectionComputeShader);

            return Core.Create.List(line3IntersectionComputeShader.LineIntersections, x => x is Line3Intersection line3Intersection && line3Intersection.IsNaN());
        }
    }
}