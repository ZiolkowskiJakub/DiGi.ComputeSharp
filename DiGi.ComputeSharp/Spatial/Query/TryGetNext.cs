using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        internal static bool TryGetNext(Triangle3 triangle_1, Triangle3 triangle_2, Coordinate3 current, Coordinate3 coordinate_1, Coordinate3 coordinate_2, Coordinate3 coordinate_3, Coordinate3 coordinate_4, Coordinate3 coordinate_5, Coordinate3 coordinate_6, out Coordinate3 next, out Coordinate3 result_1, out Coordinate3 result_2, out Coordinate3 result_3, out Coordinate3 result_4, out Coordinate3 result_5, out Coordinate3 result_6)
        {
            result_1 = new Coordinate3();
            result_2 = new Coordinate3();
            result_3 = new Coordinate3();
            result_4 = new Coordinate3();
            result_5 = new Coordinate3();
            result_6 = new Coordinate3();
            next = new Coordinate3();

            if(current.IsNaN())
            {
                if(!coordinate_1.IsNaN())
                {
                    result_1 = coordinate_1;
                    //TryGetNext(triangle_1, triangle_2, );
                }
            }


            if(!TryGetFirst(coordinate_1, coordinate_2, coordinate_3, coordinate_4, coordinate_5, coordinate_6, out result_1) || result_1.IsNaN())
            {
                return false;
            }

            return false;
        }

        internal static bool TryGetNext(Triangle3 triangle_1, Triangle3 triangle_2, Coordinate3 current, Coordinate3 coordinate_1, Coordinate3 coordinate_2, Coordinate3 coordinate_3, Coordinate3 coordinate_4, Coordinate3 coordinate_5, Coordinate3 coordinate_6, out Coordinate3 next)
        {
            next = new Coordinate3();
            return false;
        }
    }

}

