using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3ShadingComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constans.Tolerance.Distance;

        private readonly Coordinate3 vector;
        
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        public Triangle3ShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, Coordinate3 vector)
        {
            this.vector = vector;

            if (graphicsDevice != null)
            {
                int count = triangles.Count();

                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count]);
            }
        }

        public Triangle3ShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, Coordinate3 vector, double tolerance)
        {
            this.tolerance = tolerance;

            this.vector = vector;

            if (graphicsDevice != null)
            {
                int count = triangles.Count();

                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count]);
            }
        }

        public Triangle3ShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector)
        {
            this.vector = vector;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
        }

        public Triangle3ShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector, double tolerance)
        {
            this.vector = vector;
            this.triangles = triangles;
            TriangleIntersections = triangleIntersections;
            this.tolerance = tolerance;
        }

        public void Execute()
        {
            int index_1 = ThreadIds.X;
            int index_2 = ThreadIds.Y;

            TriangleIntersections[(index_1 * triangles.Length) + index_2] = Create.Triangle3Intersection(triangles[index_1], triangles[index_2], vector, true, false, tolerance);            
        }
    }
}
