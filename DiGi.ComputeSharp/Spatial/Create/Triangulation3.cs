using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Splits a triangle into smaller triangles based on a provided point and tolerance.
        /// </summary>
        /// <param name="triangle">The original triangle to be triangulated.</param>
        /// <param name="point">The coordinate point used for splitting the triangle.</param>
        /// <param name="tolerance">The precision tolerance for range, interior, and boundary checks.</param>
        /// <returns>A <see cref="Classes.Triangulation3"/> object containing the resulting sub-triangles; returns an empty triangulation if the point is outside the triangle.</returns>
        public static Triangulation3 Triangulation3(Triangle3 triangle, Coordinate3 point, double tolerance)
        {
            if (!triangle.InRange(point, tolerance))
            {
                return new Triangulation3();
            }

            if (!triangle.Inside(point, tolerance))
            {
                return new Triangulation3();
            }

            return ToTriangulation3(InsertPoint(triangle, point, tolerance));
        }

        /// <summary>
        /// Splits a triangle into smaller triangles based on its intersection with a provided line and tolerance.
        /// </summary>
        /// <param name="triangle">The original triangle to be triangulated.</param>
        /// <param name="line">The line segment used for splitting the triangle.</param>
        /// <param name="tolerance">The precision tolerance for intersection and boundary calculations.</param>
        /// <returns>A <see cref="Classes.Triangulation3"/> object containing the sub-triangles; returns an empty triangulation if no intersection occurs.</returns>
        public static Triangulation3 Triangulation3(Triangle3 triangle, Line3 line, double tolerance)
        {
            if (!triangle.InRange(line, tolerance))
            {
                return new Triangulation3();
            }

            Line3Intersection lineIntersection = Line3Intersection(line, triangle, tolerance);

            Coordinate3 point_1 = lineIntersection.Point_1;
            if (point_1.IsNaN())
            {
                return new Triangulation3();
            }

            Coordinate3 point_2 = lineIntersection.Point_2;

            // A single intersection point (or a chord that collapses to a point) -> split at that point.
            if (point_2.IsNaN() || point_1.AlmostEquals(point_2, tolerance))
            {
                return Triangulation3(triangle, point_1, tolerance);
            }

            // A chord running along a single edge does not split the triangle.
            for (int i = 0; i < 3; i++)
            {
                Line3 edge = triangle.GetLine(i);
                if (edge.On(point_1, tolerance) && edge.On(point_2, tolerance))
                {
                    return new Triangulation3(triangle);
                }
            }

            // Constrained triangulation. Inserting the first cut point yields sub-triangles that all share it
            // as a vertex; splitting whichever of them contains the second cut point therefore guarantees the
            // chord point_1-point_2 becomes an edge of the result.
            List<Triangle3> triangles = InsertPoint(triangle, point_1, tolerance);

            List<Triangle3> result = [];
            bool inserted = false;
            foreach (Triangle3 triangle_Temp in triangles)
            {
                if (!inserted && triangle_Temp.Inside(point_2, tolerance))
                {
                    result.AddRange(InsertPoint(triangle_Temp, point_2, tolerance));
                    inserted = true;
                }
                else
                {
                    result.Add(triangle_Temp);
                }
            }

            // Numerical fallback: if the second point was not located inside any sub-triangle, split the first.
            if (!inserted)
            {
                result = [.. InsertPoint(triangles[0], point_2, tolerance)];
                for (int i = 1; i < triangles.Count; i++)
                {
                    result.Add(triangles[i]);
                }
            }

            return ToTriangulation3(result);
        }

        /// <summary>
        /// Splits a single triangle at a point that lies at a vertex (no split), on an edge (two triangles),
        /// or strictly inside it (three triangles). Every produced triangle inherits the source triangle's
        /// <see cref="Triangle3.Solid"/> flag and includes the point as a vertex.
        /// </summary>
        private static List<Triangle3> InsertPoint(Triangle3 triangle, Coordinate3 point, double tolerance)
        {
            if (point.AlmostEquals(triangle.Point_1, tolerance) || point.AlmostEquals(triangle.Point_2, tolerance) || point.AlmostEquals(triangle.Point_3, tolerance))
            {
                return [triangle];
            }

            if (triangle.GetLine(0).On(point, tolerance))
            {
                return [new Triangle3(triangle.Solid, point, triangle.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, point, triangle.Point_3, triangle.Point_1)];
            }

            if (triangle.GetLine(1).On(point, tolerance))
            {
                return [new Triangle3(triangle.Solid, point, triangle.Point_3, triangle.Point_1), new Triangle3(triangle.Solid, point, triangle.Point_1, triangle.Point_2)];
            }

            if (triangle.GetLine(2).On(point, tolerance))
            {
                return [new Triangle3(triangle.Solid, point, triangle.Point_1, triangle.Point_2), new Triangle3(triangle.Solid, point, triangle.Point_2, triangle.Point_3)];
            }

            return [new Triangle3(triangle.Solid, point, triangle.Point_1, triangle.Point_2), new Triangle3(triangle.Solid, point, triangle.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, point, triangle.Point_3, triangle.Point_1)];
        }

        /// <summary>
        /// Packs a list of up to five sub-triangles into a <see cref="Classes.Triangulation3"/>.
        /// </summary>
        private static Triangulation3 ToTriangulation3(List<Triangle3> triangles)
        {
            return triangles.Count switch
            {
                0 => new Triangulation3(),
                1 => new Triangulation3(triangles[0]),
                2 => new Triangulation3(triangles[0], triangles[1]),
                3 => new Triangulation3(triangles[0], triangles[1], triangles[2]),
                4 => new Triangulation3(triangles[0], triangles[1], triangles[2], triangles[3]),
                _ => new Triangulation3(triangles[0], triangles[1], triangles[2], triangles[3], triangles[4]),
            };
        }
    }
}