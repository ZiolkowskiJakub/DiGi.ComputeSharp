using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
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