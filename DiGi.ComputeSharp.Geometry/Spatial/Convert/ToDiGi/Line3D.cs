using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Line3D ToDiGi_Line3D(this Line3? line3)
        {
            if (line3 == null || !line3.HasValue)
            {
                return null;
            }

            return new Line3D(ToDiGi(line3.Value.Start), ToDiGi(line3.Value.End));
        }
    }
}
