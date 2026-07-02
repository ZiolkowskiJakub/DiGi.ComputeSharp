using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3ShadingComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Coordinate3 vector;

        private readonly ReadOnlyBuffer<Triangle3> triangles;

        /// <summary>
        /// Gets the writeable buffer containing the triangle shading intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadingComputeShader"/> struct.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="triangles">The collection of 3D triangles to test against each other for shading.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        public Triangle3ShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, Coordinate3 vector)
        {
            this.vector = vector;

            int count = triangles.Count();

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadingComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="triangles">The collection of 3D triangles to test against each other for shading.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3ShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, Coordinate3 vector, double tolerance)
        {
            this.tolerance = tolerance;

            this.vector = vector;

            int count = triangles.Count();

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadingComputeShader"/> struct using pre-allocated buffers.
        /// </summary>
        /// <param name="triangles">The read-only buffer of 3D triangles to test against each other.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing shading results.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        public Triangle3ShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector)
        {
            this.vector = vector;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadingComputeShader"/> struct using pre-allocated buffers and a custom tolerance.
        /// </summary>
        /// <param name="triangles">The read-only buffer of 3D triangles to test against each other.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing shading results.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3ShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector, double tolerance)
        {
            this.vector = vector;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Executes the compute shader operation over the designated range of threads.
        /// </summary>
        public void Execute()
        {
            int index_1 = ThreadIds.X;
            int index_2 = ThreadIds.Y;

            TriangleIntersections[(index_1 * triangles.Length) + index_2] = Create.Triangle3Intersection(triangles[index_1], triangles[index_2], vector, true, false, tolerance);
        }
    }
}