using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3ExternalShadingComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Coordinate3 vector = new();

        private readonly ReadOnlyBuffer<Triangle3> triangles;

        private readonly ReadOnlyBuffer<Triangle3> externalTriangles;

        /// <summary>
        /// Gets the writeable buffer containing the triangle intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ExternalShadingComputeShader"/> struct.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="triangles">The collection of target 3D triangles.</param>
        /// <param name="externalTriangles">The collection of external 3D shading/blocking triangles.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        public Triangle3ExternalShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, IEnumerable<Triangle3> externalTriangles, Coordinate3 vector)
        {
            this.vector = vector;

            int count = triangles.Count();
            int count_External = externalTriangles.Count();

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            this.externalTriangles = graphicsDevice.AllocateReadOnlyBuffer(externalTriangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count_External]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ExternalShadingComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="triangles">The collection of target 3D triangles.</param>
        /// <param name="externalTriangles">The collection of external 3D shading/blocking triangles.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3ExternalShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, IEnumerable<Triangle3> externalTriangles, Coordinate3 vector, double tolerance)
        {
            this.tolerance = tolerance;

            this.vector = vector;

            int count = triangles.Count();
            int count_External = externalTriangles.Count();

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            this.externalTriangles = graphicsDevice.AllocateReadOnlyBuffer(externalTriangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count_External]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ExternalShadingComputeShader"/> struct using pre-allocated buffers.
        /// </summary>
        /// <param name="triangles">The read-only buffer of target 3D triangles.</param>
        /// <param name="externalTriangles">The read-only buffer of external 3D shading triangles.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing intersection results.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        public Triangle3ExternalShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadOnlyBuffer<Triangle3> externalTriangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector)
        {
            this.vector = vector;
            this.triangles = triangles;
            this.externalTriangles = externalTriangles;
            TriangleIntersections = triangleIntersections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ExternalShadingComputeShader"/> struct using pre-allocated buffers and a custom tolerance.
        /// </summary>
        /// <param name="triangles">The read-only buffer of target 3D triangles.</param>
        /// <param name="externalTriangles">The read-only buffer of external 3D shading triangles.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing intersection results.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3ExternalShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadOnlyBuffer<Triangle3> externalTriangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector, double tolerance)
        {
            this.vector = vector;
            this.triangles = triangles;
            this.externalTriangles = externalTriangles;
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

            TriangleIntersections[(index_1 * externalTriangles.Length) + index_2] = Create.Triangle3Intersection(triangles[index_1], externalTriangles[index_2], vector, true, false, tolerance);
        }
    }
}