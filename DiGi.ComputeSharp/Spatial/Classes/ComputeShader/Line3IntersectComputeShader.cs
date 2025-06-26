using ComputeSharp;
using DiGi.ComputeSharp.Core.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Line3IntersectComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constans.Tolerance.Distance;

        private readonly ReadOnlyBuffer<Line3> lines;
        private readonly ReadOnlyBuffer<Triangle3> triangle3s;

        public readonly ReadWriteBuffer<float> Result;

        public Line3IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line3> lines, IEnumerable<Triangle3> triangle3s)
        {
            if (graphicsDevice != null)
            {
                this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                this.triangle3s = graphicsDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());
                Result = graphicsDevice.AllocateReadWriteBuffer<float>(this.lines.Length);
            }
        }

        public Line3IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line3> lines, IEnumerable<Triangle3> triangle3s, double tolerance)
        {
            this.tolerance = tolerance;

            if (graphicsDevice != null)
            {
                this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                this.triangle3s = graphicsDevice.AllocateReadOnlyBuffer(triangle3s.ToArray());
                Result = graphicsDevice.AllocateReadWriteBuffer<float>(this.lines.Length);
            }
        }

        public Line3IntersectComputeShader(ReadOnlyBuffer<Line3> lines, ReadOnlyBuffer<Triangle3> triangle3s, ReadWriteBuffer<float> result)
        {
            this.lines = lines;
            this.triangle3s = triangle3s;
            Result = result;
        }

        public Line3IntersectComputeShader(ReadOnlyBuffer<Line3> lines, ReadOnlyBuffer<Triangle3> triangle3s, ReadWriteBuffer<float> result, double tolerance)
        {
            this.lines = lines;
            this.triangle3s = triangle3s;
            this.tolerance = tolerance;
            Result = result;
        }

        void IComputeShader.Execute()
        {
            int index = ThreadIds.X;

            Line3 line = lines[index];
            Result[index] = 0.0f;

            int length = triangle3s.Length;
            for (int i = 0; i < length; i++)
            {
                Line3Intersection line3Intersection = Create.Line3Intersection(line, triangle3s[i], tolerance);
                if (line3Intersection.IsNaN())
                {
                    continue;
                }

                Result[index] = 1.0f;
                return;
            }
        }
    }
}
