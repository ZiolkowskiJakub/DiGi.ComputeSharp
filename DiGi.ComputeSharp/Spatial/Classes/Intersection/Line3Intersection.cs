using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    public readonly struct Line3Intersection : IIntersection3
    {
        public readonly Coordinate3 Point_1;
        public readonly Coordinate3 Point_2;
        public readonly int Solid;
        public Line3Intersection()
        {
            Solid = 0;
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
        }

        public Line3Intersection(Coordinate3 point_1)
        {
            Solid = 0;
            Point_1 = point_1;
            Point_2 = new Coordinate3();
        }

        public Line3Intersection(Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = 0;
            Point_1 = point_1;
            Point_2 = point_2;
        }

        public Line3Intersection(bool solid, Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = solid ? 1 : 0;
            Point_1 = point_1;
            Point_2 = point_2;
        }

        public Line3Intersection(Line3 line)
        {
            Solid = 1;
            Point_1 = line.Start;
            Point_2 = line.End;
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

            if (IsSolid())
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
            if(!IsSolid() || Point_2.IsNaN())
            {
                return new Line3();
            }

            return new Line3(Point_1, Point_2);
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
