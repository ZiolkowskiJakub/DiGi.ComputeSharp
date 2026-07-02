using ComputeSharp;

namespace DiGi.ComputeSharp.Planar.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Line2IntersectionComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Line2 line = new();
        private readonly ReadOnlyBuffer<Line2> lines;

        /// <summary>
        /// Gets the writeable buffer containing the line intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Line2Intersection> LineIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectionComputeShader"/> struct.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="line">The primary 2D line to intersect with other lines.</param>
        /// <param name="lines">The collection of 2D lines to check against the primary line.</param>
        public Line2IntersectionComputeShader(GraphicsDevice graphicsDevice, Line2 line, IEnumerable<Line2> lines)
        {
            this.line = line;
            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line2Intersection[lines.Count()]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectionComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="line">The primary 2D line to intersect with other lines.</param>
        /// <param name="lines">The collection of 2D lines to check against the primary line.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Line2IntersectionComputeShader(GraphicsDevice graphicsDevice, Line2 line, IEnumerable<Line2> lines, double tolerance)
        {
            this.tolerance = tolerance;

            this.line = line;

            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line2Intersection[lines.Count()]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectionComputeShader"/> struct using pre-allocated buffers.
        /// </summary>
        /// <param name="line">The primary 2D line to intersect with other lines.</param>
        /// <param name="lines">The read-only buffer of 2D lines to check against.</param>
        /// <param name="lineIntersections">The read-write buffer for storing the intersection results.</param>
        public Line2IntersectionComputeShader(Line2 line, ReadOnlyBuffer<Line2> lines, ReadWriteBuffer<Line2Intersection> lineIntersections)
        {
            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectionComputeShader"/> struct using pre-allocated buffers and a custom tolerance.
        /// </summary>
        /// <param name="line">The primary 2D line to intersect with other lines.</param>
        /// <param name="lines">The read-only buffer of 2D lines to check against.</param>
        /// <param name="lineIntersections">The read-write buffer for storing the intersection results.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Line2IntersectionComputeShader(Line2 line, ReadOnlyBuffer<Line2> lines, ReadWriteBuffer<Line2Intersection> lineIntersections, double tolerance)
        {
            this.tolerance = tolerance;

            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        /// <summary>
        /// Executes the compute shader operation over the designated range of threads.
        /// </summary>
        public void Execute()
        {
            // One thread per line. ComputeSharp bounds the dispatch to the requested count, so ThreadIds.X
            // is always a valid index.
            int index = ThreadIds.X;

            LineIntersections[index] = Create.Line2Intersection(line, lines[index], tolerance);
        }
    }
}
