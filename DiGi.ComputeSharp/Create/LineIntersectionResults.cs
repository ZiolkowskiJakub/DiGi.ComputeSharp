using ComputeSharp;
using DiGi.ComputeSharp.Classes;
using DiGi.ComputeSharp.Constans;

namespace DiGi.ComputeSharp
{
    public static partial class Create
    {
        public static List<LineIntersectionResult> LineIntersectionResults(this Line3 line, IEnumerable<Classes.Triangle3> triangles, float tolerance = Tolerance.Distance)
        {
            if(triangles == null)
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if(graphicsDevice == null)
            {
                return null;
            }

            int threadsCount = 1024;

            LineIntersectionComputeShader lineIntersectionComputeShader = new LineIntersectionComputeShader(graphicsDevice, line, triangles, tolerance, threadsCount);

            graphicsDevice.For(threadsCount, lineIntersectionComputeShader);


            return List(lineIntersectionComputeShader.LineIntersectionResults, x => !x.IsNaN());
        }

        public static List<LineIntersectionResult> LineIntersectionResults(this IEnumerable<Line3> lines, IEnumerable<Classes.Triangle3> triangles, float tolerance = Tolerance.Distance)
        {
            if (triangles == null)
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            LinesIntersectionComputeShader linesIntersectionComputeShader = new LinesIntersectionComputeShader(graphicsDevice, lines, triangles, tolerance);

            graphicsDevice.For(lines.Count(), linesIntersectionComputeShader);


            return List(linesIntersectionComputeShader.LineIntersectionResults, x => !x.IsNaN());
        }
    }
}
