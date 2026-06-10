using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents the result of an intersection operation in 3D space, which can be a single point, two points, or a line segment.
    /// </summary>
    public readonly struct Line3Intersection : IIntersection3
    {
        /// <summary>
        /// The first coordinate point of the intersection.
        /// </summary>
        public readonly Coordinate3 Point_1;

        /// <summary>
        /// The second coordinate point of the intersection, used when the result is a line segment.
        /// </summary>
        public readonly Coordinate3 Point_2;

        /// <summary>
        /// Indicates whether the intersection result is a solid line segment rather than discrete points.
        /// </summary>
        public readonly Bool Solid;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3Intersection"/> struct with default values.
        /// </summary>
        public Line3Intersection()
        {
            Solid = new Bool(false);
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3Intersection"/> struct with specified solidity and the first point.
        /// </summary>
        /// <param name="solid">The solidity flag for the intersection.</param>
        /// <param name="point_1">The first coordinate point.</param>
        public Line3Intersection(Bool solid, Coordinate3 point_1)
        {
            Solid = solid;
            Point_1 = point_1;
            Point_2 = new Coordinate3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3Intersection"/> struct with the first point.
        /// </summary>
        /// <param name="point_1">The first coordinate point.</param>
        public Line3Intersection(Coordinate3 point_1)
        {
            Solid = new Bool(false);
            Point_1 = point_1;
            Point_2 = new Coordinate3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3Intersection"/> struct with two coordinate points.
        /// </summary>
        /// <param name="point_1">The first coordinate point.</param>
        /// <param name="point_2">The second coordinate point.</param>
        public Line3Intersection(Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = new Bool(false);
            Point_1 = point_1;
            Point_2 = point_2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3Intersection"/> struct with specified solidity and two coordinate points.
        /// </summary>
        /// <param name="solid">The solidity flag for the intersection.</param>
        /// <param name="point_1">The first coordinate point.</param>
        /// <param name="point_2">The second coordinate point.</param>
        public Line3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2)
        {
            Solid = solid;
            Point_1 = point_1;
            Point_2 = point_2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3Intersection"/> struct from an existing line.
        /// </summary>
        /// <param name="line">The line to use for initialization.</param>
        public Line3Intersection(Line3 line)
        {
            Solid = new Bool(true);
            Point_1 = line.Start;
            Point_2 = line.End;
        }

        /// <summary>
        /// Retrieves the geometries resulting from the intersection, optionally overriding the solidity of the result.
        /// </summary>
        /// <param name="solid">An optional override for whether the result should be treated as a solid geometry.</param>
        /// <returns>An array of <see cref="IGeometry3"/> objects representing the intersection, or null if the primary point is NaN.</returns>
        public IGeometry3[]? GetIntersectionGeometries(bool? solid = null)
        {
            if (Point_1.IsNaN())
            {
                return null;
            }

            if (Point_2.IsNaN())
            {
                return [Point_1];
            }

            bool solid_Temp = solid == null || !solid.HasValue ? Solid.ToBool() : solid.Value;

            if (solid_Temp)
            {
                return [new Line3(Point_1, Point_2)];
            }
            else
            {
                return [Point_1, Point_2];
            }
        }

        /// <summary>
        /// Converts the intersection result into a line segment if it is marked as solid and contains valid points.
        /// </summary>
        /// <returns>A <see cref="Line3"/> representing the intersection line, or an empty line if not applicable.</returns>
        public Line3 GetLine()
        {
            if (!Solid.ToBool() || Point_2.IsNaN())
            {
                return new Line3();
            }

            return new Line3(Point_1, Point_2);
        }

        /// <summary>
        /// Determines whether the intersection result is Not-a-Number (NaN).
        /// </summary>
        /// <returns>True if the first point is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return Point_1.IsNaN();
        }
    }
}