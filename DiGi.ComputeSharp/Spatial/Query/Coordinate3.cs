using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static Coordinate3 Coordinate3(ref Coordinate3 coordinate_1, ref Coordinate3 coordinate_2, ref Coordinate3 coordinate_3, ref Coordinate3 coordinate_4, ref Coordinate3 coordinate_5, ref Coordinate3 coordinate_6, int index)
        {
            if (index == 1)
            {
                return coordinate_1;
            }

            if (index == 2)
            {
                return coordinate_2;
            }

            if (index == 3)
            {
                return coordinate_3;
            }

            if (index == 4)
            {
                return coordinate_4;
            }

            if (index == 5)
            {
                return coordinate_5;
            }

            if (index == 6)
            {
                return coordinate_6;
            }

            return new Coordinate3();
        }
    }

}

