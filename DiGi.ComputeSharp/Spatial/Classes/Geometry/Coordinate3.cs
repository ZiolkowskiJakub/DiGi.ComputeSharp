using DiGi.ComputeSharp.Spatial.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    unsafe
    public readonly struct Coordinate3 : IGeometry3
    {
        public readonly float X;
        public readonly float Y;
        public readonly float Z;

        public Coordinate3()
        {
            X = float.NaN;
            Y = float.NaN;
            Z = float.NaN;
        }

        public Coordinate3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Coordinate3(Coordinate3 coordinate)
        {
            X = coordinate.X;
            Y = coordinate.Y;
            Z = coordinate.Z;
        }

        public Coordinate3(Coordinate3 start, Coordinate3 end)
        {
            X = end.X - start.X;
            Y = end.Y - start.Y;
            Z = end.Z - start.Z;
        }

        public Coordinate3 Add(Coordinate3 coordinate)
        {
            return new Coordinate3(X + coordinate.X, Y + coordinate.Y, Z + coordinate.Z);
        }

        public bool AlmostEquals(Coordinate3 coordinate, float tolerance)
        {
            bool isNaN_1 = IsNaN();
            bool isNaN_2 = coordinate.IsNaN();

            if (isNaN_1 && isNaN_2)
            {
                return true;
            }

            if (isNaN_1 || isNaN_2)
            {
                return false;
            }

            double dx = X - coordinate.X;
            if (dx < -tolerance || dx > tolerance)
            {
                return false;
            }

            double dy = Y - coordinate.Y;
            if (dy < -tolerance || dy > tolerance)
            {
                return false;
            }

            double dz = Z - coordinate.Z;
            if (dz < -tolerance || dz > tolerance)
            {
                return false;
            }

            return true;
        }

        public Coordinate3 CrossProduct(Coordinate3 vector)
        {
            return new Coordinate3(
                Y * vector.Z - Z * vector.Y,
                Z * vector.X - X * vector.Z,
                X * vector.Y - Y * vector.X);
        }

        public Coordinate3 Divide(Coordinate3 coordinate)
        {
            return new Coordinate3(X / coordinate.X, Y / coordinate.Y, Z / coordinate.Z);
        }

        public Coordinate3 Divide(float factor)
        {
            return new Coordinate3(X / factor, Y / factor, Z / factor);
        }

        public float DotProduct(Coordinate3 vector)
        {
            return X * vector.X + Y * vector.Y + Z * vector.Z;
        }

        public bool Equals(Coordinate3 coordinate)
        {
            bool isNaN_1 = IsNaN();
            bool isNaN_2 = coordinate.IsNaN();

            if (isNaN_1 && isNaN_2)
            {
                return true;
            }

            if (isNaN_1 || isNaN_2)
            {
                return false;
            }

            return X - coordinate.X == 0 && Y - coordinate.Y == 0 && Z - coordinate.Z == 0;
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is Coordinate3)
            {
                return Equals((Coordinate3)obj);
            }

            return false;
        }
        
        public float GetApproximateDistance(Coordinate3 point)
        {
            float dx = point.X - X;
            if (dx < 0)
            {
                dx = -dx;
            }

            float dy = point.Y - Y;
            if (dy < 0)
            {
                dy = -dy;
            }

            float dz = point.Z - Z;
            if (dz < 0)
            {
                dz = -dz;
            }

            float max = dx;

            if (dy > max)
            {
                max = dy;
            }

            if (dz > max)
            {
                max = dz;
            }

            float min = dx;

            if (dy < min)
            {
                min = dy;
            }

            if (dz < min)
            {
                min = dz;
            }

            float mid = dx + dy + dz - max - min;

            return 0.937562f * max + 0.392485f * mid + 0.286079f * min;
        }

        public float GetApproximateLength()
        {
            return new Coordinate3(0, 0, 0).GetApproximateDistance(this);
        }

        public Coordinate3 GetCentroid()
        {
            return new Coordinate3(X / 2, Y / 2, Z / 2);
        }

        public Coordinate3 GetCentroid(Coordinate3 point)
        {
            return new Coordinate3((X + point.X) / 2, (Y + point.Y) / 2, (Z + point.Z) / 2);
        }
        
        public Coordinate3 GetInversed()
        {
            return new Coordinate3(-X, -Y, -Z);
        }
        
        public Coordinate3 GetMoved(Coordinate3 vector)
        {
            return Add(vector);
        }

        public Coordinate3 GetNormalized()
        {
            float squaredlength = GetSquaredLength();

            return new Coordinate3(X / squaredlength, Y / squaredlength, Z / squaredlength);
        }

        public float GetSquaredDistance(Coordinate3 coordinate)
        {
            float dx = coordinate.X - X;
            float dy = coordinate.Y - Y;
            float dz = coordinate.Z - Z;

            return (dx * dx) + (dy * dy) + (dz * dz);
        }

        public float GetSquaredLength()
        {
            return X * X + Y * Y + Z * Z;
        }

        public bool InRange(Triangle3 triangle, float tolerance)
        {
            if (IsNaN() || triangle.IsNaN())
            {
                return false;
            }

            Coordinate3 min = triangle.GetMin();
            Coordinate3 max = triangle.GetMax();

            return X - tolerance <= max.X && X + tolerance >= min.X &&
                Y - tolerance <= max.Y && Y + tolerance >= min.Y &&
                Z - tolerance <= max.Z && Z + tolerance >= min.Z;
        }

        public bool InRange(Line3 line, float tolerance)
        {
            if (line.IsNaN())
            {
                return false;
            }

            if (!line.IsBounded())
            {
                return true;
            }

            if (IsNaN())
            {
                return false;
            }

            Coordinate3 min = line.GetMin();
            Coordinate3 max = line.GetMax();

            return X - tolerance <= max.X && X + tolerance >= min.X &&
                Y - tolerance <= max.Y && Y + tolerance >= min.Y &&
                Z - tolerance <= max.Z && Z + tolerance >= min.Z;
        }

        public bool IsNaN()
        {
            return !(X + 1 > X && Y + 1 > Y && Z + 1 > Z);
        }

        public Coordinate3 Multiply(Coordinate3 coordinate)
        {
            return new Coordinate3(X * coordinate.X, Y * coordinate.Y, Z * coordinate.Z);
        }

        public Coordinate3 Multiply(float factor)
        {
            return new Coordinate3(X * factor, Y * factor, Z * factor);
        }

        public Coordinate3 Project(Coordinate3 coordinate)
        {
            float squaredLength = GetSquaredLength();

            float scalarProjection = coordinate.DotProduct(this) * squaredLength;

            return Multiply(scalarProjection);
        }

        public Coordinate3 Substract(Coordinate3 coordinate)
        {
            return new Coordinate3(X - coordinate.X, Y - coordinate.Y, Z - coordinate.Z);
        }
        
        public override string ToString()
        {
            return string.Format("[X:{0};Y:{1};Z:{2}]", X, Y, Z);
        }
    }
}



