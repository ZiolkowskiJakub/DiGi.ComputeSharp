using ComputeSharp;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    [ThreadGroupSize(DefaultThreadGroupSizes.X)]
    [GeneratedComputeShaderDescriptor]
    [RequiresDoublePrecisionSupport]
    public readonly partial struct Coordinate3InsideComputeShader : IComputeShader
    {
        private readonly double tolerance = Core.Constans.Tolerance.Distance;

        private readonly ReadOnlyBuffer<Coordinate3> points;
        private readonly ReadOnlyBuffer<Triangle3> triangles;

        public readonly ReadWriteBuffer<int> Result;

        public Coordinate3InsideComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Coordinate3> points, IEnumerable<Triangle3> triangles)
        {
            if (graphicsDevice != null)
            {
                this.points = graphicsDevice.AllocateReadOnlyBuffer(points.ToArray());
                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.points.Length);
            }
        }

        public Coordinate3InsideComputeShader(GraphicsDevice graphicsDevice, IEnumerable<Coordinate3> points, IEnumerable<Triangle3> triangles, double tolerance)
        {
            this.tolerance = tolerance;

            if (graphicsDevice != null)
            {
                this.points = graphicsDevice.AllocateReadOnlyBuffer(points.ToArray());
                this.triangles = graphicsDevice.AllocateReadOnlyBuffer(triangles.ToArray());
                Result = graphicsDevice.AllocateReadWriteBuffer<int>(this.points.Length);
            }
        }

        public Coordinate3InsideComputeShader(ReadOnlyBuffer<Coordinate3> points, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<int> result)
        {
            this.points = points;
            this.triangles = triangles;
            Result = result;
        }

        public Coordinate3InsideComputeShader(ReadOnlyBuffer<Coordinate3> points, ReadOnlyBuffer<Triangle3> triangles, ReadWriteBuffer<int> result, double tolerance)
        {
            this.points = points;
            this.triangles = triangles;
            this.tolerance = tolerance;
            Result = result;
        }

        void IComputeShader.Execute()
        {
            int index = ThreadIds.X;

            Coordinate3 point = points[index];
            Result[index] = 0;

            if(point.IsNaN())
            {
                return;
            }

            int length = triangles.Length;
            for (int i = 0; i < length; i++)
            {
                Triangle3 triangle = triangles[i];
                if(triangle.IsNaN())
                {
                    continue;
                }

                if (!triangle.Inside(point, tolerance))
                {
                    continue;
                }

                Result[index] = i;
                return;
            }
        }
    }
}
