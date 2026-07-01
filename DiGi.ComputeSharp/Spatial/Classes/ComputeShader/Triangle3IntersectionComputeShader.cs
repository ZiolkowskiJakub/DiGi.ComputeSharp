using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3IntersectionComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constants.Tolerance.Distance;

        private readonly Triangle3 triangle;
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles)
        {
            this.triangle = triangle;

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
        }

        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles, double tolerance)
        {
            this.triangle = triangle;
            this.tolerance = tolerance;

            this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
            TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
        }

        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections)
        {
            this.triangle = triangle;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
        }

        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, double tolerance)
        {
            this.triangle = triangle;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
            this.tolerance = tolerance;
        }

        public void Execute()
        {
            // One thread per triangle. ComputeSharp bounds the dispatch to the requested count, so ThreadIds.X
            // is always a valid index.
            int index = ThreadIds.X;

            TriangleIntersections[index] = Create.Triangle3Intersection(triangle, triangles[index], tolerance);
        }
    }
}