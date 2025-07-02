using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static List<List<Triangle3>> Shading(this GraphicsDevice graphicDevice, ReadOnlyBuffer<Triangle3> triangle3s, Coordinate3 vector, double tolerance)
        {
            if (triangle3s == null || graphicDevice == null)
            {
                return null;
            }

            int length = triangle3s.Length;
            if (length == 0)
            {
                return new List<List<Triangle3>>();
            }


            ReadWriteBuffer<Triangle3Intersection> readWriteBuffer_Triangle3Intersection = graphicDevice.AllocateReadWriteBuffer<Triangle3Intersection>(length * length);

            graphicDevice.For(length, length, new Triangle3ShadingComputeShader(triangle3s, readWriteBuffer_Triangle3Intersection, vector));

            List<Triangle3Intersection> triangle3Intersections = Core.Create.List(readWriteBuffer_Triangle3Intersection);

            List<List<Triangle3>> result = new List<List<Triangle3>>();
            for (int i = 0; i < length; i++)
            {
                List<Triangle3> triangle3s_Temp = new List<Triangle3>();
                for (int j = 0; j < length; j++)
                {
                    Triangle3Intersection triangle3Intersection = triangle3Intersections[i * length + j];
                    if (triangle3Intersection.IsNaN())
                    {
                        continue;
                    }

                    Interfaces.IGeometry3[] geometries = triangle3Intersection.GetIntersectionGeometries();
                    if (geometries == null)
                    {
                        continue;
                    }

                    foreach (Interfaces.IGeometry3 geometry in geometries)
                    {
                        if (geometry is Triangle3)
                        {
                            triangle3s_Temp.Add((Triangle3)geometry);
                        }
                    }
                }

                result.Add(triangle3s_Temp);
            }

            return result;
        }
    }

}

