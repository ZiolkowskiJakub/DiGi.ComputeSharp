using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Line3"/> instance to a <see cref="Line3D"/> instance.
        /// </summary>
        /// <param name="line3">The source <see cref="Line3"/> instance to convert.</param>
        /// <returns>A <see cref="Line3D"/> instance if the conversion is successful; otherwise, null.</returns>
        public static Line3D? ToDiGi_Line3D(this Line3? line3)
        {
            if (line3 == null || !line3.HasValue)
            {
                return null;
            }

            return new Line3D(ToDiGi(line3.Value.Start), ToDiGi(line3.Value.End));
        }
    }
}