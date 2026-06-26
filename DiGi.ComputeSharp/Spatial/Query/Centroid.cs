using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the centroid of up to six 3D coordinates, ignoring any that are NaN.
        /// </summary>
        /// <param name="point_1">The first coordinate.</param>
        /// <param name="point_2">The second coordinate.</param>
        /// <param name="point_3">The third coordinate.</param>
        /// <param name="point_4">The fourth coordinate.</param>
        /// <param name="point_5">The fifth coordinate.</param>
        /// <param name="point_6">The sixth coordinate.</param>
        /// <returns>The calculated centroid as a Coordinate3, or a default Coordinate3 if no valid points are provided.</returns>
        public static Coordinate3 Centroid(Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3, Coordinate3 point_4, Coordinate3 point_5, Coordinate3 point_6)
        {
            int count = 0;
            double x = 0;
            double y = 0;
            double z = 0;

            if (!point_1.IsNaN())
            {
                x += point_1.X;
                y += point_1.Y;
                z += point_1.Z;
                count++;
            }

            if (!point_2.IsNaN())
            {
                x += point_2.X;
                y += point_2.Y;
                z += point_2.Z;
                count++;
            }

            if (!point_3.IsNaN())
            {
                x += point_3.X;
                y += point_3.Y;
                z += point_3.Z;
                count++;
            }

            if (!point_4.IsNaN())
            {
                x += point_4.X;
                y += point_4.Y;
                z += point_4.Z;
                count++;
            }

            if (!point_5.IsNaN())
            {
                x += point_5.X;
                y += point_5.Y;
                z += point_5.Z;
                count++;
            }

            if (!point_6.IsNaN())
            {
                x += point_6.X;
                y += point_6.Y;
                z += point_6.Z;
                count++;
            }

            if (count == 0)
            {
                return new();
            }

            return new(x / count, y / count, z / count);
        }

        /// <summary>
        /// Calculates the centroid of a triangle intersection.
        /// </summary>
        /// <param name="triangle3Intersection">The triangle intersection containing the points to evaluate.</param>
        /// <returns>The calculated centroid as a Coordinate3, or a default Coordinate3 if the intersection is NaN.</returns>
        public static Coordinate3 Centroid(Triangle3Intersection triangle3Intersection)
        {
            if (triangle3Intersection.IsNaN())
            {
                return new();
            }

            return Centroid(triangle3Intersection.Point_1, triangle3Intersection.Point_2, triangle3Intersection.Point_3, triangle3Intersection.Point_4, triangle3Intersection.Point_5, triangle3Intersection.Point_6);
        }
    }
}
