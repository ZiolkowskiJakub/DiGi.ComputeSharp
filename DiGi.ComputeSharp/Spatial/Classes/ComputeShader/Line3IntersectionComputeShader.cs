using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    public readonly partial struct Line3IntersectionComputeShader : IComputeShader
    {
        public readonly Line3 Line;
        public readonly ReadWriteBuffer<Line3Intersection> LineIntersections;
        public readonly ReadOnlyBuffer<Line3> Lines;
        public readonly int ThreadsCount = -1;

        public readonly float Tolerance = Core.Constans.Tolerance.Distance;
        
        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines)
        {
            Line = line;

            if (graphicsDevice != null)
            {
                Lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
            }
        }

        public Line3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Line3> lines, float tolerance, int threadsCount = -1)
        {
            ThreadsCount = threadsCount;

            Line = line;
            Tolerance = tolerance;

            if (graphicsDevice != null)
            {
                Lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                LineIntersections = graphicsDevice.AllocateReadWriteBuffer(new Line3Intersection[lines.Count()]);
            }
        }

        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections)
        {
            Line = line;
            Lines = lines;
            LineIntersections = lineIntersections;
        }

        public Line3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Line3> lines, ReadWriteBuffer<Line3Intersection> lineIntersections, float tolerance)
        {
            Line = line;
            Lines = lines;
            LineIntersections = lineIntersections;
            Tolerance = tolerance;
        }

        public void Execute()
        {
            int count = Lines.Length;

            int start = 0;
            int end = 0;
            if (ThreadsCount < 1)
            {
                start = 0;
                end = count;
            }
            else
            {
                int length = (count / ThreadsCount) + 1;

                int index = ThreadIds.X;

                start = index * length;
                end = index * length + length;
            }

            for (int i = start; i < end; i++)
            {
                LineIntersections[i] = Create.Line3Intersection(Line, Lines[i], Tolerance);
            }
        }
    }
}
