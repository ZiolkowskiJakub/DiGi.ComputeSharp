using DiGi.ComputeSharp.Planar.Classes;

namespace DiGi.ComputeSharp.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the intersection of two 2D lines within a specified tolerance.
        /// </summary>
        /// <param name="line_1">The first 2D line.</param>
        /// <param name="line_2">The second 2D line.</param>
        /// <param name="tolerance">The numerical tolerance used for geometric comparisons and proximity checks.</param>
        /// <returns>A <see cref="Classes.Line2Intersection"/> object containing the intersection result, which may be empty, a single point, or a line segment in the case of coincident lines.</returns>
        public static Line2Intersection Line2Intersection(Line2 line_1, Line2 line_2, double tolerance)
        {
            if (!line_1.InRange(line_2, tolerance))
            {
                return new Line2Intersection();
            }

            // Direction vectors of both lines.
            Coordinate2 d1 = line_1.GetVector();
            Coordinate2 d2 = line_2.GetVector();

            bool bounded_1 = line_1.Bounded.ToBool();
            bool bounded_2 = line_2.Bounded.ToBool();

            // In 2D the scalar cross product of the two direction vectors is the determinant of the
            // linear system. A (near) zero value means the lines are parallel (or one is degenerate),
            // so there is no unique crossing point and we fall back to the coincident-overlap handling.
            double denominator = d1.CrossProduct(d2);

            if (denominator > -tolerance && denominator < tolerance)
            {
                // Parallel lines. They only intersect if they are also collinear, i.e. the vector
                // between a point on each line is parallel to the shared direction.
                Coordinate2 r = line_1.Start.Substract(line_2.Start);
                double collinear = r.CrossProduct(d1);

                if (collinear > -tolerance && collinear < tolerance)
                {
                    if (!bounded_1 && !bounded_2)
                    {
                        return new Line2Intersection(line_1);
                    }

                    if (bounded_1 && bounded_2)
                    {
                        Coordinate2 point_1 = new();
                        Coordinate2 point_2 = new();

                        if (line_2.On(line_1.Start, tolerance))
                        {
                            Modify.Add(ref point_1, ref point_2, line_1.Start, tolerance);
                        }

                        if (line_2.On(line_1.End, tolerance))
                        {
                            Modify.Add(ref point_1, ref point_2, line_1.End, tolerance);
                        }

                        if (line_1.On(line_2.Start, tolerance))
                        {
                            Modify.Add(ref point_1, ref point_2, line_2.Start, tolerance);
                        }

                        if (line_1.On(line_2.End, tolerance))
                        {
                            Modify.Add(ref point_1, ref point_2, line_2.End, tolerance);
                        }

                        if (point_1.IsNaN())
                        {
                            return new Line2Intersection();
                        }

                        if (point_2.IsNaN())
                        {
                            return new Line2Intersection(point_1);
                        }

                        if (point_1.AlmostEquals(point_2, tolerance))
                        {
                            return new Line2Intersection(point_1);
                        }

                        return new Line2Intersection(point_1, point_2);
                    }

                    if (!bounded_1 && bounded_2)
                    {
                        return new Line2Intersection(line_2);
                    }

                    if (bounded_1 && !bounded_2)
                    {
                        return new Line2Intersection(line_1);
                    }
                }

                return new Line2Intersection();
            }

            // Non-parallel infinite lines always cross at exactly one point; solve the parameter on line_1.
            // Because the crossing is exact there is no closest-point distance gate as in the 3D (skew) case.
            Coordinate2 startToStart = new(line_1.Start, line_2.Start);
            double t = startToStart.CrossProduct(d2) / denominator;

            Coordinate2 intersectionPoint = line_1.Start.Add(d1.Multiply(t));

            if ((!bounded_1 && !bounded_2) ||
                (bounded_1 && bounded_2 && line_1.On(intersectionPoint, tolerance) && line_2.On(intersectionPoint, tolerance)) ||
                (!bounded_2 && bounded_1 && line_1.On(intersectionPoint, tolerance)) ||
                (!bounded_1 && bounded_2 && line_2.On(intersectionPoint, tolerance)))
            {
                return new Line2Intersection(intersectionPoint);
            }

            return new Line2Intersection();
        }

        /// <summary>
        /// Calculates the intersection between a line and a triangle in 2D space based on a specified tolerance.
        /// </summary>
        /// <param name="line">The line to test for intersection.</param>
        /// <param name="triangle">The triangle to test for intersection.</param>
        /// <param name="tolerance">The tolerance value used for floating-point comparisons and proximity checks.</param>
        /// <returns>A <see cref="Classes.Line2Intersection"/> object representing the intersection result (e.g., a point, a line segment, or no intersection).</returns>
        public static Line2Intersection Line2Intersection(Line2 line, Triangle2 triangle, double tolerance)
        {
            if (!line.InRange(triangle, tolerance))
            {
                return new Line2Intersection();
            }

            Line2Intersection line2Intersection;
            Line2 line_Temp;

            // Edge 0: a segment result means the line runs along the edge, which is the final answer.
            line2Intersection = Line2Intersection(line, triangle.GetLine(0), tolerance);
            line_Temp = new Line2();
            if (!line2Intersection.Point_2.IsNaN())
            {
                line_Temp = new Line2(line2Intersection.Point_1, line2Intersection.Point_2);
            }

            if (!line_Temp.IsNaN())
            {
                return new Line2Intersection(line_Temp);
            }

            Coordinate2 point_1 = new Coordinate2();
            if (!line2Intersection.Point_1.IsNaN())
            {
                point_1 = line2Intersection.Point_1;
            }

            // Edge 1.
            line2Intersection = Line2Intersection(line, triangle.GetLine(1), tolerance);
            line_Temp = new Line2();
            if (!line2Intersection.Point_2.IsNaN())
            {
                line_Temp = new Line2(line2Intersection.Point_1, line2Intersection.Point_2);
            }

            if (!line_Temp.IsNaN())
            {
                return new Line2Intersection(line_Temp);
            }

            Coordinate2 point_2 = new Coordinate2();
            if (!line2Intersection.Point_1.IsNaN())
            {
                point_2 = line2Intersection.Point_1;
            }

            // Edge 2.
            line2Intersection = Line2Intersection(line, triangle.GetLine(2), tolerance);
            line_Temp = new Line2();
            if (!line2Intersection.Point_2.IsNaN())
            {
                line_Temp = new Line2(line2Intersection.Point_1, line2Intersection.Point_2);
            }

            if (!line_Temp.IsNaN())
            {
                return new Line2Intersection(line_Temp);
            }

            Coordinate2 point_3 = new Coordinate2();
            if (!line2Intersection.Point_1.IsNaN())
            {
                point_3 = line2Intersection.Point_1;
            }

            bool solid = triangle.Solid.ToBool();

            bool notNaN_1 = !point_1.IsNaN();
            bool notNaN_2 = !point_2.IsNaN();
            bool notNaN_3 = !point_3.IsNaN();

            if (!solid && !notNaN_1 && !notNaN_2 && !notNaN_3)
            {
                return new Line2Intersection();
            }

            // The line crosses two edges: the chord between those two crossings is the intersection.
            if (notNaN_1 && notNaN_2)
            {
                return new Line2Intersection(triangle.Solid, point_1, point_2);
            }

            if (notNaN_2 && notNaN_3)
            {
                return new Line2Intersection(triangle.Solid, point_2, point_3);
            }

            if (notNaN_3 && notNaN_1)
            {
                return new Line2Intersection(triangle.Solid, point_3, point_1);
            }

            if (!solid)
            {
                if (notNaN_1)
                {
                    return new Line2Intersection(point_1);
                }

                if (notNaN_2)
                {
                    return new Line2Intersection(point_2);
                }

                if (notNaN_3)
                {
                    return new Line2Intersection(point_3);
                }

                return new Line2Intersection();
            }

            // Solid triangle with a single edge crossing: the line starts inside the triangle and exits
            // through that edge. Unlike the 3D case the line is already in the triangle's plane, so there
            // is no plane-parallel test or barycentric plane-piercing branch to perform here.
            Coordinate2 start = new Coordinate2();
            if (triangle.Inside(line.Start, tolerance))
            {
                start = line.Start;
            }
            else if (triangle.Inside(line.End, tolerance))
            {
                start = line.End;
            }

            if (start.IsNaN())
            {
                return new Line2Intersection();
            }

            Coordinate2 end = new Coordinate2();
            if (notNaN_1)
            {
                end = point_1;
            }
            else if (notNaN_2)
            {
                end = point_2;
            }
            else if (notNaN_3)
            {
                end = point_3;
            }

            if (end.IsNaN())
            {
                // No edge crossing was found. If both endpoints lie inside the solid triangle the whole
                // segment is contained, so the intersection is the segment itself.
                if (triangle.Inside(line.Start, tolerance) && triangle.Inside(line.End, tolerance))
                {
                    if (line.Start.AlmostEquals(line.End, tolerance))
                    {
                        return new Line2Intersection(triangle.Solid, line.Start.GetCentroid(line.End));
                    }

                    return new Line2Intersection(triangle.Solid, line.Start, line.End);
                }

                return new Line2Intersection();
            }

            if (start.AlmostEquals(end, tolerance))
            {
                return new Line2Intersection(triangle.Solid, start.GetCentroid(end));
            }

            return new Line2Intersection(triangle.Solid, start, end);
        }
    }
}