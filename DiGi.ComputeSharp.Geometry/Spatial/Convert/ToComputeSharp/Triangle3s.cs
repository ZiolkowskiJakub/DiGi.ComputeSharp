using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a collection of <see cref="Triangle3D"/> elements to a list of ComputeSharp <see cref="Triangle3"/> elements.
        /// </summary>
        /// <param name="triangle3Ds">The source enumerable of <see cref="Triangle3D"/> objects to convert.</param>
        /// <param name="solid">A flag indicating whether the conversion should treat the geometry as solid.</param>
        /// <returns>A list of ComputeSharp <see cref="Triangle3"/> objects, or null if the input collection is null.</returns>
        public static List<Triangle3>? ToComputeSharp(this IEnumerable<Triangle3D>? triangle3Ds, bool solid)
        {
            if (triangle3Ds == null)
            {
                return null;
            }

            List<Triangle3> result = [];
            foreach (Triangle3D triangle3D in triangle3Ds)
            {
                result.Add(ToComputeSharp(triangle3D, solid));
            }

            return result;
        }

        /// <summary>
        /// Converts a Mesh3D instance into a list of ComputeSharp Triangle3 structures.
        /// </summary>
        /// <param name="mesh3D">The source mesh to be converted.</param>
        /// <param name="solid">A flag indicating whether the conversion should treat the mesh as a solid volume.</param>
        /// <returns>A list of Triangle3 objects representing the mesh, or null if the input mesh is null.</returns>
        public static List<Triangle3>? ToComputeSharp(this Mesh3D? mesh3D, bool solid)
        {
            return ToComputeSharp(mesh3D?.GetTriangles(), solid);
        }
    }
}