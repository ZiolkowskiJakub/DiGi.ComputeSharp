using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3IntersectionsComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly ReadOnlyBuffer<Triangle3> triangles_1;
        private readonly ReadOnlyBuffer<Triangle3> triangles_2;

        /// <summary>
        /// Gets the writeable buffer containing the triangle-to-triangle intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3IntersectionsComputeShader"/> struct.
        /// </summary>
        /// <param name="triangles_1">The read-only buffer of the first collection of 3D triangles.</param>
        /// <param name="triangles_2">The read-only buffer of the second collection of 3D triangles.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing intersection results.</param>
        public Triangle3IntersectionsComputeShader(ReadOnlyBuffer<Triangle3> triangles_1, ReadOnlyBuffer<Triangle3> triangles_2, ReadWriteBuffer<Triangle3Intersection> triangleIntersections)
        {
            this.triangles_1 = triangles_1;
            this.triangles_2 = triangles_2;
            TriangleIntersections = triangleIntersections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3IntersectionsComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="triangles_1">The read-only buffer of the first collection of 3D triangles.</param>
        /// <param name="triangles_2">The read-only buffer of the second collection of 3D triangles.</param>
        /// <param name="triangleIntersections">The read-write buffer for storing intersection results.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3IntersectionsComputeShader(ReadOnlyBuffer<Triangle3> triangles_1, ReadOnlyBuffer<Triangle3> triangles_2, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, double tolerance)
        {
            this.triangles_1 = triangles_1;
            this.triangles_2 = triangles_2;
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

            // Row-major layout: row = triangles_1 index, column = triangles_2 index.
            // Stride is the inner (column) dimension == triangles_2.Length.
            TriangleIntersections[(index_1 * triangles_2.Length) + index_2] = Create.Triangle3Intersection(triangles_1[index_1], triangles_2[index_2], tolerance);
        }
    }
}