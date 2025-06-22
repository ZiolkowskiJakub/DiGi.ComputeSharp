using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Create
    {
        public static IntersectionResult3D IntersectionResult3D(this Mesh3D mesh3D, IEnumerable<Mesh3D> mesh3Ds, bool solid, float tolerance = Core.Constans.Tolerance.Distance)
        {
            if (mesh3D == null || mesh3Ds == null)
            {
                return null;
            }

            List<Triangle3> triangle3s_1 = mesh3D.ToComputeSharp(solid);

            List<Triangle3> triangle3s_2 = new List<Triangle3>();
            foreach(Mesh3D mesh3D_Temp in mesh3Ds)
            {
                List<Triangle3> triangle3s_Mesh3D = mesh3D_Temp?.ToComputeSharp(solid);
                if(triangle3s_Mesh3D == null || triangle3s_Mesh3D.Count() == 0)
                {
                    continue;
                }

                triangle3s_2.AddRange(triangle3s_Mesh3D);
            }

            IEnumerable<Triangle3Intersection> triangle3Intersections = ComputeSharp.Spatial.Create.Triangle3Intersections(triangle3s_1, triangle3s_2, tolerance);
            if(triangle3Intersections == null)
            {
                return null;
            }

            List<IGeometry3D> geometry3Ds = new List<IGeometry3D>();
            foreach(Triangle3Intersection triangle3Intersection in triangle3Intersections)
            {
                if(triangle3Intersection.IsNaN())
                {
                    continue;
                }

                IGeometry3[] geometry3s =triangle3Intersection.GetIntersectionGeometries();
                if(geometry3Ds == null || geometry3s.Length == 0)
                {
                    continue;
                }

                foreach(IGeometry3 geometry3 in geometry3s)
                {
                    IGeometry3D geometry3D = null;
                    if (geometry3 is Coordinate3)
                    {
                        geometry3D = Convert.ToDiGi((Coordinate3)geometry3);
                    }
                    else if (geometry3 is Line3)
                    {
                        Line3 line3 = (Line3)geometry3;
                        if(line3.Bounded.ToBool())
                        {
                            geometry3D = Convert.ToDiGi_Line3D(line3);
                        }
                        else
                        {
                            geometry3D = Convert.ToDiGi(line3);
                        }
                    }
                    else if (geometry3 is Triangle3)
                    {
                        geometry3D = Convert.ToDiGi((Triangle3)geometry3);
                    }

                    if (geometry3D == null)
                    {
                        continue;
                    }

                    geometry3Ds.Add(geometry3D);
                }
            }

            return new IntersectionResult3D(geometry3Ds);
        
        }
    }
}

