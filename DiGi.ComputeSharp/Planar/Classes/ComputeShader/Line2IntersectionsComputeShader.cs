using ComputeSharp;

namespace DiGi.ComputeSharp.Planar.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Line2IntersectionsComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly ReadOnlyBuffer<Line2> lines;
        private readonly ReadOnlyBuffer<Triangle2> triangles;

        /// <summary>
        /// Gets the writeable buffer containing the line-to-triangle intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Line2Intersection> LineIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectionsComputeShader"/> struct.
        /// </summary>
        /// <param name="lines">The read-only buffer of 2D lines.</param>
        /// <param name="triangles">The read-only buffer of 2D triangles.</param>
        /// <param name="lineIntersections">The read-write buffer for storing the intersection results.</param>
        public Line2IntersectionsComputeShader(ReadOnlyBuffer<Line2> lines, ReadOnlyBuffer<Triangle2> triangles, ReadWriteBuffer<Line2Intersection> lineIntersections)
        {
            this.lines = lines;
            this.triangles = triangles;
            LineIntersections = lineIntersections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectionsComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="lines">The read-only buffer of 2D lines.</param>
        /// <param name="triangles">The read-only buffer of 2D triangles.</param>
        /// <param name="lineIntersections">The read-write buffer for storing the intersection results.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Line2IntersectionsComputeShader(ReadOnlyBuffer<Line2> lines, ReadOnlyBuffer<Triangle2> triangles, ReadWriteBuffer<Line2Intersection> lineIntersections, double tolerance)
        {
            this.lines = lines;
            this.triangles = triangles;
            LineIntersections = lineIntersections;
            this.tolerance = tolerance;
        }

        /// <summary>
        /// Executes the compute shader operation over the designated range of threads.
        /// </summary>
        public void Execute()
        {
            int index_1 = ThreadIds.X;
            int index_2 = ThreadIds.Y;

            // Row-major layout: row = lines index, column = triangles index.
            // Stride is the inner (column) dimension == triangles.Length.
            LineIntersections[(index_1 * triangles.Length) + index_2] = Create.Line2Intersection(lines[index_1], triangles[index_2], tolerance);
        }
    }
}