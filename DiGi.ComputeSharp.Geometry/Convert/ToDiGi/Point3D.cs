using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry
{
    public static partial class Convert
    {
        public static Point3D ToDiGi(this Coordinate3? coordinate3)
        {
            if (coordinate3 == null || !coordinate3.HasValue)
            {
                return null;
            }

            return new Point3D(System.Convert.ToDouble(coordinate3.Value.X), System.Convert.ToDouble(coordinate3.Value.Y), System.Convert.ToDouble(coordinate3.Value.X));
        }
    }
}
