using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry
{
    public static partial class Convert
    {
        public static Mesh3D ToDiGi(this IEnumerable<Triangle3> triangle3s, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(triangle3s == null || triangle3s.Count() == 0)
            {
                return null;
            }

            List<Triangle3D> triangle3Ds = new List<Triangle3D>();
            foreach(Triangle3 triangle3 in triangle3s)
            {
               triangle3Ds.Add(ToDiGi(triangle3));
            }

            return DiGi.Geometry.Spatial.Create.Mesh3D(triangle3Ds, tolerance);
        }
    }
}
