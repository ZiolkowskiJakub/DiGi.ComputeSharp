using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the intersection of two 3D lines within a specified tolerance.
        /// </summary>
        /// <param name="line_1">The first 3D line.</param>
        /// <param name="line_2">The second 3D line.</param>
        /// <param name="tolerance">The numerical tolerance used for geometric comparisons and proximity checks.</param>
        /// <returns>A <see cref="Classes.Line3Intersection"/> object containing the intersection result, which may be empty, a single point, or a line segment in the case of coincident lines.</returns>
        public static Line3Intersection Line3Intersection(Line3 line_1, Line3 line_2, double tolerance)
        {
            if (!line_1.InRange(line_2, tolerance))
            {
                return new Line3Intersection();
            }

            // Define direction vectors
            Coordinate3 d1 = line_1.GetVector(); // Direction vector for Line 1
            Coordinate3 d2 = line_2.GetVector(); // Direction vector for Line 2

            Coordinate3 r = line_1.Start.Substract(line_2.Start); // Vector from a point on L2 to a point on L1

            double a = d1.DotProduct(d1); // squared magnitude of d1
            double b = d1.DotProduct(d2); // dot product of d1 and d2
            double c = d2.DotProduct(d2); // squared magnitude of d2
            double d = d1.DotProduct(r);  // dot product of d1 and r
            double e = d2.DotProduct(r);  // dot product of d2 and r

            double denominator = a * c - b * b;

            bool bounded_1 = line_1.Bounded.ToBool();
            bool bounded_2 = line_2.Bounded.ToBool();

            //double squaredTolerance = tolerance * tolerance;

            // Check for parallel or coincident lines
            if (denominator >= -tolerance && denominator <= tolerance)
            {
                Coordinate3 crossProduct = d1.CrossProduct(d2);

                double squaredLength = crossProduct.GetSquaredLength();

                if (squaredLength <= tolerance * tolerance)
                {
                    // Lines are parallel. Now check if they are coincident.
                    // If r is parallel to d1 (and d2), then they are coincident.

                    squaredLength = r.CrossProduct(d1).GetSquaredLength();

                    if (squaredLength <= tolerance * tolerance)
                    {
                        if (!bounded_1 && !bounded_2)
                        {
                            return new Line3Intersection(line_1);
                        }

                        if (bounded_1 && bounded_2)
                        {
                            Coordinate3 point_1 = new Coordinate3();
                            Coordinate3 point_2 = new Coordinate3();

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
                                return new Line3Intersection();
                            }

                            if (point_2.IsNaN())
                            {
                                return new Line3Intersection(point_1);
                            }

                            if (point_1.AlmostEquals(point_2, tolerance))
                            {
                                return new Line3Intersection(point_1);
                            }

                            return new Line3Intersection(point_1, point_2);
                        }

                        if (!bounded_1 && bounded_2)
                        {
                            return new Line3Intersection(line_2);
                        }

                        if (bounded_1 && !bounded_2)
                        {
                            return new Line3Intersection(line_1);
                        }
                    }
                }

                return new Line3Intersection();
            }

            // Calculate closest points coordinates on each line segment (using parameter representation)
            double s = (b * e - c * d) / denominator;
            double t = (a * e - b * d) / denominator;

            Coordinate3 intersectionPoint_1 = line_1.Start.Add(d1.Multiply(s));
            Coordinate3 intersectionPoint_2 = line_2.Start.Add(d2.Multiply(t));

            double squaredDistance = intersectionPoint_1.GetSquaredDistance(intersectionPoint_2);

            // Check if the lines actually intersect (distance between closest points is zero)
            if (squaredDistance <= tolerance * tolerance)
            {
                Coordinate3 intersectionPoint = intersectionPoint_1.GetCentroid(intersectionPoint_2);
                if ((
                    !bounded_1 && !bounded_2) ||
                    (bounded_1 && bounded_2 && line_1.On(intersectionPoint, tolerance) && line_2.On(intersectionPoint, tolerance)) ||
                    (!bounded_2 && bounded_1 && line_1.On(intersectionPoint, tolerance)) ||
                    (!bounded_1 && bounded_2 && line_2.On(intersectionPoint, tolerance))
                    )
                {
                    return new Line3Intersection(intersectionPoint);
                }
            }

            return new Line3Intersection();
        }

        /// <summary>
        /// Calculates the intersection between a line and a triangle in 3D space based on a specified tolerance.
        /// </summary>
        /// <param name="line">The line to test for intersection.</param>
        /// <param name="triangle">The triangle to test for intersection.</param>
        /// <param name="tolerance">The tolerance value used for floating-point comparisons and proximity checks.</param>
        /// <returns>A <see cref="Classes.Line3Intersection"/> object representing the intersection result (e.g., a point, a line segment, or no intersection).</returns>
        public static Line3Intersection Line3Intersection(Line3 line, Triangle3 triangle, double tolerance)
        {
            if (!line.InRange(triangle, tolerance))
            {
                return new Line3Intersection();
            }

            Line3Intersection line3Intersection;
            Line3 line_Temp;

            line3Intersection = Line3Intersection(line, triangle.GetLine(0), tolerance);
            line_Temp = new Line3();
            if (!line3Intersection.Point_2.IsNaN())
            {
                line_Temp = new Line3(line3Intersection.Point_1, line3Intersection.Point_2);
            }

            if (!line_Temp.IsNaN())
            {
                return new Line3Intersection(line_Temp);
            }

            Coordinate3 point_1 = new Coordinate3();
            if (!line3Intersection.Point_1.IsNaN())
            {
                point_1 = line3Intersection.Point_1;
            }

            line3Intersection = Line3Intersection(line, triangle.GetLine(1), tolerance);
            line_Temp = new Line3();
            if (!line3Intersection.Point_2.IsNaN())
            {
                line_Temp = new Line3(line3Intersection.Point_1, line3Intersection.Point_2);
            }

            if (!line_Temp.IsNaN())
            {
                return new Line3Intersection(line_Temp);
            }

            Coordinate3 point_2 = new Coordinate3();
            if (!line3Intersection.Point_1.IsNaN())
            {
                point_2 = line3Intersection.Point_1;
            }

            line3Intersection = Line3Intersection(line, triangle.GetLine(2), tolerance);
            line_Temp = new Line3();
            if (!line3Intersection.Point_2.IsNaN())
            {
                line_Temp = new Line3(line3Intersection.Point_1, line3Intersection.Point_2);
            }

            if (!line_Temp.IsNaN())
            {
                return new Line3Intersection(line_Temp);
            }

            Coordinate3 point_3 = new Coordinate3();
            if (!line3Intersection.Point_1.IsNaN())
            {
                point_3 = line3Intersection.Point_1;
            }

            bool solid = triangle.Solid.ToBool();

            bool notNaN_1 = !point_1.IsNaN();
            bool notNaN_2 = !point_2.IsNaN();
            bool notNaN_3 = !point_3.IsNaN();

            if (!solid && !notNaN_1 && !notNaN_2 && !notNaN_3)
            {
                return new Line3Intersection();
            }

            if (notNaN_1 && notNaN_2)
            {
                return new Line3Intersection(triangle.Solid, point_1, point_2);
            }

            if (notNaN_2 && notNaN_3)
            {
                return new Line3Intersection(triangle.Solid, point_2, point_3);
            }

            if (notNaN_3 && notNaN_1)
            {
                return new Line3Intersection(triangle.Solid, point_3, point_1);
            }

            if (!solid)
            {
                if (notNaN_1)
                {
                    return new Line3Intersection(point_1);
                }

                if (notNaN_2)
                {
                    return new Line3Intersection(point_2);
                }

                if (notNaN_3)
                {
                    return new Line3Intersection(point_3);
                }

                return new Line3Intersection();
            }

            Coordinate3 vector_1 = new Coordinate3(triangle.Point_1, triangle.Point_2);
            Coordinate3 vector_2 = new Coordinate3(triangle.Point_1, triangle.Point_3);

            Coordinate3 direction = line.GetDirection(tolerance);

            Coordinate3 crossProduct = direction.CrossProduct(vector_2);

            double factor = vector_1.DotProduct(crossProduct);

            if (factor >= -tolerance && factor <= tolerance)
            {
                Coordinate3 start = new Coordinate3();
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
                    return new Line3Intersection();
                }

                Coordinate3 end = new Coordinate3();
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
                            return new Line3Intersection(triangle.Solid, line.Start.GetCentroid(line.End));
                        }

                        return new Line3Intersection(triangle.Solid, line.Start, line.End);
                    }

                    return new Line3Intersection();
                }

                if (start.AlmostEquals(end, tolerance))
                {
                    return new Line3Intersection(triangle.Solid, start.GetCentroid(end));
                }

                return new Line3Intersection(triangle.Solid, start, end);
            }

            Coordinate3 ab = new Coordinate3(triangle.Point_1, triangle.Point_2);
            Coordinate3 ac = new Coordinate3(triangle.Point_1, triangle.Point_3);
            Coordinate3 normal = ab.CrossProduct(ac);

            double denominator = normal.DotProduct(direction);

            // If denominator is close to 0, line is parallel to the triangle's plane
            if (Core.Query.Abs(denominator) < tolerance)
            {
                return new Line3Intersection();
            }

            double t = normal.DotProduct(triangle.Point_1.Substract(line.Start)) / denominator;
            Coordinate3 intersectionPoint = line.Start.Add(direction.Multiply(t));
            if (!line.On(intersectionPoint, tolerance))
            {
                return new Line3Intersection();
            }

            // Barycentric coordinate check
            Coordinate3 ap = new Coordinate3(triangle.Point_1, intersectionPoint);

            double d00 = ab.DotProduct(ab);
            double d01 = ab.DotProduct(ac);
            double d11 = ac.DotProduct(ac);
            double d20 = ap.DotProduct(ab);
            double d21 = ap.DotProduct(ac);

            double denom = d00 * d11 - d01 * d01;
            if (Core.Query.Abs(denom) < tolerance)
            {
                return new Line3Intersection();
            }

            double u = (d11 * d20 - d01 * d21) / denom;
            double v = (d00 * d21 - d01 * d20) / denom;

            if (u >= 0 && v >= 0 && (u + v) <= 1)
            {
                return new Line3Intersection(intersectionPoint);
            }

            return new Line3Intersection();
        }
    }
}