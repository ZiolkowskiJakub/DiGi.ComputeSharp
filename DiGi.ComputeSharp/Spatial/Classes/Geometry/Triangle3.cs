using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional triangle in a spatial coordinate system.
    /// </summary>
    public readonly struct Triangle3 : IGeometry3
    {
        /// <summary>
        /// The first vertex of the triangle.
        /// </summary>
        public readonly Coordinate3 Point_1;

        /// <summary>
        /// The second vertex of the triangle.
        /// </summary>
        public readonly Coordinate3 Point_2;

        /// <summary>
        /// The third vertex of the triangle.
        /// </summary>
        public readonly Coordinate3 Point_3;

        /// <summary>
        /// A value indicating whether the triangle is solid (filled) or boundary-only.
        /// </summary>
        public readonly Bool Solid;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3"/> struct with default values (NaN coordinates and not solid).
        /// </summary>
        public Triangle3()
        {
            Solid = new Bool(false);
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3"/> struct with the specified vertices.
        /// </summary>
        /// <param name="point_1">The first vertex.</param>
        /// <param name="point_2">The second vertex.</param>
        /// <param name="point_3">The third vertex.</param>
        public Triangle3(Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3"/> struct by copying an existing triangle.
        /// </summary>
        /// <param name="triangle3">The source triangle to copy.</param>
        public Triangle3(Triangle3 triangle3)
        {
            Solid = triangle3.Solid;
            Point_1 = triangle3.Point_1;
            Point_2 = triangle3.Point_2;
            Point_3 = triangle3.Point_3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3"/> struct with specified solid state and vertices.
        /// </summary>
        /// <param name="solid">A value indicating whether the triangle is solid.</param>
        /// <param name="point_1">The first vertex.</param>
        /// <param name="point_2">The second vertex.</param>
        /// <param name="point_3">The third vertex.</param>
        public Triangle3(Bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3)
        {
            Solid = solid;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3"/> struct with specified solid state and coordinates.
        /// </summary>
        /// <param name="solid">A value indicating whether the triangle is solid.</param>
        /// <param name="x_1">The X component of the first point.</param>
        /// <param name="y_1">The Y component of the first point.</param>
        /// <param name="z_1">The Z component of the first point.</param>
        /// <param name="x_2">The X component of the second point.</param>
        /// <param name="y_2">The Y component of the second point.</param>
        /// <param name="z_2">The Z component of the second point.</param>
        /// <param name="x_3">The X component of the third point.</param>
        /// <param name="y_3">The Y component of the third point.</param>
        /// <param name="z_3">The Z component of the third point.</param>
        public Triangle3(Bool solid, double x_1, double y_1, double z_1, double x_2, double y_2, double z_2, double x_3, double y_3, double z_3)
        {
            Solid = solid;
            Point_1 = new Coordinate3(x_1, y_1, z_1);
            Point_2 = new Coordinate3(x_2, y_2, z_2);
            Point_3 = new Coordinate3(x_3, y_3, z_3);
        }

        /// <summary>
        /// Calculates the approximate perimeter of the triangle using fast distance calculations.
        /// </summary>
        /// <returns>The approximate perimeter of the triangle.</returns>
        public double GetApproximatePerimeter()
        {
            return Point_1.GetApproximateDistance(Point_2) + Point_2.GetApproximateDistance(Point_3) + Point_3.GetApproximateDistance(Point_1);
        }

        /// <summary>
        /// Calculates the area of the 3D triangle with the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The tolerance used for distance and projection calculations.</param>
        /// <returns>The area of the triangle, or NaN if any component is NaN.</returns>
        public double GetArea(double tolerance)
        {
            if (IsNaN())
            {
                return double.NaN;
            }

            return GetPlane(tolerance).Convert_Triangle(this, tolerance).GetArea();
        }

        /// <summary>
        /// Gets the centroid (geometric center) of the 3D triangle.
        /// </summary>
        /// <returns>A <see cref="Coordinate3"/> representing the centroid of the triangle.</returns>
        public Coordinate3 GetCentroid()
        {
            double centroidX = (Point_1.X + Point_2.X + Point_3.X) / 3.0f;
            double centroidY = (Point_1.Y + Point_2.Y + Point_3.Y) / 3.0f;
            double centroidZ = (Point_1.Z + Point_2.Z + Point_3.Z) / 3.0f;

            return new Coordinate3(centroidX, centroidY, centroidZ);
        }

        /// <summary>
        /// Calculates the equilaterality factor of the triangle, indicating how close it is to an equilateral triangle.
        /// </summary>
        /// <returns>The equilaterality factor (0 to 1, where 1 is perfectly equilateral).</returns>
        public double GetEquilateralityFactor()
        {
            if (IsNaN())
            {
                return 0;
            }

            double length_1 = GetLine(0).GetSquaredLength();
            double length_2 = GetLine(1).GetSquaredLength();
            double length_3 = GetLine(2).GetSquaredLength();

            double mean = (length_1 + length_2 + length_3) / 3f;

            double length = length_1;

            if (length_2 < length)
            {
                length = length_2;
            }

            if (length_3 < length)
            {
                length = length_3;
            }

            return length / mean;
        }

        /// <summary>
        /// Gets a new triangle with inverted winding order (reversing normal direction).
        /// </summary>
        /// <returns>An inverted <see cref="Triangle3"/>.</returns>
        public Triangle3 GetInversed()
        {
            return new Triangle3(Point_3, Point_2, Point_1);
        }

        /// <summary>
        /// Gets one of the boundary lines of the triangle by index.
        /// </summary>
        /// <param name="index">The line index (0, 1, or 2).</param>
        /// <returns>The boundary <see cref="Line3"/> at the specified index.</returns>
        public Line3 GetLine(int index)
        {
            switch (index)
            {
                case 0:
                    return new Line3(new Bool(true), Point_1, Point_2);

                case 1:
                    return new Line3(new Bool(true), Point_2, Point_3);

                case 2:
                    return new Line3(new Bool(true), Point_3, Point_1);
            }

            return new Line3();
        }

        /// <summary>
        /// Gets all boundary lines of the triangle.
        /// </summary>
        /// <returns>An array of three <see cref="Line3"/> objects representing the boundary lines.</returns>
        public Line3[] GetLines()
        {
            return [GetLine(0), GetLine(1), GetLine(2)];
        }

        /// <summary>
        /// Gets the maximum coordinate bounds of the triangle.
        /// </summary>
        /// <returns>A <see cref="Coordinate3"/> representing the maximum X, Y, and Z coordinates.</returns>
        public Coordinate3 GetMax()
        {
            double x = Point_1.X;
            if (x < Point_2.X)
            {
                x = Point_2.X;
            }

            if (x < Point_3.X)
            {
                x = Point_3.X;
            }

            double y = Point_1.Y;
            if (y < Point_2.Y)
            {
                y = Point_2.Y;
            }
            if (y < Point_3.Y)
            {
                y = Point_3.Y;
            }

            double z = Point_1.Z;
            if (z < Point_2.Z)
            {
                z = Point_2.Z;
            }

            if (z < Point_3.Z)
            {
                z = Point_3.Z;
            }

            return new Coordinate3(x, y, z);
        }

        /// <summary>
        /// Gets the minimum coordinate bounds of the triangle.
        /// </summary>
        /// <returns>A <see cref="Coordinate3"/> representing the minimum X, Y, and Z coordinates.</returns>
        public Coordinate3 GetMin()
        {
            double x = Point_1.X;
            if (x > Point_2.X)
            {
                x = Point_2.X;
            }

            if (x > Point_3.X)
            {
                x = Point_3.X;
            }

            double y = Point_1.Y;
            if (y > Point_2.Y)
            {
                y = Point_2.Y;
            }
            if (y > Point_3.Y)
            {
                y = Point_3.Y;
            }

            double z = Point_1.Z;
            if (z > Point_2.Z)
            {
                z = Point_2.Z;
            }

            if (z > Point_3.Z)
            {
                z = Point_3.Z;
            }

            return new Coordinate3(x, y, z);
        }

        /// <summary>
        /// Translates the triangle by the specified offset vector.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>A translated <see cref="Triangle3"/>.</returns>
        public Triangle3 GetMoved(Coordinate3 vector)
        {
            return new Triangle3(Point_1.GetMoved(vector), Point_2.GetMoved(vector), Point_3.GetMoved(vector));
        }

        /// <summary>
        /// Calculates the normal vector of the triangle.
        /// </summary>
        /// <param name="tolerance">The tolerance value used for vector normalization.</param>
        /// <returns>The normalized normal vector.</returns>
        public Coordinate3 GetNormal(double tolerance)
        {
            return new Coordinate3(Point_1, Point_2).CrossProduct(new Coordinate3(Point_1, Point_3)).GetNormalized(tolerance);
        }

        /// <summary>
        /// Calculates the perimeter of the triangle with the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The tolerance used for distance calculations.</param>
        /// <returns>The perimeter of the triangle.</returns>
        public double GetPerimeter(double tolerance)
        {
            return Point_1.GetDistance(Point_2, tolerance) + Point_2.GetDistance(Point_3, tolerance) + Point_3.GetDistance(Point_1, tolerance);
        }

        /// <summary>
        /// Gets the plane defined by the triangle's vertices and its normal vector.
        /// </summary>
        /// <param name="tolerance">The tolerance value used for normal calculation.</param>
        /// <returns>The <see cref="Plane"/> on which the triangle lies.</returns>
        public Plane GetPlane(double tolerance)
        {
            return new Plane(Point_1, GetNormal(tolerance), tolerance);
        }

        /// <summary>
        /// Checks if a set of coordinates is within the bounding box of the triangle expanded by a tolerance.
        /// </summary>
        /// <param name="x">The X component of the point.</param>
        /// <param name="y">The Y component of the point.</param>
        /// <param name="z">The Z component of the point.</param>
        /// <param name="tolerance">The distance used to expand the bounding box.</param>
        /// <returns>True if the coordinates are within the expanded bounding box; otherwise, false.</returns>
        public bool InRange(double x, double y, double z, double tolerance)
        {
            if (IsNaN())
            {
                return false;
            }

            Coordinate3 min = GetMin();
            Coordinate3 max = GetMax();

            return x - tolerance <= max.X && x + tolerance >= min.X &&
                y - tolerance <= max.Y && y + tolerance >= min.Y &&
                z - tolerance <= max.Z && z + tolerance >= min.Z;
        }

        /// <summary>
        /// Checks if a point is within the range of the triangle's bounding box expanded by a tolerance.
        /// </summary>
        /// <param name="point">The point to check.</param>
        /// <param name="tolerance">The distance used to expand the bounding box.</param>
        /// <returns>True if the point is within range; otherwise, false.</returns>
        public bool InRange(Coordinate3 point, double tolerance)
        {
            if (point.IsNaN())
            {
                return false;
            }

            return InRange(point.X, point.Y, point.Z, tolerance);
        }

        /// <summary>
        /// Checks if a line is within the bounding range of the triangle.
        /// </summary>
        /// <param name="line3">The line to check.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>True if the bounding boxes overlap; otherwise, false.</returns>
        public bool InRange(Line3 line3, double tolerance)
        {
            return line3.InRange(this, tolerance);
        }

        /// <summary>
        /// Checks if another triangle is within the bounding range of this triangle.
        /// </summary>
        /// <param name="triangle3">The other triangle to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the triangles' bounding boxes overlap; otherwise, false.</returns>
        public bool InRange(Triangle3 triangle3, double tolerance)
        {
            if (IsNaN() || triangle3.IsNaN())
            {
                return false;
            }

            Coordinate3 minA = GetMin();
            Coordinate3 maxA = GetMax();
            Coordinate3 minB = triangle3.GetMin();
            Coordinate3 maxB = triangle3.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y) &&
                    (minA.Z - tolerance <= maxB.Z && maxA.Z + tolerance >= minB.Z);
        }

        /// <summary>
        /// Determines whether a point lies inside the triangle using barycentric coordinates in 3D.
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <param name="tolerance">The numerical tolerance value.</param>
        /// <returns>True if the point lies inside or on the boundary of the triangle; otherwise, false.</returns>
        public bool Inside(Coordinate3 point, double tolerance)
        {
            // Vectors forming two sides of the triangle
            Coordinate3 ab = Point_2.Substract(Point_1);
            Coordinate3 ac = Point_3.Substract(Point_1);

            // Calculate the triangle's normal
            Coordinate3 crossProduct = ab.CrossProduct(ac);
            double squaredLength = crossProduct.GetSquaredLength();

            double squaredTolerance = tolerance * tolerance;

            // Handle degenerate triangles (area is zero, points are collinear)
            if (squaredLength <= squaredTolerance) // Use a small epsilon for robustness against near-zero length
            {
                // If the triangle is degenerate (a line or a point), check if the point lies on that line/point within tolerance.
                // This is a simplified check for a 3D line.
                // If the triangle is a point (A=B=C), check distance to A.
                if (ab.GetSquaredLength() <= squaredTolerance && ac.GetSquaredLength() <= squaredTolerance)
                {
                    return point.Substract(Point_1).GetSquaredLength() <= squaredTolerance;
                }
                // If the triangle is a line (A, B, C are collinear)
                Coordinate3 closestOnLine = new Line3(new Bool(true), Point_1, Point_2).GetClosestPoint(point); // Assuming A-B defines the primary line
                double distSq = point.Substract(closestOnLine).GetSquaredLength();
                return distSq <= squaredTolerance;
            }

            // Normalize the normal vector
            Coordinate3 unitNormal = crossProduct.GetNormalized(tolerance);

            // Calculate the signed distance from point P to the plane of the triangle
            // The plane equation is: N . (X - A) = 0
            // Distance = N . (P - A) / |N|
            Coordinate3 ap = point.Substract(Point_1);
            double signedDistance = ap.DotProduct(unitNormal);

            // Check if the point is within the plane tolerance
            if (Core.Query.Abs(signedDistance) > tolerance)
            {
                return false; // Point is too far from the triangle's plane
            }

            // Project P onto the triangle's plane to get the point Q (unless it's already very close)
            Coordinate3 q = point.Substract(unitNormal).Multiply(signedDistance);

            // Now, check if Q is inside the 2D triangle (defined by A, B, C) using barycentric coordinates
            // We're working in the plane of the triangle, so we can flatten it to 2D for barycentric calculation if needed,
            // or keep it in 3D using the dot product method. The 3D dot product method is more general.

            double dot00 = ab.DotProduct(ab); // |AB|^2
            double dot01 = ab.DotProduct(ac); // AB . AC
            double dot02 = ab.DotProduct(ap); // AB . AP
            double dot11 = ac.DotProduct(ac); // |AC|^2
            double dot12 = ac.DotProduct(ap); // AC . AP

            double invDenom = 1.0f / (dot00 * dot11 - dot01 * dot01); // 1 / (2 * Area_parallelogram)^2
                                                                      // If denominator is zero or near-zero, it means the triangle is degenerate (collinear vertices),
                                                                      // which should have been caught by the normalLength check above. However, for robustness:
            if (!Core.Query.IsValid(invDenom))
            {
                // This case should ideally be handled by the normalLength check.
                // If it slips through, fall back to line check.
                Coordinate3 closestOnLine = new Line3(new Bool(true), Point_1, Point_2).GetClosestPoint(point);
                double distSq = point.Substract(closestOnLine).GetSquaredLength();
                return distSq <= squaredTolerance;
            }

            double u = (dot11 * dot02 - dot01 * dot12) * invDenom;
            double v = (dot00 * dot12 - dot01 * dot02) * invDenom;
            double w = 1.0f - u - v; // The third barycentric coordinate

            // Apply tolerance to barycentric coordinates
            // If u, v, w are all within [0-tolerance, 1+tolerance], the point is considered inside.
            // This makes the triangle slightly "fatter" at the edges/corners.
            bool isInside2D = (u >= -tolerance && u <= 1.0 + tolerance) &&
                              (v >= -tolerance && v <= 1.0 + tolerance) &&
                              (w >= -tolerance && w <= 1.0 + tolerance);

            return isInside2D;
        }

        /// <summary>
        /// Checks if any of the triangle's vertices contain NaN coordinates.
        /// </summary>
        /// <returns>True if any vertex is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return Point_1.IsNaN() || Point_2.IsNaN() || Point_3.IsNaN();
        }

        /// <summary>
        /// Determines whether a point lies on the triangle (inside if solid, or on boundary lines if not).
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>True if the point lies on the triangle; otherwise, false.</returns>
        public bool On(Coordinate3 point, double tolerance)
        {
            if (Solid.ToBool())
            {
                return Inside(point, tolerance);
            }
            else
            {
                if (GetLine(0).On(point, tolerance))
                {
                    return true;
                }

                if (GetLine(1).On(point, tolerance))
                {
                    return true;
                }

                if (GetLine(2).On(point, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns a string representation of the current triangle.
        /// </summary>
        /// <returns>A formatted string describing the triangle vertices.</returns>
        public override string ToString()
        {
            return string.Format("P1:{0};P2:{1};P3:{2}", Point_1, Point_2, Point_3);
        }
    }
}