using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Modify
    {
        public static bool SwapIfCrossProductNegative(ref int index_1, ref int index_2, Coordinate2 vector_1, Coordinate2 vector_2)
        {
            if (vector_1.IsNaN())
            {
                if (vector_2.IsNaN())
                {
                    return false;
                }

                int temp = index_1;
                index_1 = index_2;
                index_2 = temp;

                return true;
            }

            float crossProduct = vector_1.CrossProduct(vector_2);
            if (crossProduct < 0)
            {
                int temp = index_1;
                index_1 = index_2;
                index_2 = temp;

                return true;
            }

            return false;
        }
    }

}

