using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        public static Triangle3Intersection Triangle3Intersection(Triangle3 triangle, Line3 line, float tolerance)
        {
            return new Triangle3Intersection(Line3Intersection(line, triangle, tolerance));
        }

        public static Triangle3Intersection Triangle3Intersection(Triangle3 triangle_1, Triangle3 triangle_2, float tolerance)
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

            bool notNaN_1 = !line3Intersection_1.IsNaN();
            bool notNaN_2 = !line3Intersection_2.IsNaN();
            bool notNaN_3 = !line3Intersection_3.IsNaN();
            bool notNaN_4 = !line3Intersection_4.IsNaN();
            bool notNaN_5 = !line3Intersection_5.IsNaN();
            bool notNaN_6 = !line3Intersection_6.IsNaN();

            if (!notNaN_1 && !notNaN_2 && !notNaN_3 && !notNaN_4 && !notNaN_5 && !notNaN_6)
            {
                return new Triangle3Intersection();
            }

            bool solid = triangle_1.IsSolid() && triangle_2.IsSolid();

            int count = 0;
            count += notNaN_1 ? 1 : 0;
            count += notNaN_2 ? 1 : 0;
            count += notNaN_3 ? 1 : 0;
            count += notNaN_4 ? 1 : 0;
            count += notNaN_5 ? 1 : 0;
            count += notNaN_6 ? 1 : 0;

            if (count == 1)
            {
                Query.TryGetFirst(line3Intersection_1.Point_1, line3Intersection_2.Point_1, line3Intersection_3.Point_1, line3Intersection_4.Point_1, line3Intersection_5.Point_1, line3Intersection_6.Point_1, out Coordinate3 pointIntersection);

                return new Triangle3Intersection(solid, pointIntersection);
            }

            if (count == 2)
            {
                Query.TryGetFirst(line3Intersection_1.Point_1, line3Intersection_2.Point_1, line3Intersection_3.Point_1, line3Intersection_4.Point_1, line3Intersection_5.Point_1, line3Intersection_6.Point_1, out Coordinate3 pointIntersection_1);
                Query.TryGetFirst(line3Intersection_6.Point_1, line3Intersection_5.Point_1, line3Intersection_4.Point_1, line3Intersection_3.Point_1, line3Intersection_2.Point_1, line3Intersection_1.Point_1, out Coordinate3 pointIntersection_2);

                if (pointIntersection_1.AlmostEquals(pointIntersection_2, tolerance))
                {
                    return new Triangle3Intersection(solid, pointIntersection_1.GetCentroid(pointIntersection_2));
                }

                return new Triangle3Intersection(solid, pointIntersection_1, pointIntersection_2);
            }

            Coordinate3 point_1 = line3Intersection_1.Point_1;
            
            Coordinate3 point_2 = line3Intersection_2.Point_1;
            if(notNaN_2)
            {
                if (notNaN_1 && point_2.AlmostEquals(point_1, tolerance))
                {
                    point_1 = point_1.GetCentroid(point_2);
                    point_2 = new Coordinate3();
                    notNaN_2 = false;
                    count--;
                }
            }

            Coordinate3 point_3 = line3Intersection_3.Point_1;
            if(notNaN_3)
            {
                if (notNaN_1 && point_3.AlmostEquals(point_1, tolerance))
                {
                    point_1 = point_1.GetCentroid(point_3);
                    point_3 = new Coordinate3();
                    notNaN_3 = false;
                    count--;
                }
                else if (notNaN_2 && point_3.AlmostEquals(point_2, tolerance))
                {
                    point_2 = point_2.GetCentroid(point_3);
                    point_3 = new Coordinate3();
                    notNaN_3 = false;
                    count--;
                }
            }

            Coordinate3 point_4 = line3Intersection_4.Point_1;
            if (notNaN_4)
            {
                if (notNaN_1 && point_4.AlmostEquals(point_1, tolerance))
                {
                    point_1 = point_1.GetCentroid(point_4);
                    point_4 = new Coordinate3();
                    notNaN_4 = false;
                    count--;
                }
                else if (notNaN_2 && point_4.AlmostEquals(point_2, tolerance))
                {
                    point_2 = point_2.GetCentroid(point_4);
                    point_4 = new Coordinate3();
                    notNaN_4 = false;
                    count--;
                }
                else if (notNaN_3 && point_4.AlmostEquals(point_3, tolerance))
                {
                    point_3 = point_3.GetCentroid(point_4);
                    point_4 = new Coordinate3();
                    notNaN_4 = false;
                    count--;
                }
            }

            Coordinate3 point_5 = line3Intersection_5.Point_1;
            if (notNaN_5)
            {
                if (notNaN_1 && point_5.AlmostEquals(point_1, tolerance))
                {
                    point_1 = point_1.GetCentroid(point_5);
                    point_5 = new Coordinate3();
                    notNaN_5 = false;
                    count--;
                }
                else if (notNaN_2 && point_5.AlmostEquals(point_2, tolerance))
                {
                    point_2 = point_2.GetCentroid(point_5);
                    point_5 = new Coordinate3();
                    notNaN_5 = false;
                    count--;
                }
                else if (notNaN_3 && point_5.AlmostEquals(point_3, tolerance))
                {
                    point_3 = point_3.GetCentroid(point_5);
                    point_5 = new Coordinate3();
                    notNaN_5 = false;
                    count--;
                }
                else if (notNaN_4 && point_5.AlmostEquals(point_4, tolerance))
                {
                    point_4 = point_4.GetCentroid(point_5);
                    point_5 = new Coordinate3();
                    notNaN_5 = false;
                    count--;
                }
            }

            Coordinate3 point_6 = line3Intersection_6.Point_1;
            if (notNaN_6)
            {
                if (notNaN_1 && point_6.AlmostEquals(point_1, tolerance))
                {
                    point_1 = point_1.GetCentroid(point_6);
                    point_6 = new Coordinate3();
                    notNaN_6 = false;
                    count--;
                }
                else if (notNaN_2 && point_6.AlmostEquals(point_2, tolerance))
                {
                    point_2 = point_2.GetCentroid(point_6);
                    point_6 = new Coordinate3();
                    notNaN_6 = false;
                    count--;
                }
                else if (notNaN_3 && point_6.AlmostEquals(point_3, tolerance))
                {
                    point_3 = point_3.GetCentroid(point_6);
                    point_6 = new Coordinate3();
                    notNaN_6 = false;
                    count--;
                }
                else if (notNaN_4 && point_6.AlmostEquals(point_4, tolerance))
                {
                    point_4 = point_4.GetCentroid(point_6);
                    point_6 = new Coordinate3();
                    notNaN_6 = false;
                    count--;
                }
                else if (notNaN_5 && point_6.AlmostEquals(point_5, tolerance))
                {
                    point_5 = point_5.GetCentroid(point_6);
                    point_6 = new Coordinate3();
                    notNaN_6 = false;
                    count--;
                }
            }

            if (count == 1)
            {
                Query.TryGetFirst(point_1, point_2, point_3, point_4, point_5, point_6, out Coordinate3 pointIntersection);

                return new Triangle3Intersection(solid, pointIntersection);
            }

            if (count == 2)
            {
                Query.TryGetFirst(point_1, point_2, point_3, point_4, point_5, point_6, out Coordinate3 pointIntersection_1);
                Query.TryGetFirst(point_6, point_5, point_4, point_3, point_2, point_1, out Coordinate3 pointIntersection_2);

                return new Triangle3Intersection(solid, pointIntersection_1, pointIntersection_2);
            }

            if (count == 3)
            {
                Query.TryGetFirst(point_1, point_2, point_3, point_4, point_5, point_6, out Coordinate3 pointIntersection_1);
                Query.TryGetFirst(point_6, point_5, point_4, point_3, point_2, point_1, out Coordinate3 pointIntersection_2);

                Coordinate3 pointIntersection_3 = point_2;
                if(pointIntersection_3.IsNaN())
                {
                    pointIntersection_3 = point_3;
                    if(pointIntersection_3.IsNaN())
                    {
                        pointIntersection_3 = point_4;
                        if (pointIntersection_3.IsNaN())
                        {
                            pointIntersection_3 = point_5;
                        }
                    }
                }

                return new Triangle3Intersection(solid, pointIntersection_1, pointIntersection_2, pointIntersection_3);
            }

            Query.Sort(triangle_1, triangle_2, point_1, point_2, point_3, point_4, point_5, point_6, out Coordinate3 result_1, out Coordinate3 result_2, out Coordinate3 result_3, out Coordinate3 result_4, out Coordinate3 result_5, out Coordinate3 result_6);

            return new Triangle3Intersection(solid, result_1, result_2, result_3, result_4, result_5, result_6);

        }
    }
}
