using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Mesh3D? ToDiGi(this IEnumerable<Triangle3> triangle3s, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (triangle3s == null || !triangle3s.Any())
            {
                return null;
            }

            List<Triangle3D> triangle3Ds = [];
            foreach (Triangle3 triangle3 in triangle3s)
            {
                if (ToDiGi(triangle3) is Triangle3D triangle3D)
                {
                    triangle3Ds.Add(triangle3D);
                }
            }

            return DiGi.Geometry.Spatial.Create.Mesh3D(triangle3Ds, tolerance);
        }
    }
}