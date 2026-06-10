using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Modify
    {
        /// <summary>
        /// Swaps two provided indices if the cross product of the given vectors is negative, 
        /// or if the first vector is NaN while the second is not.
        /// </summary>
        /// <param name="index_1">A reference to the first index to be potentially swapped.</param>
        /// <param name="index_2">A reference to the second index to be potentially swapped.</param>
        /// <param name="vector_1">The first coordinate vector used for the cross product calculation.</param>
        /// <param name="vector_2">The second coordinate vector used for the cross product calculation.</param>
        /// <returns>True if the indices were swapped; otherwise, false.</returns>
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

            double crossProduct = vector_1.CrossProduct(vector_2);
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