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

        /// <summary>
        /// Gets the writeable buffer containing the index of the first intersecting triangle for each line, or -1 if no intersection is found.
        /// </summary>
        public readonly ReadWriteBuffer<int> Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectComputeShader"/> struct.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="lines">The collection of 2D lines to check for intersections.</param>
        /// <param name="triangles">The collection of 2D triangles to test against.</param>
        /// <param name="includeStart">A value indicating whether to include the start point of each line in the intersection tests.</param>
        /// <param name="includeEnd">A value indicating whether to include the end point of each line in the intersection tests.</param>
        public Line2IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line2> lines, IEnumerable<Triangle2> triangles, bool includeStart, bool includeEnd)
        {
            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.lines.Length);
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectComputeShader"/> struct with a custom tolerance.
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to use for allocating resources.</param>
        /// <param name="lines">The collection of 2D lines to check for intersections.</param>
        /// <param name="triangles">The collection of 2D triangles to test against.</param>
        /// <param name="includeStart">A value indicating whether to include the start point of each line in the intersection tests.</param>
        /// <param name="includeEnd">A value indicating whether to include the end point of each line in the intersection tests.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        public Line2IntersectComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Line2> lines, IEnumerable<Triangle2> triangles, bool includeStart, bool includeEnd, double tolerance)
        {
            this.tolerance = tolerance;

            this.lines = graphicsDevice.AllocateReadOnlyBuffer(lines.ToArray());
            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.lines.Length);
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectComputeShader"/> struct using pre-allocated buffers.
        /// </summary>
        /// <param name="lines">The read-only buffer of 2D lines.</param>
        /// <param name="triangles">The read-only buffer of 2D triangles.</param>
        /// <param name="result">The read-write buffer for storing the intersection results.</param>
        /// <param name="includeStart">A value indicating whether to include the start point of each line in the intersection tests.</param>
        /// <param name="includeEnd">A value indicating whether to include the end point of each line in the intersection tests.</param>
        public Line2IntersectComputeShader(ReadOnlyBuffer<Line2> lines, ReadOnlyBuffer<Triangle2> triangles, ReadWriteBuffer<int> result, bool includeStart, bool includeEnd)
        {
            this.lines = lines;
            this.triangles = triangles;
            Result = result;
            this.includeStart = includeStart;
            this.includeEnd = includeEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2IntersectComputeShader"/> struct using pre-allocated buffers and a custom tolerance.
        /// </summary>
        /// <param name="lines">The read-only buffer of 2D lines.</param>
        /// <param name="triangles">The read-only buffer of 2D triangles.</param>
        /// <param name="result">The read-write buffer for storing the intersection results.</param>
        /// <param name="tolerance">The tolerance value used for geometric comparison.</param>
        /// <param name="includeStart">A value indicating whether to include the start point of each line in the intersection tests.</param>
        /// <param name="includeEnd">A value indicating whether to include the end point of each line in the intersection tests.</param>
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
