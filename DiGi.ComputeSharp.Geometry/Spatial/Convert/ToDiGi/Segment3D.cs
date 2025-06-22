using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Segment3D ToDiGi(this Line3? line3)
        {
            if (line3 == null || !line3.HasValue)
            {
                return null;
            }

            return new Segment3D(ToDiGi(line3.Value.Start), ToDiGi(line3.Value.End));
        }
    }
}
