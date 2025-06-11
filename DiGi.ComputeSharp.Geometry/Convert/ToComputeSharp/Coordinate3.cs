using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry
{
    public static partial class Convert
    {
        public static Coordinate3 ToComputeSharp(this Point3D point3D)
        {
            if (point3D == null)
            {
                return new Coordinate3();
            }

            return new Coordinate3(System.Convert.ToSingle(point3D.X), System.Convert.ToSingle(point3D.Y), System.Convert.ToSingle(point3D.X));
        }

        public static Coordinate3 ToComputeSharp(this Vector3D vetcor3D)
        {
            if (vetcor3D == null)
            {
                return new Coordinate3();
            }

            return new Coordinate3(System.Convert.ToSingle(vetcor3D.X), System.Convert.ToSingle(vetcor3D.Y), System.Convert.ToSingle(vetcor3D.X));
        }
    }
}
