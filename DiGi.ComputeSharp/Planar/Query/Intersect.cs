using ComputeSharp;
using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Performs an intersection test between a collection of 2D lines and a buffer of 2D triangles using the specified graphics device.
        /// </summary>
        /// <param name="graphicDevice">The graphics device used to perform the intersection calculations.</param>
        /// <param name="line2s">An enumerable collection of 2D lines to be tested for intersections.</param>
        /// <param name="triangle2s">A read-only buffer containing the 2D triangles to test against.</param>
        /// <param name="includeStart">If set to <c>true</c>, includes the start point of each line in the intersection check.</param>
        /// <param name="includeEnd">If set to <c>true</c>, includes the end point of each line in the intersection check.</param>
        /// <returns>A list of boolean values indicating whether each corresponding line intersects any triangle, or <c>null</c> if the operation failed.</returns>
        public static List<bool>? Intersect(this GraphicsDevice? graphicDevice, IEnumerable<Line2>? line2s, ReadOnlyBuffer<Triangle2>? triangle2s, bool includeStart, bool includeEnd)
        {
            if (line2s == null || triangle2s == null || triangle2s.Length == 0 || graphicDevice == null)
            {
                return null;
            }

            using ReadOnlyBuffer<Line2> line2s_Temp = graphicDevice.AllocateReadOnlyBuffer(line2s.ToArray());
            using ReadWriteBuffer<int> result = graphicDevice.AllocateReadWriteBuffer<int>(line2s_Temp.Length);

            graphicDevice.For(line2s_Temp.Length, new Line2IntersectComputeShader(line2s_Temp, triangle2s, result, includeStart, includeEnd));

            return Core.Create.List(result)?.ConvertAll(x => x != -1);
        }

        /// <summary>
        /// Determines whether a 2D line intersects any of the triangles contained within the specified read-only buffer.
        /// </summary>
        /// <param name="graphicDevice">The graphics device used to perform the intersection calculation.</param>
        /// <param name="line2">The 2D line to test for intersection.</param>
        /// <param name="triangle2s">A read-only buffer containing the triangles to be tested against the line.</param>
        /// <param name="includeStart">If set to <c>true</c>, includes the start point of the line in the intersection test.</param>
        /// <param name="includeEnd">If set to <c>true</c>, includes the end point of the line in the intersection test.</param>
        /// <returns>True if an intersection is found; otherwise, false.</returns>
        public static bool Intersect(this GraphicsDevice graphicDevice, Line2 line2, ReadOnlyBuffer<Triangle2> triangle2s, bool includeStart, bool includeEnd)
        {
            List<bool>? result = Intersect(graphicDevice, [line2], triangle2s, includeStart, includeEnd);
            if (result == null || result.Count == 0)
            {
                return false;
            }

            return result[0];
        }

        /// <summary>
        /// Determines whether each line in the provided collection intersects with any of the specified 2D triangles.
        /// </summary>
        /// <param name="line2s">The collection of 2D lines to evaluate for intersections.</param>
        /// <param name="triangle2s">The collection of 2D triangles to test against.</param>
        /// <param name="includeStart">If set to <c>true</c>, the start point of the line is included in the intersection calculation.</param>
        /// <param name="includeEnd">If set to <c>true</c>, the end point of the line is included in the intersection calculation.</param>
        /// <returns>A list of boolean values indicating the intersection result for each input line, or <c>null</c> if the input collections are null.</returns>
        public static List<bool>? Intersect(IEnumerable<Line2>? line2s, IEnumerable<Triangle2>? triangle2s, bool includeStart, bool includeEnd)
        {
            if (line2s == null || triangle2s == null)
            {
                return null;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return null;
            }

            using ReadOnlyBuffer<Triangle2> triangle2s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangle2s.ToArray());

            return Intersect(graphicDevice, line2s, triangle2s_Temp, includeStart, includeEnd);
        }

        /// <summary>
        /// Determines whether a specified line segment intersects with any triangle in the provided collection.
        /// </summary>
        /// <param name="line2">The line segment to evaluate for intersection.</param>
        /// <param name="triangle2s">A collection of triangles to check against the line segment.</param>
        /// <param name="includeStart">Indicates whether the start point of the line should be included in the intersection test.</param>
        /// <param name="includeEnd">Indicates whether the end point of the line should be included in the intersection test.</param>
        /// <returns>True if an intersection is found; otherwise, false.</returns>
        public static bool Intersect(Line2 line2, IEnumerable<Triangle2>? triangle2s, bool includeStart, bool includeEnd)
        {
            if (line2.IsNaN() || triangle2s == null)
            {
                return false;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return false;
            }

            using ReadOnlyBuffer<Triangle2> triangle2s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangle2s.ToArray());

            return Intersect(graphicDevice, line2, triangle2s_Temp, includeStart, includeEnd);
        }
    }
}
