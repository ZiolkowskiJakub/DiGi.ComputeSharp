using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;
using System.Net.Http.Headers;

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

        public readonly Bool Solid;

        public Triangle3Intersection()
        {
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = new Bool(false);
        }

        public Triangle3Intersection(Line3Intersection line3Intersection)
        {
            Point_1 = line3Intersection.Point_1;
            Point_2 = line3Intersection.Point_2;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = line3Intersection.Solid;
        }

        public Triangle3Intersection(Line3 line)
        {
            Point_1 = line.Start;
            Point_2 = line.End;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = new Bool(false);
        }

        public Triangle3Intersection(Bool solid, Coordinate3 point_1)
        {
            Point_1 = point_1;
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = solid;
        }

        public Triangle3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = solid;
        }

        public Triangle3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = solid;
        }

        public Triangle3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3, Coordinate3 point_4, Coordinate3 point_5, Coordinate3 point_6)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
            Point_4 = point_4;
            Point_5 = point_5;
            Point_6 = point_6;

            Solid = solid;
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

            if (Point_3.IsNaN())
            {
                if (Solid.ToBool())
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
                if (Solid.ToBool())
                {
                    return [new Triangle3(Solid, Point_1, Point_2, Point_3)];
                }
                else
                {
                    return [new Line3(Point_1, Point_2), new Line3(Point_2, Point_3), new Line3(Point_3, Point_1)];
                }
            }

            if (Point_5.IsNaN())
            {
                if (Solid.ToBool())
                {
                    return [new Triangle3(Solid, Point_1, Point_2, Point_3), new Triangle3(Solid, Point_1, Point_3, Point_4)];
                }
                else
                {
                    Bool @bool = new Bool(true);

                    return [new Line3(@bool, Point_1, Point_2), new Line3(@bool, Point_2, Point_3), new Line3(@bool, Point_3, Point_4), new Line3(@bool, Point_4, Point_1)];
                }
            }

            if (Point_6.IsNaN())
            {
                if (Solid.ToBool())
                {
                    return [new Triangle3(Solid, Point_1, Point_2, Point_3), new Triangle3(Solid, Point_1, Point_3, Point_4), new Triangle3(Solid, Point_1, Point_4, Point_5)];
                }
                else
                {
                    Bool @bool = new Bool(true);

                    return [new Line3(@bool, Point_1, Point_2), new Line3(@bool, Point_2, Point_3), new Line3(@bool, Point_3, Point_4), new Line3(@bool, Point_4, Point_5), new Line3(@bool, Point_5, Point_1)];
                }
            }

            if (Solid.ToBool())
            {
                return [new Triangle3(Solid, Point_1, Point_2, Point_3), new Triangle3(Solid, Point_3, Point_4, Point_5), new Triangle3(Solid, Point_1, Point_5, Point_6), new Triangle3(Solid, Point_1, Point_3, Point_5)];
            }
            else
            {
                Bool @bool = new Bool(true);

                return [new Line3(@bool, Point_1, Point_2), new Line3(@bool, Point_2, Point_3), new Line3(@bool, Point_3, Point_4), new Line3(@bool, Point_4, Point_5), new Line3(@bool, Point_5, Point_6), new Line3(@bool, Point_6, Point_1)];
            }
        }

        public bool IsNaN()
        {
            return Point_1.IsNaN();
        }
    }
}
