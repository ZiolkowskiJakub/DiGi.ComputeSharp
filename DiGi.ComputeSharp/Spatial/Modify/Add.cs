using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Modify
    {
        public static bool Add(ref Coordinate3 point_1, ref Coordinate3 point_2, Coordinate3 point, float tolerance)
        {
            if(point.IsNaN())
            {
                return false;
            }

            if(point_1.IsNaN())
            {
                point_1 = point;
                return true;
            }
            else if(point_1.AlmostEquals(point, tolerance))
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

        public static bool Add(ref Coordinate3 point_1, ref Coordinate3 point_2, ref Coordinate3 point_3, ref Coordinate3 point_4, ref Coordinate3 point_5, ref Coordinate3 point_6, Coordinate3 point, float tolerance)
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

        public static bool Add(ref Coordinate3 point_1, ref Coordinate3 point_2, ref Coordinate3 point_3, ref Coordinate3 point_4, ref Coordinate3 point_5, ref Coordinate3 point_6, Line3Intersection line3Intersection, float tolerance)
        {
            if (line3Intersection.Point_1.IsNaN())
            {
                return false;
            }

            bool result = false;

            if(Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection.Point_1, tolerance))
            {
                result = true;
            }

            if(Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection.Point_2, tolerance))
            {
                result = true;
            }

            return result;
        }
    }

}

