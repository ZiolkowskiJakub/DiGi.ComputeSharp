using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Planar.Interfaces;

namespace DiGi.ComputeSharp.Planar.Classes
{
    /// <summary>
    /// Represents a 2D line segment or an infinite line in a planar coordinate system.
    /// </summary>
    public readonly struct Line2 : IGeometry2
    {
        /// <summary>
        /// Indicates whether the line is bounded (a segment) or unbounded (an infinite line).
        /// </summary>
        public readonly Bool Bounded;

        /// <summary>
        /// The end coordinate of the line.
        /// </summary>
        public readonly Coordinate2 End;

        /// <summary>
        /// The start coordinate of the line.
        /// </summary>
        public readonly Coordinate2 Start;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2"/> struct with default NaN values and unbounded flag.
        /// </summary>
        public Line2()
        {
            Bounded = new Bool(false);
            End = new Coordinate2();
            Start = new Coordinate2();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2"/> struct as a bounded line using specific coordinates.
        /// </summary>
        /// <param name="x_1">The X coordinate of the first point.</param>
        /// <param name="y_1">The Y coordinate of the first point.</param>
        /// <param name="x_2">The X coordinate of the second point.</param>
        /// <param name="y_2">The Y coordinate of the second point.</param>
        public Line2(double x_1, double y_1, double x_2, double y_2)
        {
            Bounded = new Bool(true);
            End = new Coordinate2(x_1, y_1);
            Start = new Coordinate2(x_2, y_2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2"/> struct with specified boundedness and coordinates.
        /// </summary>
        /// <param name="bounded">Whether the line is bounded.</param>
        /// <param name="x_1">The X coordinate of the first point.</param>
        /// <param name="y_1">The Y coordinate of the first point.</param>
        /// <param name="x_2">The X coordinate of the second point.</param>
        /// <param name="y_2">The Y coordinate of the second point.</param>
        public Line2(Bool bounded, double x_1, double y_1, double x_2, double y_2)
        {
            Bounded = bounded;
            End = new Coordinate2(x_1, y_1);
            Start = new Coordinate2(x_2, y_2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2"/> struct as a bounded line using start and end coordinates.
        /// </summary>
        /// <param name="start">The starting coordinate.</param>
        /// <param name="end">The ending coordinate.</param>
        public Line2(Coordinate2 start, Coordinate2 end)
        {
            Bounded = new Bool(true);
            Start = start;
            End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2"/> struct with specified boundedness and coordinate objects.
        /// </summary>
        /// <param name="bounded">Whether the line is bounded.</param>
        /// <param name="start">The starting coordinate.</param>
        /// <param name="end">The ending coordinate.</param>
        public Line2(Bool bounded, Coordinate2 start, Coordinate2 end)
        {
            Bounded = bounded;
            Start = start;
            End = end;
        }

        /// <summary>
        /// Calculates the approximate distance from a given point to the line.
        /// </summary>
        /// <param name="point">The point to measure distance from.</param>
        /// <returns>The approximate distance as a double.</returns>
        public double GetApproximateDistance(Coordinate2 point) { return GetClosestPoint(point).GetApproximateDistance(point); }

        /// <summary>
        /// Calculates the approximate length of the line.
        /// </summary>
        /// <returns>The distance between start and end, or positive infinity if the line is unbounded.</returns>
        public double GetApproximateLength() { if (Bounded.ToBool()) { return double.PositiveInfinity; } return Start.GetApproximateDistance(End); }

        /// <summary>
        /// Calculates the centroid of the line.
        /// </summary>
        /// <returns>The coordinate representing the center point of the line.</returns>
        public Coordinate2 GetCentroid() { return Start.Add(GetVector().GetCentroid()); }

        /// <summary>
        /// Finds the closest point on the line to a specified target point.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <returns>The coordinate on the line closest to the provided point.</returns>
        public Coordinate2 GetClosestPoint(Coordinate2 point) { Coordinate2 lineVector = GetVector(); Coordinate2 pointToLineVector = point.Substract(Start); double lengthSquared = lineVector.GetSquaredLength(); if (lengthSquared == 0.0) { return Start; } double t = pointToLineVector.DotProduct(lineVector) / lengthSquared; if (true) { if (t > 1.0f) { t = 1.0f; } if (t < 0.0f) { t = 0.0f; } } return Start.Add(lineVector.Multiply(t)); }

        /// <summary>
        /// Gets the normalized direction vector of the line.
        /// </summary>
        /// <param name="tolerance">The tolerance used for normalization.</param>
        /// <returns>A normalized coordinate representing the direction.</returns>
        public Coordinate2 GetDirection(double tolerance) { return new Coordinate2(Start, End).GetNormalized(tolerance); }

        /// <summary>
        /// Creates a new line that is the inverse of the current line (swapping start and end points).
        /// </summary>
        /// <returns>A new <see cref="Line2"/> instance with inverted coordinates.</returns>
        public Line2 GetInversed() { return new Line2(Bounded, End, Start); }

        /// <summary>
        /// Gets the maximum coordinate (top-right corner) of the line's axis-aligned bounding box.
        /// </summary>
        /// <returns>The maximum X and Y coordinates as a <see cref="Coordinate2"/>.</returns>
        public Coordinate2 GetMax() { double x = Start.X; if (x < End.X) { x = End.X; } double y = Start.Y; if (y < End.Y) { y = End.Y; } return new Coordinate2(x, y); }

        /// <summary>
        /// Gets the minimum coordinate (bottom-left corner) of the line's axis-aligned bounding box.
        /// </summary>
        /// <returns>The minimum X and Y coordinates as a <see cref="Coordinate2"/>.</returns>
        public Coordinate2 GetMin() { double x = Start.X; if (x > End.X) { x = End.X; } double y = Start.Y; if (y > End.Y) { y = End.Y; } return new Coordinate2(x, y); }

        /// <summary>
        /// Moves the line by a specified translation vector.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>A new <see cref="Line2"/> instance shifted by the provided vector.</returns>
        public Line2 GetMoved(Coordinate2 vector) { return new Line2(Bounded, End.GetMoved(vector), Start.GetMoved(vector)); }

        /// <summary>
        /// Calculates the squared distance from a given point to the closest point on the line.
        /// </summary>
        /// <param name="point">The point to measure distance from.</param>
        /// <returns>The squared distance as a double.</returns>
        public double GetSquaredDistance(Coordinate2 point) { return GetClosestPoint(point).GetSquaredDistance(point); }

        /// <summary>
        /// Calculates the squared length of the line.
        /// </summary>
        /// <returns>The squared distance between start and end, or positive infinity if the line is unbounded.</returns>
        public double GetSquaredLength() { if (Bounded.ToBool()) { return double.PositiveInfinity; } return Start.GetSquaredDistance(End); }

        /// <summary>
        /// Calculates the actual length of the line using a specified tolerance for the square root operation.
        /// </summary>
        /// <param name="tolerance">The precision tolerance.</param>
        /// <returns>The length of the line as a double.</returns>
        public double GetLength(double tolerance) { double squaredLength = GetSquaredLength(); if (!Core.Query.IsValid(squaredLength)) { return squaredLength; } return Core.Query.Sqrt(squaredLength, tolerance); }

        /// <summary>
        /// Gets the vector representing the direction and magnitude from the start to the end of the line.
        /// </summary>
        /// <returns>A <see cref="Coordinate2"/> representing the direction and magnitude of the line.</returns>
        public Coordinate2 GetVector() { return new Coordinate2(Start, End); }

        /// <summary>
        /// Determines whether this line's bounding box overlaps with another line's bounding box within a given tolerance.
        /// </summary>
        /// <param name="line">The other line to check.</param>
        /// <param name="tolerance">The overlap tolerance.</param>
        /// <returns>True if the lines are in range; otherwise, false.</returns>
        public bool InRange(Line2 line, double tolerance) { if (IsNaN() || line.IsNaN()) { return false; } if (!Bounded.ToBool() || !line.Bounded.ToBool()) { return true; } Coordinate2 minA = GetMin(); Coordinate2 maxA = GetMax(); Coordinate2 minB = line.GetMin(); Coordinate2 maxB = line.GetMax(); return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) && (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y); }

        /// <summary>
        /// Determines whether a given point is within the range of this line's bounding box.
        /// </summary>
        /// <param name="point">The point to check.</param>
        /// <param name="tolerance">The overlap tolerance.</param>
        /// <returns>True if the point is in range; otherwise, false.</returns>
        public bool InRange(Coordinate2 point, double tolerance) { return point.InRange(this, tolerance); }

        /// <summary>
        /// Determines whether this line's bounding box overlaps with a triangle's bounding box within a given tolerance.
        /// </summary>
        /// <param name="triangle">The triangle to check.</param>
        /// <param name="tolerance">The overlap tolerance.</param>
        /// <returns>True if the line and triangle are in range; otherwise, false.</returns>
        public bool InRange(Triangle2 triangle, double tolerance) { if (IsNaN() || triangle.IsNaN()) { return false; } if (!Bounded.ToBool()) { return true; } Coordinate2 minA = GetMin(); Coordinate2 maxA = GetMax(); Coordinate2 minB = triangle.GetMin(); Coordinate2 maxB = triangle.GetMax(); return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) && (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y); }

        /// <summary>
        /// Checks if either the start or end coordinates of the line are Not-a-Number (NaN).
        /// </summary>
        /// <returns>True if any coordinate is NaN; otherwise, false.</returns>
        public bool IsNaN() { return Start.IsNaN() || End.IsNaN(); }

        /// <summary>
        /// Determines whether a point lies on the line within a specified squared distance tolerance.
        /// </summary>
        /// <param name="point">The point to check.</param>
        /// <param name="tolerance">The squared distance tolerance.</param>
        /// <returns>True if the point is on the line; otherwise, false.</returns>
        public bool On(Coordinate2 point, double tolerance) { return GetSquaredDistance(point) <= tolerance; }

        /// <summary>
        /// Projects a given point onto the line, returning the closest point on the line.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <returns>The closest <see cref="Coordinate2"/> on this line to the given point.</returns>
        public Coordinate2 Project(Coordinate2 point) { return GetClosestPoint(point); }

        /// <summary>
        /// Projects another line onto this line by finding the closest points for the start and end of the given line.
        /// </summary>
        /// <param name="line">The line to project onto this line.</param>
        /// <returns>A new <see cref="Line2"/> representing the projected line, or a default <see cref="Line2"/> if the projection collapses to a point.</returns>
        public Line2 Project(Line2 line) { Coordinate2 start = GetClosestPoint(line.Start); Coordinate2 end = GetClosestPoint(line.Start); if (start.Equals(end)) { return new Line2(); } return new Line2(line.Bounded, GetClosestPoint(line.Start), GetClosestPoint(line.End)); }

        /// <summary>
        /// Returns a string representation of the line showing start and end coordinates.
        /// </summary>
        /// <returns>A formatted string containing the start and end coordinates.</returns>
        public override string ToString() { return string.Format("S:{0};E:{1}", Start, End); }
    }
}