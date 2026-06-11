using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a Coordinate3 instance to a Point3D instance.
        /// </summary>
        /// <param name="coordinate3">The source Coordinate3 object to convert.</param>
        /// <returns>A Point3D representation of the coordinate, or null if the input is null.</returns>
        public static Point3D? ToDiGi(this Coordinate3? coordinate3)
        {
            if (coordinate3 == null || !coordinate3.HasValue)
            {
                return null;
            }

            return new Point3D(System.Convert.ToDouble(coordinate3.Value.X), System.Convert.ToDouble(coordinate3.Value.Y), System.Convert.ToDouble(coordinate3.Value.Z));
        }
    }
}