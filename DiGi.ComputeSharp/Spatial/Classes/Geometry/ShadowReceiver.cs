using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a planar receiver face of a shadow projection: the plane's local frame and the face's 2D bounding box in that frame.
    /// <para><see cref="AxisX"/> is carried explicitly rather than derived (as <see cref="Plane.GetAxisX(double)"/> does), so that projected plane coordinates match the receiver's own 2D geometry exactly.</para>
    /// </summary>
    public readonly struct ShadowReceiver : IGeometry3
    {
        /// <summary>
        /// The origin of the receiver's plane.
        /// </summary>
        public readonly Coordinate3 Origin;

        /// <summary>
        /// The unit normal of the receiver's plane.
        /// </summary>
        public readonly Coordinate3 Normal;

        /// <summary>
        /// The local X axis of the receiver's plane.
        /// </summary>
        public readonly Coordinate3 AxisX;

        /// <summary>
        /// The local Y axis of the receiver's plane.
        /// </summary>
        public readonly Coordinate3 AxisY;

        /// <summary>
        /// The minimum corner of the face's 2D bounding box in plane coordinates.
        /// </summary>
        public readonly Coordinate2 Min;

        /// <summary>
        /// The maximum corner of the face's 2D bounding box in plane coordinates.
        /// </summary>
        public readonly Coordinate2 Max;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowReceiver"/> struct with NaN values.
        /// </summary>
        public ShadowReceiver()
        {
            Origin = new Coordinate3();
            Normal = new Coordinate3();
            AxisX = new Coordinate3();
            AxisY = new Coordinate3();
            Min = new Coordinate2();
            Max = new Coordinate2();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowReceiver"/> struct with the specified plane frame and bounding box.
        /// </summary>
        /// <param name="origin">The origin of the receiver's plane.</param>
        /// <param name="normal">The unit normal of the receiver's plane.</param>
        /// <param name="axisX">The local X axis of the receiver's plane.</param>
        /// <param name="axisY">The local Y axis of the receiver's plane.</param>
        /// <param name="min">The minimum corner of the face's 2D bounding box in plane coordinates.</param>
        /// <param name="max">The maximum corner of the face's 2D bounding box in plane coordinates.</param>
        public ShadowReceiver(Coordinate3 origin, Coordinate3 normal, Coordinate3 axisX, Coordinate3 axisY, Coordinate2 min, Coordinate2 max)
        {
            Origin = origin;
            Normal = normal;
            AxisX = axisX;
            AxisY = axisY;
            Min = min;
            Max = max;
        }
    }
}
