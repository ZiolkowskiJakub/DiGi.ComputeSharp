using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a point to the pair of points defined by two coordinates within the specified tolerance, filling the first free (NaN) slot.
        /// </summary>
        /// <param name="point_1">The first endpoint of the pair.</param>
        /// <param name="point_2">The second endpoint of the pair.</param>
        /// <param name="point">The point to be added.</param>
        /// <param name="tolerance">The tolerance value for the operation.</param>
        /// <returns>True if the point was successfully added; otherwise, false.</returns>
        public static bool Add(ref Coordinate2 point_1, ref Coordinate2 point_2, Coordinate2 point, double tolerance)
        {
            if (point.IsNaN())
            {
                return false;
            }

            if (point_1.IsNaN())
            {
                point_1 = point;
                return true;
            }
            else if (point_1.AlmostEquals(point, tolerance))
            {
                return false;
            }

            if (point_2.IsNaN())
            {
                point_2 = point;
                return true;
            }
            else if (point_2.AlmostEquals(point, tolerance))
            {
                return false;
            }

            return false;
        }
    }
}
