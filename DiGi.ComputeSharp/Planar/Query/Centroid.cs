using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the centroid of up to six 2D coordinates, ignoring any coordinates that are NaN.
        /// </summary>
        /// <param name="point_1">The first coordinate.</param>
        /// <param name="point_2">The second coordinate.</param>
        /// <param name="point_3">The third coordinate.</param>
        /// <param name="point_4">The fourth coordinate.</param>
        /// <param name="point_5">The fifth coordinate.</param>
        /// <param name="point_6">The sixth coordinate.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the centroid of the valid coordinates.</returns>
        internal static Coordinate2 Centroid(Coordinate2 point_1, Coordinate2 point_2, Coordinate2 point_3, Coordinate2 point_4, Coordinate2 point_5, Coordinate2 point_6)
        {
            double x = 0;
            double y = 0;

            bool isNaN = true;

            int count = 0;

            if (!point_1.IsNaN())
            {
                x += point_1.X;
                y += point_1.Y;
                isNaN = false;

                count++;
            }

            if (!point_2.IsNaN())
            {
                x += point_2.X;
                y += point_2.Y;
                isNaN = false;

                count++;
            }

            if (!point_3.IsNaN())
            {
                x += point_3.X;
                y += point_3.Y;
                isNaN = false;

                count++;
            }

            if (!point_4.IsNaN())
            {
                x += point_4.X;
                y += point_4.Y;
                isNaN = false;

                count++;
            }

            if (!point_5.IsNaN())
            {
                x += point_5.X;
                y += point_5.Y;
                isNaN = false;

                count++;
            }

            if (!point_6.IsNaN())
            {
                x += point_6.X;
                y += point_6.Y;
                isNaN = false;

                count++;
            }

            if (isNaN)
            {
                return new Coordinate2();
            }

            return new Coordinate2(x / (double)count, y / (double)count);
        }
    }
}