using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 3D intersection between a source mesh and a collection of other meshes.
        /// </summary>
        /// <param name="mesh3D">The source mesh to evaluate.</param>
        /// <param name="mesh3Ds">The collection of meshes to intersect with the source mesh.</param>
        /// <param name="solid">A boolean value indicating whether to perform a solid intersection operation.</param>
        /// <param name="tolerance">The distance tolerance for the intersection calculation.</param>
        /// <returns>An <see cref="IntersectionResult3D"/> containing the result of the intersection, or null if no valid intersection is found.</returns>
        public static IntersectionResult3D? IntersectionResult3D(this Mesh3D? mesh3D, IEnumerable<Mesh3D>? mesh3Ds, bool solid, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (mesh3D == null || mesh3Ds == null)
            {
                return null;
            }

            List<Triangle3>? triangle3s_1 = mesh3D.ToComputeSharp(solid);
            if (triangle3s_1 is null)
            {
                return null;
            }

            List<Triangle3> triangle3s_2 = [];
            foreach (Mesh3D mesh3D_Temp in mesh3Ds)
            {
                List<Triangle3>? triangle3s_Mesh3D = mesh3D_Temp?.ToComputeSharp(solid);
                if (triangle3s_Mesh3D == null || triangle3s_Mesh3D.Count == 0)
                {
                    continue;
                }

                triangle3s_2.AddRange(triangle3s_Mesh3D);
            }

            IEnumerable<Triangle3Intersection>? triangle3Intersections = ComputeSharp.Spatial.Create.Triangle3Intersections(triangle3s_1, triangle3s_2, tolerance);
            if (triangle3Intersections == null)
            {
                return null;
            }

            List<IGeometry3D> geometry3Ds = [];
            foreach (Triangle3Intersection triangle3Intersection in triangle3Intersections)
            {
                if (triangle3Intersection.IsNaN())
                {
                    continue;
                }

                IGeometry3[]? geometry3s = triangle3Intersection.GetIntersectionGeometries();
                if (geometry3s == null || geometry3s.Length == 0)
                {
                    continue;
                }

                foreach (IGeometry3 geometry3 in geometry3s)
                {
                    IGeometry3D? geometry3D = null;
                    if (geometry3 is Coordinate3 coordinate3)
                    {
                        geometry3D = Convert.ToDiGi(coordinate3);
                    }
                    else if (geometry3 is Line3 line3)
                    {
                        if (line3.Bounded.ToBool())
                        {
                            geometry3D = Convert.ToDiGi(line3);
                        }
                        else
                        {
                            geometry3D = Convert.ToDiGi_Line3D(line3);
                        }
                    }
                    else if (geometry3 is Triangle3 triangle3)
                    {
                        geometry3D = Convert.ToDiGi(triangle3);
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

        /// <summary>
        /// Computes the 3D intersection between a source mesh and a collection of other meshes using CPU processing.
        /// </summary>
        /// <param name="mesh3D">The source mesh to evaluate for intersections.</param>
        /// <param name="mesh3Ds">The collection of target meshes to intersect with the source mesh.</param>
        /// <param name="solid">Specifies whether to perform a solid intersection (volumetric) or a surface-based intersection.</param>
        /// <param name="tolerance">The distance tolerance used for numerical precision during the intersection calculation.</param>
        /// <returns>An <see cref="IntersectionResult3D"/> containing the intersection data if successful; otherwise, null.</returns>
        public static IntersectionResult3D? IntersectionResult3D_CPU(this Mesh3D? mesh3D, IEnumerable<Mesh3D>? mesh3Ds, bool solid, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (mesh3D == null || mesh3Ds == null || !mesh3Ds.Any())
            {
                return null;
            }

            BoundingBox3D? boundingBox3D = mesh3D.GetBoundingBox();
            if (boundingBox3D == null)
            {
                return null;
            }

            List<Mesh3D> mesh3Ds_Temp = [];
            foreach (Mesh3D mesh3D_Temp in mesh3Ds)
            {
                BoundingBox3D? boundingBox3D_Temp = mesh3D_Temp?.GetBoundingBox();
                if (boundingBox3D_Temp == null)
                {
                    continue;
                }

                if (!boundingBox3D.InRange(boundingBox3D_Temp, tolerance))
                {
                    continue;
                }

                mesh3Ds_Temp.Add(mesh3D_Temp!);
            }

            if (mesh3Ds_Temp == null || mesh3Ds_Temp.Count == 0)
            {
                return new IntersectionResult3D();
            }

            List<Triangle3>? triangle3s = mesh3D.GetTriangles()?.ConvertAll(x => x.ToComputeSharp(solid));
            if (triangle3s is null)
            {
                return new IntersectionResult3D();
            }

            List<IGeometry3D> geometry3Ds = [];

            foreach (Mesh3D mesh3D_Temp in mesh3Ds_Temp)
            {
                List<Triangle3>? triangle3s_Temp = mesh3D_Temp.GetTriangles()?.ConvertAll(x => x.ToComputeSharp(solid));
                if (triangle3s_Temp is null)
                {
                    continue;
                }

                foreach (Triangle3 triangle3 in triangle3s)
                {
                    foreach (Triangle3 triangle3_Temp in triangle3s_Temp)
                    {
                        Triangle3Intersection triangle3Intersection = ComputeSharp.Spatial.Create.Triangle3Intersection(triangle3, triangle3_Temp, tolerance);
                        if (triangle3Intersection.IsNaN())
                        {
                            continue;
                        }

                        IGeometry3[]? geometry3s = triangle3Intersection.GetIntersectionGeometries();
                        if (geometry3s == null || geometry3s.Length == 0)
                        {
                            continue;
                        }

                        foreach (IGeometry3 geometry3 in geometry3s)
                        {
                            IGeometry3D? geometry3D = null;
                            if (geometry3 is Coordinate3 coordinate3)
                            {
                                geometry3D = Convert.ToDiGi(coordinate3);
                            }
                            else if (geometry3 is Line3 line3)
                            {
                                if (line3.Bounded.ToBool())
                                {
                                    geometry3D = Convert.ToDiGi(line3);
                                }
                                else
                                {
                                    geometry3D = Convert.ToDiGi_Line3D(line3);
                                }
                            }
                            else if (geometry3 is Triangle3 triangle3_Temp_Temp)
                            {
                                geometry3D = Convert.ToDiGi(triangle3_Temp_Temp);
                            }

                            if (geometry3D == null)
                            {
                                continue;
                            }

                            geometry3Ds.Add(geometry3D);
                        }
                    }
                }
            }

            return new IntersectionResult3D(geometry3Ds);
        }
    }
}