using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Create
    {
        public static IntersectionResult3D IntersectionResult3D(this Mesh3D mesh3D, IEnumerable<Mesh3D> mesh3Ds, float tolerance = Core.Constans.Tolerance.Distance)
        {
            if (mesh3D == null || mesh3Ds == null)
            {
                return null;
            }

            List<Triangle3> triangle3s_1 = mesh3D.ToComputeSharp();

            List<Triangle3> triangle3s_2 = new List<Triangle3>();
            foreach(Mesh3D mesh3D_Temp in mesh3Ds)
            {
                List<Triangle3> triangle3s_Mesh3D = mesh3D_Temp?.ToComputeSharp();
                if(triangle3s_Mesh3D == null || triangle3s_Mesh3D.Count() == 0)
                {
                    continue;
                }

                triangle3s_2.AddRange(triangle3s_Mesh3D);
            }

            IEnumerable<Triangle3Intersection> triangle3Intersections = ComputeSharp.Spatial.Create.Triangle3Intersections(triangle3s_1, triangle3s_2, tolerance);
        }
    }
}

