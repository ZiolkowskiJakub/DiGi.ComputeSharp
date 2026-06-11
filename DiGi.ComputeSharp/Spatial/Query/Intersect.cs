using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Performs an intersection test between a collection of 3D lines and a buffer of 3D triangles using the specified graphics device.
        /// </summary>
        /// <param name="graphicDevice">The graphics device used to perform the intersection calculations.</param>
        /// <param name="line3s">An enumerable collection of 3D lines to be tested for intersections.</param>
        /// <param name="triangle3s">A read-only buffer containing the 3D triangles to test against.</param>
        /// <param name="includeStart">If set to <c>true</c>, includes the start point of each line in the intersection check.</param>
        /// <param name="includeEnd">If set to <c>true</c>, includes the end point of each line in the intersection check.</param>
        /// <returns>A list of boolean values indicating whether each corresponding line intersects any triangle, or <c>null</c> if the operation failed.</returns>
        public static List<bool>? Intersect(this GraphicsDevice? graphicDevice, IEnumerable<Line3>? line3s, ReadOnlyBuffer<Triangle3>? triangle3s, bool includeStart, bool includeEnd)
        {
            if (line3s == null || triangle3s == null || triangle3s.Length == 0 || graphicDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Line3> line3s_Temp = graphicDevice.AllocateReadOnlyBuffer(line3s.ToArray());
            ReadWriteBuffer<int> result = graphicDevice.AllocateReadWriteBuffer<int>(line3s_Temp.Length);

            graphicDevice.For(line3s_Temp.Length, new Line3IntersectComputeShader(line3s_Temp, triangle3s, result, includeStart, includeEnd));

            return Core.Create.List(result)?.ConvertAll(x => x != -1);
        }

        /// <summary>
        /// Determines whether a 3D line intersects any of the triangles contained within the specified read-only buffer.
        /// </summary>
        /// <param name="graphicDevice">The graphics device used to perform the intersection calculation.</param>
        /// <param name="line3">The 3D line to test for intersection.</param>
        /// <param name="triangle3s">A read-only buffer containing the triangles to be tested against the line.</param>
        /// <param name="includeStart">If set to <c>true</c>, includes the start point of the line in the intersection test.</param>
        /// <param name="includeEnd">If set to <c>true</c>, includes the end point of the line in the intersection test.</param>
        /// <returns>True if an intersection is found; otherwise, false.</returns>
        public static bool Intersect(this GraphicsDevice graphicDevice, Line3 line3, ReadOnlyBuffer<Triangle3> triangle3s, bool includeStart, bool includeEnd)
        {
            List<bool>? result = Intersect(graphicDevice, [line3], triangle3s, includeStart, includeEnd);
            if (result == null || result.Count == 0)
            {
                return false;
            }

            return result[0];
        }

        /// <summary>
        /// Determines whether each line in the provided collection intersects with any of the specified 3D triangles.
        /// </summary>
        /// <param name="line3s">The collection of 3D lines to evaluate for intersections.</param>
        /// <param name="triangle3s">The collection of 3D triangles to test against.</param>
        /// <param name="includeStart">If set to <c>true</c>, the start point of the line is included in the intersection calculation.</param>
        /// <param name="includeEnd">If set to <c>true</c>, the end point of the line is included in the intersection calculation.</param>
        /// <returns>A list of boolean values indicating the intersection result for each input line, or <c>null</c> if the input collections are null.</returns>
        public static List<bool>? Intersect(IEnumerable<Line3>? line3s, IEnumerable<Triangle3>? triangle3s, bool includeStart, bool includeEnd)
        {
            if (line3s == null || triangle3s == null)
            {
                return null;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return null;
            }

            ReadOnlyBuffer<Triangle3> triangle3s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());

            return Intersect(graphicDevice, line3s, triangle3s_Temp, includeStart, includeEnd);
        }

        /// <summary>
        /// Determines whether a specified line segment intersects with any triangle in the provided collection.
        /// </summary>
        /// <param name="line3">The line segment to evaluate for intersection.</param>
        /// <param name="triangle3s">A collection of triangles to check against the line segment.</param>
        /// <param name="includeStart">Indicates whether the start point of the line should be included in the intersection test.</param>
        /// <param name="includeEnd">Indicates whether the end point of the line should be included in the intersection test.</param>
        /// <returns>True if an intersection is found; otherwise, false.</returns>
        public static bool Intersect(Line3 line3, IEnumerable<Triangle3>? triangle3s, bool includeStart, bool includeEnd)
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

            return Intersect(graphicDevice, line3, triangle3s_Temp, includeStart, includeEnd);
        }
    }
}