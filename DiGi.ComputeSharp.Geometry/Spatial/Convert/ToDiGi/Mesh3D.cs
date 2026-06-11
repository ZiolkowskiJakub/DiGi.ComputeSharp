using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a collection of Triangle3 objects into a Mesh3D object.
        /// </summary>
        /// <param name="triangle3s">The collection of triangles to be converted.</param>
        /// <param name="tolerance">The distance tolerance used for vertex merging or processing.</param>
        /// <returns>A Mesh3D instance if the conversion is successful; otherwise, null.</returns>
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