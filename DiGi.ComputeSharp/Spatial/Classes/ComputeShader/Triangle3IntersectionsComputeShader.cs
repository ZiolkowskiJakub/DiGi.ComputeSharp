using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3IntersectionsComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly ReadOnlyBuffer<Triangle3> triangles_1;
        private readonly ReadOnlyBuffer<Triangle3> triangles_2;

        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        public Triangle3IntersectionsComputeShader(ReadOnlyBuffer<Triangle3> triangles_1, ReadOnlyBuffer<Triangle3> triangles_2, ReadWriteBuffer<Triangle3Intersection> triangleIntersections)
        {
            this.triangles_1 = triangles_1;
            this.triangles_2 = triangles_2;
            TriangleIntersections = triangleIntersections;
        }

        public Triangle3IntersectionsComputeShader(ReadOnlyBuffer<Triangle3> triangles_1, ReadOnlyBuffer<Triangle3> triangles_2, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, double tolerance)
        {
            this.triangles_1 = triangles_1;
            this.triangles_2 = triangles_2;
            TriangleIntersections = triangleIntersections;
            this.tolerance = tolerance;
        }

        public void Execute()
        {
            int index_1 = ThreadIds.X;
            int index_2 = ThreadIds.Y;

            // Row-major layout: row = triangles_1 index, column = triangles_2 index.
            // Stride is the inner (column) dimension == triangles_2.Length.
            TriangleIntersections[(index_1 * triangles_2.Length) + index_2] = Create.Triangle3Intersection(triangles_1[index_1], triangles_2[index_2], tolerance);
        }
    }
}
