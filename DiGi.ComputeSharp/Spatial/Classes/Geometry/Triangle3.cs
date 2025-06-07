using DiGi.ComputeSharp.Spatial.Interfaces;

namespace DiGi.ComputeSharp.Spatial.Classes
{
    public readonly struct Triangle3 : IGeometry3
    {
        public readonly Coordinate3 Point_1;
        public readonly Coordinate3 Point_2;
        public readonly Coordinate3 Point_3;
        public readonly int Solid;
        
        public Triangle3()
        {
            Solid = 1;
            Point_1 = new Coordinate3();
            Point_2 = new Coordinate3();
            Point_3 = new Coordinate3();
        }

        public Triangle3(Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3)
        {
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
        }

        public Triangle3(bool solid, Coordinate3 point_1, Coordinate3 point_2, Coordinate3 point_3)
        {
            Solid = solid ? 1 : 0;
            Point_1 = point_1;
            Point_2 = point_2;
            Point_3 = point_3;
        }

        public double GetApproximatePerimeter()
        {
            return Point_1.GetApproximateDistance(Point_2) + Point_2.GetApproximateDistance(Point_3) + Point_3.GetApproximateDistance(Point_1);
        }

        public float GetArea()
        {
            if(IsNaN())
            {
                return float.NaN;
            }

            return GetPlane().Convert_Triangle(this).GetArea();
        }

        public Coordinate3 GetCentroid()
        {
            float centroidX = (Point_1.X + Point_2.X + Point_3.X) / 3.0f;
            float centroidY = (Point_1.Y + Point_2.Y + Point_3.Y) / 3.0f;
            float centroidZ = (Point_1.Z + Point_2.Z + Point_3.Z) / 3.0f;

            return new Coordinate3(centroidX, centroidY, centroidZ);
        }

        public Triangle3 GetInversed()
        {
            return new Triangle3(Point_3, Point_2, Point_1);
        }

        public Line3 GetLine(int index)
        {
            switch (index)
            {
                case 0:
                    return new Line3(true, Point_1, Point_2);

                case 1:
                    return new Line3(true, Point_2, Point_3);

                case 2:
                    return new Line3(true, Point_3, Point_1);
            }

            return new Line3();
        }

        public Line3[] GetLines()
        {
            return [GetLine(0), GetLine(1), GetLine(2)];
        }

        public Coordinate3 GetMax()
        {
            float x = Point_1.X;
            if (x < Point_2.X)
            {
                x = Point_2.X;
            }

            if (x < Point_3.X)
            {
                x = Point_3.X;
            }

            float y = Point_1.Y;
            if (y < Point_2.Y)
            {
                y = Point_2.Y;
            }
            if (y < Point_3.Y)
            {
                y = Point_3.Y;
            }

            float z = Point_1.Z;
            if (z < Point_2.Z)
            {
                z = Point_2.Z;
            }

            if (z < Point_3.Z)
            {
                z = Point_3.Z;
            }

            return new Coordinate3(x, y, z);
        }

        public Coordinate3 GetMin()
        {
            float x = Point_1.X;
            if (x > Point_2.X)
            {
                x = Point_2.X;
            }

            if (x > Point_3.X)
            {
                x = Point_3.X;
            }

            float y = Point_1.Y;
            if (y > Point_2.Y)
            {
                y = Point_2.Y;
            }
            if (y > Point_3.Y)
            {
                y = Point_3.Y;
            }

            float z = Point_1.Z;
            if (z > Point_2.Z)
            {
                z = Point_2.Z;
            }

            if (z > Point_3.Z)
            {
                z = Point_3.Z;
            }

            return new Coordinate3(x, y, z);
        }

        public Triangle3 GetMoved(Coordinate3 vector)
        {
            return new Triangle3(Point_1.GetMoved(vector), Point_2.GetMoved(vector), Point_3.GetMoved(vector));
        }

        public Coordinate3 GetNormal()
        {
            return new Coordinate3(Point_1, Point_2).CrossProduct(new Coordinate3(Point_1, Point_3)).GetNormalized();
        }
        
        public Plane GetPlane()
        {
            return new Plane(Point_1, GetNormal());
        }

        public bool InRange(Coordinate3 point, float tolerance)
        {
            return point.InRange(this, tolerance);
        }

        public bool InRange(Line3 line3, float tolerance)
        {
            return line3.InRange(this, tolerance);
        }

        public bool InRange(Triangle3 triangle3, float tolerance)
        {
            if (IsNaN() || triangle3.IsNaN())
            {
                return false;
            }

            Coordinate3 minA = GetMin();
            Coordinate3 maxA = GetMax();
            Coordinate3 minB = triangle3.GetMin();
            Coordinate3 maxB = triangle3.GetMax();

            return (minA.X - tolerance <= maxB.X && maxA.X + tolerance >= minB.X) &&
                    (minA.Y - tolerance <= maxB.Y && maxA.Y + tolerance >= minB.Y) &&
                    (minA.Z - tolerance <= maxB.Z && maxA.Z + tolerance >= minB.Z);
        }

        public bool Inside(Coordinate3 point, float tolerance)
        {
            // Vectors forming two sides of the triangle
            Coordinate3 ab = Point_2.Substract(Point_1);
            Coordinate3 ac = Point_3.Substract(Point_1);

            // Calculate the triangle's normal
            Coordinate3 crossProduct = ab.CrossProduct(ac);
            float squaredLength = crossProduct.GetSquaredLength();

            float squaredTolerance = tolerance * tolerance;

            // Handle degenerate triangles (area is zero, points are collinear)
            if (squaredLength <= squaredTolerance) // Use a small epsilon for robustness against near-zero length
            {
                // If the triangle is degenerate (a line or a point), check if the point lies on that line/point within tolerance.
                // This is a simplified check for a 3D line.
                // If the triangle is a point (A=B=C), check distance to A.
                if (ab.GetSquaredLength() <= squaredTolerance && ac.GetSquaredLength() <= squaredTolerance)
                {
                    return point.Substract(Point_1).GetSquaredLength() <= squaredTolerance;
                }
                // If the triangle is a line (A, B, C are collinear)
                Coordinate3 closestOnLine = new Line3(true, Point_1, Point_2).GetClosestPoint(point); // Assuming A-B defines the primary line
                double distSq = point.Substract(closestOnLine).GetSquaredLength();
                return distSq <= squaredTolerance;
            }

            // Normalize the normal vector
            Coordinate3 unitNormal = crossProduct.GetNormalized();

            // Calculate the signed distance from point P to the plane of the triangle
            // The plane equation is: N . (X - A) = 0
            // Distance = N . (P - A) / |N|
            Coordinate3 ap = point.Substract(Point_1);
            float signedDistance = ap.DotProduct(unitNormal);

            // Check if the point is within the plane tolerance
            if (Math.Abs(signedDistance) > tolerance)
            {
                return false; // Point is too far from the triangle's plane
            }

            // Project P onto the triangle's plane to get the point Q (unless it's already very close)
            Coordinate3 q = point.Substract(unitNormal).Multiply(signedDistance);

            // Now, check if Q is inside the 2D triangle (defined by A, B, C) using barycentric coordinates
            // We're working in the plane of the triangle, so we can flatten it to 2D for barycentric calculation if needed,
            // or keep it in 3D using the dot product method. The 3D dot product method is more general.

            double dot00 = ab.DotProduct(ab); // |AB|^2
            double dot01 = ab.DotProduct(ac); // AB . AC
            double dot02 = ab.DotProduct(ap); // AB . AP
            double dot11 = ac.DotProduct(ac); // |AC|^2
            double dot12 = ac.DotProduct(ap); // AC . AP

            double invDenom = 1.0 / (dot00 * dot11 - dot01 * dot01); // 1 / (2 * Area_parallelogram)^2
                                                                     // If denominator is zero or near-zero, it means the triangle is degenerate (collinear vertices),
                                                                     // which should have been caught by the normalLength check above. However, for robustness:
            if (double.IsInfinity(invDenom) || double.IsNaN(invDenom))
            {
                // This case should ideally be handled by the normalLength check.
                // If it slips through, fall back to line check.
                Coordinate3 closestOnLine = new Line3(true, Point_1, Point_2).GetClosestPoint(point);
                double distSq = point.Substract(closestOnLine).GetSquaredLength();
                return distSq <= squaredTolerance;
            }


            double u = (dot11 * dot02 - dot01 * dot12) * invDenom;
            double v = (dot00 * dot12 - dot01 * dot02) * invDenom;
            double w = 1.0 - u - v; // The third barycentric coordinate

            // Apply tolerance to barycentric coordinates
            // If u, v, w are all within [0-tolerance, 1+tolerance], the point is considered inside.
            // This makes the triangle slightly "fatter" at the edges/corners.
            bool isInside2D = (u >= -tolerance && u <= 1.0 + tolerance) &&
                              (v >= -tolerance && v <= 1.0 + tolerance) &&
                              (w >= -tolerance && w <= 1.0 + tolerance);

            return isInside2D;
        }

        public bool IsNaN()
        {
            return Point_1.IsNaN() || Point_1.IsNaN() || Point_3.IsNaN();
        }
        
        public bool IsSolid()
        {
            return Solid == 1;
        }

        public bool On(Coordinate3 point, float tolerance)
        {

            if(IsSolid())
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
        
        public override string ToString()
        {
            return string.Format("P1:{0};P2:{1};P3:{2}", Point_1, Point_2, Point_3);
        }
    }
}
