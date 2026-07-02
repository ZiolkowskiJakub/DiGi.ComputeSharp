using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Line3IntersectionComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Line3 line = new();
        private readonly ReadOnlyBuffer<Line3> lines;

        /// <summary>
        /// Gets the writeable buffer containing the line intersection results.
        /// </summary>
        public readonly ReadWriteBuffer<Line3Intersection> LineIntersections;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3IntersectionComputeShader"/> struct.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="line">The primary 3D line to intersect with other lines.</param>
        /// <param name="lines">The collection of 3D lines to check against the primary line.</param>
        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines)
        {
            this.line = line;
            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3IntersectionComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="line">The primary 3D line to intersect with other lines.</param>
        /// <param name="lines">The collection of 3D lines to check against the primary line.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines, double tolerance)
        {
            this.tolerance = tolerance;

            this.line = line;

            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3IntersectionComputeShader"/> struct using pre-allocated buffers.
        /// </summary>
        /// <param name="line">The primary 3D line to intersect with other lines.</param>
        /// <param name="lines">The read-only buffer of 3D lines to check against.</param>
        /// <param name="lineIntersections">The read-write buffer for storing the intersection results.</param>
        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections)
        {
            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3IntersectionComputeShader"/> struct using pre-allocated buffers and a custom tolerance.
        /// </summary>
        /// <param name="line">The primary 3D line to intersect with other lines.</param>
        /// <param name="lines">The read-only buffer of 3D lines to check against.</param>
        /// <param name="lineIntersections">The read-write buffer for storing the intersection results.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections, double tolerance)
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

            LineIntersections[index] = Create.Line3Intersection(line, lines[index], tolerance);
        }
    }
}