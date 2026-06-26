using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the intersections between a specified line and a collection of other lines using GPU acceleration.
        /// </summary>
        /// <param name="line">The primary line to check for intersections.</param>
        /// <param name="lines">The collection of lines to test against the primary line.</param>
        /// <param name="tolerance">The distance tolerance used to determine if two lines are intersecting.</param>
        /// <returns>A collection of <see cref="Classes.Line3Intersection"/> results, or <c>null</c> if the input line is invalid, the lines collection is empty/null, or the graphics device is unavailable.</returns>
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

            using ReadOnlyBuffer<Line3> linesBuffer = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            using ReadWriteBuffer<Line3Intersection> intersectionsBuffer = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[linesBuffer.Length]);

            Line3IntersectionComputeShader line3IntersectionComputeShader = new(line, linesBuffer, intersectionsBuffer, tolerance, threadsCount);

            graphicsDevice.For(threadsCount, line3IntersectionComputeShader);

            return Core.Create.List(intersectionsBuffer, x => x is Line3Intersection line3Intersection && !line3Intersection.IsNaN());
        }
    }
}