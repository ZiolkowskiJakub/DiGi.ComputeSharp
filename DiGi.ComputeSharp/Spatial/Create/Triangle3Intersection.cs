using DiGi.ComputeSharp.Spatial.Classes;
using System;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        public static Triangle3Intersection Triangle3Intersection(Triangle3 triangle, Line3 line, double tolerance)
        {
            return new Triangle3Intersection(Line3Intersection(line, triangle, tolerance));
        }

        public static Triangle3Intersection Triangle3Intersection(Triangle3 triangle_1, Triangle3 triangle_2, double tolerance)
        {
            if(!triangle_1.InRange(triangle_2, tolerance))
            {
                return new Triangle3Intersection();
            }

            Line3Intersection line3Intersection_1 = Line3Intersection(triangle_1.GetLine(0), triangle_2, tolerance);
            Line3Intersection line3Intersection_2 = Line3Intersection(triangle_1.GetLine(1), triangle_2, tolerance);
            Line3Intersection line3Intersection_3 = Line3Intersection(triangle_1.GetLine(2), triangle_2, tolerance);
            
            Line3Intersection line3Intersection_4 = Line3Intersection(triangle_2.GetLine(0), triangle_1, tolerance);
            Line3Intersection line3Intersection_5 = Line3Intersection(triangle_2.GetLine(1), triangle_1, tolerance);
            Line3Intersection line3Intersection_6 = Line3Intersection(triangle_2.GetLine(2), triangle_1, tolerance);

            bool notNaN_1 = !line3Intersection_1.IsNaN(),
                notNaN_2 = !line3Intersection_2.IsNaN(),
                notNaN_3 = !line3Intersection_3.IsNaN(),
                notNaN_4 = !line3Intersection_4.IsNaN(),
                notNaN_5 = !line3Intersection_5.IsNaN(),
                notNaN_6 = !line3Intersection_6.IsNaN();

            if (!notNaN_1 && !notNaN_2 && !notNaN_3 && !notNaN_4 && !notNaN_5 && !notNaN_6)
            {
                return new Triangle3Intersection();
            }

            Core.Classes.Bool solid = new Core.Classes.Bool(triangle_1.Solid.ToBool() && triangle_2.Solid.ToBool());

            int count = Core.Query.Count(true, notNaN_1, notNaN_2, notNaN_3, notNaN_4, notNaN_5, notNaN_6);

            if (count == 1)
            {
                return new Triangle3Intersection(solid, Query.First(line3Intersection_1.Point_1, line3Intersection_2.Point_1, line3Intersection_3.Point_1, line3Intersection_4.Point_1, line3Intersection_5.Point_1, line3Intersection_6.Point_1));
            }

            if (count == 2)
            {
                Coordinate3 pointIntersection_1 = Query.First(line3Intersection_1.Point_1, line3Intersection_2.Point_1, line3Intersection_3.Point_1, line3Intersection_4.Point_1, line3Intersection_5.Point_1, line3Intersection_6.Point_1);
                Coordinate3 pointIntersection_2 = Query.First(line3Intersection_6.Point_1, line3Intersection_5.Point_1, line3Intersection_4.Point_1, line3Intersection_3.Point_1, line3Intersection_2.Point_1, line3Intersection_1.Point_1);

                if (pointIntersection_1.AlmostEquals(pointIntersection_2, tolerance))
                {
                    return new Triangle3Intersection(solid, pointIntersection_1.GetCentroid(pointIntersection_2));
                }

                return new Triangle3Intersection(solid, pointIntersection_1, pointIntersection_2);
            }

            Coordinate3 point_1 = new Coordinate3(),
                point_2 = new Coordinate3(),
                point_3 = new Coordinate3(),
                point_4 = new Coordinate3(),
                point_5 = new Coordinate3(),
                point_6 = new Coordinate3();

            Modify.Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection_1, tolerance);
            Modify.Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection_2, tolerance);
            Modify.Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection_3, tolerance);
            Modify.Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection_4, tolerance);
            Modify.Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection_5, tolerance);
            Modify.Add(ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, line3Intersection_6, tolerance);

            count = (point_1.IsNaN() ? 0 : 1) + (point_2.IsNaN() ? 0 : 1) + (point_3.IsNaN() ? 0 : 1) + (point_4.IsNaN() ? 0 : 1) + (point_5.IsNaN() ? 0 : 1) + (point_6.IsNaN() ? 0 : 1);

            if (count == 1)
            {
                return new Triangle3Intersection(solid, point_1);
            }

            if (count == 2)
            {
                return new Triangle3Intersection(solid, point_1, point_2);
            }

            if (count == 3)
            {
                return new Triangle3Intersection(solid, point_1, point_2, point_3);
            }

            Query.Sort(triangle_1.GetPlane(tolerance), ref point_1, ref point_2, ref point_3, ref point_4, ref point_5, ref point_6, tolerance);

            return new Triangle3Intersection(solid, point_1, point_2, point_3, point_4, point_5, point_6);
        }

        public static Triangle3Intersection Triangle3Intersection(Triangle3 triangle_1, Triangle3 triangle_2, Coordinate3 vector, bool frontSide, bool backSide, double tolerance)
        {
            if (triangle_1.IsNaN() || triangle_2.IsNaN())
            {
                return new Triangle3Intersection();
            }

            if(!frontSide && !backSide)
            {
                return Triangle3Intersection(triangle_1, triangle_2, tolerance);
            }

            Plane plane_1 = triangle_1.GetPlane(tolerance);
            if (plane_1.IsNaN())
            {
                return new Triangle3Intersection();
            }

            Triangle3 triangle_Projected = plane_1.Project(triangle_2, vector, tolerance);
            if (triangle_Projected.IsNaN())
            {
                return new Triangle3Intersection();
            }

            Triangle3Intersection triangle3Intersection = Triangle3Intersection(triangle_1, triangle_Projected, tolerance);
            if (triangle3Intersection.IsNaN() || triangle3Intersection.Point_3.IsNaN())
            {
                return new Triangle3Intersection();
            }

            if(frontSide && backSide)
            {
                return triangle3Intersection;
            }

            Coordinate3 centroid = Query.Centroid(triangle3Intersection);
            if (centroid.IsNaN())
            {
                return new Triangle3Intersection();
            }

            Plane plane_2 = triangle_2.GetPlane(tolerance);
            if (plane_2.IsNaN())
            {
                return new Triangle3Intersection();
            }

            Coordinate3 centroid_Projected = plane_2.Project(centroid);
            if(centroid_Projected.IsNaN() || centroid.GetDistance(centroid_Projected, tolerance) < tolerance)
            {
                return new Triangle3Intersection();
            }

            bool sameHalf = Query.SameHalf(vector, new Coordinate3(centroid_Projected, centroid), tolerance);

            if((sameHalf && frontSide) || (!sameHalf && backSide))
            {
                return triangle3Intersection;
            }
                
            return new Triangle3Intersection();
        }
    }
}
