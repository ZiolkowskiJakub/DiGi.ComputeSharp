using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Performs shading calculations on a collection of triangles grouped by shading results, using the specified graphics device.
        /// </summary>
        /// <param name="graphicDevice">The graphics device used to execute the shading operations.</param>
        /// <param name="triangle3s">A read-only buffer containing the triangle data to be shaded.</param>
        /// <param name="vector">The vector representing the light or view direction for the shading calculation.</param>
        /// <returns>A nested list of triangles grouped by shading results, or null if the operation could not be completed.</returns>
        public static List<List<Triangle3>>? Shading(this GraphicsDevice graphicDevice, ReadOnlyBuffer<Triangle3> triangle3s, Coordinate3 vector)
        {
            if (triangle3s == null || graphicDevice == null)
            {
                return null;
            }

            int length = triangle3s.Length;
            if (length == 0)
            {
                return [];
            }

            using ReadWriteBuffer<Triangle3Intersection> readWriteBuffer_Triangle3Intersection = graphicDevice.AllocateReadWriteBuffer<Triangle3Intersection>(length * length);

            graphicDevice.For(length, length, new Triangle3ShadingComputeShader(triangle3s, readWriteBuffer_Triangle3Intersection, vector));

            List<Triangle3Intersection>? triangle3Intersections = Core.Create.List(readWriteBuffer_Triangle3Intersection);
            if (triangle3Intersections is null)
            {
                return [];
            }

            List<List<Triangle3>> result = [];
            for (int i = 0; i < length; i++)
            {
                List<Triangle3> triangle3s_Temp = [];
                for (int j = 0; j < length; j++)
                {
                    Triangle3Intersection triangle3Intersection = triangle3Intersections[i * length + j];
                    if (triangle3Intersection.IsNaN())
                    {
                        continue;
                    }

                    Interfaces.IGeometry3[]? geometries = triangle3Intersection.GetIntersectionGeometries();
                    if (geometries == null)
                    {
                        continue;
                    }

                    foreach (Interfaces.IGeometry3 geometry in geometries)
                    {
                        if (geometry is Triangle3 triangle3)
                        {
                            triangle3s_Temp.Add(triangle3);
                        }
                    }
                }

                result.Add(triangle3s_Temp);
            }

            return result;
        }
    }
}