using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Planar.Interfaces;

namespace DiGi.ComputeSharp.Planar.Classes
{
    public readonly struct Triangle2 : IGeometry2
    {
        public readonly Coordinate2 Point_1;
        public readonly Coordinate2 Point_2;
        public readonly Coordinate2 Point_3;
        public readonly Bool Solid;
        
        public Triangle2()
        {
            Solid = new Bool(false);
            Point_1 = new Coordinate2();
            Point_2 = new Coordinate2();
            Point_3 = new Coordinate2();
        }

        public Triangle2(Bool solid, Coordinate2 point_1, Coordinate2 point_2, Coordinate2 point_3)
        {
            Solid = solid;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
        }

        public float GetApproximatePerimeter()
        {
            return Point_1.GetApproximateDistance(Point_2) + Point_2.GetApproximateDistance(Point_3) + Point_3.GetApproximateDistance(Point_1);
        }

        public float GetArea()
        {
            float result = 0.5f * ((Point_2.X - Point_1.X) * (Point_3.Y - Point_1.Y) - (Point_2.Y - Point_1.Y) * (Point_3.X - Point_1.X));

            if (result < 0)
            {
                result = -result;
            }

            return result;
        }

        public Coordinate2 GetCentroid()
        {
            float centroidX = (Point_1.X + Point_2.X + Point_3.X) / 3.0f;
            float centroidY = (Point_1.Y + Point_2.Y + Point_3.Y) / 3.0f;

            return new Coordinate2(centroidX, centroidY);
        }

        public Triangle2 GetInversed()
        {
            return new Triangle2(Solid, Point_3, Point_2, Point_1);
        }

        public Line2 GetLine(int index)
        {
            switch (index)
            {
                case 0:
                    return new Line2(new Bool(true), Point_1, Point_2);

                case 1:
                    return new Line2(new Bool(true), Point_2, Point_3);

                case 2:
                    return new Line2(new Bool(true), Point_3, Point_1);
            }

            return new Line2();
        }

        public Line2[] GetLines()
        {
            return [GetLine(0), GetLine(1), GetLine(2)];
        }

        public Coordinate2 GetMax()
        {
            float x = Point_1.X;
            if (x < Point_2.X)
            {
                x = Point_2.X;
            }

            if (x < Point_3.X)
            {
                x = Point_3.X;
            }

            float y = Point_1.Y;
            if (y < Point_2.Y)
            {
                y = Point_2.Y;
            }
            if (y < Point_3.Y)
            {
                y = Point_3.Y;
            }

            return new Coordinate2(x, y);
        }

        public Coordinate2 GetMin()
        {
            float x = Point_1.X;
            if (x > Point_2.X)
            {
                x = Point_2.X;
            }

            if (x > Point_3.X)
            {
                x = Point_3.X;
            }

            float y = Point_1.Y;
            if (y > Point_2.Y)
            {
                y = Point_2.Y;
            }
            if (y > Point_3.Y)
            {
                y = Point_3.Y;
            }

            return new Coordinate2(x, y);
        }

        public Triangle2 GetMoved(Coordinate2 vector)
        {
            return new Triangle2(Solid, Point_1.GetMoved(vector), Point_2.GetMoved(vector), Point_3.GetMoved(vector));
        }

        public bool InRange(Coordinate2 point, float tolerance)
        {
            return point.InRange(this, tolerance);
        }

        public bool InRange(Line2 line, float tolerance)
        {
            return line.InRange(this, tolerance);
        }

        public bool InRange(Triangle2 triangle, float tolerance)
        {
            if (IsNaN() || triangle.IsNaN())
            {
                return false;
            }

            Coordinate2 minA = GetMin();
            Coordinate2 maxA = GetMax();
            Coordinate2 minB = triangle.GetMin();
            Coordinate2 maxB = triangle.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y);
        }

        public bool Inside(Coordinate2 point, float tolerance)
        {
            throw new NotImplementedException();
        }

        public bool IsNaN()
        {
            return Point_1.IsNaN() || Point_1.IsNaN() || Point_3.IsNaN();
        }

        public bool On(Coordinate2 point, float tolerance)
        {

            if(Solid.ToBool())
            {
                return Inside(point, tolerance);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (GetLine(i).On(point, tolerance))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        public override string ToString()
        {
            return string.Format("P1:{0};P2:{1};P3:{2}", Point_1, Point_2, Point_3);
        }
    }
}
