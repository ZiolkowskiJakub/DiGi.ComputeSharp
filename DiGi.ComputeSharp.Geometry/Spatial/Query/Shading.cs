using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Core;
using DiGi.Geometry.Planar;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Query
    {
        public static List<List<IPolygonalFace3D>> Shading(this IEnumerable<IPolygonalFace3D> polygonalFace3Ds, Vector3D direction, double tolerance)
        {
            if (polygonalFace3Ds == null || direction == null)
            {
                return null;
            }

            int count = polygonalFace3Ds.Count();
            if (count == 0)
            {
                return null;
            }

            List<Tuple<Triangle3D, int>> tuples = new List<Tuple<Triangle3D, int>>();
            for (int i = 0; i < count; i++)
            {
                List<Triangle3D> triangle3Ds = polygonalFace3Ds.ElementAt(i)?.Triangulate(tolerance);
                if (triangle3Ds == null || triangle3Ds.Count == 0)
                {
                    continue;
                }

                foreach (Triangle3D triangle3D in triangle3Ds)
                {
                    tuples.Add(new Tuple<Triangle3D, int>(triangle3D, i));
                }
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return null;
            }

            int length = tuples.Count;

            ReadOnlyBuffer<Triangle3> triangle3s = graphicDevice.AllocateReadOnlyBuffer(tuples.ConvertAll(x => x.Item1.ToComputeSharp(true)).ToArray());

            ReadWriteBuffer<Triangle3Intersection> readWriteBuffer_Triangle3Intersection = graphicDevice.AllocateReadWriteBuffer<Triangle3Intersection>(length * length);

            graphicDevice.For(length, length, new Triangle3ShadingComputeShader(triangle3s, readWriteBuffer_Triangle3Intersection, direction.ToComputeSharp()));

            List<Triangle3Intersection> triangle3Intersections = Core.Create.List(readWriteBuffer_Triangle3Intersection);

            List<List<Triangle3D>> triangle3DsList = new List<List<Triangle3D>>();
            for (int i = 0; i < length; i++)
            {
                List<Triangle3D> triangle3Ds = new List<Triangle3D>();
                for (int j = 0; j < length; j++)
                {
                    Triangle3Intersection triangle3Intersection = triangle3Intersections[i * length + j];
                    if (triangle3Intersection.IsNaN())
                    {
                        continue;
                    }

                    ComputeSharp.Spatial.Interfaces.IGeometry3[] geometries = triangle3Intersection.GetIntersectionGeometries();
                    if (geometries == null)
                    {
                        continue;
                    }

                    foreach (ComputeSharp.Spatial.Interfaces.IGeometry3 geometry in geometries)
                    {
                        if (geometry is Triangle3)
                        {
                            triangle3Ds.Add(Convert.ToDiGi((Triangle3)geometry));
                        }
                    }
                }

                triangle3DsList.Add(triangle3Ds);
            }

            List<List<IPolygonalFace3D>> result = new List<List<IPolygonalFace3D>>();
            for (int i = count - 1; i >= 0; i--)
            {
                IPolygonalFace3D polygonalFace3D = polygonalFace3Ds.ElementAt(i);

                DiGi.Geometry.Spatial.Classes.Plane plane = polygonalFace3D?.Plane;
                if (plane == null)
                {
                    result.Add(null);
                    continue;
                }

                List<Triangle3D> triangle3Ds = new List<Triangle3D>();

                List<int> indexes = new List<int>();
                int index = tuples.FindLastIndex(x => x.Item2 == i);
                while(index != -1)
                {
                    tuples.RemoveAt(index);
                    List<Triangle3D> triangle3Ds_Temp = triangle3DsList[index];

                    index = tuples.FindLastIndex(x => x.Item2 == i);

                    if (triangle3Ds_Temp == null || triangle3Ds_Temp.Count == 0)
                    {
                        continue;
                    }

                    triangle3Ds.AddRange(triangle3Ds_Temp);
                }

                if(triangle3Ds == null || triangle3Ds.Count == 0)
                {
                    result.Add(null);
                    continue;
                }

                List<Polygon2D> polygon2Ds = triangle3Ds.ConvertAll(x => plane.Convert(x)).Union();

                List<IPolygonalFace2D> polygonalFace2Ds = DiGi.Geometry.Planar.Create.PolygonalFace2Ds(polygon2Ds, tolerance);

                result.Add(polygonalFace2Ds?.ConvertAll(x => plane.Convert(x)));
            }

            result.Reverse();

            return result;
        }

        public static List<List<IPolygonalFace3D>> Shading_CPU(this IEnumerable<IPolygonalFace3D> polygonalFace3Ds, Vector3D direction, double tolerance)
        {
            if (polygonalFace3Ds == null || direction == null)
            {
                return null;
            }

            int count = polygonalFace3Ds.Count();
            if (count == 0)
            {
                return null;
            }

            List<Tuple<Triangle3D, int>> tuples = new List<Tuple<Triangle3D, int>>();
            for (int i = 0; i < count; i++)
            {
                List<Triangle3D> triangle3Ds = polygonalFace3Ds.ElementAt(i)?.Triangulate(tolerance);
                if (triangle3Ds == null || triangle3Ds.Count == 0)
                {
                    continue;
                }

                foreach (Triangle3D triangle3D in triangle3Ds)
                {
                    tuples.Add(new Tuple<Triangle3D, int>(triangle3D, i));
                }
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return null;
            }

            int length = tuples.Count;

            List<Triangle3Intersection> triangle3Intersections = new List<Triangle3Intersection>();
            for (int i =0; i < tuples.Count; i++)
            {
                for (int j = 0; j < tuples.Count; j++)
                {
                    triangle3Intersections.Add(ComputeSharp.Spatial.Create.Triangle3Intersection(tuples[i].Item1.ToComputeSharp(true), tuples[j].Item1.ToComputeSharp(true), direction.Unit.ToComputeSharp(), true, false, tolerance));
                }
            }

            List<List<Triangle3D>> triangle3DsList = new List<List<Triangle3D>>();
            for (int i = 0; i < length; i++)
            {
                List<Triangle3D> triangle3Ds = new List<Triangle3D>();
                for (int j = 0; j < length; j++)
                {
                    Triangle3Intersection triangle3Intersection = triangle3Intersections[i * length + j];
                    if (triangle3Intersection.IsNaN())
                    {
                        continue;
                    }

                    ComputeSharp.Spatial.Interfaces.IGeometry3[] geometries = triangle3Intersection.GetIntersectionGeometries();
                    if (geometries == null)
                    {
                        continue;
                    }

                    foreach (ComputeSharp.Spatial.Interfaces.IGeometry3 geometry in geometries)
                    {
                        if (geometry is Triangle3)
                        {
                            triangle3Ds.Add(Convert.ToDiGi((Triangle3)geometry));
                        }
                    }
                }

                triangle3DsList.Add(triangle3Ds);
            }

            List<List<IPolygonalFace3D>> result = new List<List<IPolygonalFace3D>>();
            for (int i = count - 1; i >= 0; i--)
            {
                IPolygonalFace3D polygonalFace3D = polygonalFace3Ds.ElementAt(i);

                DiGi.Geometry.Spatial.Classes.Plane plane = polygonalFace3D?.Plane;
                if (plane == null)
                {
                    result.Add(null);
                    continue;
                }

                List<Triangle3D> triangle3Ds = new List<Triangle3D>();

                List<int> indexes = new List<int>();
                int index = tuples.FindLastIndex(x => x.Item2 == i);
                while (index != -1)
                {
                    tuples.RemoveAt(index);
                    List<Triangle3D> triangle3Ds_Temp = triangle3DsList[index];

                    index = tuples.FindLastIndex(x => x.Item2 == i);

                    if (triangle3Ds_Temp == null || triangle3Ds_Temp.Count == 0)
                    {
                        continue;
                    }

                    triangle3Ds.AddRange(triangle3Ds_Temp);
                }

                if (triangle3Ds == null || triangle3Ds.Count == 0)
                {
                    result.Add(null);
                    continue;
                }

                List<Polygon2D> polygon2Ds = triangle3Ds.ConvertAll(x => plane.Convert(x)).Union();

                List<IPolygonalFace2D> polygonalFace2Ds = DiGi.Geometry.Planar.Create.PolygonalFace2Ds(polygon2Ds, tolerance);

                result.Add(polygonalFace2Ds?.ConvertAll(x => plane.Convert(x)));
            }

            result.Reverse();

            return result;
        }
    }

}

