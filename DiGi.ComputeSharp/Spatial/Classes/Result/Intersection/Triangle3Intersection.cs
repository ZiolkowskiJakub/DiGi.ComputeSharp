using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a 3D triangle intersection result containing up to six coordinates and a solidity flag.
    /// </summary>
    public struct Triangle3Intersection : IIntersection3
    {
        /// <summary>The first coordinate of the intersection.</summary>
        public readonly Coordinate3 Point_1;

        /// <summary>The second coordinate of the intersection.</summary>
        public readonly Coordinate3 Point_2;

        /// <summary>The third coordinate of the intersection.</summary>
        public readonly Coordinate3 Point_3;

        /// <summary>The fourth coordinate of the intersection.</summary>
        public readonly Coordinate3 Point_4;

        /// <summary>The fifth coordinate of the intersection.</summary>
        public readonly Coordinate3 Point_5;

        /// <summary>The sixth coordinate of the intersection.</summary>
        public readonly Coordinate3 Point_6;

        /// <summary>Indicates whether the intersection is considered a solid geometry.</summary>
        public readonly Bool Solid;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3Intersection"/> struct with default values.
        /// </summary>
        public Triangle3Intersection()
        {
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = new Bool(false);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3Intersection"/> struct from a <see cref="Line3Intersection"/>.
        /// </summary>
        /// <param name="line3Intersection">The line intersection to convert from.</param>
        public Triangle3Intersection(Line3Intersection line3Intersection)
        {
            Point_1 = line3Intersection.Point_1;
            Point_2 = line3Intersection.Point_2;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = line3Intersection.Solid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3Intersection"/> struct from a <see cref="Line3"/>.
        /// </summary>
        /// <param name="line">The line used to initialize the intersection points.</param>
        public Triangle3Intersection(Line3 line)
        {
            Point_1 = line.Start;
            Point_2 = line.End;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = new Bool(false);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3Intersection"/> struct with a solidity flag and one point.
        /// </summary>
        /// <param name="solid">Whether the geometry is solid.</param>
        /// <param name="point_1">The first coordinate.</param>
        public Triangle3Intersection(Bool solid, Coordinate3 point_1)
        {
            Point_1 = point_1;
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = solid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3Intersection"/> struct with a solidity flag and two points.
        /// </summary>
        /// <param name="solid">Whether the geometry is solid.</param>
        /// <param name="point_1">The first coordinate.</param>
        /// <param name="point_2">The second coordinate.</param>
        public Triangle3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = new Coordinate3();
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = solid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3Intersection"/> struct with a solidity flag and three points.
        /// </summary>
        /// <param name="solid">Whether the geometry is solid.</param>
        /// <param name="point_1">The first coordinate.</param>
        /// <param name="point_2">The second coordinate.</param>
        /// <param name="point_3">The third coordinate.</param>
        public Triangle3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
            Point_4 = new Coordinate3();
            Point_5 = new Coordinate3();
            Point_6 = new Coordinate3();

            Solid = solid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3Intersection"/> struct with a solidity flag and six points.
        /// </summary>
        /// <param name="solid">Whether the geometry is solid.</param>
        /// <param name="point_1">The first coordinate.</param>
        /// <param name="point_2">The second coordinate.</param>
        /// <param name="point_3">The third coordinate.</param>
        /// <param name="point_4">The fourth coordinate.</param>
        /// <param name="point_5">The fifth coordinate.</param>
        /// <param name="point_6">The sixth coordinate.</param>
        public Triangle3Intersection(Bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3, Coordinate3 point_4, Coordinate3 point_5, Coordinate3 point_6)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
            Point_4 = point_4;
            Point_5 = point_5;
            Point_6 = point_6;

            Solid = solid;
        }

        /// <summary>
        /// Retrieves the intersection geometries based on the available points and solidity.
        /// </summary>
        /// <param name="solid">Optional override for the solidity flag.</param>
        /// <returns>An array of 3D geometries, or null if no valid points exist.</returns>
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

            if (Point_3.IsNaN())
            {
                if (solid_Temp)
                {
                    return [new Line3(Point_1, Point_2)];
                }
                else
                {
                    return [Point_1, Point_2];
                }
            }

            if (Point_4.IsNaN())
            {
                if (solid_Temp)
                {
                    return [new Triangle3(Solid, Point_1, Point_2, Point_3)];
                }
                else
                {
                    return [new Line3(Point_1, Point_2), new Line3(Point_2, Point_3), new Line3(Point_3, Point_1)];
                }
            }

            if (Point_5.IsNaN())
            {
                if (solid_Temp)
                {
                    return [new Triangle3(Solid, Point_1, Point_2, Point_3), new Triangle3(Solid, Point_1, Point_3, Point_4)];
                }
                else
                {
                    Bool @bool = new Bool(true);

                    return [new Line3(@bool, Point_1, Point_2), new Line3(@bool, Point_2, Point_3), new Line3(@bool, Point_3, Point_4), new Line3(@bool, Point_4, Point_1)];
                }
            }

            if (Point_6.IsNaN())
            {
                if (solid_Temp)
                {
                    return [new Triangle3(Solid, Point_1, Point_2, Point_3), new Triangle3(Solid, Point_1, Point_3, Point_4), new Triangle3(Solid, Point_1, Point_4, Point_5)];
                }
                else
                {
                    Bool @bool = new Bool(true);

                    return [new Line3(@bool, Point_1, Point_2), new Line3(@bool, Point_2, Point_3), new Line3(@bool, Point_3, Point_4), new Line3(@bool, Point_4, Point_5), new Line3(@bool, Point_5, Point_1)];
                }
            }

            if (solid_Temp)
            {
                return [new Triangle3(Solid, Point_1, Point_2, Point_3), new Triangle3(Solid, Point_3, Point_4, Point_5), new Triangle3(Solid, Point_1, Point_5, Point_6), new Triangle3(Solid, Point_1, Point_3, Point_5)];
            }
            else
            {
                Bool @bool = new Bool(true);

                return [new Line3(@bool, Point_1, Point_2), new Line3(@bool, Point_2, Point_3), new Line3(@bool, Point_3, Point_4), new Line3(@bool, Point_4, Point_5), new Line3(@bool, Point_5, Point_6), new Line3(@bool, Point_6, Point_1)];
            }
        }

        /// <summary>
        /// Determines whether the intersection is not a number (NaN), indicating it is invalid or empty.
        /// </summary>
        /// <returns>True if the first point is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return Point_1.IsNaN();
        }
    }
}