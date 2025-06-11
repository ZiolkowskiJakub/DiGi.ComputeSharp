using DiGi.ComputeSharp.Planar.Classes;
using System.Reflection.Metadata.Ecma335;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Query
    {
        internal static Coordinate2 Coordinate2(ref Coordinate2 coordinate_1, ref Coordinate2 coordinate_2, ref Coordinate2 coordinate_3, ref Coordinate2 coordinate_4, ref Coordinate2 coordinate_5, ref Coordinate2 coordinate_6, int index)
        {
            if(index == 1)
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

            return new Coordinate2();
        }
    }

}

