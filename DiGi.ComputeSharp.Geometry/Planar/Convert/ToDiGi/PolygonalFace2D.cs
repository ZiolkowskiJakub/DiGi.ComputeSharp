using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.ComputeSharp.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a ComputeSharp <see cref="ShadowPolygon2"/> to a <see cref="PolygonalFace2D"/> built from its first <see cref="ShadowPolygon2.Count"/> points.
        /// </summary>
        /// <param name="shadowPolygon2">The source shadow polygon.</param>
        /// <returns>The face, or <see langword="null"/> when the point count is not 3 or 4, a used point is NaN, or the face cannot be created.</returns>
        public static PolygonalFace2D? ToDiGi(this ShadowPolygon2 shadowPolygon2)
        {
            int count = shadowPolygon2.Count;
            if (count != 3 && count != 4)
            {
                return null;
            }

            Coordinate2[] coordinate2s = [shadowPolygon2.Point_1, shadowPolygon2.Point_2, shadowPolygon2.Point_3, shadowPolygon2.Point_4];

            Point2D[] point2Ds = new Point2D[count];
            for (int i = 0; i < count; i++)
            {
                Coordinate2 coordinate2 = coordinate2s[i];
                if (double.IsNaN(coordinate2.X) || double.IsNaN(coordinate2.Y))
                {
                    return null;
                }

                point2Ds[i] = new Point2D(coordinate2.X, coordinate2.Y);
            }

            return DiGi.Geometry.Planar.Create.PolygonalFace2D(point2Ds);
        }
    }
}
