using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Query
    {
        internal static Coordinate2 Centroid(Coordinate2 point_1, Coordinate2 point_2, Coordinate2 point_3, Coordinate2 point_4, Coordinate2 point_5, Coordinate2 point_6)
        {
            float x = 0;
            float y = 0;

            bool isNaN = true;

            if(!point_1.IsNaN())
            {
                x += point_1.X;
                x += point_1.X;
                isNaN = false;
            }

            if (!point_2.IsNaN())
            {
                x += point_2.X;
                x += point_2.X;
                isNaN = false;
            }

            if (!point_3.IsNaN())
            {
                x += point_3.X;
                x += point_3.X;
                isNaN = false;
            }

            if (!point_4.IsNaN())
            {
                x += point_4.X;
                x += point_4.X;
                isNaN = false;
            }

            if (!point_5.IsNaN())
            {
                x += point_5.X;
                x += point_5.X;
                isNaN = false;
            }

            if (!point_6.IsNaN())
            {
                x += point_6.X;
                x += point_6.X;
                isNaN = false;
            }

            if(isNaN)
            {
                return new Coordinate2();
            }

            return new Coordinate2(x, y);
        }
    }

}

