using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the first coordinate from a set of six provided points.
        /// </summary>
        /// <param name="point_1">The first coordinate point.</param>
        /// <param name="point_2">The second coordinate point.</param>
        /// <param name="point_3">The third coordinate point.</param>
        /// <param name="point_4">The fourth coordinate point.</param>
        /// <param name="point_5">The fifth coordinate point.</param>
        /// <param name="point_6">The sixth coordinate point.</param>
        /// <returns>The resulting Coordinate3 point.</returns>
        public static Coordinate3 First(Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3, Coordinate3 point_4, Coordinate3 point_5, Coordinate3 point_6)
        {
            if (!point_1.IsNaN())
            {
                return point_1;
            }

            if (!point_2.IsNaN())
            {
                return point_2;
            }

            if (!point_3.IsNaN())
            {
                return point_3;
            }

            if (!point_4.IsNaN())
            {
                return point_4;
            }

            if (!point_5.IsNaN())
            {
                return point_5;
            }

            return point_6;
        }
    }
}