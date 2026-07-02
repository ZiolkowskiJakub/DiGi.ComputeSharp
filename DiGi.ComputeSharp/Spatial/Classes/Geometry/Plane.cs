using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional plane defined by an origin, a normal vector, and a local Y-axis.
    /// </summary>
    public readonly struct Plane : IGeometry3
    {
        /// <summary>
        /// The local Y-axis direction vector of the plane.
        /// </summary>
        public readonly Coordinate3 AxisY;

        /// <summary>
        /// The normal vector of the plane.
        /// </summary>
        public readonly Coordinate3 Normal;

        /// <summary>
        /// The origin point of the plane.
        /// </summary>
        public readonly Coordinate3 Origin;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> struct with default values (NaN coordinates).
        /// </summary>
        public Plane()
        {
            AxisY = new Coordinate3();
            Normal = new Coordinate3();
            Origin = new Coordinate3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> struct with specified origin, normal, and local Y-axis.
        /// </summary>
        /// <param name="origin">The origin point.</param>
        /// <param name="normal">The normal vector.</param>
        /// <param name="axisY">The local Y-axis direction vector.</param>
        public Plane(Coordinate3 origin, Coordinate3 normal, Coordinate3 axisY)
        {
            AxisY = axisY;
            Normal = normal;
            Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> struct with specified origin and normal, automatically deriving the local Y-axis.
        /// </summary>
        /// <param name="origin">The origin point.</param>
        /// <param name="normal">The normal vector.</param>
        /// <param name="tolerance">The tolerance value used for normalizations.</param>
        public Plane(Coordinate3 origin, Coordinate3 normal, double tolerance)
        {
            Normal = normal;
            Origin = origin;

            Coordinate3 axisX = new (normal.Y, -normal.X, 0);
            if (normal.X == 0 && normal.Y == 0)
            {
                axisX = new Coordinate3(1, 0, 0);
            }
            AxisY = normal.CrossProduct(axisX).GetNormalized(tolerance);
        }

        /// <summary>
        /// Transforms a 2D line on the plane back to a 3D line in space.
        /// </summary>
        /// <param name="line">The 2D line on the plane.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A 3D <see cref="Line3"/> in space.</returns>
        public Line3 Convert_Line(Line2 line, double tolerance)
        {
            return new Line3(Convert_Point(line.Start, tolerance), Convert_Point(line.End, tolerance));
        }

        /// <summary>
        /// Projects a 3D line onto the plane and converts it to a local 2D line representation.
        /// </summary>
        /// <param name="line">The 3D line in space.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A local 2D <see cref="Line2"/> on the plane.</returns>
        public Line2 Convert_Line(Line3 line, double tolerance)
        {
            return new Line2(Convert_Point(line.Start, tolerance), Convert_Point(line.End, tolerance));
        }

        /// <summary>
        /// Projects a 3D point onto the plane and converts it to local 2D coordinates.
        /// </summary>
        /// <param name="point">The 3D point in space.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A local <see cref="Coordinate2"/> representation on the plane.</returns>
        public Coordinate2 Convert_Point(Coordinate3 point, double tolerance)
        {
            if (point.IsNaN())
            {
                return new Coordinate2();
            }

            Coordinate3 vector = new Coordinate3(point.X - Origin.X, point.Y - Origin.Y, point.Z - Origin.Z);

            return new Coordinate2(GetAxisX(tolerance).DotProduct(vector), AxisY.DotProduct(vector));
        }

        /// <summary>
        /// Converts local 2D coordinates on the plane back to a 3D point in space.
        /// </summary>
        /// <param name="point">The local 2D point on the plane.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A 3D <see cref="Coordinate3"/> in space.</returns>
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

        /// <summary>
        /// Projects a 3D triangle onto the plane and converts it to a local 2D triangle representation.
        /// </summary>
        /// <param name="triangle">The 3D triangle in space.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A local 2D <see cref="Triangle2"/> on the plane.</returns>
        public Triangle2 Convert_Triangle(Triangle3 triangle, double tolerance)
        {
            return new Triangle2(triangle.Solid, Convert_Point(triangle.Point_1, tolerance), Convert_Point(triangle.Point_2, tolerance), Convert_Point(triangle.Point_3, tolerance));
        }

        /// <summary>
        /// Converts a local 2D triangle on the plane back to a 3D triangle in space.
        /// </summary>
        /// <param name="triangle">The local 2D triangle on the plane.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A 3D <see cref="Triangle3"/> in space.</returns>
        public Triangle3 Convert_Triangle(Triangle2 triangle, double tolerance)
        {
            return new Triangle3(triangle.Solid, Convert_Point(triangle.Point_1, tolerance), Convert_Point(triangle.Point_2, tolerance), Convert_Point(triangle.Point_3, tolerance));
        }

        /// <summary>
        /// Projects a 3D vector onto the plane and converts it to local 2D coordinates.
        /// </summary>
        /// <param name="vector">The 3D vector.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A local 2D <see cref="Coordinate2"/> representation of the vector.</returns>
        public Coordinate2 Convert_Vector(Coordinate3 vector, double tolerance)
        {
            if (vector.IsNaN())
            {
                return new Coordinate2();
            }

            return new Coordinate2(GetAxisX(tolerance).DotProduct(vector), AxisY.DotProduct(vector));
        }

        /// <summary>
        /// Converts local 2D coordinates representing a vector on the plane back to a 3D vector.
        /// </summary>
        /// <param name="vector">The local 2D vector on the plane.</param>
        /// <param name="tolerance">The tolerance used for calculations.</param>
        /// <returns>A 3D <see cref="Coordinate3"/> vector in space.</returns>
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

        /// <summary>
        /// Calculates the approximate distance from a point to this plane.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <returns>The approximate distance value.</returns>
        public double GetApproximateDistance(Coordinate3 point)
        {
            return point.GetApproximateDistance(GetClosestPoint(point));
        }

        /// <summary>
        /// Derives the local X-axis vector of the plane.
        /// </summary>
        /// <param name="tolerance">The tolerance used for normalization.</param>
        /// <returns>The derived local X-axis <see cref="Coordinate3"/> vector.</returns>
        public Coordinate3 GetAxisX(double tolerance)
        {
            return AxisY.CrossProduct(Normal).GetNormalized(tolerance);
        }

        /// <summary>
        /// Finds the point on this plane that is closest to the specified point.
        /// </summary>
        /// <param name="point">The point to project onto the plane.</param>
        /// <returns>The closest <see cref="Coordinate3"/> on this plane.</returns>
        public Coordinate3 GetClosestPoint(Coordinate3 point)
        {
            double factor = point.DotProduct(Normal) - Normal.DotProduct(Origin);

            return new Coordinate3(point.X - (Normal.X * factor), point.Y - (Normal.Y * factor), point.Z - (Normal.Z * factor));
        }

        /// <summary>
        /// Calculates the distance from a point to this plane with a specified tolerance.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <param name="tolerance">The tolerance value used for calculations.</param>
        /// <returns>The distance value.</returns>
        public double GetDistance(Coordinate3 point, double tolerance)
        {
            return GetClosestPoint(point).GetDistance(point, tolerance);
        }

        /// <summary>
        /// Returns a new plane with inverted normal and Y-axis directions.
        /// </summary>
        /// <returns>An inverted <see cref="Plane"/>.</returns>
        public Plane GetInversed()
        {
            return new Plane(Origin, Normal.GetInversed(), AxisY.GetInversed());
        }

        /// <summary>
        /// Translates the plane by the specified offset vector.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>A translated <see cref="Plane"/>.</returns>
        public Plane GetMoved(Coordinate3 vector)
        {
            return new Plane(Origin.GetMoved(vector), Normal, AxisY);
        }

        /// <summary>
        /// Calculates the squared distance from a point to this plane.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <returns>The squared distance value.</returns>
        public double GetSquaredDistance(Coordinate3 point)
        {
            return point.GetSquaredDistance(GetClosestPoint(point));
        }

        /// <summary>
        /// Checks if any vector or origin defining this plane is NaN.
        /// </summary>
        /// <returns>True if AxisY, Normal, or Origin is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return AxisY.IsNaN() || Normal.IsNaN() || Origin.IsNaN();
        }

        /// <summary>
        /// Checks if a point lies on the plane within the specified tolerance.
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>True if the point lies on the plane; otherwise, false.</returns>
        public bool On(Coordinate3 point, double tolerance)
        {
            return GetSquaredDistance(point) <= tolerance * tolerance;
        }

        /// <summary>
        /// Projects a point onto the plane along a specified direction vector.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <param name="vector">The projection direction vector.</param>
        /// <param name="tolerance">The tolerance used for comparison checks.</param>
        /// <returns>The projected 3D <see cref="Coordinate3"/> point, or NaN if the projection is parallel to the plane.</returns>
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

        /// <summary>
        /// Projects a triangle onto the plane along a specified direction vector.
        /// </summary>
        /// <param name="triangle">The triangle to project.</param>
        /// <param name="vector">The projection direction vector.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>The projected <see cref="Triangle3"/>, or NaN if any point cannot be projected.</returns>
        public Triangle3 Project(Triangle3 triangle, Coordinate3 vector, double tolerance)
        {
            Coordinate3 point_1 = Project(triangle.Point_1, vector, tolerance);
            if (point_1.IsNaN())
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

        /// <summary>
        /// Projects a line onto the plane along a specified direction vector.
        /// </summary>
        /// <param name="line">The line to project.</param>
        /// <param name="vector">The projection direction vector.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>The projected <see cref="Line3"/>, or NaN if any point cannot be projected.</returns>
        public Line3 Project(Line3 line, Coordinate3 vector, double tolerance)
        {
            Coordinate3 start = Project(line.Start, vector, tolerance);
            if (start.IsNaN())
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

        /// <summary>
        /// Projects another plane onto this plane along a specified direction vector.
        /// </summary>
        /// <param name="plane">The plane to project.</param>
        /// <param name="vector">The projection direction vector.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>The projected <see cref="Plane"/>.</returns>
        public Plane Project(Plane plane, Coordinate3 vector, double tolerance)
        {
            return new Plane(Project(plane.Origin, vector, tolerance), Normal.Project(plane.Normal).GetNormalized(tolerance), AxisY.Project(plane.AxisY).GetNormalized(tolerance));
        }

        /// <summary>
        /// Orthogonally projects a point onto the plane.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <returns>The closest 3D <see cref="Coordinate3"/> point on the plane.</returns>
        public Coordinate3 Project(Coordinate3 point)
        {
            return GetClosestPoint(point);
        }

        /// <summary>
        /// Orthogonally projects a line onto the plane.
        /// </summary>
        /// <param name="line">The line to project.</param>
        /// <returns>The projected <see cref="Line3"/>.</returns>
        public Line3 Project(Line3 line)
        {
            return new Line3(line.Bounded, GetClosestPoint(line.Start), GetClosestPoint(line.End));
        }

        /// <summary>
        /// Orthogonally projects a triangle onto the plane.
        /// </summary>
        /// <param name="triangle3">The triangle to project.</param>
        /// <returns>The projected <see cref="Triangle3"/>.</returns>
        public Triangle3 Project(Triangle3 triangle3)
        {
            return new Triangle3(GetClosestPoint(triangle3.Point_1), GetClosestPoint(triangle3.Point_2), GetClosestPoint(triangle3.Point_3));
        }

        /// <summary>
        /// Orthogonally projects another plane onto this plane.
        /// </summary>
        /// <param name="plane">The plane to project.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>The projected <see cref="Plane"/>.</returns>
        public Plane Project(Plane plane, double tolerance)
        {
            return new Plane(Project(plane.Origin), Normal.Project(plane.Normal).GetNormalized(tolerance), AxisY.Project(plane.AxisY).GetNormalized(tolerance));
        }

        /// <summary>
        /// Returns a string representation of the current plane.
        /// </summary>
        /// <returns>A formatted string containing the origin, normal, and local Y-axis coordinates.</returns>
        public override string ToString()
        {
            return string.Format("O:{0};N:{1};AY:{2}", Origin, Normal, AxisY);
        }
    }
}