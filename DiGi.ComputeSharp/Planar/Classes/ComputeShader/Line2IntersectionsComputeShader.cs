using ComputeSharp;

namespace DiGi.ComputeSharp.Planar.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Line2IntersectionsComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly ReadOnlyBuffer<Line2> lines;
        private readonly ReadOnlyBuffer<Triangle2> triangles;

        public readonly ReadWriteBuffer<Line2Intersection> LineIntersections;

        public Line2IntersectionsComputeShader(ReadOnlyBuffer<Line2> lines, ReadOnlyBuffer<Triangle2> triangles, ReadWriteBuffer<Line2Intersection> lineIntersections)
        {
            this.lines = lines;
            this.triangles = triangles;
            LineIntersections = lineIntersections;
        }

        public Line2IntersectionsComputeShader(ReadOnlyBuffer<Line2> lines, ReadOnlyBuffer<Triangle2> triangles, ReadWriteBuffer<Line2Intersection> lineIntersections, double tolerance)
        {
            this.lines = lines;
            this.triangles = triangles;
            LineIntersections = lineIntersections;
            this.tolerance = tolerance;
        }

        public void Execute()
        {
            int index_1 = ThreadIds.X;
            int index_2 = ThreadIds.Y;

            // Row-major layout: row = lines index, column = triangles index.
            // Stride is the inner (column) dimension == triangles.Length.
            LineIntersections[(index_1 * triangles.Length) + index_2] = Create.Line2Intersection(lines[index_1], triangles[index_2], tolerance);
        }
    }
}
