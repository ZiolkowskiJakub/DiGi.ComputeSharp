using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    unsafe
    public readonly struct Coordinate3 : IGeometry3
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public Coordinate3()
        {
            X = double.NaN;
            Y = double.NaN;
            Z = double.NaN;
        }

        public Coordinate3(double x, double y, double z)
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

        public bool AlmostEquals(Coordinate3 coordinate, double tolerance)
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

        public Coordinate3 Divide(double factor)
        {
            return new Coordinate3(X / factor, Y / factor, Z / factor);
        }

        public double DotProduct(Coordinate3 vector)
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
        
        public double GetApproximateDistance(Coordinate3 point)
        {
            double dx = point.X - X;
            if (dx < 0)
            {
                dx = -dx;
            }

            double dy = point.Y - Y;
            if (dy < 0)
            {
                dy = -dy;
            }

            double dz = point.Z - Z;
            if (dz < 0)
            {
                dz = -dz;
            }

            double max = dx;

            if (dy > max)
            {
                max = dy;
            }

            if (dz > max)
            {
                max = dz;
            }

            double min = dx;

            if (dy < min)
            {
                min = dy;
            }

            if (dz < min)
            {
                min = dz;
            }

            double mid = dx + dy + dz - max - min;

            return 0.937562f * max + 0.392485f * mid + 0.286079f * min;
        }

        public double GetApproximateLength()
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

        public double GetDistance(Coordinate3 point, double tolerance)
        {
            return new Coordinate3(this, point).GetLength(tolerance);
        }

        public Coordinate3 GetInversed()
        {
            return new Coordinate3(-X, -Y, -Z);
        }

        public double GetLength(double tolerance)
        {
            return Core.Query.Sqrt(GetSquaredLength(), tolerance);
        }
        
        public Coordinate3 GetMoved(Coordinate3 vector)
        {
            return Add(vector);
        }

        public Coordinate3 GetNormalized(double tolerance)
        {
            double length = GetLength(tolerance);

            return new Coordinate3(X / length, Y / length, Z / length);
        }

        public double GetSquaredDistance(Coordinate3 coordinate)
        {
            double dx = coordinate.X - X;
            double dy = coordinate.Y - Y;
            double dz = coordinate.Z - Z;

            return (dx * dx) + (dy * dy) + (dz * dz);
        }

        public double GetSquaredLength()
        {
            return X * X + Y * Y + Z * Z;
        }

        public bool InRange(Triangle3 triangle, double tolerance)
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

        public bool InRange(Line3 line, double tolerance)
        {
            if (line.IsNaN())
            {
                return false;
            }

            if (!line.Bounded.ToBool())
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

        public Coordinate3 Multiply(double factor)
        {
            return new Coordinate3(X * factor, Y * factor, Z * factor);
        }

        public Coordinate3 Project(Coordinate3 coordinate)
        {
            double squaredLength = GetSquaredLength();

            double scalarProjection = coordinate.DotProduct(this) * squaredLength;

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



