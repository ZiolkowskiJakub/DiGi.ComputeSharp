using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3IntersectionComputeShader : IComputeShader
    {
        public readonly Triangle3 Triangle;
        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;
        public readonly ReadOnlyBuffer<Triangle3> Triangles;
        public readonly int ThreadsCount = -1;

        public readonly float Tolerance = Core.Constans.Tolerance.Distance;
        
        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles)
        {
            Triangle = triangle;

            if (graphicsDevice != null)
            {
                Triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
            }
        }

        public Triangle3IntersectionComputeShader(GraphicsDevice graphicsDevice, Triangle3 triangle, IEnumerable<Triangle3> triangles, float tolerance, int threadsCount = -1)
        {
            ThreadsCount = threadsCount;

            Triangle = triangle;
            Tolerance = tolerance;

            if (graphicsDevice != null)
            {
                Triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[triangles.Count()]);
            }
        }

        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections)
        {
            Triangle = triangle;
            Triangles = triangles;
            TriangleIntersections = triangleIntersections;
        }

        public Triangle3IntersectionComputeShader(Triangle3 triangle, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, float tolerance, int threadsCount = -1)
        {
            ThreadsCount = threadsCount;

            Triangle = triangle;
            Triangles = triangles;
            TriangleIntersections = triangleIntersections;
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
                TriangleIntersections[i] = Create.Triangle3Intersection(Triangle, Triangles[i], Tolerance);
            }
        }
    }
}
