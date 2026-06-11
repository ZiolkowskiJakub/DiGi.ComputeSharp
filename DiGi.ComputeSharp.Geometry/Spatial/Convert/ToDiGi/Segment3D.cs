using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Line3"/> instance to a <see cref="Segment3D"/> instance.
        /// </summary>
        /// <param name="line3">The <see cref="Line3"/> object to convert.</param>
        /// <returns>A <see cref="Segment3D"/> representation of the line, or null if the input is null.</returns>
        public static Segment3D? ToDiGi(this Line3? line3)
        {
            if (line3 == null || !line3.HasValue)
            {
                return null;
            }

            return new Segment3D(ToDiGi(line3.Value.Start), ToDiGi(line3.Value.End));
        }
    }
}