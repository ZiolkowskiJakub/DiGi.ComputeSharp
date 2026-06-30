using DiGi.ComputeSharp.Planar.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace DiGi.ComputeSharp.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional coordinate or vector in a planar system.
    /// </summary>
    public readonly unsafe struct Coordinate2 : IGeometry2
    {
        /// <summary>
        /// The X-coordinate of the point or the X-component of the vector.
        /// </summary>
        public readonly double X;

        /// <summary>
        /// The Y-coordinate of the point or the Y-component of the vector.
        /// </summary>
        public readonly double Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2"/> struct with NaN values.
        /// </summary>
        public Coordinate2()
        {
            X = double.NaN;
            Y = double.NaN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2"/> struct with specified X and Y coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate.</param>
        /// <param name="y">The Y-coordinate.</param>
        public Coordinate2(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2"/> struct by copying an existing coordinate.
        /// </summary>
        /// <param name="coordinate">The source coordinate to copy.</param>
        public Coordinate2(Coordinate2 coordinate)
        {
            X = coordinate.X;
            Y = coordinate.Y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2"/> struct as a vector representing the difference between two points.
        /// </summary>
        /// <param name="start">The starting point.</param>
        /// <param name="end">The ending point.</param>
        public Coordinate2(Coordinate2 start, Coordinate2 end)
        {
            X = end.X - start.X;
            Y = end.Y - start.Y;
        }

        /// <summary>
        /// Performs vector addition of this coordinate and another coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to add.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the sum.</returns>
        public Coordinate2 Add(Coordinate2 coordinate)
        {
            return new Coordinate2(X + coordinate.X, Y + coordinate.Y);
        }

        /// <summary>
        /// Determines whether this coordinate is approximately equal to another coordinate within a specified tolerance.
        /// </summary>
        /// <param name="coordinate">The coordinate to compare.</param>
        /// <param name="tolerance">The maximum allowed difference between coordinates.</param>
        /// <returns>True if the coordinates are within the tolerance; otherwise, false.</returns>
        public bool AlmostEquals(Coordinate2 coordinate, double tolerance)
        {
            bool isNaN_1 = IsNaN();
            bool isNaN_2 = coordinate.IsNaN();

            if (isNaN_1 && isNaN_2)
            {
                return true;
            }

            if (isNaN_1 || isNaN_2)
            {
                return false;
            }

            double dx = X - coordinate.X;
            if (dx < -tolerance || dx > tolerance)
            {
                return false;
            }

            double dy = Y - coordinate.Y;
            if (dy < -tolerance || dy > tolerance)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calculates the 2D cross product of this vector and another vector.
        /// </summary>
        /// <param name="vector">The other vector.</param>
        /// <returns>The scalar result of the 2D cross product.</returns>
        public double CrossProduct(Coordinate2 vector)
        {
            return X * vector.Y - Y * vector.X;
        }

        /// <summary>
        /// Performs component-wise division of this coordinate by another coordinate.
        /// </summary>
        /// <param name="coordinate">The divisor coordinate.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the result of the division.</returns>
        public Coordinate2 Divide(Coordinate2 coordinate)
        {
            return new Coordinate2(X / coordinate.X, Y / coordinate.Y);
        }

        /// <summary>
        /// Divides this coordinate by a scalar factor.
        /// </summary>
        /// <param name="factor">The divisor value.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the result of the division.</returns>
        public Coordinate2 Divide(double factor)
        {
            return new Coordinate2(X / factor, Y / factor);
        }

        /// <summary>
        /// Calculates the dot product of this vector and another vector.
        /// </summary>
        /// <param name="vector">The other vector.</param>
        /// <returns>The scalar result of the dot product.</returns>
        public double DotProduct(Coordinate2 vector)
        {
            return X * vector.X + Y * vector.Y;
        }

        /// <summary>
        /// Determines whether this coordinate is equal to another coordinate based on exact values.
        /// </summary>
        /// <param name="coordinate">The coordinate to compare.</param>
        /// <returns>True if the coordinates are identical or both are NaN; otherwise, false.</returns>
        public bool Equals(Coordinate2 coordinate)
        {
            bool isNaN_1 = IsNaN();
            bool isNaN_2 = coordinate.IsNaN();

            if (isNaN_1 && isNaN_2)
            {
                return true;
            }

            if (isNaN_1 || isNaN_2)
            {
                return false;
            }

            return X - coordinate.X == 0 && Y - coordinate.Y == 0;
        }

        /// <summary>
        /// Determines whether this instance is equal to a specified object.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>True if the object is a <see cref="Coordinate2"/> and has identical values; otherwise, false.</returns>
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is Coordinate2 coordinate2)
            {
                return Equals(coordinate2);
            }

            return false;
        }

        /// <summary>
        /// Calculates an approximate distance between this point and another point using a fast approximation formula.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <returns>An approximated Euclidean distance.</returns>
        public double GetApproximateDistance(Coordinate2 point)
        {
            double dx = point.X - X;
            if (dx < 0)
            {
                dx = -dx;
            }

            double dy = point.Y - Y;
            if (dy < 0)
            {
                dy = -dy;
            }

            double max = dx;

            if (dy > max)
            {
                max = dy;
            }

            double min = dx;

            if (dy < min)
            {
                min = dy;
            }

            return 0.96043387f * max + 0.39782473f * min;
        }

        /// <summary>
        /// Calculates the approximate length of this vector from the origin (0,0).
        /// </summary>
        /// <returns>An approximated magnitude of the vector.</returns>
        public double GetApproximateLength()
        {
            return new Coordinate2(0, 0).GetApproximateDistance(this);
        }

        /// <summary>
        /// Calculates the centroid (midpoint) between this coordinate and the origin.
        /// </summary>
        /// <returns>A new <see cref="Coordinate2"/> representing the midpoint.</returns>
        public Coordinate2 GetCentroid()
        {
            return new Coordinate2(X / 2, Y / 2);
        }

        /// <summary>
        /// Calculates the centroid (midpoint) between this coordinate and another point.
        /// </summary>
        /// <param name="point">The other point.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the midpoint.</returns>
        public Coordinate2 GetCentroid(Coordinate2 point)
        {
            return new Coordinate2((X + point.X) / 2, (Y + point.Y) / 2);
        }

        /// <summary>
        /// Calculates the Euclidean distance between this coordinate and another point.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <param name="tolerance">Tolerance used for the square root calculation.</param>
        /// <returns>The distance between the two points.</returns>
        public double GetDistance(Coordinate2 point, double tolerance)
        {
            return new Coordinate2(this, point).GetLength(tolerance);
        }

        /// <summary>
        /// Returns a coordinate with inverted X and Y values.
        /// </summary>
        /// <returns>A new <see cref="Coordinate2"/> representing the inverse vector.</returns>
        public Coordinate2 GetInversed()
        {
            return new Coordinate2(-X, -Y);
        }

        /// <summary>
        /// Calculates the magnitude (length) of this vector.
        /// </summary>
        /// <param name="tolerance">Tolerance used for the square root calculation.</param>
        /// <returns>The length of the vector.</returns>
        public double GetLength(double tolerance)
        {
            return Core.Query.Sqrt(GetSquaredLength(), tolerance);
        }

        /// <summary>
        /// Translates this coordinate by a given vector.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the moved position.</returns>
        public Coordinate2 GetMoved(Coordinate2 vector)
        {
            return Add(vector);
        }

        /// <summary>
        /// Returns a unit vector in the same direction as this coordinate.
        /// </summary>
        /// <param name="tolerance">Tolerance used for length calculation.</param>
        /// <returns>A normalized <see cref="Coordinate2"/> with a magnitude of 1.</returns>
        public Coordinate2 GetNormalized(double tolerance)
        {
            double length = GetLength(tolerance);

            return new Coordinate2(X / length, Y / length);
        }

        /// <summary>
        /// Calculates the squared Euclidean distance between this coordinate and another.
        /// </summary>
        /// <param name="coordinate">The target coordinate.</param>
        /// <returns>The squared distance value.</returns>
        public double GetSquaredDistance(Coordinate2 coordinate)
        {
            double dx = coordinate.X - X;
            double dy = coordinate.Y - Y;

            return (dx * dx) + (dy * dy);
        }

        /// <summary>
        /// Calculates the squared length of the coordinate vector (X*X + Y*Y).
        /// </summary>
        /// <returns>The sum of the squares of the X and Y components.</returns>
        public double GetSquaredLength()
        {
            return X * X + Y * Y;
        }

        /// <summary>
        /// Checks if this point is within the bounding box of the specified triangle expanded by a tolerance.
        /// </summary>
        /// <param name="triangle">The triangle to check against.</param>
        /// <param name="tolerance">The distance used to expand the bounding box.</param>
        /// <returns>True if the point is within the expanded bounding box; otherwise, false.</returns>
        public bool InRange(Triangle2 triangle, double tolerance)
        {
            if (IsNaN() || triangle.IsNaN())
            {
                return false;
            }

            Coordinate2 min = triangle.GetMin();
            Coordinate2 max = triangle.GetMax();

            return X - tolerance <= max.X && X + tolerance >= min.X &&
                Y - tolerance <= max.Y && Y + tolerance >= min.Y;
        }

        /// <summary>
        /// Checks if this point is within the range of the specified line's bounding box expanded by a tolerance.
        /// </summary>
        /// <param name="line">The line to check against.</param>
        /// <param name="tolerance">The distance used to expand the bounding box.</param>
        /// <returns>True if the point is within the expanded bounding box; otherwise, false.</returns>
        public bool InRange(Line2 line, double tolerance)
        {
            if (line.IsNaN())
            {
                return false;
            }

            if (!line.Bounded.ToBool())
            {
                return true;
            }

            if (IsNaN())
            {
                return false;
            }

            Coordinate2 min = line.GetMin();
            Coordinate2 max = line.GetMax();

            return X - tolerance <= max.X && X + tolerance >= min.X &&
                Y - tolerance <= max.Y && Y + tolerance >= min.Y;
        }

        /// <summary>
        /// Determines whether either the X or Y component of this coordinate is Not-a-Number (NaN).
        /// </summary>
        /// <returns>True if X or Y is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return !(X + 1 > X && Y + 1 > Y);
        }

        /// <summary>
        /// Performs a component-wise multiplication of this coordinate with another coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to multiply by.</param>
        /// <returns>A new <see cref="Coordinate2"/> resulting from the component-wise multiplication.</returns>
        public Coordinate2 Multiply(Coordinate2 coordinate)
        {
            return new Coordinate2(X * coordinate.X, Y * coordinate.Y);
        }

        /// <summary>
        /// Performs scalar multiplication of this coordinate by a specified factor.
        /// </summary>
        /// <param name="factor">The scalar value to multiply by.</param>
        /// <returns>A new <see cref="Coordinate2"/> resulting from the scalar multiplication.</returns>
        public Coordinate2 Multiply(double factor)
        {
            return new Coordinate2(X * factor, Y * factor);
        }

        /// <summary>
        /// Projects the specified coordinate onto this vector.
        /// </summary>
        /// <param name="coordinate">The coordinate to project.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the projection of the given coordinate onto this vector.</returns>
        public Coordinate2 Project(Coordinate2 coordinate)
        {
            double squaredLength = GetSquaredLength();

            double scalarProjection = coordinate.DotProduct(this) / squaredLength;

            return Multiply(scalarProjection);
        }

        /// <summary>
        /// Subtracts another coordinate from this coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to subtract.</param>
        /// <returns>A new <see cref="Coordinate2"/> representing the result of the subtraction.</returns>
        public Coordinate2 Substract(Coordinate2 coordinate)
        {
            return new Coordinate2(X - coordinate.X, Y - coordinate.Y);
        }

        /// <summary>
        /// Returns a string representation of the current coordinate.
        /// </summary>
        /// <returns>A formatted string containing the X and Y components.</returns>
        public override string ToString()
        {
            return string.Format("[X:{0};Y:{1}]", X, Y);
        }

        /// <summary>
        /// Returns a hash code for the current coordinate.
        /// </summary>
        /// <returns>An integer hash code representing the coordinate's value.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /// <summary>
        /// Determines whether two <see cref="Coordinate2"/> objects are equal.
        /// </summary>
        /// <param name="left">The first coordinate to compare.</param>
        /// <param name="right">The second coordinate to compare.</param>
        /// <returns>True if the coordinates are equal; otherwise, false.</returns>
        public static bool operator ==(Coordinate2 left, Coordinate2 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two <see cref="Coordinate2"/> objects are not equal.
        /// </summary>
        /// <param name="left">The first coordinate to compare.</param>
        /// <param name="right">The second coordinate to compare.</param>
        /// <returns>True if the coordinates are not equal; otherwise, false.</returns>
        public static bool operator !=(Coordinate2 left, Coordinate2 right)
        {
            return !(left == right);
        }
    }
}