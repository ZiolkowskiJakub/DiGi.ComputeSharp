using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Line3IntersectionComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constans.Tolerance.Distance;

        private readonly int threadsCount = -1;

        private readonly Line3 line;
        private readonly ReadOnlyBuffer<Line3> lines;

        public readonly ReadWriteBuffer<Line3Intersection> LineIntersections;


        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines)
        {
            this.line = line;

            if (graphicsDevice != null)
            {
                this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
            }
        }

        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines, double tolerance, int threadsCount = -1)
        {
            this.threadsCount = threadsCount;
            this.tolerance = tolerance;

            this.line = line;

            if (graphicsDevice != null)
            {
                this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
            }
        }

        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections)
        {
            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections, double tolerance, int threadsCount = -1)
        {
            this.tolerance = tolerance;
            this.threadsCount = threadsCount;

            this.line = line;
            this.lines = lines;

            LineIntersections = lineIntersections;
        }

        public void Execute()
        {
            int count = lines.Length;

            int start = 0;
            int end = 0;
            if (threadsCount < 1)
            {
                start = 0;
                end = count;
            }
            else
            {
                int length = (count / threadsCount) + 1;

                int index = ThreadIds.X;

                start = index * length;
                end = index * length + length;
            }

            for (int i = start; i < end; i++)
            {
                LineIntersections[i] = Create.Line3Intersection(line, lines[i], tolerance);
            }
        }
    }
}
