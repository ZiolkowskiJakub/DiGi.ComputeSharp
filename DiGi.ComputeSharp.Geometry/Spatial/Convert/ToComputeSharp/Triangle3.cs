using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Triangle3D"/> instance to a ComputeSharp <see cref="Triangle3"/>.
        /// </summary>
        /// <param name="triangle3D">The source triangle to convert.</param>
        /// <param name="solid">Indicates whether the resulting triangle should be treated as solid.</param>
        /// <returns>A new <see cref="Triangle3"/> instance representing the converted geometry.</returns>
        public static Triangle3 ToComputeSharp(this Triangle3D triangle3D, bool solid)
        {
            if (triangle3D == null)
            {
                return new Triangle3();
            }

            return new Triangle3(new Bool(solid), ToComputeSharp(triangle3D[0]), ToComputeSharp(triangle3D[1]), ToComputeSharp(triangle3D[2]));
        }
    }
}