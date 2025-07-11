﻿using DiGi.ComputeSharp.Spatial.Interfaces;
using DiGi.ComputeSharp.Core.Classes;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    public readonly struct Line3 : IGeometry3
    {
        public readonly Bool Bounded;
        public readonly Coordinate3 End;
        public readonly Coordinate3 Start;

        public Line3()
        {
            Bounded = new Bool(false);
            End = new Coordinate3();
            Start = new Coordinate3();
        }

        public Line3(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
        {
            Bounded = new Bool(true);
            End = new Coordinate3(x_1, y_1, z_1);
            Start = new Coordinate3(x_2, y_2, z_2);
        }

        public Line3(Bool bounded, double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
        {
            Bounded = bounded;
            End = new Coordinate3(x_1, y_1, z_1);
            Start = new Coordinate3(x_2, y_2, z_2);
        }

        public Line3(Coordinate3 start, Coordinate3 end)
        {
            Bounded = new Bool(true);
            Start = start;
            End = end;
        }

        public Line3(Bool bounded, Coordinate3 start, Coordinate3 end)
        {
            Bounded = bounded;
            Start = start;
            End = end;
        }

        public double GetApproximateDistance(Coordinate3 point)
        {
            return GetClosestPoint(point).GetApproximateDistance(point);
        }

        public double GetApproximateLength()
        {
            if (!Bounded.ToBool())
            {
                return double.PositiveInfinity;
            }

            return Start.GetApproximateDistance(End);
        }

        public Coordinate3 GetCentroid()
        {
            return Start.Add(GetVector().GetCentroid());
        }

        public Coordinate3 GetClosestPoint(Coordinate3 point)
        {
            Coordinate3 lineVector = GetVector();
            Coordinate3 pointToLineVector = point.Substract(Start);

            double lengthSquared = lineVector.GetSquaredLength();
            if (lengthSquared == 0.0)
            {
                return Start;
            }

            double t = pointToLineVector.DotProduct(lineVector) / lengthSquared;

            if (Bounded.ToBool())
            {
                if(t > 1.0f)
                {
                    t = 1.0f;
                }

                if(t < 0.0f)
                {
                    t = 0.0f;
                }
            }

            return Start.Add(lineVector.Multiply(t));
        }

        public Coordinate3 GetDirection(double tolerance)
        {
            return new Coordinate3(Start, End).GetNormalized(tolerance);
        }

        public double GetDistance(Coordinate3 point, double tolerance)
        {
            return GetClosestPoint(point).GetDistance(point, tolerance);
        }

        public Line3 GetInversed()
        {
            return new Line3(Bounded, End, Start);
        }

        public double GetLength(double tolerance)
        {
            double squaredLength = GetSquaredLength();

            if (!Core.Query.IsValid(squaredLength))
            {
                return squaredLength;
            }

            return Core.Query.Sqrt(squaredLength, tolerance);
        }

        public Coordinate3 GetMax()
        {
            double x = Start.X;
            if (x < End.X)
            {
                x = End.X;
            }

            double y = Start.Y;
            if (y < End.Y)
            {
                y = End.Y;
            }

            double z = Start.Z;
            if (z < End.Z)
            {
                z = End.Z;
            }

            return new Coordinate3(x, y, z);
        }

        public Coordinate3 GetMin()
        {
            double x = Start.X;
            if (x > End.X)
            {
                x = End.X;
            }

            double y = Start.Y;
            if (y > End.Y)
            {
                y = End.Y;
            }

            double z = Start.Z;
            if (z > End.Z)
            {
                z = End.Z;
            }

            return new Coordinate3(x, y, z);
        }

        public Line3 GetMoved(Coordinate3 vector)
        {
            return new Line3(Bounded, End.GetMoved(vector), Start.GetMoved(vector));
        }

        public double GetSquaredDistance(Coordinate3 point)
        {
            return GetClosestPoint(point).GetSquaredDistance(point);
        }

        public double GetSquaredLength()
        {
            if(!Bounded.ToBool())
            {
                return double.PositiveInfinity;
            }

            return Start.GetSquaredDistance(End);
        }

        public Coordinate3 GetVector()
        {
            return new Coordinate3(Start, End);
        }

        public bool InRange(Line3 line3, double tolerance)
        {
            if (IsNaN() || line3.IsNaN())
            {
                return false;
            }

            if (!Bounded.ToBool() || !line3.Bounded.ToBool())
            {
                return true;
            }

            Coordinate3 minA = GetMin();
            Coordinate3 maxA = GetMax();
            Coordinate3 minB = line3.GetMin();
            Coordinate3 maxB = line3.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y) &&
                    (minA.Z - tolerance <= maxB.Z && maxA.Z + tolerance >= minB.Z);
        }

        public bool InRange(Coordinate3 point, double tolerance)
        {
            return point.InRange(this, tolerance);
        }

        public bool InRange(Triangle3 triangle3, double tolerance)
        {
            if (IsNaN() || triangle3.IsNaN())
            {
                return false;
            }

            if (!Bounded.ToBool())
            {
                return true;
            }

            Coordinate3 minA = GetMin();
            Coordinate3 maxA = GetMax();
            Coordinate3 minB = triangle3.GetMin();
            Coordinate3 maxB = triangle3.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y) &&
                    (minA.Z - tolerance <= maxB.Z && maxA.Z + tolerance >= minB.Z);
        }

        public bool IsNaN()
        {
            return Start.IsNaN() || End.IsNaN();
        }
       
        public bool On(Coordinate3 point, double tolerance)
        {
            return GetSquaredDistance(point) <= tolerance;
        }
        
        public Coordinate3 Project(Coordinate3 point)
        {
            return GetClosestPoint(point);
        }
        
        public Line3 Project(Line3 line)
        {
            Coordinate3 start = GetClosestPoint(line.Start);
            Coordinate3 end = GetClosestPoint(line.Start);
            if(start.Equals(end))
            {
                return new Line3();
            }

            return new Line3(line.Bounded, GetClosestPoint(line.Start), GetClosestPoint(line.End));
        }

        public override string ToString()
        {
            return string.Format("S:{0};E:{1}", Start, End);
        }
    }
}
