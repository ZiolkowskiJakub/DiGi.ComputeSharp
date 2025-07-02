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

        private readonly bool includeStart = true;
        private readonly bool includeEnd = true;

        private readonly ReadOnlyBuffer<Line3> lines;
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        public readonly ReadWriteBuffer<int> Result;

        public Line3IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line3> lines, IEnumerable<Triangle3> triangles, bool includeStart, bool includeEnd)
        {
            if (graphicsDevice != null)
            {
                this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.lines.Length);
                this.includeStart = includeStart;
                this.includeEnd = includeEnd;
            }
        }

        public Line3IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line3> lines, IEnumerable<Triangle3> triangles, bool includeStart, bool includeEnd, double tolerance)
        {
            this.tolerance = tolerance;

            if (graphicsDevice != null)
            {
                this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.lines.Length);
                this.includeStart = includeStart;
                this.includeEnd = includeEnd;
            }
        }

        public Line3IntersectComputeShader(ReadOnlyBuffer<Line3> lines, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<int> result, bool includeStart, bool includeEnd)
        {
            this.lines = lines;
            this.triangles = triangles;
            Result = result;
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        public Line3IntersectComputeShader(ReadOnlyBuffer<Line3> lines, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<int> result, double tolerance, bool includeStart, bool includeEnd)
        {
            this.lines = lines;
            this.triangles = triangles;
            this.tolerance = tolerance;
            Result = result;
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        void IComputeShader.Execute()
        {
            int index = ThreadIds.X;

            Line3 line = lines[index];
            Result[index] = -1;

            int length = triangles.Length;
            for (int i = 0; i < length; i++)
            {
                Line3Intersection line3Intersection = Create.Line3Intersection(line, triangles[i], tolerance);
                if (line3Intersection.IsNaN())
                {
                    continue;
                }

                if(!includeStart)
                {
                    if(!line3Intersection.Point_1.IsNaN() && line3Intersection.Point_1.AlmostEquals(line.Start, tolerance))
                    {
                        continue;
                    }

                    if (!line3Intersection.Point_2.IsNaN() && line3Intersection.Point_2.AlmostEquals(line.Start, tolerance))
                    {
                        continue;
                    }
                }

                if (!includeEnd)
                {
                    if (!line3Intersection.Point_1.IsNaN() && line3Intersection.Point_1.AlmostEquals(line.End, tolerance))
                    {
                        continue;
                    }

                    if (!line3Intersection.Point_2.IsNaN() && line3Intersection.Point_2.AlmostEquals(line.End, tolerance))
                    {
                        continue;
                    }
                }

                Result[index] = i;
                return;
            }
        }
    }
}
