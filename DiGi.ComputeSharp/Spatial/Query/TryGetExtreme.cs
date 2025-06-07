using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static bool TryGetExtreme(Coordinate3 coordinate_1, Coordinate3 coordinate_2, Coordinate3 coordinate_3, Coordinate3 coordinate_4, out Coordinate3 result_1, out Coordinate3 result_2)
        {
            result_1 = new Coordinate3();
            result_2 = new Coordinate3();

            if (!coordinate_1.IsNaN())
            {
                result_1 = coordinate_1;
            }

            if (!coordinate_2.IsNaN())
            {
                if (result_1.IsNaN())
                {
                    result_1 = coordinate_2;
                }
                else
                {
                    result_2 = coordinate_2;
                }

                if (!result_2.IsNaN())
                {
                    return true;
                }
            }

            if (!coordinate_3.IsNaN())
            {
                if (result_1.IsNaN())
                {
                    result_1 = coordinate_3;
                }
                else
                {
                    result_2 = coordinate_3;
                }

                if (!result_2.IsNaN())
                {
                    return true;
                }
            }

            if (!coordinate_4.IsNaN())
            {
                if (result_1.IsNaN())
                {
                    result_1 = coordinate_4;
                }
                else
                {
                    result_2 = coordinate_4;
                }

                if (!result_2.IsNaN())
                {
                    return true;
                }
            }

            return !result_1.IsNaN() && !result_2.IsNaN();
        }
    }

}

