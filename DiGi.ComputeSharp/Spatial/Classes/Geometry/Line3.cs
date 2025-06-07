using DiGi.ComputeSharp.Spatial.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    public readonly struct Line3 : IGeometry3
    {
        public readonly int Bounded;
        public readonly Coordinate3 End;
        public readonly Coordinate3 Start;

        public Line3()
        {
            Bounded = 0;
            End = new Coordinate3();
            Start = new Coordinate3();
        }

        public Line3(float x_1, float y_1, float z_1, float x_2, float y_2, float z_2)
        {
            Bounded = 1;
            End = new Coordinate3(x_1, y_1, z_1);
            Start = new Coordinate3(x_2, y_2, z_2);
        }

        public Line3(bool bounded, float x_1, float y_1, float z_1, float x_2, float y_2, float z_2)
        {
            Bounded = bounded ? 1 : 0;
            End = new Coordinate3(x_1, y_1, z_1);
            Start = new Coordinate3(x_2, y_2, z_2);
        }

        public Line3(Coordinate3 start, Coordinate3 end)
        {
            Bounded = 1;
            Start = start;
            End = end;
        }

        public Line3(bool bounded, Coordinate3 start, Coordinate3 end)
        {
            Bounded = bounded ? 1 : 0;
            Start = start;
            End = end;
        }

        private Line3(int bounded, float x_1, float y_1, float z_1, float x_2, float y_2, float z_2)
        {
            Bounded = bounded;
            End = new Coordinate3(x_1, y_1, z_1);
            Start = new Coordinate3(x_2, y_2, z_2);
        }
        
        private Line3(int bounded, Coordinate3 start, Coordinate3 end)
        {
            Bounded = bounded;
            Start = start;
            End = end;
        }

        public float GetApproximateDistance(Coordinate3 point)
        {
            return GetClosestPoint(point).GetApproximateDistance(point);
        }

        public float GetApproximateLength()
        {
            if (IsBounded())
            {
                return float.PositiveInfinity;
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

            float lengthSquared = lineVector.GetSquaredLength();
            if (lengthSquared == 0.0)
            {
                return Start;
            }

            float t = pointToLineVector.DotProduct(lineVector) / lengthSquared;

            if (true)
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

        public Coordinate3 GetDirection()
        {
            return new Coordinate3(Start, End).GetNormalized();
        }
        
        public Line3 GetInversed()
        {
            return new Line3(Bounded, End, Start);
        }
        
        public Coordinate3 GetMax()
        {
            float x = Start.X;
            if (x < End.X)
            {
                x = End.X;
            }

            float y = Start.Y;
            if (y < End.Y)
            {
                y = End.Y;
            }

            float z = Start.Z;
            if (z < End.Z)
            {
                z = End.Z;
            }

            return new Coordinate3(x, y, z);
        }

        public Coordinate3 GetMin()
        {
            float x = Start.X;
            if (x > End.X)
            {
                x = End.X;
            }

            float y = Start.Y;
            if (y > End.Y)
            {
                y = End.Y;
            }

            float z = Start.Z;
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

        public float GetSquaredDistance(Coordinate3 point)
        {
            return GetClosestPoint(point).GetSquaredDistance(point);
        }

        public float GetSquaredLength()
        {
            if(IsBounded())
            {
                return float.PositiveInfinity;
            }

            return Start.GetSquaredDistance(End);
        }

        public Coordinate3 GetVector()
        {
            return new Coordinate3(Start, End);
        }

        public bool InRange(Line3 line3, float tolerance)
        {
            if (IsNaN() || line3.IsNaN())
            {
                return false;
            }

            if (!IsBounded() || !line3.IsBounded())
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

        public bool InRange(Coordinate3 point, float tolerance)
        {
            return point.InRange(this, tolerance);
        }

        public bool InRange(Triangle3 triangle3, float tolerance)
        {
            if (IsNaN() || triangle3.IsNaN())
            {
                return false;
            }

            if (!IsBounded())
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

        public bool IsBounded()
        {
            return Bounded == 1;
        }

        public bool IsNaN()
        {
            return Start.IsNaN() || End.IsNaN();
        }
       
        public bool On(Coordinate3 point, float tolerance)
        {
            return GetSquaredDistance(point) <= tolerance * tolerance;
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
