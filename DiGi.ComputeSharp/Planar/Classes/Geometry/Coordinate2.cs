using DiGi.ComputeSharp.Planar.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace DiGi.ComputeSharp.Planar.Classes
{
    unsafe
    public readonly struct Coordinate2 : IGeometry2
    {
        public readonly float X;
        public readonly float Y;

        public Coordinate2()
        {
            X = float.NaN;
            Y = float.NaN;
        }

        public Coordinate2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Coordinate2(Coordinate2 coordinate)
        {
            X = coordinate.X;
            Y = coordinate.Y;
        }

        public Coordinate2(Coordinate2 start, Coordinate2 end)
        {
            X = end.X - start.X;
            Y = end.Y - start.Y;
        }

        public Coordinate2 Add(Coordinate2 coordinate)
        {
            return new Coordinate2(X + coordinate.X, Y + coordinate.Y);
        }

        public bool AlmostEquals(Coordinate2 coordinate, float tolerance)
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

            return true;
        }

        public float CrossProduct(Coordinate2 vector)
        {
            return X * vector.Y - Y * vector.X;
        }

        public Coordinate2 Divide(Coordinate2 coordinate)
        {
            return new Coordinate2(X / coordinate.X, Y / coordinate.Y);
        }

        public Coordinate2 Divide(float factor)
        {
            return new Coordinate2(X / factor, Y / factor);
        }

        public float DotProduct(Coordinate2 vector)
        {
            return X * vector.X + Y * vector.Y;
        }

        public bool Equals(Coordinate2 coordinate)
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

            return X - coordinate.X == 0 && Y - coordinate.Y == 0;
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is Coordinate2)
            {
                return Equals((Coordinate2)obj);
            }

            return false;
        }
        
        public float GetApproximateDistance(Coordinate2 point)
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

            float max = dx;

            if (dy > max)
            {
                max = dy;
            }

            float min = dx;

            if (dy < min)
            {
                min = dy;
            }


            return 0.96043387f * max + 0.39782473f * min;
        }

        public float GetApproximateLength()
        {
            return new Coordinate2(0, 0).GetApproximateDistance(this);
        }

        public Coordinate2 GetCentroid()
        {
            return new Coordinate2(X / 2, Y / 2);
        }

        public Coordinate2 GetCentroid(Coordinate2 point)
        {
            return new Coordinate2((X + point.X) / 2, (Y + point.Y) / 2);
        }
        
        public Coordinate2 GetInversed()
        {
            return new Coordinate2(-X, -Y);
        }
        
        public Coordinate2 GetMoved(Coordinate2 vector)
        {
            return Add(vector);
        }

        public Coordinate2 GetNormalized()
        {
            float squaredlength = GetSquaredLength();

            return new Coordinate2(X / squaredlength, Y / squaredlength);
        }

        public float GetSquaredDistance(Coordinate2 coordinate)
        {
            float dx = coordinate.X - X;
            float dy = coordinate.Y - Y;

            return (dx * dx) + (dy * dy);
        }

        public float GetSquaredLength()
        {
            return X * X + Y * Y;
        }

        public bool InRange(Triangle2 triangle, float tolerance)
        {
            if (IsNaN() || triangle.IsNaN())
            {
                return false;
            }

            Coordinate2 min = triangle.GetMin();
            Coordinate2 max = triangle.GetMax();

            return X - tolerance <= max.X && X + tolerance >= min.X &&
                Y - tolerance <= max.Y && Y + tolerance >= min.Y;
        }

        public bool InRange(Line2 line, float tolerance)
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

            Coordinate2 min = line.GetMin();
            Coordinate2 max = line.GetMax();

            return X - tolerance <= max.X && X + tolerance >= min.X &&
                Y - tolerance <= max.Y && Y + tolerance >= min.Y;
        }

        public bool IsNaN()
        {
            return !(X + 1 > X && Y + 1 > Y);
        }

        public Coordinate2 Multiply(Coordinate2 coordinate)
        {
            return new Coordinate2(X * coordinate.X, Y * coordinate.Y);
        }

        public Coordinate2 Multiply(float factor)
        {
            return new Coordinate2(X * factor, Y * factor);
        }

        public Coordinate2 Project(Coordinate2 coordinate)
        {
            float squaredLength = GetSquaredLength();

            float scalarProjection = coordinate.DotProduct(this) * squaredLength;

            return Multiply(scalarProjection);
        }

        public Coordinate2 Substract(Coordinate2 coordinate)
        {
            return new Coordinate2(X - coordinate.X, Y - coordinate.Y);
        }
        
        public override string ToString()
        {
            return string.Format("[X:{0};Y:{1}]", X, Y);
        }
    }
}



