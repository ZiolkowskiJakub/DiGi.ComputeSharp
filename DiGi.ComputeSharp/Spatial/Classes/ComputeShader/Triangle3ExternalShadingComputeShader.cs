using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.XY)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Triangle3ExternalShadingComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constans.Tolerance.Distance;

        private readonly Coordinate3 vector;
        
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        private readonly ReadOnlyBuffer<Triangle3> externalTriangles;

        public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;

        public Triangle3ExternalShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, IEnumerable<Triangle3> externalTriangles, Coordinate3 vector)
        {
            this.vector = vector;

            if (graphicsDevice != null)
            {
                int count = triangles.Count();
                int count_External = externalTriangles.Count();

                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                this.externalTriangles = graphicsDevice.AllocateReadOnlyBuffer(externalTriangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count_External]);
            }
        }

        public Triangle3ExternalShadingComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Triangle3> triangles, IEnumerable<Triangle3> externalTriangles, Coordinate3 vector, double tolerance)
        {
            this.tolerance = tolerance;

            this.vector = vector;

            if (graphicsDevice != null)
            {
                int count = triangles.Count();
                int count_External = externalTriangles.Count();

                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                this.externalTriangles = graphicsDevice.AllocateReadOnlyBuffer(externalTriangles.ToArray());
                TriangleIntersections = graphicsDevice.AllocateReadWriteBuffer(new Triangle3Intersection[count * count_External]);
            }
        }

        public Triangle3ExternalShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadOnlyBuffer<Triangle3> externalTriangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector)
        {
            this.vector = vector;
            this.triangles = triangles;
            this.externalTriangles = externalTriangles;
            TriangleIntersections = triangleIntersections;
        }

        public Triangle3ExternalShadingComputeShader(ReadOnlyBuffer<Triangle3> triangles, ReadOnlyBuffer<Triangle3> externalTriangles, ReadWriteBuffer<Triangle3Intersection> triangleIntersections, Coordinate3 vector, double tolerance)
        {
            this.vector = vector;
            this.triangles = triangles;
            this.externalTriangles = externalTriangles;
            TriangleIntersections = triangleIntersections;
            this.tolerance = tolerance;
        }

        public void Execute()
        {
            int index_1 = ThreadIds.X;
            int index_2 = ThreadIds.Y;

            TriangleIntersections[(index_1 * triangles.Length) + index_2] = Create.Triangle3Intersection(triangles[index_1], externalTriangles[index_2], vector, true, false, tolerance);            
        }
    }
}
