using ComputeSharp;
using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a compute shader that clips each caster triangle to the sun side of a receiver's plane, projects it along the sun direction onto the plane and appends only the resulting shadow polygons.
    /// <para>Thread <c>(x, y)</c> handles receiver <c>rowOffset + x</c> and triangle <c>y</c>. Dispatch over <c>rowCount x triangles.Length</c> threads (<c>graphicsDevice.For(rowCount, triangles.Length, shader)</c>); threads with <c>rowOffset + x >= receivers.Length</c> are ignored.</para>
    /// <para>Hits are appended through <c>counter[0]</c>, which must be 0 before the dispatch. The counter always ends at the true hit count, while records are written only below <c>polygons.Length</c>; a counter above the capacity means the buffer overflowed and the dispatch must be repeated with a larger buffer. Record order is not deterministic: sort by <see cref="ShadowPolygon2.ReceiverIndex"/> and <see cref="ShadowPolygon2.TriangleIndex"/>.</para>
    /// <para>The <c>rowOffset</c> field is intentionally declared first: it lands at byte offset 12 of the constant buffer, after the <c>__x</c>/<c>__y</c>/<c>__z</c> dispatch header, so the buffer is 56 bytes (14 root constants, even), with <c>tolerance</c> at offset 16 and <c>vector</c> at offsets 32 to 55. With five bound resources an odd root constant count would trigger the driver defect of ZiolkowskiJakub/DiGi.ComputeSharp#3.</para>
    /// </summary>
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3ShadowProjectionComputeShader : IComputeShader
    {
        private readonly int rowOffset = 0;

        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Coordinate3 vector;

        private readonly ReadOnlyBuffer<ShadowReceiver> receivers;

        private readonly ReadOnlyBuffer<Triangle3> triangles;

        private readonly ReadOnlyBuffer<int> elementIndexes;

        /// <summary>
        /// Gets the writeable buffer receiving the appended shadow polygons.
        /// </summary>
        public readonly ReadWriteBuffer<ShadowPolygon2> Polygons;

        /// <summary>
        /// Gets the writeable single-element buffer holding the append counter (the total hit count after the dispatch).
        /// </summary>
        public readonly ReadWriteBuffer<int> Counter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadowProjectionComputeShader"/> struct.
        /// </summary>
        /// <param name="receivers">The receiver faces.</param>
        /// <param name="triangles">The caster triangles.</param>
        /// <param name="elementIndexes">For each caster triangle, the index of the receiver it belongs to, or -1 for a shading-only triangle; a receiver never shades itself.</param>
        /// <param name="polygons">The output buffer of shadow polygons.</param>
        /// <param name="counter">The single-element append counter, 0 before the dispatch.</param>
        /// <param name="vector">The sun propagation direction.</param>
        /// <param name="rowOffset">The zero-based index of the first receiver to process.</param>
        public Triangle3ShadowProjectionComputeShader(ReadOnlyBuffer<ShadowReceiver> receivers, ReadOnlyBuffer<Triangle3> triangles, ReadOnlyBuffer<int> elementIndexes, ReadWriteBuffer<ShadowPolygon2> polygons, ReadWriteBuffer<int> counter, Coordinate3 vector, int rowOffset)
        {
            if (rowOffset < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rowOffset));
            }

            this.vector = vector;
            this.receivers = receivers;
            this.triangles = triangles;
            this.elementIndexes = elementIndexes;
            Polygons = polygons;
            Counter = counter;
            this.rowOffset = rowOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadowProjectionComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="receivers">The receiver faces.</param>
        /// <param name="triangles">The caster triangles.</param>
        /// <param name="elementIndexes">For each caster triangle, the index of the receiver it belongs to, or -1 for a shading-only triangle; a receiver never shades itself.</param>
        /// <param name="polygons">The output buffer of shadow polygons.</param>
        /// <param name="counter">The single-element append counter, 0 before the dispatch.</param>
        /// <param name="vector">The sun propagation direction.</param>
        /// <param name="rowOffset">The zero-based index of the first receiver to process.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3ShadowProjectionComputeShader(ReadOnlyBuffer<ShadowReceiver> receivers, ReadOnlyBuffer<Triangle3> triangles, ReadOnlyBuffer<int> elementIndexes, ReadWriteBuffer<ShadowPolygon2> polygons, ReadWriteBuffer<int> counter, Coordinate3 vector, int rowOffset, double tolerance)
        {
            if (rowOffset < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rowOffset));
            }

            this.tolerance = tolerance;
            this.vector = vector;
            this.receivers = receivers;
            this.triangles = triangles;
            this.elementIndexes = elementIndexes;
            Polygons = polygons;
            Counter = counter;
            this.rowOffset = rowOffset;
        }

        /// <summary>
        /// Executes the compute shader operation over the designated range of threads.
        /// </summary>
        public void Execute()
        {
            int index_Receiver = rowOffset + ThreadIds.X;
            int index_Triangle = ThreadIds.Y;

            if (index_Receiver >= receivers.Length)
            {
                return;
            }

            // A receiver never shades itself.
            if (elementIndexes[index_Triangle] == index_Receiver)
            {
                return;
            }

            ShadowReceiver receiver = receivers[index_Receiver];
            Coordinate3 normal = receiver.Normal;

            // Change of the signed plane distance per unit travelled along the sun direction; near zero the sun grazes the plane.
            double dotProduct = (normal.X * vector.X) + (normal.Y * vector.Y) + (normal.Z * vector.Z);
            if (Hlsl.Abs(dotProduct) <= tolerance)
            {
                return;
            }

            double sign = dotProduct > 0 ? 1 : -1;

            Triangle3 triangle = triangles[index_Triangle];
            Coordinate3 origin = receiver.Origin;

            Coordinate3 point_1 = new(triangle.Point_1.X - origin.X, triangle.Point_1.Y - origin.Y, triangle.Point_1.Z - origin.Z);
            Coordinate3 point_2 = new(triangle.Point_2.X - origin.X, triangle.Point_2.Y - origin.Y, triangle.Point_2.Z - origin.Z);
            Coordinate3 point_3 = new(triangle.Point_3.X - origin.X, triangle.Point_3.Y - origin.Y, triangle.Point_3.Z - origin.Z);

            double s_1 = (normal.X * point_1.X) + (normal.Y * point_1.Y) + (normal.Z * point_1.Z);
            double s_2 = (normal.X * point_2.X) + (normal.Y * point_2.Y) + (normal.Z * point_2.Z);
            double s_3 = (normal.X * point_3.X) + (normal.Y * point_3.Y) + (normal.Z * point_3.Z);

            // Caster fully downstream of the plane.
            double upstream_Max = Hlsl.Max(Hlsl.Max(-sign * s_1, -sign * s_2), -sign * s_3);
            if (upstream_Max <= tolerance)
            {
                return;
            }

            // Sutherland-Hodgman clip against the upstream half-space: at most 4 points.
            int count = 0;
            Coordinate3 clip_1 = point_1, clip_2 = point_1, clip_3 = point_1, clip_4 = point_1;
            double clipS_1 = 0, clipS_2 = 0, clipS_3 = 0, clipS_4 = 0;

            ClipEdge(point_1, point_2, s_1, s_2, sign, tolerance, ref count, ref clip_1, ref clip_2, ref clip_3, ref clip_4, ref clipS_1, ref clipS_2, ref clipS_3, ref clipS_4);
            ClipEdge(point_2, point_3, s_2, s_3, sign, tolerance, ref count, ref clip_1, ref clip_2, ref clip_3, ref clip_4, ref clipS_1, ref clipS_2, ref clipS_3, ref clipS_4);
            ClipEdge(point_3, point_1, s_3, s_1, sign, tolerance, ref count, ref clip_1, ref clip_2, ref clip_3, ref clip_4, ref clipS_1, ref clipS_2, ref clipS_3, ref clipS_4);

            if (count < 3)
            {
                return;
            }

            // Project along the sun direction onto the plane and express in plane coordinates.
            Coordinate2 uv_1 = Project(clip_1, clipS_1, dotProduct, vector, receiver.AxisX, receiver.AxisY);
            Coordinate2 uv_2 = Project(clip_2, clipS_2, dotProduct, vector, receiver.AxisX, receiver.AxisY);
            Coordinate2 uv_3 = Project(clip_3, clipS_3, dotProduct, vector, receiver.AxisX, receiver.AxisY);
            Coordinate2 uv_4 = uv_1;
            if (count == 4)
            {
                uv_4 = Project(clip_4, clipS_4, dotProduct, vector, receiver.AxisX, receiver.AxisY);
            }

            // Bounding-box reject (OR-flags, as the CPU solver): a repeated first point changes no flag.
            double minX = receiver.Min.X - tolerance, minY = receiver.Min.Y - tolerance;
            double maxX = receiver.Max.X + tolerance, maxY = receiver.Max.Y + tolerance;

            bool inRange_X_Min = uv_1.X >= minX || uv_2.X >= minX || uv_3.X >= minX || uv_4.X >= minX;
            bool inRange_X_Max = uv_1.X <= maxX || uv_2.X <= maxX || uv_3.X <= maxX || uv_4.X <= maxX;
            bool inRange_Y_Min = uv_1.Y >= minY || uv_2.Y >= minY || uv_3.Y >= minY || uv_4.Y >= minY;
            bool inRange_Y_Max = uv_1.Y <= maxY || uv_2.Y <= maxY || uv_3.Y <= maxY || uv_4.Y <= maxY;
            if (!inRange_X_Min || !inRange_X_Max || !inRange_Y_Min || !inRange_Y_Max)
            {
                return;
            }

            // Shoelace area; for a triangle the repeated first point closes the ring and adds a zero term.
            double area = (uv_1.X * uv_2.Y) - (uv_2.X * uv_1.Y);
            area += (uv_2.X * uv_3.Y) - (uv_3.X * uv_2.Y);
            area += (uv_3.X * uv_4.Y) - (uv_4.X * uv_3.Y);
            area += (uv_4.X * uv_1.Y) - (uv_1.X * uv_4.Y);

            if (Hlsl.Abs(area / 2) <= tolerance * tolerance)
            {
                return;
            }

            Hlsl.InterlockedAdd(ref Counter[0], 1, out int index);
            if (index >= Polygons.Length)
            {
                return;
            }

            double nan = Hlsl.AsDouble(0u, 0x7FF80000u);
            Coordinate2 point_4 = new(nan, nan);
            if (count == 4)
            {
                point_4 = uv_4;
            }

            Polygons[index] = new ShadowPolygon2(uv_1, uv_2, uv_3, point_4, index_Receiver, index_Triangle, count);
        }

        /// <summary>
        /// Processes one edge of the Sutherland-Hodgman clip against the upstream half-space, appending up to two points.
        /// </summary>
        private static void ClipEdge(Coordinate3 point_1, Coordinate3 point_2, double s_1, double s_2, double sign, double tolerance, ref int count, ref Coordinate3 clip_1, ref Coordinate3 clip_2, ref Coordinate3 clip_3, ref Coordinate3 clip_4, ref double clipS_1, ref double clipS_2, ref double clipS_3, ref double clipS_4)
        {
            double upstream_1 = -sign * s_1;
            double upstream_2 = -sign * s_2;

            bool inside_1 = upstream_1 >= -tolerance;
            bool inside_2 = upstream_2 >= -tolerance;

            if (inside_1)
            {
                Store(point_1, s_1, ref count, ref clip_1, ref clip_2, ref clip_3, ref clip_4, ref clipS_1, ref clipS_2, ref clipS_3, ref clipS_4);
            }

            if (inside_1 != inside_2 && Hlsl.Abs(upstream_1 - upstream_2) > tolerance)
            {
                double factor = upstream_1 / (upstream_1 - upstream_2);
                if (factor > 0 && factor < 1)
                {
                    Coordinate3 point = new(point_1.X + (factor * (point_2.X - point_1.X)), point_1.Y + (factor * (point_2.Y - point_1.Y)), point_1.Z + (factor * (point_2.Z - point_1.Z)));
                    Store(point, 0, ref count, ref clip_1, ref clip_2, ref clip_3, ref clip_4, ref clipS_1, ref clipS_2, ref clipS_3, ref clipS_4);
                }
            }
        }

        /// <summary>
        /// Stores a clipped point and its signed plane distance in the next free slot.
        /// </summary>
        private static void Store(Coordinate3 point, double s, ref int count, ref Coordinate3 clip_1, ref Coordinate3 clip_2, ref Coordinate3 clip_3, ref Coordinate3 clip_4, ref double clipS_1, ref double clipS_2, ref double clipS_3, ref double clipS_4)
        {
            if (count == 0)
            {
                clip_1 = point;
                clipS_1 = s;
            }
            else if (count == 1)
            {
                clip_2 = point;
                clipS_2 = s;
            }
            else if (count == 2)
            {
                clip_3 = point;
                clipS_3 = s;
            }
            else if (count == 3)
            {
                clip_4 = point;
                clipS_4 = s;
            }

            count++;
        }

        /// <summary>
        /// Projects a point along the sun direction onto the receiver's plane and returns its plane coordinates.
        /// </summary>
        private static Coordinate2 Project(Coordinate3 point, double s, double dotProduct, Coordinate3 vector, Coordinate3 axisX, Coordinate3 axisY)
        {
            double factor = -s / dotProduct;

            double x = point.X + (factor * vector.X);
            double y = point.Y + (factor * vector.Y);
            double z = point.Z + (factor * vector.Z);

            return new Coordinate2((axisX.X * x) + (axisX.Y * y) + (axisX.Z * z), (axisY.X * x) + (axisY.Y * y) + (axisY.Z * z));
        }
    }
}
