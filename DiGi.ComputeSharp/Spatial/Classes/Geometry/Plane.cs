﻿using DiGi.ComputeSharp.Core.Constans;
using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;
using System.Numerics;

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

        public Plane(Coordinate3 origin, Coordinate3 normal, double tolerance)
        {
            Normal = normal;
            Origin = origin;

            Coordinate3 axisX = new Coordinate3(normal.Y, -normal.X, 0);
            if(normal.X == 0 && normal.Y == 0)
            {
                axisX = new Coordinate3(1, 0, 0);
            }
            AxisY = normal.CrossProduct(axisX).GetNormalized(tolerance);
        }

        public Line3 Convert_Line(Line2 line, double tolerance)
        {
            return new Line3(Convert_Point(line.Start, tolerance), Convert_Point(line.End, tolerance));
        }

        public Line2 Convert_Line(Line3 line, double tolerance)
        {
            return new Line2(Convert_Point(line.Start, tolerance), Convert_Point(line.End, tolerance));
        }

        public Coordinate2 Convert_Point(Coordinate3 point, double tolerance)
        {
            if (point.IsNaN())
            {
                return new Coordinate2();
            }

            Coordinate3 vector = new Coordinate3(point.X - Origin.X, point.Y - Origin.Y, point.Z - Origin.Z);

            return new Coordinate2(GetAxisX(tolerance).DotProduct(vector), AxisY.DotProduct(vector));
        }

        public Coordinate3 Convert_Point(Coordinate2 point, double tolerance)
        {
            if (point.IsNaN())
            {
                return new Coordinate3();
            }

            Coordinate3 axisX = GetAxisX(tolerance);

            Coordinate3 u = new Coordinate3(AxisY.X * point.Y, AxisY.Y * point.Y, AxisY.Z * point.Y);
            Coordinate3 v = new Coordinate3(axisX.X * point.X, axisX.Y * point.X, axisX.Z * point.X);

            return new Coordinate3(Origin.X + u.X + v.X, Origin.Y + u.Y + v.Y, Origin.Z + u.Z + v.Z);
        }

        public Triangle2 Convert_Triangle(Triangle3 triangle, double tolerance)
        {
            return new Triangle2(triangle.Solid, Convert_Point(triangle.Point_1, tolerance), Convert_Point(triangle.Point_2, tolerance), Convert_Point(triangle.Point_3, tolerance));
        }

        public Triangle3 Convert_Triangle(Triangle2 triangle, double tolerance)
        {
            return new Triangle3(triangle.Solid, Convert_Point(triangle.Point_1, tolerance), Convert_Point(triangle.Point_2, tolerance), Convert_Point(triangle.Point_3, tolerance));
        }

        public Coordinate2 Convert_Vector(Coordinate3 vector, double tolerance)
        {
            if (vector.IsNaN())
            {
                return new Coordinate2();
            }

            return new Coordinate2(GetAxisX(tolerance).DotProduct(vector), AxisY.DotProduct(vector));
        }

        public Coordinate3 Convert_Vector(Coordinate2 vector, double tolerance)
        {
            if (vector.IsNaN())
            {
                return new Coordinate3();
            }

            Coordinate3 axisX = GetAxisX(tolerance);

            Coordinate3 u = new Coordinate3(AxisY.X * vector.Y, AxisY.Y * vector.Y, AxisY.Z * vector.Y);
            Coordinate3 v = new Coordinate3(axisX.X * vector.X, axisX.Y * vector.X, axisX.Z * vector.X);

            return new Coordinate3(u.X + v.X, u.Y + v.Y, u.Z + v.Z);
        }
        
        public double GetApproximateDistance(Coordinate3 point)
        {
            return point.GetApproximateDistance(GetClosestPoint(point));
        }

        public Coordinate3 GetAxisX(double tolerance)
        {
            return AxisY.CrossProduct(Normal).GetNormalized(tolerance);
        }

        public Coordinate3 GetClosestPoint(Coordinate3 point)
        {
            double factor = point.DotProduct(Normal) - Normal.DotProduct(Origin);

            return new Coordinate3(point.X - (Normal.X * factor), point.Y - (Normal.Y * factor), point.Z - (Normal.Z * factor));
        }

        public double GetDistance(Coordinate3 point, double tolerance)
        {
            return GetClosestPoint(point).GetDistance(point, tolerance);
        }

        public Plane GetInversed()
        {
            return new Plane(Origin, Normal.GetInversed(), AxisY.GetInversed());
        }

        public Plane GetMoved(Coordinate3 vector)
        {
            return new Plane(Origin.GetMoved(vector), Normal, AxisY);
        }

        public double GetSquaredDistance(Coordinate3 point)
        {
            return point.GetSquaredDistance(GetClosestPoint(point));
        }

        public bool IsNaN()
        {
            return AxisY.IsNaN() || Normal.IsNaN() || Origin.IsNaN();
        }

        public bool On(Coordinate3 point, double tolerance)
        {
            return GetSquaredDistance(point) <= tolerance;
        }

        public Coordinate3 Project(Coordinate3 point, Coordinate3 vector, double tolerance)
        {
            double denom = vector.DotProduct(Normal);
            if (Core.Query.Abs(denom) < tolerance)
            {
                return new Coordinate3();
            }

            double t = new Coordinate3(point, Origin).DotProduct(Normal) / denom;
            return point.Add(vector.Multiply(t));
        }

        public Triangle3 Project(Triangle3 triangle, Coordinate3 vector, double tolerance)
        {
            Coordinate3 point_1 = Project(triangle.Point_1, vector, tolerance);
            if(point_1.IsNaN())
            {
                return new Triangle3();
            }

            Coordinate3 point_2 = Project(triangle.Point_2, vector, tolerance);
            if (point_2.IsNaN())
            {
                return new Triangle3();
            }

            Coordinate3 point_3 = Project(triangle.Point_3, vector, tolerance);
            if (point_3.IsNaN())
            {
                return new Triangle3();
            }

            return new Triangle3(triangle.Solid, point_1, point_2, point_3);
        }

        public Line3 Project(Line3 line, Coordinate3 vector, double tolerance)
        {
            Coordinate3 start = Project(line.Start, vector, tolerance);
            if(start.IsNaN())
            {
                return new Line3();
            }

            Coordinate3 end = Project(line.End, vector, tolerance);
            if (end.IsNaN())
            {
                return new Line3();
            }

            return new Line3(line.Bounded, start, end);
        }

        public Plane Project(Plane plane, Coordinate3 vector, double tolerance)
        {
            return new Plane(Project(plane.Origin, vector, tolerance), Normal.Project(plane.Normal).GetNormalized(tolerance), AxisY.Project(plane.AxisY).GetNormalized(tolerance));
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

        public Plane Project(Plane plane, double tolerance)
        {
            return new Plane(Project(plane.Origin), Normal.Project(plane.Normal).GetNormalized(tolerance), AxisY.Project(plane.AxisY).GetNormalized(tolerance));
        }
        
        public override string ToString()
        {
            return string.Format("O:{0};N:{1};AY:{2}", Origin, Normal, AxisY);
        }
    }
}
