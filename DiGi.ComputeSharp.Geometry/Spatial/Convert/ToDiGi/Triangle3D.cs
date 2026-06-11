using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Triangle3"/> instance to a <see cref="Triangle3D"/> instance.
        /// </summary>
        /// <param name="triangle3">The source <see cref="Triangle3"/> object to convert.</param>
        /// <returns>A <see cref="Triangle3D"/> representation of the input triangle, or null if the input is null.</returns>
        public static Triangle3D? ToDiGi(this Triangle3? triangle3)
        {
            if (triangle3 == null || !triangle3.HasValue)
            {
                return null;
            }

            return new Triangle3D(ToDiGi(triangle3.Value.Point_1), ToDiGi(triangle3.Value.Point_2), ToDiGi(triangle3.Value.Point_3));
        }
    }
}