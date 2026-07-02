using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3IntersectionComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Triangle3 triangle;
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        /// <summary>
        /// Gets the writeable buffer containing the triangle intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3IntersectionComputeShader"/> struct.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="triangle">The primary 3D triangle to intersect with other triangles.</param>
        /// <param name="triangles">The collection of 3D triangles to check against the primary triangle.</param>
        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles)
        {
            this.triangle = triangle;

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3IntersectionComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="triangle">The primary 3D triangle to intersect with other triangles.</param>
        /// <param name="triangles">The collection of 3D triangles to check against the primary triangle.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles, double tolerance)
        {
            this.triangle = triangle;
            this.tolerance = tolerance;

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3IntersectionComputeShader"/> struct using pre-allocated buffers.
        /// </summary>
        /// <param name="triangle">The primary 3D triangle to intersect with other triangles.</param>
        /// <param name="triangles">The read-only buffer of 3D triangles to check against.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing intersection results.</param>
        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections)
        {
            this.triangle = triangle;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3IntersectionComputeShader"/> struct using pre-allocated buffers and a custom tolerance.
        /// </summary>
        /// <param name="triangle">The primary 3D triangle to intersect with other triangles.</param>
        /// <param name="triangles">The read-only buffer of 3D triangles to check against.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing intersection results.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, double tolerance)
        {
            this.triangle = triangle;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Executes the compute shader operation over the designated range of threads.
        /// </summary>
        public void Execute()
        {
            // One thread per triangle. ComputeSharp bounds the dispatch to the requested count, so ThreadIds.X
            // is always a valid index.
            int index = ThreadIds.X;

            TriangleIntersections[index] = Create.Triangle3Intersection(triangle, triangles[index], tolerance);
        }
    }
}