using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Planar.Interfaces;

namespace DiGi.ComputeSharp.Planar.Classes
{
    public readonly struct Line2 : IGeometry2
    {
        public readonly Bool Bounded;
        public readonly Coordinate2 End;
        public readonly Coordinate2 Start;

        public Line2()
        {
            Bounded = new Bool(false);
            End = new Coordinate2();
            Start = new Coordinate2();
        }

        public Line2(float x_1, float y_1, float x_2, float y_2)
        {
            Bounded = new Bool(true);
            End = new Coordinate2(x_1, y_1);
            Start = new Coordinate2(x_2, y_2);
        }

        public Line2(Bool bounded, float x_1, float y_1, float x_2, float y_2)
        {
            Bounded = bounded;
            End = new Coordinate2(x_1, y_1);
            Start = new Coordinate2(x_2, y_2);
        }

        public Line2(Coordinate2 start, Coordinate2 end)
        {
            Bounded = new Bool(true);
            Start = start;
            End = end;
        }

        public Line2(Bool bounded, Coordinate2 start, Coordinate2 end)
        {
            Bounded = bounded;
            Start = start;
            End = end;
        }

        public float GetApproximateDistance(Coordinate2 point)
        {
            return GetClosestPoint(point).GetApproximateDistance(point);
        }

        public float GetApproximateLength()
        {
            if (Bounded.ToBool())
            {
                return float.PositiveInfinity;
            }

            return Start.GetApproximateDistance(End);
        }

        public Coordinate2 GetCentroid()
        {
            return Start.Add(GetVector().GetCentroid());
        }

        public Coordinate2 GetClosestPoint(Coordinate2 point)
        {
            Coordinate2 lineVector = GetVector();
            Coordinate2 pointToLineVector = point.Substract(Start);

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

        public Coordinate2 GetDirection(float tolerance)
        {
            return new Coordinate2(Start, End).GetNormalized(tolerance);
        }
        
        public Line2 GetInversed()
        {
            return new Line2(Bounded, End, Start);
        }
        
        public Coordinate2 GetMax()
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

            return new Coordinate2(x, y);
        }

        public Coordinate2 GetMin()
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

            return new Coordinate2(x, y);
        }

        public Line2 GetMoved(Coordinate2 vector)
        {
            return new Line2(Bounded, End.GetMoved(vector), Start.GetMoved(vector));
        }

        public float GetSquaredDistance(Coordinate2 point)
        {
            return GetClosestPoint(point).GetSquaredDistance(point);
        }

        public float GetSquaredLength()
        {
            if(Bounded.ToBool())
            {
                return float.PositiveInfinity;
            }

            return Start.GetSquaredDistance(End);
        }

        public float GetLength(float tolerance)
        {
            float squaredLength = GetSquaredLength();

            if(!Core.Query.IsValid(squaredLength))
            {
                return squaredLength;
            }

            return Core.Query.Sqrt(squaredLength, tolerance);
        }

        public Coordinate2 GetVector()
        {
            return new Coordinate2(Start, End);
        }

        public bool InRange(Line2 line, float tolerance)
        {
            if (IsNaN() || line.IsNaN())
            {
                return false;
            }

            if (!Bounded.ToBool() || !line.Bounded.ToBool())
            {
                return true;
            }

            Coordinate2 minA = GetMin();
            Coordinate2 maxA = GetMax();
            Coordinate2 minB = line.GetMin();
            Coordinate2 maxB = line.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y);
        }

        public bool InRange(Coordinate2 point, float tolerance)
        {
            return point.InRange(this, tolerance);
        }

        public bool InRange(Triangle2 triangle, float tolerance)
        {
            if (IsNaN() || triangle.IsNaN())
            {
                return false;
            }

            if (!Bounded.ToBool())
            {
                return true;
            }

            Coordinate2 minA = GetMin();
            Coordinate2 maxA = GetMax();
            Coordinate2 minB = triangle.GetMin();
            Coordinate2 maxB = triangle.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y);
        }

        public bool IsNaN()
        {
            return Start.IsNaN() || End.IsNaN();
        }
       
        public bool On(Coordinate2 point, float tolerance)
        {
            return GetSquaredDistance(point) <= tolerance;
        }

        public Coordinate2 Project(Coordinate2 point)
        {
            return GetClosestPoint(point);
        }
        
        public Line2 Project(Line2 line)
        {
            Coordinate2 start = GetClosestPoint(line.Start);
            Coordinate2 end = GetClosestPoint(line.Start);
            if(start.Equals(end))
            {
                return new Line2();
            }

            return new Line2(line.Bounded, GetClosestPoint(line.Start), GetClosestPoint(line.End));
        }

        public override string ToString()
        {
            return string.Format("S:{0};E:{1}", Start, End);
        }
    }
}
