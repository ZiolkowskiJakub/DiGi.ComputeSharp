using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Selects one of the six 2D coordinates by its index (1-based).
        /// </summary>
        /// <param name="coordinate_1">The first coordinate reference.</param>
        /// <param name="coordinate_2">The second coordinate reference.</param>
        /// <param name="coordinate_3">The third coordinate reference.</param>
        /// <param name="coordinate_4">The fourth coordinate reference.</param>
        /// <param name="coordinate_5">The fifth coordinate reference.</param>
        /// <param name="coordinate_6">The sixth coordinate reference.</param>
        /// <param name="index">The 1-based index of the coordinate to select.</param>
        /// <returns>The selected <see cref="Coordinate2"/>, or a default coordinate if index is out of bounds.</returns>
        internal static Coordinate2 Coordinate2(ref Coordinate2 coordinate_1, ref Coordinate2 coordinate_2, ref Coordinate2 coordinate_3, ref Coordinate2 coordinate_4, ref Coordinate2 coordinate_5, ref Coordinate2 coordinate_6, int index)
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

            return new Coordinate2();
        }
    }
}