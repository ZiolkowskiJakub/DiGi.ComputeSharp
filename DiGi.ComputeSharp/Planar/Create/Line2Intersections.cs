using ComputeSharp;
using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the intersections between a specified line and a collection of other lines using GPU acceleration.
        /// </summary>
        /// <param name="line">The primary line to check for intersections.</param>
        /// <param name="lines">The collection of lines to test against the primary line.</param>
        /// <param name="tolerance">The distance tolerance used to determine if two lines are intersecting.</param>
        /// <returns>A collection of <see cref="Classes.Line2Intersection"/> results, or <c>null</c> if the input line is invalid, the lines collection is empty/null, or the graphics device is unavailable.</returns>
        public static IEnumerable<Line2Intersection>? Line2Intersections(Line2 line, IEnumerable<Line2>? lines, double tolerance)
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

            using ReadOnlyBuffer<Line2> linesBuffer = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            using ReadWriteBuffer<Line2Intersection> intersectionsBuffer = graphicsDevice.AllocateReadWriteBuffer(new Line2Intersection[linesBuffer.Length]);

            Line2IntersectionComputeShader line2IntersectionComputeShader = new(line, linesBuffer, intersectionsBuffer, tolerance);

            graphicsDevice.For(linesBuffer.Length, line2IntersectionComputeShader);

            return Core.Create.List(intersectionsBuffer, x => x is Line2Intersection line2Intersection && !line2Intersection.IsNaN());
        }

        /// <summary>
        /// Calculates the intersections between a collection of lines and a collection of triangles using GPU acceleration.
        /// </summary>
        /// <param name="lines">The collection of lines to test.</param>
        /// <param name="triangles">The collection of triangles to intersect against.</param>
        /// <param name="tolerance">The distance tolerance used to determine intersections.</param>
        /// <returns>A collection of <see cref="Classes.Line2Intersection"/> results laid out row-major (row = line index, column = triangle index) with NaN results filtered out, or <c>null</c> if either input collection is null/empty or the graphics device is unavailable.</returns>
        public static IEnumerable<Line2Intersection>? Line2Intersections(IEnumerable<Line2>? lines, IEnumerable<Triangle2>? triangles, double tolerance)
        {
            if (lines == null || !lines.Any() || triangles == null || !triangles.Any())
            {
                return null;
            }

            using GraphicsDevice graphicsDevice = GraphicsDevice.GetDefault();
            if (graphicsDevice == null)
            {
                return null;
            }

            Line2[] lines_Temp = lines as Line2[] ?? lines.ToArray();
            Triangle2[] triangles_Temp = triangles as Triangle2[] ?? triangles.ToArray();

            int count_1 = lines_Temp.Length;
            int count_2 = triangles_Temp.Length;

            using ReadOnlyBuffer<Line2> linesBuffer = graphicsDevice.AllocateReadOnlyBuffer(lines_Temp);
            using ReadOnlyBuffer<Triangle2> trianglesBuffer = graphicsDevice.AllocateReadOnlyBuffer(triangles_Temp);
            using ReadWriteBuffer<Line2Intersection> intersectionsBuffer = graphicsDevice.AllocateReadWriteBuffer<Line2Intersection>(count_1 * count_2);

            graphicsDevice.For(count_1, count_2, new Line2IntersectionsComputeShader(linesBuffer, trianglesBuffer, intersectionsBuffer, tolerance));

            return Core.Create.List(intersectionsBuffer, x => x is Line2Intersection line2Intersection && !line2Intersection.IsNaN());
        }
    }
}
