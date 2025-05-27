using ComputeSharp;

namespace DiGi.ComputeSharp.Classes
{
    public readonly struct Point3
    {
        public readonly Float3 Float3;

        public Point3()
        {
            Float3 = Constans.Float3.NaN;
        }

        public Point3(float x, float y, float z)
        {
            Float3 = new Float3(x, y, z);
        }

        public Point3(Float3 float3)
        {
            Float3 = new Float3(float3.X, float3.Y, float3.Z);
        }

        public Point3(Point3 point3)
        {
            Float3 = new Float3(point3.Float3.X, point3.Float3.Y, point3.Float3.Z);
        }

        public bool IsNaN()
        {
            return Float3.X != Float3.X || Float3.Y != Float3.Y || Float3.Z != Float3.Z;
        }

        public Point3 Add(Point3 point3)
        {
            return new Point3(Float3.X + point3.Float3.X, Float3.Y + point3.Float3.Y, Float3.Z + point3.Float3.Z);
        }

        public Point3 Add(Vector3 vector3)
        {
            return new Point3(Float3.X + vector3.Float3.X, Float3.Y + vector3.Float3.Y, Float3.Z + vector3.Float3.Z);
        }

        public float Distance(Point3 point3)
        {
            float dx = point3.Float3.X - Float3.X;
            float dy = point3.Float3.Y - Float3.Y;
            float dz = point3.Float3.Z - Float3.Z;

            return (float)Math.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
        }

        public Point3 Divide(Point3 point3)
        {
            return new Point3(Float3.X / point3.Float3.X, Float3.Y / point3.Float3.Y, Float3.Z / point3.Float3.Z);
        }

        public Point3 Divide(float factor)
        {
            return new Point3(Float3.X / factor, Float3.Y / factor, Float3.Z / factor);
        }

        public Point3 Multiply(Point3 point3)
        {
            return new Point3(Float3.X * point3.Float3.X, Float3.Y * point3.Float3.Y, Float3.Z * point3.Float3.Z);
        }

        public Point3 Multiply(float factor)
        {
            return new Point3(Float3.X * factor, Float3.Y * factor, Float3.Z * factor);
        }

        public Point3 Substract(Point3 point3)
        {
            return new Point3(Float3.X - point3.Float3.X, Float3.Y - point3.Float3.Y, Float3.Z - point3.Float3.Z);
        }

        public Point3 Substract(Vector3 vector3)
        {
            return new Point3(Float3.X - vector3.Float3.X, Float3.Y - vector3.Float3.Y, Float3.Z - vector3.Float3.Z);
        }

        public override string ToString()
        {
            return Float3.ToString();
        }
    }
}



