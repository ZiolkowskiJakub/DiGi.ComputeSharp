using ComputeSharp;
using DiGi.ComputeSharp.Legacy.Classes;
using DiGi.ComputeSharp.Legacy.Classes.Result;

namespace DiGi.ComputeSharp.Legacy.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    public readonly partial struct LinesIntersectionComputeShader : IComputeShader
    {
        public readonly float Tolerance = Legacy.Constans.Tolerance.Distance;

        public readonly ReadOnlyBuffer<Line3> Lines;
        public readonly ReadOnlyBuffer<Triangle3> Triangles;
        public readonly ReadWriteBuffer<LineIntersectionResult> LineIntersectionResults;

        public LinesIntersectionComputeShader(ReadOnlyBuffer<Line3> lines, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<LineIntersectionResult> LineIntersectionResults)
        {
            Lines = lines;
            Triangles = triangles;
            this.LineIntersectionResults = LineIntersectionResults;
        }

        public LinesIntersectionComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line3> lines, IEnumerable<Triangle3> triangles, float tolerance)
        {
            Tolerance = tolerance;

            if (graphicsDevice != null)
            {
                Lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                Triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                LineIntersectionResults = graphicsDevice.AllocateReadWriteBuffer(new LineIntersectionResult[lines.Count()]);
            }
        }

        public LinesIntersectionComputeShader(ReadOnlyBuffer<Line3> lines, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<LineIntersectionResult> LineIntersectionResults, float tolerance)
        {
            Lines = lines;
            Triangles = triangles;
            this.LineIntersectionResults = LineIntersectionResults;
            Tolerance = tolerance;
        }

        public void Execute()
        {
            int index = ThreadIds.X;

            Line3 line3 = Lines[index];

            float distance_Min = float.MaxValue;

            for (int i = 0; i < Triangles.Length; i++)
            {
                LineIntersectionResult intersectionResult = Create.LineIntersectionResult(line3, Triangles[i], Tolerance);
                if (intersectionResult.IsNaN())
                {
                    continue;
                }

                if(intersectionResult.Distance < distance_Min)
                {
                    LineIntersectionResults[index] = intersectionResult;
                }
            }
        }
    }
}
