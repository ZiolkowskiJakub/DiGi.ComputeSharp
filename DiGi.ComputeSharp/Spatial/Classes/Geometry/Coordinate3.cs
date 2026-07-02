using DiGi.ComputeSharp.Spatial.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional coordinate or vector in a spatial coordinate system.
    /// </summary>
    public readonly unsafe struct Coordinate3 : IGeometry3
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
        /// The Z-coordinate of the point or the Z-component of the vector.
        /// </summary>
        public readonly double Z;

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3"/> struct with NaN coordinates.
        /// </summary>
        public Coordinate3()
        {
            X = double.NaN;
            Y = double.NaN;
            Z = double.NaN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3"/> struct with the specified X, Y, and Z components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public Coordinate3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3"/> struct as a vector representing the difference between two sets of coordinates.
        /// </summary>
        /// <param name="x_1">The starting X component.</param>
        /// <param name="y_1">The starting Y component.</param>
        /// <param name="z_1">The starting Z component.</param>
        /// <param name="x_2">The ending X component.</param>
        /// <param name="y_2">The ending Y component.</param>
        /// <param name="z_2">The ending Z component.</param>
        public Coordinate3(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
        {
            X = x_2 - x_1;
            Y = y_2 - y_1;
            Z = z_2 - z_1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3"/> struct by copying an existing coordinate.
        /// </summary>
        /// <param name="coordinate">The source coordinate to copy.</param>
        public Coordinate3(Coordinate3 coordinate)
        {
            X = coordinate.X;
            Y = coordinate.Y;
            Z = coordinate.Z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3"/> struct as a vector representing the difference between two points.
        /// </summary>
        /// <param name="start">The starting point.</param>
        /// <param name="end">The ending point.</param>
        public Coordinate3(Coordinate3 start, Coordinate3 end)
        {
            X = end.X - start.X;
            Y = end.Y - start.Y;
            Z = end.Z - start.Z;
        }

        /// <summary>
        /// Performs vector addition of this coordinate and another coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to add.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the sum.</returns>
        public Coordinate3 Add(Coordinate3 coordinate)
        {
            return new Coordinate3(X + coordinate.X, Y + coordinate.Y, Z + coordinate.Z);
        }

        /// <summary>
        /// Determines whether this coordinate is approximately equal to another coordinate within a specified tolerance.
        /// </summary>
        /// <param name="coordinate">The coordinate to compare.</param>
        /// <param name="tolerance">The maximum allowed difference between components.</param>
        /// <returns>True if the coordinates are within the tolerance; otherwise, false.</returns>
        public bool AlmostEquals(Coordinate3 coordinate, double tolerance)
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

            double dz = Z - coordinate.Z;
            if (dz < -tolerance || dz > tolerance)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calculates the cross product of this vector and another vector.
        /// </summary>
        /// <param name="vector">The other vector.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the cross product vector.</returns>
        public Coordinate3 CrossProduct(Coordinate3 vector)
        {
            return new Coordinate3(
                Y * vector.Z - Z * vector.Y,
                Z * vector.X - X * vector.Z,
                X * vector.Y - Y * vector.X);
        }

        /// <summary>
        /// Performs component-wise division of this coordinate by another coordinate.
        /// </summary>
        /// <param name="coordinate">The divisor coordinate.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the component-wise quotient.</returns>
        public Coordinate3 Divide(Coordinate3 coordinate)
        {
            return new Coordinate3(X / coordinate.X, Y / coordinate.Y, Z / coordinate.Z);
        }

        /// <summary>
        /// Divides this coordinate by a scalar factor.
        /// </summary>
        /// <param name="factor">The divisor value.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the quotient.</returns>
        public Coordinate3 Divide(double factor)
        {
            return new Coordinate3(X / factor, Y / factor, Z / factor);
        }

        /// <summary>
        /// Calculates the dot product of this vector and another vector.
        /// </summary>
        /// <param name="vector">The other vector.</param>
        /// <returns>The scalar result of the dot product.</returns>
        public double DotProduct(Coordinate3 vector)
        {
            return X * vector.X + Y * vector.Y + Z * vector.Z;
        }

        /// <summary>
        /// Calculates the dot product of this vector and specified components.
        /// </summary>
        /// <param name="x">The X component of the other vector.</param>
        /// <param name="y">The Y component of the other vector.</param>
        /// <param name="z">The Z component of the other vector.</param>
        /// <returns>The scalar result of the dot product.</returns>
        public double DotProduct(double x, double y, double z)
        {
            return X * x + Y * y + Z * z;
        }

        /// <summary>
        /// Determines whether this coordinate is exactly equal to another coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to compare.</param>
        /// <returns>True if the coordinates are identical or both are NaN; otherwise, false.</returns>
        public bool Equals(Coordinate3 coordinate)
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

            return X - coordinate.X == 0 && Y - coordinate.Y == 0 && Z - coordinate.Z == 0;
        }

        /// <summary>
        /// Determines whether this coordinate is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>True if the object is a <see cref="Coordinate3"/> and has identical values; otherwise, false.</returns>
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is Coordinate3 coordinate3)
            {
                return Equals(coordinate3);
            }

            return false;
        }

        /// <summary>
        /// Calculates an approximate distance between this point and another point using a fast approximation formula.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <returns>An approximated Euclidean distance.</returns>
        public double GetApproximateDistance(Coordinate3 point)
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

            double dz = point.Z - Z;
            if (dz < 0)
            {
                dz = -dz;
            }

            double max = dx;

            if (dy > max)
            {
                max = dy;
            }

            if (dz > max)
            {
                max = dz;
            }

            double min = dx;

            if (dy < min)
            {
                min = dy;
            }

            if (dz < min)
            {
                min = dz;
            }

            double mid = dx + dy + dz - max - min;

            return 0.937562f * max + 0.392485f * mid + 0.286079f * min;
        }

        /// <summary>
        /// Calculates the approximate length of this vector from the origin (0,0,0).
        /// </summary>
        /// <returns>An approximated magnitude of the vector.</returns>
        public double GetApproximateLength()
        {
            return new Coordinate3(0, 0, 0).GetApproximateDistance(this);
        }

        /// <summary>
        /// Calculates the centroid (midpoint) between this coordinate and the origin.
        /// </summary>
        /// <returns>A new <see cref="Coordinate3"/> representing the midpoint.</returns>
        public Coordinate3 GetCentroid()
        {
            return new Coordinate3(X / 2, Y / 2, Z / 2);
        }

        /// <summary>
        /// Calculates the centroid (midpoint) between this coordinate and another point.
        /// </summary>
        /// <param name="point">The other point.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the midpoint.</returns>
        public Coordinate3 GetCentroid(Coordinate3 point)
        {
            return new Coordinate3((X + point.X) / 2, (Y + point.Y) / 2, (Z + point.Z) / 2);
        }

        /// <summary>
        /// Calculates the Euclidean distance between this coordinate and another point.
        /// </summary>
        /// <param name="point">The target point.</param>
        /// <param name="tolerance">Tolerance used for square root calculation.</param>
        /// <returns>The distance value.</returns>
        public double GetDistance(Coordinate3 point, double tolerance)
        {
            return new Coordinate3(X, Y, Z, point.X, point.Y, point.Z).GetLength(tolerance);
        }

        /// <summary>
        /// Returns a coordinate with inverted X, Y, and Z values.
        /// </summary>
        /// <returns>A new <see cref="Coordinate3"/> representing the inverted vector.</returns>
        public Coordinate3 GetInversed()
        {
            return new Coordinate3(-X, -Y, -Z);
        }

        /// <summary>
        /// Calculates the magnitude (length) of this vector.
        /// </summary>
        /// <param name="tolerance">Tolerance used for square root calculation.</param>
        /// <returns>The length value.</returns>
        public double GetLength(double tolerance)
        {
            return Core.Query.Sqrt(GetSquaredLength(), tolerance);
        }

        /// <summary>
        /// Translates this coordinate by a given vector.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the moved position.</returns>
        public Coordinate3 GetMoved(Coordinate3 vector)
        {
            return Add(vector);
        }

        /// <summary>
        /// Returns a unit vector in the same direction as this coordinate.
        /// </summary>
        /// <param name="tolerance">Tolerance used for length calculation.</param>
        /// <returns>A normalized <see cref="Coordinate3"/> with a magnitude of 1.</returns>
        public Coordinate3 GetNormalized(double tolerance)
        {
            double length = GetLength(tolerance);

            return new Coordinate3(X / length, Y / length, Z / length);
        }

        /// <summary>
        /// Calculates the squared Euclidean distance between this coordinate and another.
        /// </summary>
        /// <param name="coordinate">The target coordinate.</param>
        /// <returns>The squared distance value.</returns>
        public double GetSquaredDistance(Coordinate3 coordinate)
        {
            double dx = coordinate.X - X;
            double dy = coordinate.Y - Y;
            double dz = coordinate.Z - Z;

            return (dx * dx) + (dy * dy) + (dz * dz);
        }

        /// <summary>
        /// Calculates the squared length of the coordinate vector (X*X + Y*Y + Z*Z).
        /// </summary>
        /// <returns>The sum of the squares of the components.</returns>
        public double GetSquaredLength()
        {
            return X * X + Y * Y + Z * Z;
        }

        /// <summary>
        /// Checks if this point is within the range of the specified triangle's bounding box expanded by a tolerance.
        /// </summary>
        /// <param name="triangle">The triangle to check against.</param>
        /// <param name="tolerance">The distance tolerance used to expand the bounding box.</param>
        /// <returns>True if the point is within range; otherwise, false.</returns>
        public bool InRange(Triangle3 triangle, double tolerance)
        {
            if (IsNaN())
            {
                return false;
            }

            return triangle.InRange(X, Y, Z, tolerance);
        }

        /// <summary>
        /// Checks if this point is within the range of the specified line's bounding box expanded by a tolerance.
        /// </summary>
        /// <param name="line">The line to check against.</param>
        /// <param name="tolerance">The distance tolerance used to expand the bounding box.</param>
        /// <returns>True if the point is within range; otherwise, false.</returns>
        public bool InRange(Line3 line, double tolerance)
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

            Coordinate3 min = line.GetMin();
            Coordinate3 max = line.GetMax();

            return X - tolerance <= max.X && X + tolerance >= min.X &&
                Y - tolerance <= max.Y && Y + tolerance >= min.Y &&
                Z - tolerance <= max.Z && Z + tolerance >= min.Z;
        }

        /// <summary>
        /// Determines whether any component of this coordinate is Not-a-Number (NaN).
        /// </summary>
        /// <returns>True if X, Y, or Z is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return !(X + 1 > X && Y + 1 > Y && Z + 1 > Z);
        }

        /// <summary>
        /// Performs component-wise multiplication of this coordinate with another coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to multiply by.</param>
        /// <returns>A new <see cref="Coordinate3"/> resulting from the component-wise multiplication.</returns>
        public Coordinate3 Multiply(Coordinate3 coordinate)
        {
            return new Coordinate3(X * coordinate.X, Y * coordinate.Y, Z * coordinate.Z);
        }

        /// <summary>
        /// Performs scalar multiplication of this coordinate by a specified factor.
        /// </summary>
        /// <param name="factor">The scalar value to multiply by.</param>
        /// <returns>A new <see cref="Coordinate3"/> resulting from the scalar multiplication.</returns>
        public Coordinate3 Multiply(double factor)
        {
            return new Coordinate3(X * factor, Y * factor, Z * factor);
        }

        /// <summary>
        /// Projects the specified coordinate onto this vector.
        /// </summary>
        /// <param name="coordinate">The coordinate to project.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the projection of the coordinate onto this vector.</returns>
        public Coordinate3 Project(Coordinate3 coordinate)
        {
            double squaredLength = GetSquaredLength();

            double scalarProjection = coordinate.DotProduct(X, Y, Z) / squaredLength;

            return Multiply(scalarProjection);
        }

        /// <summary>
        /// Subtracts another coordinate from this coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to subtract.</param>
        /// <returns>A new <see cref="Coordinate3"/> representing the result of the subtraction.</returns>
        public Coordinate3 Substract(Coordinate3 coordinate)
        {
            return new Coordinate3(X - coordinate.X, Y - coordinate.Y, Z - coordinate.Z);
        }

        /// <summary>
        /// Returns a string representation of the current coordinate.
        /// </summary>
        /// <returns>A formatted string containing the X, Y, and Z components.</returns>
        public override string ToString()
        {
            return string.Format("[X:{0};Y:{1};Z:{2}]", X, Y, Z);
        }

        /// <summary>
        /// Returns a hash code for the current coordinate.
        /// </summary>
        /// <returns>An integer hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        /// <summary>
        /// Determines whether two <see cref="Coordinate3"/> objects are equal.
        /// </summary>
        /// <param name="left">The first coordinate to compare.</param>
        /// <param name="right">The second coordinate to compare.</param>
        /// <returns>True if the coordinates are equal; otherwise, false.</returns>
        public static bool operator ==(Coordinate3 left, Coordinate3 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two <see cref="Coordinate3"/> objects are not equal.
        /// </summary>
        /// <param name="left">The first coordinate to compare.</param>
        /// <param name="right">The second coordinate to compare.</param>
        /// <returns>True if the coordinates are not equal; otherwise, false.</returns>
        public static bool operator !=(Coordinate3 left, Coordinate3 right)
        {
            return !(left == right);
        }
    }
}