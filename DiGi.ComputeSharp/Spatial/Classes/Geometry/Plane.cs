using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    public readonly struct Plane : IGeometry3
    {
        public readonly Coordinate3 AxisY;
        public readonly Coordinate3 Normal;
        public readonly Coordinate3 Origin;

        public Plane()
        {
            AxisY = new Coordinate3();
            Normal = new Coordinate3();
            Origin = new Coordinate3();
        }

        public Plane(Coordinate3 origin, Coordinate3 normal, Coordinate3 axisY)
        {
            AxisY = axisY;
            Normal = normal;
            Origin = origin;
        }

        public Plane(Coordinate3 origin, Coordinate3 normal)
        {
            Normal = normal;
            Origin = origin;

            Coordinate3 axisX = new Coordinate3(normal.Y, -normal.X, 0);
            if(normal.X == 0 && normal.Y == 0)
            {
                axisX = new Coordinate3(1, 0, 0);
            }
            AxisY = normal.CrossProduct(axisX).GetNormalized();
        }

        public Line3 Convert_Line(Line2 line)
        {
            return new Line3(Convert_Point(line.Start), Convert_Point(line.End));
        }

        public Line2 Convert_Line(Line3 line)
        {
            return new Line2(Convert_Point(line.Start), Convert_Point(line.End));
        }

        public Coordinate2 Convert_Point(Coordinate3 point)
        {
            if (point.IsNaN())
            {
                return new Coordinate2();
            }

            Coordinate3 vector = new Coordinate3(point.X - Origin.X, point.Y - Origin.Y, point.Z - Origin.Z);

            return new Coordinate2(GetAxisX().DotProduct(vector), AxisY.DotProduct(vector));
        }

        public Coordinate3 Convert_Point(Coordinate2 point)
        {
            if (point.IsNaN())
            {
                return new Coordinate3();
            }

            Coordinate3 axisX = GetAxisX();

            Coordinate3 u = new Coordinate3(AxisY.X * point.Y, AxisY.Y * point.Y, AxisY.Z * point.Y);
            Coordinate3 v = new Coordinate3(axisX.X * point.X, axisX.Y * point.X, axisX.Z * point.X);

            return new Coordinate3(Origin.X + u.X + v.X, Origin.Y + u.Y + v.Y, Origin.Z + u.Z + v.Z);
        }

        public Triangle2 Convert_Triangle(Triangle3 triangle)
        {
            return new Triangle2(triangle.Solid, Convert_Point(triangle.Point_1), Convert_Point(triangle.Point_2), Convert_Point(triangle.Point_3));
        }

        public Triangle3 Convert_Triangle(Triangle2 triangle)
        {
            return new Triangle3(triangle.Solid, Convert_Point(triangle.Point_1), Convert_Point(triangle.Point_2), Convert_Point(triangle.Point_3));
        }

        public Coordinate2 Convert_Vector(Coordinate3 vector)
        {
            if (vector.IsNaN())
            {
                return new Coordinate2();
            }

            return new Coordinate2(GetAxisX().DotProduct(vector), AxisY.DotProduct(vector));
        }

        public Coordinate3 Convert_Vector(Coordinate2 vector)
        {
            if (vector.IsNaN())
            {
                return new Coordinate3();
            }

            Coordinate3 axisX = GetAxisX();

            Coordinate3 u = new Coordinate3(AxisY.X * vector.Y, AxisY.Y * vector.Y, AxisY.Z * vector.Y);
            Coordinate3 v = new Coordinate3(axisX.X * vector.X, axisX.Y * vector.X, axisX.Z * vector.X);

            return new Coordinate3(u.X + v.X, u.Y + v.Y, u.Z + v.Z);
        }
        
        public float GetApproximateDistance(Coordinate3 point)
        {
            return point.GetApproximateDistance(GetClosestPoint(point));
        }

        public Coordinate3 GetAxisX()
        {
            return AxisY.CrossProduct(Normal).GetNormalized();
        }

        public Coordinate3 GetClosestPoint(Coordinate3 point)
        {
            float factor = point.DotProduct(Normal) - Normal.DotProduct(Origin);

            return new Coordinate3(point.X - (Normal.X * factor), point.Y - (Normal.Y * factor), point.Z - (Normal.Z * factor));
        }
        
        public Plane GetInversed()
        {
            return new Plane(Origin, Normal.GetInversed(), AxisY.GetInversed());
        }

        public Plane GetMoved(Coordinate3 vector)
        {
            return new Plane(Origin.GetMoved(vector), Normal, AxisY);
        }

        public float GetSquaredDistance(Coordinate3 point)
        {
            return point.GetSquaredDistance(GetClosestPoint(point));
        }
        
        public bool IsNaN()
        {
            return AxisY.IsNaN() || Normal.IsNaN() || Origin.IsNaN();
        }
        
        public Coordinate3 Project(Coordinate3 point)
        {
            return GetClosestPoint(point);
        }

        public Line3 Project(Line3 line)
        {
            return new Line3(line.Bounded, GetClosestPoint(line.Start), GetClosestPoint(line.End));
        }

        public Triangle3 Project(Triangle3 triangle3)
        {
            return new Triangle3(GetClosestPoint(triangle3.Point_1), GetClosestPoint(triangle3.Point_2), GetClosestPoint(triangle3.Point_3));
        }

        public Plane Project(Plane plane)
        {
            return new Plane(Project(plane.Origin), Normal.Project(plane.Normal).GetNormalized(), AxisY.Project(plane.AxisY).GetNormalized());
        }
        
        public override string ToString()
        {
            return string.Format("O:{0};N:{1};AY:{2}", Origin, Normal, AxisY);
        }
    }
}
