using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        internal static void Sort(Triangle3 triangle_1, Triangle3 triangle_2, Coordinate3 coordinate_1, Coordinate3 coordinate_2, Coordinate3 coordinate_3, Coordinate3 coordinate_4, Coordinate3 coordinate_5, Coordinate3 coordinate_6, out Coordinate3 result_1, out Coordinate3 result_2, out Coordinate3 result_3, out Coordinate3 result_4, out Coordinate3 result_5, out Coordinate3 result_6)
        {
            result_1 = new Coordinate3();
            result_2 = new Coordinate3();
            result_3 = new Coordinate3();
            result_4 = new Coordinate3();
            result_5 = new Coordinate3();
            result_6 = new Coordinate3();

            Coordinate3 next = new Coordinate3();

            if (!TryGetNext(triangle_1, triangle_2, next, coordinate_1, coordinate_2, coordinate_3, coordinate_4, coordinate_5, coordinate_6, out next, out result_1, out result_2, out result_3, out result_4, out result_5, out result_6) || next.IsNaN())
            {
                return;
            }

            coordinate_1 = result_1;
            coordinate_2 = result_2;
            coordinate_3 = result_3;
            coordinate_4 = result_4;
            coordinate_5 = result_5;
            coordinate_6 = result_6;

            if (!TryGetNext(triangle_1, triangle_2, next, coordinate_1, coordinate_2, coordinate_3, coordinate_4, coordinate_5, coordinate_6, out next, out result_1, out result_2, out result_3, out result_4, out result_5, out result_6) || next.IsNaN())
            {
                return;
            }

            coordinate_1 = result_1;
            coordinate_2 = result_2;
            coordinate_3 = result_3;
            coordinate_4 = result_4;
            coordinate_5 = result_5;
            coordinate_6 = result_6;

            if (!TryGetNext(triangle_1, triangle_2, next, coordinate_1, coordinate_2, coordinate_3, coordinate_4, coordinate_5, coordinate_6, out next, out result_1, out result_2, out result_3, out result_4, out result_5, out result_6) || next.IsNaN())
            {
                return;
            }

            coordinate_1 = result_1;
            coordinate_2 = result_2;
            coordinate_3 = result_3;
            coordinate_4 = result_4;
            coordinate_5 = result_5;
            coordinate_6 = result_6;

            if (!TryGetNext(triangle_1, triangle_2, next, coordinate_1, coordinate_2, coordinate_3, coordinate_4, coordinate_5, coordinate_6, out next, out result_1, out result_2, out result_3, out result_4, out result_5, out result_6) || next.IsNaN())
            {
                return;
            }

            coordinate_1 = result_1;
            coordinate_2 = result_2;
            coordinate_3 = result_3;
            coordinate_4 = result_4;
            coordinate_5 = result_5;
            coordinate_6 = result_6;

            if (!TryGetNext(triangle_1, triangle_2, next, coordinate_1, coordinate_2, coordinate_3, coordinate_4, coordinate_5, coordinate_6, out next, out result_1, out result_2, out result_3, out result_4, out result_5, out result_6) || next.IsNaN())
            {
                return;
            }

            coordinate_1 = result_1;
            coordinate_2 = result_2;
            coordinate_3 = result_3;
            coordinate_4 = result_4;
            coordinate_5 = result_5;
            coordinate_6 = result_6;

            TryGetNext(triangle_1, triangle_2, next, coordinate_1, coordinate_2, coordinate_3, coordinate_4, coordinate_5, coordinate_6, out next, out result_1, out result_2, out result_3, out result_4, out result_5, out result_6);
        }
    }

}

