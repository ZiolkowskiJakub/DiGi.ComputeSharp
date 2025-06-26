using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Classes;
using System.Numerics;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        
        public static Line3Intersection Line3Intersection(Line3 line_1, Line3 line_2, float tolerance)
        {
            if (!line_1.InRange(line_2, tolerance))
            {
                return new Line3Intersection();
            }

            // Define direction vectors
            Coordinate3 d1 = line_1.GetVector(); // Direction vector for Line 1
            Coordinate3 d2 = line_2.GetVector(); // Direction vector for Line 2

            Coordinate3 r = line_1.Start.Substract(line_2.Start); // Vector from a point on L2 to a point on L1

            float a = d1.DotProduct(d1); // squared magnitude of d1
            float b = d1.DotProduct(d2); // dot product of d1 and d2
            float c = d2.DotProduct(d2); // squared magnitude of d2
            float d = d1.DotProduct(r);  // dot product of d1 and r
            float e = d2.DotProduct(r);  // dot product of d2 and r

            float denominator = a * c - b * b;

            bool bounded_1 = line_1.Bounded.ToBool();
            bool bounded_2 = line_2.Bounded.ToBool();

            //float squaredTolerance = tolerance * tolerance;

            // Check for parallel or coincident lines
            if (denominator >= -tolerance && denominator <= tolerance)
            {
                Coordinate3 crossProduct = d1.CrossProduct(d2);

                float squaredLength = crossProduct.GetSquaredLength();

                if (squaredLength <= tolerance || Core.Query.Sqrt(squaredLength, tolerance) <= tolerance)
                {
                    // Lines are parallel. Now check if they are coincident.
                    // If r is parallel to d1 (and d2), then they are coincident.

                    squaredLength = r.CrossProduct(d1).GetSquaredLength();

                    if (squaredLength <= tolerance || Core.Query.Sqrt(squaredLength, tolerance) <= tolerance)
                    {
                        if(!bounded_1 && !bounded_2)
                        {
                            return new Line3Intersection(line_1);
                        }

                        if(bounded_1 && bounded_2)
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

                            if(point_2.IsNaN())
                            {
                                return new Line3Intersection(point_1);
                            }

                            return new Line3Intersection(new Line3(new Bool(true), point_1, point_2));
                        }

                        if(bounded_1)
                        {
                            return new Line3Intersection(line_1);
                        }

                        if (bounded_2)
                        {
                            return new Line3Intersection(line_2);
                        }
                    }

                    
                }

                // This case should ideally not be reached if determinant is near zero
                // unless d1 or d2 is a zero vector (points are the same).
                // If d1 or d2 is zero vector, they are not well-defined lines.
                // We'll treat this as skew for simplicity, but a more robust solution
                // might handle degenerate line cases explicitly.
                return new Line3Intersection();
            }

            // Calculate parameters s and t for the points of closest approach
            // (Using s and t for the parameters to avoid confusion with the method parameters)
            float s = (b * e - c * d) / denominator; // Parameter for Line 1
            float t = (a * e - b * d) / denominator; // Parameter for Line 2 (Note: This is the 'u' in the formula)

            Coordinate3 intersectionPoint_1 = line_1.Start.Add(d1.Multiply(s));
            Coordinate3 intersectionPoint_2 = line_2.Start.Add(d2.Multiply(t));

            float squaredDistance = intersectionPoint_1.GetSquaredDistance(intersectionPoint_2);

            // Check if the lines actually intersect (distance between closest points is zero)
            if (squaredDistance <= tolerance || Core.Query.Sqrt(squaredDistance, tolerance) <= tolerance)
            {
                Coordinate3 intersectionPoint = intersectionPoint_1.GetCentroid(intersectionPoint_2);
                if((
                    !bounded_1 && !bounded_2) ||
                    (bounded_1 && bounded_2 && line_1.On(intersectionPoint, tolerance) && line_2.On(intersectionPoint, tolerance)) ||
                    (!bounded_2 && bounded_1 && line_1.On(intersectionPoint, tolerance)) ||
                    (!bounded_1 && bounded_2 && line_2.On(intersectionPoint, tolerance) )
                    )
                {
                    return new Line3Intersection(intersectionPoint);
                }
            }

            return new Line3Intersection();
        }
        
        public static Line3Intersection Line3Intersection(Line3 line, Triangle3 triangle, float tolerance)
        {
            if(!line.InRange(triangle, tolerance))
            {
                return new Line3Intersection();
            }

            Line3Intersection line3Intersection;
            Line3 line_Temp;

            line3Intersection = Line3Intersection(line, triangle.GetLine(0), tolerance);
            line_Temp = new Line3();
            if(!line3Intersection.Point_2.IsNaN())
            {
                line_Temp = new Line3(line3Intersection.Point_1, line3Intersection.Point_2);
            }

            if (!line_Temp.IsNaN())
            {
                return new Line3Intersection(line_Temp);
            }

            Coordinate3 point_1 = new Coordinate3();
            if(!line3Intersection.Point_1.IsNaN())
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
            if(!line3Intersection.Point_1.IsNaN())
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
            if(!line3Intersection.Point_1.IsNaN())
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

            if(!solid)
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

            float factor = vector_1.DotProduct(crossProduct);

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

                if (start.IsNaN())
                {
                    return new Line3Intersection();
                }

                if (start.AlmostEquals(end, tolerance))
                {
                    return new Line3Intersection(triangle.Solid, start.GetCentroid(end));
                }

                return new Line3Intersection(triangle.Solid, start, end);
            }

            //factor = 1.0f / factor;

            //Coordinate3 vector;

            //Coordinate3 origin = line.Start;

            //vector = new Coordinate3(triangle.Point_1, origin);

            //float factor_1 = factor * vector.DotProduct(crossProduct);
            //if (factor_1 < -tolerance || factor_1 > 1.0 + tolerance)
            //{
            //    return new Line3Intersection();
            //}

            //vector = vector.CrossProduct(vector_1);
            //double factor_2 = factor * direction.DotProduct(vector);
            //if (factor_2 < -tolerance || factor_1 + factor_2 > 1.0 + tolerance)
            //{
            //    return new Line3Intersection();
            //}

            //factor = factor * vector_2.DotProduct(vector);

            //if (factor < tolerance)
            //{
            //    return new Line3Intersection();
            //}

            //Coordinate3 intersectionPoint = origin.Add(direction.Multiply(factor));

            //if (line.On(intersectionPoint, tolerance))
            //{
            //    return new Line3Intersection(intersectionPoint);
            //}

            //return new Line3Intersection();

            Coordinate3 ab = new Coordinate3(triangle.Point_1, triangle.Point_2);
            Coordinate3 ac = new Coordinate3(triangle.Point_1, triangle.Point_3);
            Coordinate3 normal = ab.CrossProduct(ac);

            float denominator = normal.DotProduct(direction);

            // If denominator is close to 0, line is parallel to the triangle's plane
            if (Core.Query.Abs(denominator) < tolerance)
            {
                return new Line3Intersection();
            }

            float t = normal.DotProduct(triangle.Point_1.Substract(line.Start)) / denominator;
            Coordinate3 intersectionPoint = line.Start.Add(direction.Multiply(t));

            // Optional: if treating line as segment, check if t in [0,1]
            //if (t <  - tolerance || t > 1.0f + tolerance)
            //{
            //    return new Line3Intersection();
            //}

            // Barycentric coordinate check
            Coordinate3 ap = new Coordinate3(triangle.Point_1, intersectionPoint);

            float d00 = ab.DotProduct(ab);
            float d01 = ab.DotProduct(ac);
            float d11 = ac.DotProduct(ac);
            float d20 = ap.DotProduct(ab);
            float d21 = ap.DotProduct(ac);

            float denom = d00 * d11 - d01 * d01;
            if (Core.Query.Abs(denom) < tolerance)
            {
                return new Line3Intersection();
            }

            float u = (d11 * d20 - d01 * d21) / denom;
            float v = (d00 * d21 - d01 * d20) / denom;

            if(u >= 0 && v >= 0 && (u + v) <= 1)
            {
                return new Line3Intersection(intersectionPoint);
            }
          
            return new Line3Intersection();
        }
    }
}
