using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Triangle3D ToDiGi(this Triangle3? triangle3)
        {
            if(triangle3 == null || !triangle3.HasValue)
            {
                return null;
            }

            return new Triangle3D(ToDiGi(triangle3.Value.Point_1), ToDiGi(triangle3.Value.Point_2), ToDiGi(triangle3.Value.Point_3));
        }
    }
}
