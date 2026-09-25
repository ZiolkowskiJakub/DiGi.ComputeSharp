using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="IPolygonalFace3D"/> to a ComputeSharp <see cref="ShadowReceiver"/>.
        /// <para>The plane frame (origin, normal and both axes) comes from <see cref="IPlanar.Plane"/> and the bounding box from the face's 2D geometry, so projected plane coordinates match that geometry.</para>
        /// </summary>
        /// <param name="polygonalFace3D">The source face.</param>
        /// <returns>The receiver, or <see langword="null"/> when the face, its plane, its 2D geometry or its bounding box is missing.</returns>
        public static ShadowReceiver? ToComputeSharp(this IPolygonalFace3D? polygonalFace3D)
        {
            DiGi.Geometry.Spatial.Classes.Plane? plane = polygonalFace3D?.Plane;
            if (plane is null)
            {
                return null;
            }

            Point3D? origin = plane.Origin;
            Vector3D? normal = plane.Normal;
            Vector3D? axisX = plane.AxisX;
            Vector3D? axisY = plane.AxisY;
            BoundingBox2D? boundingBox2D = polygonalFace3D?.Geometry2D?.GetBoundingBox();
            if (origin is null || normal is null || axisX is null || axisY is null || boundingBox2D?.Min is null || boundingBox2D.Max is null)
            {
                return null;
            }

            return new ShadowReceiver(origin.ToComputeSharp(), normal.ToComputeSharp(), axisX.ToComputeSharp(), axisY.ToComputeSharp(), new Coordinate2(boundingBox2D.Min.X, boundingBox2D.Min.Y), new Coordinate2(boundingBox2D.Max.X, boundingBox2D.Max.Y));
        }
    }
}
