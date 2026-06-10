using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point3D"/> to a <see cref="Coordinate3"/>.
        /// </summary>
        /// <param name="point3D">The point to convert.</param>
        /// <returns>The equivalent <see cref="Coordinate3"/>, or a default instance if the input is null.</returns>
        public static Coordinate3 ToComputeSharp(this Point3D? point3D)
        {
            if (point3D == null)
            {
                return new Coordinate3();
            }

            return new Coordinate3(point3D.X, point3D.Y, point3D.Z);
        }

        /// <summary>
        /// Converts a <see cref="Vector3D"/> to a <see cref="Coordinate3"/>.
        /// </summary>
        /// <param name="vetcor3D">The vector to convert.</param>
        /// <returns>The equivalent <see cref="Coordinate3"/>, or a default instance if the input is null.</returns>
        public static Coordinate3 ToComputeSharp(this Vector3D? vetcor3D)
        {
            if (vetcor3D == null)
            {
                return new Coordinate3();
            }

            return new Coordinate3(vetcor3D.X, vetcor3D.Y, vetcor3D.Z);
        }
    }
}