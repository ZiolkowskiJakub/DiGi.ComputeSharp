using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3IntersectionComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constans.Tolerance.Distance;
        private readonly int threadsCount = -1;
        
        private readonly Triangle3 triangle;
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles)
        {
            this.triangle = triangle;

            if (graphicsDevice != null)
            {
                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
            }
        }

        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles, double tolerance, int threadsCount = -1)
        {
            this.threadsCount = threadsCount;

            this.triangle = triangle;
            this.tolerance = tolerance;

            if (graphicsDevice != null)
            {
                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
            }
        }

        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections)
        {
            this.triangle = triangle;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
        }

        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, double tolerance, int threadsCount = -1)
        {
            this.threadsCount = threadsCount;

            this.triangle = triangle;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
            this.tolerance = tolerance;
        }

        public void Execute()
        {
            int count = triangles.Length;

            int start = 0;
            int end = 0;
            if (threadsCount < 1)
            {
                start = 0;
                end = count;
            }
            else
            {
                int length = (count / threadsCount) + 1;

                int index = ThreadIds.X;

                start = index * length;
                end = index * length + length;
            }

            for (int i = start; i < end; i++)
            {
                TriangleIntersections[i] = Create.Triangle3Intersection(triangle, triangles[i], tolerance);
            }
        }
    }
}
