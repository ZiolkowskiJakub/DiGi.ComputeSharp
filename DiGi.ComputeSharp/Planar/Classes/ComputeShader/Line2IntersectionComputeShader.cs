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

        public readonly ReadWriteBuffer<Line2Intersection> LineIntersections;

        public Line2IntersectionComputeShader(GraphicsDevice graphicsDevice, Line2 line, IEnumerable<Line2> lines)
        {
            this.line = line;
            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line2Intersection[lines.Count()]);
        }

        public Line2IntersectionComputeShader(GraphicsDevice graphicsDevice, Line2 line, IEnumerable<Line2> lines, double tolerance)
        {
            this.tolerance = tolerance;

            this.line = line;

            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line2Intersection[lines.Count()]);
        }

        public Line2IntersectionComputeShader(Line2 line, ReadOnlyBuffer<Line2> lines, ReadWriteBuffer<Line2Intersection> lineIntersections)
        {
            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        public Line2IntersectionComputeShader(Line2 line, ReadOnlyBuffer<Line2> lines, ReadWriteBuffer<Line2Intersection> lineIntersections, double tolerance)
        {
            this.tolerance = tolerance;

            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        public void Execute()
        {
            // One thread per line. ComputeSharp bounds the dispatch to the requested count, so ThreadIds.X
            // is always a valid index.
            int index = ThreadIds.X;

            LineIntersections[index] = Create.Line2Intersection(line, lines[index], tolerance);
        }
    }
}
