using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    public readonly struct Line3Intersection : IIntersection3
    {
        public readonly Coordinate3 Point_1;
        public readonly Coordinate3 Point_2;
        public readonly Bool Solid;
        public Line3Intersection()
        {
            Solid = new Bool(false);
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
        }

        public Line3Intersection(Bool solid, Coordinate3 point_1)
        {
            Solid = solid;
            Point_1 = point_1;
            Point_2 = new Coordinate3();
        }

        public Line3Intersection(Coordinate3 point_1)
        {
            Solid = new Bool(false);
            Point_1 = point_1;
            Point_2 = new Coordinate3();
        }

        public Line3Intersection(Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = new Bool(false);
            Point_1 = point_1;
            Point_2 = point_2;
        }

        public Line3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = solid;
            Point_1 = point_1;
            Point_2 = point_2;
        }

        public Line3Intersection(Line3 line)
        {
            Solid = new Bool(true);
            Point_1 = line.Start;
            Point_2 = line.End;
        }

        public IGeometry3[] GetIntersectionGeometries(bool? solid = null)
        {
            if (Point_1.IsNaN())
            {
                return null;
            }

            if (Point_2.IsNaN())
            {
                return [Point_1];
            }

            bool solid_Temp = solid == null || !solid.HasValue ? Solid.ToBool() : solid.Value;

            if (solid_Temp)
            {
                return [new Line3(Point_1, Point_2)];
            }
            else
            {
                return [Point_1, Point_2];
            }
        }

        public Line3 GetLine()
        {
            if(!Solid.ToBool() || Point_2.IsNaN())
            {
                return new Line3();
            }

            return new Line3(Point_1, Point_2);
        }

        public bool IsNaN()
        {
            return Point_1.IsNaN();
        }
    }
}
