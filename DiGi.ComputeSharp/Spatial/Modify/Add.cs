using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a point to the line segment defined by two points within the specified tolerance.
        /// </summary>
        /// <param name="point_1">The first endpoint of the line segment.</param>
        /// <param name="point_2">The second endpoint of the line segment.</param>
        /// <param name="point">The point to be added.</param>
        /// <param name="tolerance">The tolerance value for the operation.</param>
        /// <returns>True if the point was successfully added; otherwise, false.</returns>
        public static bool Add(ref Coordinate3 point_1, ref Coordinate3 point_2, Coordinate3 point, double tolerance)
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

        /// <summary>
        /// Adds a coordinate point based on six reference points and a specified tolerance.
        /// </summary>
        /// <param name="point_1">A reference to the first coordinate point.</param>
        /// <param name="point_2">A reference to the second coordinate point.</param>
        /// <param name="point_3">A reference to the third coordinate point.</param>
        /// <param name="point_4">A reference to the fourth coordinate point.</param>
        /// <param name="point_5">A reference to the fifth coordinate point.</param>
        /// <param name="point_6">A reference to the sixth coordinate point.</param>
        /// <param name="point">The coordinate point to be added.</param>
        /// <param name="tolerance">The tolerance value for the operation.</param>
        /// <returns>True if the point was successfully added; otherwise, false.</returns>
        public static bool Add(ref Coordinate3 point_1, ref Coordinate3 point_2, ref Coordinate3 point_3, ref Coordinate3 point_4, ref Coordinate3 point_5, ref Coordinate3 point_6, Coordinate3 point, double tolerance)
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

            if (point_3.IsNaN())
            {
                point_3 = point;
                return true;
            }
            else if (point_3.AlmostEquals(point, tolerance))
            {
                return false;
            }

            if (point_4.IsNaN())
            {
                point_4 = point;
                return true;
            }
            else if (point_4.AlmostEquals(point, tolerance))
            {
                return false;
            }

            if (point_5.IsNaN())
            {
                point_5 = point;
                return true;
            }
            else if (point_5.AlmostEquals(point, tolerance))
            {
                return false;
            }

            if (point_6.IsNaN())
            {
                point_6 = point;
                return true;
            }
            else if (point_6.AlmostEquals(point, tolerance))
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// Adds six coordinate points to calculate a 3D line intersection within the specified tolerance.
        /// </summary>
        /// <param name="point_1">A reference to the first coordinate point.</param>
        /// <param name="point_2">A reference to the second coordinate point.</param>
        /// <param name="point_3">A reference to the third coordinate point.</param>
        /// <param name="point_4">A reference to the fourth coordinate point.</param>
        /// <param name="point_5">A reference to the fifth coordinate point.</param>
        /// <param name="point_6">A reference to the sixth coordinate point.</param>
        /// <param name="line3Intersection">The Line3Intersection object used to store or evaluate the intersection result.</param>
        /// <param name="tolerance">The precision tolerance for the intersection calculation.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public static bool Add(ref Coordinate3 point_1, ref Coordinate3 point_2, ref Coordinate3 point_3, ref Coordinate3 point_4, ref Coordinate3 point_5, ref Coordinate3 point_6, Line3Intersection line3Intersection, double tolerance)
        {
            if (line3Intersection.Point_1.IsNaN())
            {
                return false;
            }

            bool result = false;

            if (Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection.Point_1, tolerance))
            {
                result = true;
            }

            if (Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection.Point_2, tolerance))
            {
                result = true;
            }

            return result;
        }
    }
}