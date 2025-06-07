using ComputeSharp;
using DiGi.ComputeSharp.Legacy.Constans;

namespace DiGi.ComputeSharp.Legacy.Classes
{
    public readonly struct Vector3
    {
        public readonly float3 Float3;

        public Vector3()
        {
            Float3 = Constans.Float3.NaN;
        }

        public Vector3(float x, float y, float z)
        {
            Float3 = new float3(x, y, z);
        }

        public Vector3(float3 float3)
        {
            Float3 = new float3(float3.X, float3.Y, float3.Z);
        }

        public Vector3(Point3 point3)
        {
            Float3 = new float3(point3.Float3.X, point3.Float3.Y, point3.Float3.Z);
        }

        public Vector3(Vector3 vector3)
        {
            Float3 = new float3(vector3.Float3.X, vector3.Float3.Y, vector3.Float3.Z);
        }

        public Vector3(Point3 start, Point3 end)
        {
            Float3 = new float3(end.Float3.X - start.Float3.X, end.Float3.Y - start.Float3.Y, end.Float3.Z - start.Float3.Z);
        }

        public Vector3 Add(Vector3 vector3)
        {
            return new Vector3(Float3.X + vector3.Float3.X, Float3.Y + vector3.Float3.Y, Float3.Z + vector3.Float3.Z);
        }

        public Vector3 CrossProduct(Vector3 vector3)
        {
            return new Vector3(
                Float3.Y * vector3.Float3.Z - Float3.Z * vector3.Float3.Y,
                Float3.Z * vector3.Float3.X - Float3.X * vector3.Float3.Z,
                Float3.X * vector3.Float3.Y - Float3.Y * vector3.Float3.X);
        }

        public Vector3 Divide(Vector3 vector3)
        {
            return new Vector3(Float3.X / vector3.Float3.X, Float3.Y / vector3.Float3.Y, Float3.Z / vector3.Float3.Z);
        }

        public Vector3 Divide(float factor)
        {
            return new Vector3(Float3.X / factor, Float3.Y / factor, Float3.Z / factor);
        }

        public float DotProduct(Vector3 vector3)
        {
            return Float3.X * vector3.Float3.X + Float3.Y * vector3.Float3.Y + Float3.Z * vector3.Float3.Z;
        }

        public Vector3 GetInversed()
        {
            return new Vector3(-Float3.X, -Float3.Y, -Float3.Z);
        }

        public float GetLength()
        {
            return (float)Math.Sqrt(Float3.X * Float3.X + Float3.Y * Float3.Y + Float3.Z * Float3.Z);
        }

        public Vector3 GetUnit()
        {
            float length = GetLength();

            return new Vector3(Float3.X / length, Float3.Y / length, Float3.Z / length);
        }

        public bool IsNaN()
        {
            return Float3.X != Float3.X || Float3.Y != Float3.Y || Float3.Z != Float3.Z;
        }
        public Vector3 Multiply(Vector3 vector3)
        {
            return new Vector3(Float3.X * vector3.Float3.X, Float3.Y * vector3.Float3.Y, Float3.Z * vector3.Float3.Z);
        }

        public Vector3 Multiply(float factor)
        {
            return new Vector3(Float3.X * factor, Float3.Y * factor, Float3.Z * factor);
        }

        public Vector3 Substract(Vector3 vector3)
        {
            return new Vector3(Float3.X - vector3.Float3.X, Float3.Y - vector3.Float3.Y, Float3.Z - vector3.Float3.Z);
        }

        public override string ToString()
        {
            return Float3.ToString();
        }
    }
}



