using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Returns a specific Coordinate3 from a set of six coordinates based on the provided index.
        /// </summary>
        /// <param name="coordinate_1">The first coordinate.</param>
        /// <param name="coordinate_2">The second coordinate.</param>
        /// <param name="coordinate_3">The third coordinate.</param>
        /// <param name="coordinate_4">The fourth coordinate.</param>
        /// <param name="coordinate_5">The fifth coordinate.</param>
        /// <param name="coordinate_6">The sixth coordinate.</param>
        /// <param name="index">The index of the coordinate to retrieve (1-6).</param>
        /// <returns>The Coordinate3 corresponding to the specified index, or a new default Coordinate3 if the index is out of range.</returns>
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