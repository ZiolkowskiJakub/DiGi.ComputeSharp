using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional line or line segment in a spatial coordinate system.
    /// </summary>
    public readonly struct Line3 : IGeometry3
    {
        /// <summary>
        /// A value indicating whether this line is bounded (representing a finite segment) or unbounded (an infinite line).
        /// </summary>
        public readonly Bool Bounded;

        /// <summary>
        /// The end point of the line segment.
        /// </summary>
        public readonly Coordinate3 End;

        /// <summary>
        /// The start point of the line segment.
        /// </summary>
        public readonly Coordinate3 Start;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3"/> struct with default values (NaN coordinates and not bounded).
        /// </summary>
        public Line3()
        {
            Bounded = new Bool(false);
            End = new Coordinate3();
            Start = new Coordinate3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3"/> struct as a bounded segment with specified start and end coordinates.
        /// </summary>
        /// <param name="x_1">The X component of the end point.</param>
        /// <param name="y_1">The Y component of the end point.</param>
        /// <param name="z_1">The Z component of the end point.</param>
        /// <param name="x_2">The X component of the start point.</param>
        /// <param name="y_2">The Y component of the start point.</param>
        /// <param name="z_2">The Z component of the start point.</param>
        public Line3(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
        {
            Bounded = new Bool(true);
            End = new Coordinate3(x_1, y_1, z_1);
            Start = new Coordinate3(x_2, y_2, z_2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3"/> struct with specified boundedness and coordinates.
        /// </summary>
        /// <param name="bounded">A value indicating whether the line is bounded.</param>
        /// <param name="x_1">The X component of the end point.</param>
        /// <param name="y_1">The Y component of the end point.</param>
        /// <param name="z_1">The Z component of the end point.</param>
        /// <param name="x_2">The X component of the start point.</param>
        /// <param name="y_2">The Y component of the start point.</param>
        /// <param name="z_2">The Z component of the start point.</param>
        public Line3(Bool bounded, double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
        {
            Bounded = bounded;
            End = new Coordinate3(x_1, y_1, z_1);
            Start = new Coordinate3(x_2, y_2, z_2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3"/> struct as a bounded segment between two points.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        public Line3(Coordinate3 start, Coordinate3 end)
        {
            Bounded = new Bool(true);
            Start = start;
            End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3"/> struct with specified boundedness between two points.
        /// </summary>
        /// <param name="bounded">A value indicating whether the line is bounded.</param>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        public Line3(Bool bounded, Coordinate3 start, Coordinate3 end)
        {
            Bounded = bounded;
            Start = start;
            End = end;
        }

        /// <summary>
        /// Calculates the approximate distance from a point to this line.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <returns>The approximate distance value.</returns>
        public double GetApproximateDistance(Coordinate3 point)
        {
            return GetClosestPoint(point).GetApproximateDistance(point);
        }

        /// <summary>
        /// Calculates the approximate length of this line.
        /// </summary>
        /// <returns>The approximate length of the segment, or positive infinity if the line is unbounded.</returns>
        public double GetApproximateLength()
        {
            if (!Bounded.ToBool())
            {
                return double.PositiveInfinity;
            }

            return Start.GetApproximateDistance(End);
        }

        /// <summary>
        /// Gets the centroid (midpoint) of the line segment.
        /// </summary>
        /// <returns>A <see cref="Coordinate3"/> representing the centroid.</returns>
        public Coordinate3 GetCentroid()
        {
            return Start.Add(GetVector().GetCentroid());
        }

        /// <summary>
        /// Finds the point on this line that is closest to the specified point.
        /// </summary>
        /// <param name="point">The point to project onto the line.</param>
        /// <returns>The closest <see cref="Coordinate3"/> on this line.</returns>
        public Coordinate3 GetClosestPoint(Coordinate3 point)
        {
            Coordinate3 lineVector = GetVector();
            Coordinate3 pointToLineVector = point.Substract(Start);

            double lengthSquared = lineVector.GetSquaredLength();
            if (lengthSquared == 0.0)
            {
                return Start;
            }

            double t = pointToLineVector.DotProduct(lineVector) / lengthSquared;

            if (Bounded.ToBool())
            {
                if (t > 1.0f)
                {
                    t = 1.0f;
                }

                if (t < 0.0f)
                {
                    t = 0.0f;
                }
            }

            return Start.Add(lineVector.Multiply(t));
        }

        /// <summary>
        /// Calculates the unit direction vector of this line.
        /// </summary>
        /// <param name="tolerance">The tolerance value used for length calculation.</param>
        /// <returns>The normalized direction <see cref="Coordinate3"/>.</returns>
        public Coordinate3 GetDirection(double tolerance)
        {
            return new Coordinate3(Start, End).GetNormalized(tolerance);
        }

        /// <summary>
        /// Calculates the distance from a point to this line with a specified tolerance.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <param name="tolerance">The tolerance value used for distance calculations.</param>
        /// <returns>The distance value.</returns>
        public double GetDistance(Coordinate3 point, double tolerance)
        {
            return GetClosestPoint(point).GetDistance(point, tolerance);
        }

        /// <summary>
        /// Returns a new line with reversed direction.
        /// </summary>
        /// <returns>A new <see cref="Line3"/> with start and end swapped.</returns>
        public Line3 GetInversed()
        {
            return new Line3(Bounded, End, Start);
        }

        /// <summary>
        /// Calculates the length of this line segment.
        /// </summary>
        /// <param name="tolerance">The tolerance value used for square root calculation.</param>
        /// <returns>The length of the line segment, or positive infinity if the line is unbounded.</returns>
        public double GetLength(double tolerance)
        {
            double squaredLength = GetSquaredLength();

            if (!Core.Query.IsValid(squaredLength))
            {
                return squaredLength;
            }

            return Core.Query.Sqrt(squaredLength, tolerance);
        }

        /// <summary>
        /// Gets the maximum coordinate bounds of the line segment.
        /// </summary>
        /// <returns>A <see cref="Coordinate3"/> representing the maximum coordinates.</returns>
        public Coordinate3 GetMax()
        {
            double x = Start.X;
            if (x < End.X)
            {
                x = End.X;
            }

            double y = Start.Y;
            if (y < End.Y)
            {
                y = End.Y;
            }

            double z = Start.Z;
            if (z < End.Z)
            {
                z = End.Z;
            }

            return new Coordinate3(x, y, z);
        }

        /// <summary>
        /// Gets the minimum coordinate bounds of the line segment.
        /// </summary>
        /// <returns>A <see cref="Coordinate3"/> representing the minimum coordinates.</returns>
        public Coordinate3 GetMin()
        {
            double x = Start.X;
            if (x > End.X)
            {
                x = End.X;
            }

            double y = Start.Y;
            if (y > End.Y)
            {
                y = End.Y;
            }

            double z = Start.Z;
            if (z > End.Z)
            {
                z = End.Z;
            }

            return new Coordinate3(x, y, z);
        }

        /// <summary>
        /// Translates the line by the specified offset vector.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>A translated <see cref="Line3"/>.</returns>
        public Line3 GetMoved(Coordinate3 vector)
        {
            return new Line3(Bounded, End.GetMoved(vector), Start.GetMoved(vector));
        }

        /// <summary>
        /// Calculates the squared distance from a point to this line.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <returns>The squared distance value.</returns>
        public double GetSquaredDistance(Coordinate3 point)
        {
            return GetClosestPoint(point).GetSquaredDistance(point);
        }

        /// <summary>
        /// Calculates the squared length of the line segment.
        /// </summary>
        /// <returns>The squared length, or positive infinity if the line is unbounded.</returns>
        public double GetSquaredLength()
        {
            if (!Bounded.ToBool())
            {
                return double.PositiveInfinity;
            }

            return Start.GetSquaredDistance(End);
        }

        /// <summary>
        /// Gets the vector representing this line (from start to end).
        /// </summary>
        /// <returns>A <see cref="Coordinate3"/> representing the line vector.</returns>
        public Coordinate3 GetVector()
        {
            return new Coordinate3(Start, End);
        }

        /// <summary>
        /// Checks if another line is within the bounding range of this line.
        /// </summary>
        /// <param name="line3">The other line to check.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>True if the lines' bounding boxes overlap; otherwise, false.</returns>
        public bool InRange(Line3 line3, double tolerance)
        {
            if (IsNaN() || line3.IsNaN())
            {
                return false;
            }

            if (!Bounded.ToBool() || !line3.Bounded.ToBool())
            {
                return true;
            }

            Coordinate3 minA = GetMin();
            Coordinate3 maxA = GetMax();
            Coordinate3 minB = line3.GetMin();
            Coordinate3 maxB = line3.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y) &&
                    (minA.Z - tolerance <= maxB.Z && maxA.Z + tolerance >= minB.Z);
        }

        /// <summary>
        /// Checks if a point is within the bounding range of the line.
        /// </summary>
        /// <param name="point">The point to check.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>True if the point is within range; otherwise, false.</returns>
        public bool InRange(Coordinate3 point, double tolerance)
        {
            return point.InRange(this, tolerance);
        }

        /// <summary>
        /// Checks if a triangle is within the bounding range of the line.
        /// </summary>
        /// <param name="triangle3">The triangle to check.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>True if the bounding boxes overlap; otherwise, false.</returns>
        public bool InRange(Triangle3 triangle3, double tolerance)
        {
            if (IsNaN() || triangle3.IsNaN())
            {
                return false;
            }

            if (!Bounded.ToBool())
            {
                return true;
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
        /// Checks if either start or end point of this line is NaN.
        /// </summary>
        /// <returns>True if any component is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return Start.IsNaN() || End.IsNaN();
        }

        /// <summary>
        /// Determines whether a point lies on the line within the specified tolerance.
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <param name="tolerance">The tolerance value.</param>
        /// <returns>True if the point lies on the line; otherwise, false.</returns>
        public bool On(Coordinate3 point, double tolerance)
        {
            return GetSquaredDistance(point) <= tolerance * tolerance;
        }

        /// <summary>
        /// Projects a point onto the line.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <returns>The projected <see cref="Coordinate3"/> on the line.</returns>
        public Coordinate3 Project(Coordinate3 point)
        {
            return GetClosestPoint(point);
        }

        /// <summary>
        /// Projects another line onto this line.
        /// </summary>
        /// <param name="line">The line to project.</param>
        /// <returns>A projected <see cref="Line3"/>, or a default line if the projection degenerates to a point.</returns>
        public Line3 Project(Line3 line)
        {
            Coordinate3 start = GetClosestPoint(line.Start);
            Coordinate3 end = GetClosestPoint(line.End);
            if (start.Equals(end))
            {
                return new Line3();
            }

            return new Line3(line.Bounded, start, end);
        }

        /// <summary>
        /// Returns a string representation of the current line.
        /// </summary>
        /// <returns>A formatted string containing the start and end coordinates.</returns>
        public override string ToString()
        {
            return string.Format("S:{0};E:{1}", Start, End);
        }
    }
}