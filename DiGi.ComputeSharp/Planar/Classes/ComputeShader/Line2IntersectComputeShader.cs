using ComputeSharp;

namespace DiGi.ComputeSharp.Planar.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Line2IntersectComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly bool includeStart = true;
        private readonly bool includeEnd = true;

        private readonly ReadOnlyBuffer<Line2> lines;
        private readonly ReadOnlyBuffer<Triangle2> triangles;

        public readonly ReadWriteBuffer<int> Result;

        public Line2IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line2> lines, IEnumerable<Triangle2> triangles, bool includeStart, bool includeEnd)
        {
            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.lines.Length);
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        public Line2IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line2> lines, IEnumerable<Triangle2> triangles, bool includeStart, bool includeEnd, double tolerance)
        {
            this.tolerance = tolerance;

            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.lines.Length);
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        public Line2IntersectComputeShader(ReadOnlyBuffer<Line2> lines, ReadOnlyBuffer<Triangle2> triangles, ReadWriteBuffer<int> result, bool includeStart, bool includeEnd)
        {
            this.lines = lines;
            this.triangles = triangles;
            Result = result;
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        public Line2IntersectComputeShader(ReadOnlyBuffer<Line2> lines, ReadOnlyBuffer<Triangle2> triangles, ReadWriteBuffer<int> result, double tolerance, bool includeStart, bool includeEnd)
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

            Line2 line = lines[index];
            Result[index] = -1;

            int length = triangles.Length;
            for (int i = 0; i < length; i++)
            {
                Line2Intersection line2Intersection = Create.Line2Intersection(line, triangles[i], tolerance);
                if (line2Intersection.IsNaN())
                {
                    continue;
                }

                if (!includeStart)
                {
                    if (!line2Intersection.Point_1.IsNaN() && line2Intersection.Point_1.AlmostEquals(line.Start, tolerance))
                    {
                        continue;
                    }

                    if (!line2Intersection.Point_2.IsNaN() && line2Intersection.Point_2.AlmostEquals(line.Start, tolerance))
                    {
                        continue;
                    }
                }

                if (!includeEnd)
                {
                    if (!line2Intersection.Point_1.IsNaN() && line2Intersection.Point_1.AlmostEquals(line.End, tolerance))
                    {
                        continue;
                    }

                    if (!line2Intersection.Point_2.IsNaN() && line2Intersection.Point_2.AlmostEquals(line.End, tolerance))
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
