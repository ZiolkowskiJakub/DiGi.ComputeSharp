using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry
{
    public static partial class Convert
    {
        public static List<Triangle3> ToComputeSharp(this IEnumerable<Triangle3D> triangle3Ds)
        {
            if (triangle3Ds == null)
            {
                return null;
            }

            List<Triangle3> result = new List<Triangle3>();
            foreach(Triangle3D triangle3D in triangle3Ds)
            {
                result.Add(ToComputeSharp(triangle3D));
            }


            return result;
        }
    }
}
