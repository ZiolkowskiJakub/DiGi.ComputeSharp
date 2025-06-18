using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Vector3D ToDiGi_Vector3D(this Coordinate3? coordinate3)
        {
            if (coordinate3 == null || !coordinate3.HasValue)
            {
                return null;
            }

            return new Vector3D(System.Convert.ToDouble(coordinate3.Value.X), System.Convert.ToDouble(coordinate3.Value.Y), System.Convert.ToDouble(coordinate3.Value.X));
        }
    }
}
