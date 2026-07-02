using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a compute shader used to determine if a 3D coordinate is inside a set of triangles.
    /// </summary>
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Coordinate3InsideComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly ReadOnlyBuffer<Coordinate3> points;
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        /// <summary>
        /// Gets the writeable buffer containing the index of the first containing triangle for each point, or -1 if the point is outside all triangles.
        /// </summary>
        public readonly ReadWriteBuffer<int> Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3InsideComputeShader"/> struct.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="points">The collection of 3D points to test.</param>
        /// <param name="triangles">The collection of 3D triangles to test against.</param>
        public Coordinate3InsideComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Coordinate3> points, IEnumerable<Triangle3> triangles)
        {
            this.points = graphicsDevice.AllocateReadOnlyBuffer(points.ToArray());
            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.points.Length);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3InsideComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="points">The collection of 3D points to test.</param>
        /// <param name="triangles">The collection of 3D triangles to test against.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Coordinate3InsideComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Coordinate3> points, IEnumerable<Triangle3> triangles, double tolerance)
        {
            this.tolerance = tolerance;

            this.points = graphicsDevice.AllocateReadOnlyBuffer(points.ToArray());
            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.points.Length);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3InsideComputeShader"/> struct using pre-allocated buffers.
        /// </summary>
        /// <param name="points">The read-only buffer of 3D points.</param>
        /// <param name="triangles">The read-only buffer of 3D triangles.</param>
        /// <param name="result">The read-write buffer for storing results.</param>
        public Coordinate3InsideComputeShader(ReadOnlyBuffer<Coordinate3> points, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<int> result)
        {
            this.points = points;
            this.triangles = triangles;
            Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3InsideComputeShader"/> struct using pre-allocated buffers and a custom tolerance.
        /// </summary>
        /// <param name="points">The read-only buffer of 3D points.</param>
        /// <param name="triangles">The read-only buffer of 3D triangles.</param>
        /// <param name="result">The read-write buffer for storing results.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Coordinate3InsideComputeShader(ReadOnlyBuffer<Coordinate3> points, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<int> result, double tolerance)
        {
            this.points = points;
            this.triangles = triangles;
            this.tolerance = tolerance;
            Result = result;
        }

        void IComputeShader.Execute()
        {
            int index = ThreadIds.X;

            Coordinate3 point = points[index];
            Result[index] = -1;

            if (point.IsNaN())
            {
                return;
            }

            int length = triangles.Length;
            for (int i = 0; i < length; i++)
            {
                Triangle3 triangle = triangles[i];
                if (triangle.IsNaN())
                {
                    continue;
                }

                if (!triangle.Inside(point, tolerance))
                {
                    continue;
                }

                Result[index] = i;
                return;
            }
        }
    }
}