using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Planar.Interfaces;

namespace DiGi.ComputeSharp.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional triangle in a planar coordinate system.
    /// </summary>
    public readonly struct Triangle2 : IGeometry2
    {
        /// <summary>
        /// The first vertex of the triangle.
        /// </summary>
        public readonly Coordinate2 Point_1;

        /// <summary>
        /// The second vertex of the triangle.
        /// </summary>
        public readonly Coordinate2 Point_2;

        /// <summary>
        /// The third vertex of the triangle.
        /// </summary>
        public readonly Coordinate2 Point_3;

        /// <summary>
        /// A value indicating whether the triangle is solid (filled) or boundary-only.
        /// </summary>
        public readonly Bool Solid;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2"/> struct with default values (NaN coordinates and not solid).
        /// </summary>
        public Triangle2()
        {
            Solid = new Bool(false);
            Point_1 = new Coordinate2();
            Point_2 = new Coordinate2();
            Point_3 = new Coordinate2();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle2"/> struct with the specified solid state and vertices.
        /// </summary>
        /// <param name="solid">A value indicating whether the triangle is solid.</param>
        /// <param name="point_1">The first vertex.</param>
        /// <param name="point_2">The second vertex.</param>
        /// <param name="point_3">The third vertex.</param>
        public Triangle2(Bool solid, Coordinate2 point_1, Coordinate2 point_2, Coordinate2 point_3)
        {
            Solid = solid;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
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
        /// Calculates the perimeter of the triangle with the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The tolerance used for distance calculations.</param>
        /// <returns>The perimeter of the triangle.</returns>
        public double GetPerimeter(double tolerance)
        {
            return Point_1.GetDistance(Point_2, tolerance) + Point_2.GetDistance(Point_3, tolerance) + Point_3.GetDistance(Point_1, tolerance);
        }

        /// <summary>
        /// Calculates the signed area of the triangle.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double GetArea()
        {
            double result = 0.5f * ((Point_2.X - Point_1.X) * (Point_3.Y - Point_1.Y) - (Point_2.Y - Point_1.Y) * (Point_3.X - Point_1.X));

            if (result < 0)
            {
                result = -result;
            }

            return result;
        }

        /// <summary>
        /// Gets the centroid (geometric center) of the triangle.
        /// </summary>
        /// <returns>A <see cref="Coordinate2"/> representing the centroid of the triangle.</returns>
        public Coordinate2 GetCentroid()
        {
            double centroidX = (Point_1.X + Point_2.X + Point_3.X) / 3.0f;
            double centroidY = (Point_1.Y + Point_2.Y + Point_3.Y) / 3.0f;

            return new Coordinate2(centroidX, centroidY);
        }

        /// <summary>
        /// Gets a new triangle with inverted vertex order (reversing winding direction).
        /// </summary>
        /// <returns>An inverted <see cref="Triangle2"/>.</returns>
        public Triangle2 GetInversed()
        {
            return new Triangle2(Solid, Point_3, Point_2, Point_1);
        }

        /// <summary>
        /// Gets one of the boundary lines of the triangle by index.
        /// </summary>
        /// <param name="index">The line index (0, 1, or 2).</param>
        /// <returns>The boundary <see cref="Line2"/> at the specified index.</returns>
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

        /// <summary>
        /// Gets all boundary lines of the triangle.
        /// </summary>
        /// <returns>An array of three <see cref="Line2"/> objects representing the boundary lines.</returns>
        public Line2[] GetLines()
        {
            return [GetLine(0), GetLine(1), GetLine(2)];
        }

        /// <summary>
        /// Gets the maximum coordinate bounds of the triangle.
        /// </summary>
        /// <returns>A <see cref="Coordinate2"/> representing the maximum X and Y coordinates.</returns>
        public Coordinate2 GetMax()
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

            return new Coordinate2(x, y);
        }

        /// <summary>
        /// Gets the minimum coordinate bounds of the triangle.
        /// </summary>
        /// <returns>A <see cref="Coordinate2"/> representing the minimum X and Y coordinates.</returns>
        public Coordinate2 GetMin()
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

            return new Coordinate2(x, y);
        }

        /// <summary>
        /// Translates the triangle by the specified offset vector.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>A translated <see cref="Triangle2"/>.</returns>
        public Triangle2 GetMoved(Coordinate2 vector)
        {
            return new Triangle2(Solid, Point_1.GetMoved(vector), Point_2.GetMoved(vector), Point_3.GetMoved(vector));
        }

        /// <summary>
        /// Checks if a point is within the bounding range of the triangle.
        /// </summary>
        /// <param name="point">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is within range; otherwise, false.</returns>
        public bool InRange(Coordinate2 point, double tolerance)
        {
            return point.InRange(this, tolerance);
        }

        /// <summary>
        /// Checks if a line is within the bounding range of the triangle.
        /// </summary>
        /// <param name="line">The line to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the line is within range; otherwise, false.</returns>
        public bool InRange(Line2 line, double tolerance)
        {
            return line.InRange(this, tolerance);
        }

        /// <summary>
        /// Checks if another triangle is within the bounding range of this triangle.
        /// </summary>
        /// <param name="triangle">The other triangle to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the triangles' bounding boxes overlap; otherwise, false.</returns>
        public bool InRange(Triangle2 triangle, double tolerance)
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

        /// <summary>
        /// Determines whether a point lies inside the triangle using barycentric coordinates.
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <param name="tolerance">The numerical tolerance value.</param>
        /// <returns>True if the point lies inside or on the boundary of the triangle; otherwise, false.</returns>
        public bool Inside(Coordinate2 point, double tolerance)
        {
            if (IsNaN() || point.IsNaN())
            {
                return false;
            }

            Coordinate2 ab = Point_2.Substract(Point_1);
            Coordinate2 ac = Point_3.Substract(Point_1);
            Coordinate2 ap = point.Substract(Point_1);

            double dot00 = ab.DotProduct(ab);
            double dot01 = ab.DotProduct(ac);
            double dot02 = ab.DotProduct(ap);
            double dot11 = ac.DotProduct(ac);
            double dot12 = ac.DotProduct(ap);

            // |ab|^2 |ac|^2 - (ab.ac)^2 == (2 * area)^2; zero for a degenerate (collinear) triangle.
            double denominator = (dot00 * dot11) - (dot01 * dot01);
            if (!Core.Query.IsValid(denominator) || (denominator > -tolerance && denominator < tolerance))
            {
                return false;
            }

            double u = ((dot11 * dot02) - (dot01 * dot12)) / denominator;
            double v = ((dot00 * dot12) - (dot01 * dot02)) / denominator;
            double w = 1.0 - u - v;

            return u >= -tolerance && u <= 1.0 + tolerance &&
                   v >= -tolerance && v <= 1.0 + tolerance &&
                   w >= -tolerance && w <= 1.0 + tolerance;
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
        public bool On(Coordinate2 point, double tolerance)
        {
            if (Solid.ToBool())
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