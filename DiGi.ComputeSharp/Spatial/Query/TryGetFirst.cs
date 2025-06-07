using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static bool TryGetFirst(Coordinate3 coordinate_1, Coordinate3 coordinate_2, Coordinate3 coordinate_3, Coordinate3 coordinate_4, out Coordinate3 result)
        {
            if(!coordinate_1.IsNaN())
            {
                result = coordinate_1;
                return true;
            }

            if (!coordinate_2.IsNaN())
            {
                result = coordinate_2;
                return true;
            }

            if (!coordinate_3.IsNaN())
            {
                result = coordinate_3;
                return true;
            }

            if (!coordinate_4.IsNaN())
            {
                result = coordinate_4;
                return true;
            }

            result = coordinate_1;
            return false;
        }

        public static bool TryGetFirst(Coordinate3 coordinate_1, Coordinate3 coordinate_2, Coordinate3 coordinate_3, Coordinate3 coordinate_4, Coordinate3 coordinate_5, Coordinate3 coordinate_6, out Coordinate3 result)
        {
            if (!coordinate_1.IsNaN())
            {
                result = coordinate_1;
                return true;
            }

            if (!coordinate_2.IsNaN())
            {
                result = coordinate_2;
                return true;
            }

            if (!coordinate_3.IsNaN())
            {
                result = coordinate_3;
                return true;
            }

            if (!coordinate_4.IsNaN())
            {
                result = coordinate_4;
                return true;
            }

            if (!coordinate_5.IsNaN())
            {
                result = coordinate_5;
                return true;
            }

            if (!coordinate_6.IsNaN())
            {
                result = coordinate_6;
                return true;
            }

            result = coordinate_1;
            return false;
        }
    }

}

