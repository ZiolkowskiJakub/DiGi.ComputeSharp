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

        public readonly ReadWriteBuffer<Line3Intersection> LineIntersections;

        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines)
        {
            this.line = line;
            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
        }

        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines, double tolerance)
        {
            this.tolerance = tolerance;

            this.line = line;

            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
        }

        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections)
        {
            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections, double tolerance)
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

            LineIntersections[index] = Create.Line3Intersection(line, lines[index], tolerance);
        }
    }
}
