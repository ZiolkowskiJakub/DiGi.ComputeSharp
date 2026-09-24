using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a compute shader used to calculate self-shading intersections among a collection of 3D triangles along a direction vector, starting from a row offset.
    /// <para>The shader processes a horizontal slice of the full intersection matrix so that the output buffer only holds the processed rows instead of the full <c>triangles.Length x triangles.Length</c> matrix. The concatenation of successive row-offset dispatches reproduces the layout of a single full dispatch of <see cref="Triangle3ShadingComputeShader"/>.</para>
    /// <para>The <c>rowOffset</c> field is intentionally declared first: ComputeSharp places it at byte offset 12 of the constant buffer, in the 4 padding bytes after the <c>__x</c>/<c>__y</c>/<c>__z</c> dispatch header, so the buffer keeps the exact 56-byte layout of <see cref="Triangle3ShadingComputeShader"/> (<c>tolerance</c> at offset 16, <c>vector</c> at offsets 32 to 55), matching the layout choice of <see cref="Triangle3ExternalShadingRowOffsetComputeShader"/>.</para>
    /// </summary>
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3ShadingRowOffsetComputeShader : IComputeShader
    {
        private readonly int rowOffset = 0;

        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Coordinate3 vector;

        private readonly ReadOnlyBuffer<Triangle3> triangles;

        /// <summary>
        /// Gets the writeable buffer containing the triangle shading intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadingRowOffsetComputeShader"/> struct using pre-allocated buffers and a row offset.
        /// <para>The shader processes a horizontal slice of the full intersection matrix: the input triangle of a thread is <c>triangles[rowOffset + ThreadIds.X]</c> and the output cell is <c>(ThreadIds.X * triangles.Length) + ThreadIds.Y</c> of <paramref name="triangleIntersections"/>, so the row stride stays <c>triangles.Length</c> (the full column count) and the concatenation of successive row-offset dispatches reproduces the layout of a single full dispatch of <see cref="Triangle3ShadingComputeShader"/>.</para>
        /// <para>Buffer-size contract: dispatch over <c>rowCount x triangles.Length</c> threads (<c>graphicsDevice.For(rowCount, triangles.Length, shader)</c>) and provide a <paramref name="triangleIntersections"/> buffer holding at least <c>rowCount x triangles.Length</c> elements. Threads with <c>rowOffset + ThreadIds.X >= triangles.Length</c> are ignored, so the last partial block of a tiled dispatch is safe. Ignored threads write nothing: when one output buffer is reused across blocks, its rows beyond <c>triangles.Length - rowOffset</c> keep the previous block's results, so read only the first <c>min(rowCount, triangles.Length - rowOffset) x triangles.Length</c> elements.</para>
        /// </summary>
        /// <param name="triangles">The read-only buffer of 3D triangles to test against each other. Its length is the output row stride (column count).</param>
        /// <param name="triangleIntersections">The read-write buffer for storing shading results. Must hold at least <c>rowCount x triangles.Length</c> elements, where <c>rowCount</c> is the dispatch width.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        /// <param name="rowOffset">The zero-based index of the first input triangle row to process.</param>
        public Triangle3ShadingRowOffsetComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector, int rowOffset)
        {
            if (rowOffset < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rowOffset));
            }

            this.vector = vector;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
            this.rowOffset = rowOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3ShadingRowOffsetComputeShader"/> struct using pre-allocated buffers, a row offset, and a custom tolerance.
        /// <para>The shader processes a horizontal slice of the full intersection matrix: the input triangle of a thread is <c>triangles[rowOffset + ThreadIds.X]</c> and the output cell is <c>(ThreadIds.X * triangles.Length) + ThreadIds.Y</c> of <paramref name="triangleIntersections"/>, so the row stride stays <c>triangles.Length</c> (the full column count) and the concatenation of successive row-offset dispatches reproduces the layout of a single full dispatch of <see cref="Triangle3ShadingComputeShader"/>.</para>
        /// <para>Buffer-size contract: dispatch over <c>rowCount x triangles.Length</c> threads (<c>graphicsDevice.For(rowCount, triangles.Length, shader)</c>) and provide a <paramref name="triangleIntersections"/> buffer holding at least <c>rowCount x triangles.Length</c> elements. Threads with <c>rowOffset + ThreadIds.X >= triangles.Length</c> are ignored, so the last partial block of a tiled dispatch is safe. Ignored threads write nothing: when one output buffer is reused across blocks, its rows beyond <c>triangles.Length - rowOffset</c> keep the previous block's results, so read only the first <c>min(rowCount, triangles.Length - rowOffset) x triangles.Length</c> elements.</para>
        /// </summary>
        /// <param name="triangles">The read-only buffer of 3D triangles to test against each other. Its length is the output row stride (column count).</param>
        /// <param name="triangleIntersections">The read-write buffer for storing shading results. Must hold at least <c>rowCount x triangles.Length</c> elements, where <c>rowCount</c> is the dispatch width.</param>
        /// <param name="vector">The direction vector for the shading calculation.</param>
        /// <param name="rowOffset">The zero-based index of the first input triangle row to process.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Triangle3ShadingRowOffsetComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector, int rowOffset, double tolerance)
        {
            if (rowOffset < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rowOffset));
            }

            this.tolerance = tolerance;
            this.vector = vector;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
            this.rowOffset = rowOffset;
        }

        /// <summary>
        /// Executes the compute shader operation over the designated range of threads.
        /// </summary>
        public void Execute()
        {
            int index_1 = ThreadIds.X;
            int index_2 = ThreadIds.Y;

            int index_Row = rowOffset + index_1;
            if (index_Row >= triangles.Length)
            {
                return;
            }

            TriangleIntersections[(index_1 * triangles.Length) + index_2] = Create.Triangle3Intersection(triangles[index_Row], triangles[index_2], vector, true, false, tolerance);
        }
    }
}
