using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    public struct Triangle3Intersection : IIntersection3
    {
        public readonly Coordinate3 Point_1;
        public readonly Coordinate3 Point_2;
        public readonly Coordinate3 Point_3;
        public readonly Coordinate3 Point_4;
        public readonly Coordinate3 Point_5;
        public readonly Coordinate3 Point_6;
        public readonly int Solid;
        public Triangle3Intersection()
        {
            Solid = 0;
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(Line3Intersection line3Intersection)
        {
            Solid = line3Intersection.Solid;
            Point_1 = line3Intersection.Point_1;
            Point_2 = line3Intersection.Point_2;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(Coordinate3 point_1)
        {
            Solid = 0;
            Point_1 = point_1;
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(bool solid, Coordinate3 point_1)
        {
            Solid = solid ? 1 : 0;
            Point_1 = point_1;
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = 0;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(bool solid, Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = solid ? 1 : 0;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3)
        {
            Solid = solid ? 1 : 0;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(Line3 line)
        {
            Solid = 1;
            Point_1 = line.Start;
            Point_2 = line.End;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();
        }

        public Triangle3Intersection(bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3, Coordinate3 point_4, Coordinate3 point_5, Coordinate3 point_6)
        {
            Solid = 1;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
            Point_4 = point_4;
            Point_5 = point_5;
            Point_6 = point_6;
        }

        public IGeometry3[] GetIntersectionGeometries()
        {
            if (Point_1.IsNaN())
            {
                return null;
            }

            if (Point_2.IsNaN())
            {
                return [Point_1];
            }

            bool solid = IsSolid();

            if (Point_3.IsNaN())
            {
                if (solid)
                {
                    return [new Line3(Point_1, Point_2)];
                }
                else
                {
                    return [Point_1, Point_2];
                }
            }

            if (Point_4.IsNaN())
            {
                if (solid)
                {
                    return [new Triangle3(solid, Point_1, Point_2, Point_3)];
                }
                else
                {
                    return [new Line3(Point_1, Point_2), new Line3(Point_2, Point_3), new Line3(Point_3, Point_1)];
                }
            }

            if (Point_5.IsNaN())
            {
                return [new Triangle3(IsSolid(), Point_1, Point_2, Point_3), new Triangle3(IsSolid(), Point_2, Point_3, Point_4)];
            }



            return null;
        }

        public bool IsNaN()
        {
            return Point_1.IsNaN();
        }

        public bool IsSolid()
        {
            return Solid == 1;
        }
    }
}
