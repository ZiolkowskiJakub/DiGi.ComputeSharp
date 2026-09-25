using DiGi.ComputeSharp.Core.Interfaces;
using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents one shadow polygon cast by a caster triangle on a receiver face, in the receiver's plane coordinates.
    /// <para>The polygon has 3 or 4 points (<see cref="Count"/>); unused points are NaN. The doubles are declared first, so the struct's 8-byte alignment pads it to 80 bytes.</para>
    /// </summary>
    public readonly struct ShadowPolygon2 : IResult
    {
        /// <summary>The first point of the polygon.</summary>
        public readonly Coordinate2 Point_1;

        /// <summary>The second point of the polygon.</summary>
        public readonly Coordinate2 Point_2;

        /// <summary>The third point of the polygon.</summary>
        public readonly Coordinate2 Point_3;

        /// <summary>The fourth point of the polygon, NaN when <see cref="Count"/> is 3.</summary>
        public readonly Coordinate2 Point_4;

        /// <summary>The index of the receiver the polygon lies on.</summary>
        public readonly int ReceiverIndex;

        /// <summary>The index of the caster triangle that casts the polygon.</summary>
        public readonly int TriangleIndex;

        /// <summary>The number of valid points (3 or 4).</summary>
        public readonly int Count;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowPolygon2"/> struct with NaN points and no valid point.
        /// </summary>
        public ShadowPolygon2()
        {
            Point_1 = new Coordinate2();
            Point_2 = new Coordinate2();
            Point_3 = new Coordinate2();
            Point_4 = new Coordinate2();
            ReceiverIndex = -1;
            TriangleIndex = -1;
            Count = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowPolygon2"/> struct with the specified points and indexes.
        /// </summary>
        /// <param name="point_1">The first point.</param>
        /// <param name="point_2">The second point.</param>
        /// <param name="point_3">The third point.</param>
        /// <param name="point_4">The fourth point, NaN when <paramref name="count"/> is 3.</param>
        /// <param name="receiverIndex">The index of the receiver.</param>
        /// <param name="triangleIndex">The index of the caster triangle.</param>
        /// <param name="count">The number of valid points (3 or 4).</param>
        public ShadowPolygon2(Coordinate2 point_1, Coordinate2 point_2, Coordinate2 point_3, Coordinate2 point_4, int receiverIndex, int triangleIndex, int count)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
            Point_4 = point_4;
            ReceiverIndex = receiverIndex;
            TriangleIndex = triangleIndex;
            Count = count;
        }
    }
}
