using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Coordinate3"/> instance to a <see cref="Vector3D"/> instance.
        /// </summary>
        /// <param name="coordinate3">The source coordinate to convert.</param>
        /// <returns>A <see cref="Vector3D"/> representation of the coordinate, or null if the input is null.</returns>
        public static Vector3D? ToDiGi_Vector3D(this Coordinate3? coordinate3)
        {
            if (coordinate3 == null || !coordinate3.HasValue)
            {
                return null;
            }

            return new Vector3D(System.Convert.ToDouble(coordinate3.Value.X), System.Convert.ToDouble(coordinate3.Value.Y), System.Convert.ToDouble(coordinate3.Value.Z));
        }
    }
}