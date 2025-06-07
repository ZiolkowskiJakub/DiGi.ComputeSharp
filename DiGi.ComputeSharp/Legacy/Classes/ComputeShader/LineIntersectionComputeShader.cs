using ComputeSharp;
using DiGi.ComputeSharp.Legacy.Classes;
using DiGi.ComputeSharp.Legacy.Classes.Result;

namespace DiGi.ComputeSharp.Legacy.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    public readonly partial struct Segment3IntersectionComputeShader : IComputeShader
    {
        public readonly int ThreadsCount = -1;
        
        public readonly float Tolerance = Legacy.Constans.Tolerance.Distance;

        public readonly Line3 Line;
        public readonly ReadWriteBuffer<LineIntersectionResult> LineIntersectionResults;
        public readonly ReadOnlyBuffer<Triangle3> Triangles;

        public Segment3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Triangle3> triangles)
        {
            Line = line;

            if (graphicsDevice != null)
            {
                Triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                LineIntersectionResults = graphicsDevice.AllocateReadWriteBuffer(new LineIntersectionResult[triangles.Count()]);
            }
        }

        public Segment3IntersectionComputeShader(GraphicsDevice graphicsDevice, Line3 line, IEnumerable<Triangle3> triangles, float tolerance, int threadsCount = -1)
        {
            ThreadsCount = threadsCount;

            Line = line;
            Tolerance = tolerance;

            if (graphicsDevice != null)
            {
                Triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                LineIntersectionResults = graphicsDevice.AllocateReadWriteBuffer(new LineIntersectionResult[triangles.Count()]);
            }
        }

        public Segment3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<LineIntersectionResult> intersectionResults)
        {
            Line = line;
            Triangles = triangles;
            LineIntersectionResults = intersectionResults;
        }

        public Segment3IntersectionComputeShader(Line3 line, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<LineIntersectionResult> intersectionResults, float tolerance)
        {
            Line = line;
            Triangles = triangles;
            LineIntersectionResults = intersectionResults;
            Tolerance = tolerance;
        }

        public void Execute()
        {
            int count = Triangles.Length;

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
                LineIntersectionResults[i] = Create.LineIntersectionResult(Line, Triangles[i], Tolerance);
            }
        }
    }
}
