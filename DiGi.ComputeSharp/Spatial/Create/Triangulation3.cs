using DiGi.ComputeSharp.Core.Classes;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {
        
        public static Triangulation3 Triangulation3(Triangle3 triangle, Coordinate3 point, double tolerance)
        {
            if(!triangle.InRange(point, tolerance))
            {
                return new Triangulation3();
            }

            if(!triangle.Inside(point, tolerance))
            {
                return new Triangulation3();
            }

            bool isSolid = triangle.Solid.ToBool();

            Line3 line = triangle.GetLine(0);
            if (line.On(point, tolerance))
            {
                if(line.Start.AlmostEquals(point, tolerance) || line.End.AlmostEquals(point, tolerance))
                {
                    return new Triangulation3(triangle);
                }

                return new Triangulation3(new Triangle3(point, triangle.Point_3, triangle.Point_1), new Triangle3(point, triangle.Point_2, triangle.Point_3));
            }

            line = triangle.GetLine(1);
            if (line.On(point, tolerance))
            {
                if (line.Start.AlmostEquals(point, tolerance) || line.End.AlmostEquals(point, tolerance))
                {
                    return new Triangulation3(triangle);
                }

                return new Triangulation3(new Triangle3(point, triangle.Point_1, triangle.Point_2), new Triangle3(point, triangle.Point_3, triangle.Point_1));
            }

            line = triangle.GetLine(2);
            if (line.On(point, tolerance))
            {
                if (line.Start.AlmostEquals(point, tolerance) || line.End.AlmostEquals(point, tolerance))
                {
                    return new Triangulation3(triangle);
                }

                return new Triangulation3(new Triangle3(point, triangle.Point_2, triangle.Point_3), new Triangle3(point, triangle.Point_1, triangle.Point_2));
            }

            return new Triangulation3(new Triangle3(triangle.Solid, triangle.Point_1, triangle.Point_2, point), new Triangle3(triangle.Solid, triangle.Point_2, triangle.Point_3, point), new Triangle3(triangle.Solid, triangle.Point_3, triangle.Point_1, point));
        }

        public static Triangulation3 Triangulation3(Triangle3 triangle, Line3 line, double tolerance)
        {
            if (!triangle.InRange(line, tolerance))
            {
                return new Triangulation3();
            }

            Line3Intersection lineIntersection = Line3Intersection(line, triangle, tolerance);
            if (lineIntersection.Point_1.IsNaN())
            {
                return new Triangulation3();
            }

            if (lineIntersection.Point_2.IsNaN())
            {
                return Triangulation3(triangle, lineIntersection.Point_1, tolerance);
            }

            Line3 line_1 = triangle.GetLine(0);
            Line3 line_2 = triangle.GetLine(1);
            Line3 line_3 = triangle.GetLine(2);

            bool on_1_1 = line_1.On(lineIntersection.Point_1, tolerance);
            bool on_2_1 = line_1.On(lineIntersection.Point_2, tolerance);
            if (on_1_1 && on_2_1)
            {
                return new Triangulation3(triangle);
            }

            bool on_1_2 = line_2.On(lineIntersection.Point_1, tolerance);
            bool on_2_2 = line_2.On(lineIntersection.Point_2, tolerance);
            if (on_1_2 && on_2_2)
            {
                return new Triangulation3(triangle);
            }

            bool on_1_3 = line_3.On(lineIntersection.Point_1, tolerance);
            bool on_2_3 = line_3.On(lineIntersection.Point_2, tolerance);
            if (on_1_2 && on_2_2)
            {
                return new Triangulation3(triangle);
            }

            bool isSolid = triangle.Solid.ToBool();

            if ((on_1_1 || on_1_2 || on_1_3) && (on_2_1 || on_2_2 || on_2_3))
            {
                if ((on_1_1 && on_1_2) || (on_2_1 && on_2_2))
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3));
                }

                if ((on_1_2 && on_1_3) || (on_2_2 && on_2_3))
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_2));
                }

                if ((on_1_1 && on_1_3) || (on_2_1 && on_2_3))
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3));
                }

                Triangle3 triangle_1_1 = new Triangle3();
                Triangle3 triangle_1_2 = new Triangle3();
                Triangle3 triangle_1_3 = new Triangle3();

                Triangle3 triangle_2_1 = new Triangle3();
                Triangle3 triangle_2_2 = new Triangle3();
                Triangle3 triangle_2_3 = new Triangle3();

                if (on_1_1 && on_2_2)
                {
                    triangle_1_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, lineIntersection.Point_2);
                    triangle_1_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3);
                    triangle_1_3 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, triangle.Point_1);

                    triangle_2_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_2, triangle.Point_2);
                    triangle_2_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, lineIntersection.Point_1);
                    triangle_2_3 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, triangle.Point_1);

                }
                else if (on_2_1 && on_1_2)
                {
                    triangle_1_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_2);
                    triangle_1_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, triangle.Point_1);
                    triangle_1_3 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, lineIntersection.Point_2);

                    triangle_2_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, lineIntersection.Point_1);
                    triangle_2_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_2, triangle.Point_3);
                    triangle_2_3 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, triangle.Point_1);
                }
                else if (on_1_2 && on_2_3)
                {
                    triangle_1_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, lineIntersection.Point_2);
                    triangle_1_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_1);
                    triangle_1_3 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, triangle.Point_2);

                    triangle_2_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_3);
                    triangle_2_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, triangle.Point_2);
                    triangle_2_3 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, lineIntersection.Point_1);
                }
                else if (on_2_2 && on_1_3)
                {
                    triangle_1_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3);
                    triangle_1_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, lineIntersection.Point_2);
                    triangle_1_3 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, lineIntersection.Point_2);

                    triangle_2_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, lineIntersection.Point_1);
                    triangle_2_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, triangle.Point_2);
                    triangle_2_3 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_1);

                }
                else if (on_1_3 && on_2_1)
                {
                    triangle_1_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, lineIntersection.Point_2);
                    triangle_1_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_2);
                    triangle_1_3 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, triangle.Point_3);

                    triangle_2_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_1);
                    triangle_2_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, lineIntersection.Point_1);
                    triangle_2_3 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_3);
                }
                else if (on_2_3 && on_1_1)
                {
                    triangle_1_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_1);
                    triangle_1_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, lineIntersection.Point_2);
                    triangle_1_3 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, triangle.Point_3);

                    triangle_2_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, lineIntersection.Point_1);
                    triangle_2_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_2);
                    triangle_2_3 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_3);
                }

                double factor_Temp;

                double factor_1 = triangle_1_2.GetEquilateralityFactor();
                factor_Temp = triangle_1_3.GetEquilateralityFactor();
                if (factor_1 > factor_Temp)
                {
                    factor_1 = factor_Temp;
                }

                double factor_2 = triangle_2_2.GetEquilateralityFactor();
                factor_Temp = triangle_2_3.GetEquilateralityFactor();
                if (factor_2 > factor_Temp)
                {
                    factor_2 = factor_Temp;
                }

                return factor_1 > factor_2 ? new Triangulation3(triangle_1_1, triangle_1_2, triangle_1_3) : new Triangulation3(triangle_2_1, triangle_2_2, triangle_2_3);
            }

            if (on_1_1 || on_1_2 || on_1_3)
            {
                if ((on_1_1 && on_1_2) || (on_1_2 && on_1_3) || (on_1_3 || on_1_1))
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, triangle.Point_1));
                }

                if (on_1_1)
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, lineIntersection.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, triangle.Point_1));
                }

                if (on_1_2)
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, lineIntersection.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, triangle.Point_3));
                }

                if (on_1_3)
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_3), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, lineIntersection.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_1));
                }

                return new Triangulation3();
            }

            if (on_2_1 || on_2_2 || on_2_3)
            {
                if ((on_2_1 && on_2_2) || (on_2_2 && on_2_3) || (on_2_3 || on_2_1))
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, triangle.Point_1));
                }

                if (on_2_1)
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_1), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, lineIntersection.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, triangle.Point_1));
                }

                if (on_2_2)
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, triangle.Point_1));
                }

                if (on_2_3)
                {
                    return new Triangulation3(new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, lineIntersection.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, triangle.Point_2), new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, triangle.Point_1));
                }

                return new Triangulation3();
            }

            Triangle3 triangle_1 = new Triangle3();
            Triangle3 triangle_2 = new Triangle3();
            Triangle3 triangle_3 = new Triangle3();
            Triangle3 triangle_4_1 = new Triangle3();
            Triangle3 triangle_4_2 = new Triangle3();
            Triangle3 triangle_5_1 = new Triangle3();
            Triangle3 triangle_5_2 = new Triangle3();

            Line3 line_1_Temp, line_2_Temp;
            Line3Intersection lineIntersection_Temp;


            line_1_Temp = new Line3(new Bool(true), lineIntersection.Point_1, triangle.Point_1);
            line_2_Temp = new Line3(new Bool(true), lineIntersection.Point_2, triangle.Point_2);

            lineIntersection_Temp = Line3Intersection(line_1_Temp, line_2_Temp, tolerance);
            if(!lineIntersection_Temp.IsNaN())
            {
                triangle_1 = new Triangle3(lineIntersection.Point_1, triangle.Point_3, triangle.Point_2);
                triangle_2 = new Triangle3(lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3);
                triangle_3 = new Triangle3(lineIntersection.Point_2, triangle.Point_1, triangle.Point_3);

                triangle_4_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_1);
                triangle_5_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_2);

                triangle_4_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, lineIntersection.Point_2);
                triangle_5_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, triangle.Point_1);

            }
            else
            {
                line_1_Temp = new Line3(new Bool(true), lineIntersection.Point_1, triangle.Point_2);
                line_2_Temp = new Line3(new Bool(true), lineIntersection.Point_2, triangle.Point_1);

                lineIntersection_Temp = Line3Intersection(line_1_Temp, line_2_Temp, tolerance);
                if (!lineIntersection_Temp.IsNaN())
                {
                    triangle_1 = new Triangle3(lineIntersection.Point_2, triangle.Point_3, triangle.Point_2);
                    triangle_2 = new Triangle3(lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_3);
                    triangle_3 = new Triangle3(lineIntersection.Point_1, triangle.Point_1, triangle.Point_3);

                    triangle_4_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_2, triangle.Point_1);
                    triangle_5_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_2);

                    triangle_4_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, lineIntersection.Point_1);
                    triangle_5_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, triangle.Point_1);
                }
                else
                {
                    line_1_Temp = new Line3(new Bool(true), lineIntersection.Point_1, triangle.Point_3);
                    line_2_Temp = new Line3(new Bool(true), lineIntersection.Point_2, triangle.Point_2);

                    lineIntersection_Temp = Line3Intersection(line_1_Temp, line_2_Temp, tolerance);
                    if (!lineIntersection_Temp.IsNaN())
                    {
                        triangle_1 = new Triangle3(lineIntersection.Point_2, triangle.Point_1, triangle.Point_3);
                        triangle_2 = new Triangle3(lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_1);
                        triangle_3 = new Triangle3(lineIntersection.Point_1, triangle.Point_2, triangle.Point_1);

                        triangle_4_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, triangle.Point_2);
                        triangle_5_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_3);

                        triangle_4_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_2, lineIntersection.Point_1);
                        triangle_5_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, triangle.Point_2);
                    }
                    else
                    {
                        line_1_Temp = new Line3(new Bool(true), lineIntersection.Point_1, triangle.Point_1);
                        line_2_Temp = new Line3(new Bool(true), lineIntersection.Point_2, triangle.Point_3);

                        lineIntersection_Temp = Line3Intersection(line_1_Temp, line_2_Temp, tolerance);
                        if (!lineIntersection_Temp.IsNaN())
                        {
                            triangle_1 = new Triangle3(lineIntersection.Point_2, triangle.Point_2, triangle.Point_1);
                            triangle_2 = new Triangle3(lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_2);
                            triangle_3 = new Triangle3(lineIntersection.Point_1, triangle.Point_3, triangle.Point_2);

                            triangle_4_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, triangle.Point_3);
                            triangle_5_1 = new Triangle3(triangle.Solid, lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_1);

                            triangle_4_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_3, lineIntersection.Point_1);
                            triangle_5_2 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, triangle.Point_3);
                        }
                        else
                        {
                            line_1_Temp = new Line3(new Bool(true), lineIntersection.Point_1, triangle.Point_3);
                            line_2_Temp = new Line3(new Bool(true), lineIntersection.Point_2, triangle.Point_1);

                            lineIntersection_Temp = Line3Intersection(line_1_Temp, line_2_Temp, tolerance);
                            if (!lineIntersection_Temp.IsNaN())
                            {
                                triangle_1 = new Triangle3(lineIntersection.Point_1, triangle.Point_2, triangle.Point_1);
                                triangle_2 = new Triangle3(lineIntersection.Point_1, lineIntersection.Point_2, triangle.Point_2);
                                triangle_3 = new Triangle3(lineIntersection.Point_2, triangle.Point_3, triangle.Point_2);

                                triangle_4_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, triangle.Point_1, triangle.Point_3);
                                triangle_5_1 = new Triangle3(triangle.Solid, lineIntersection.Point_2, lineIntersection.Point_1, triangle.Point_1);

                                triangle_4_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_3, lineIntersection.Point_2);
                                triangle_5_2 = new Triangle3(triangle.Solid, lineIntersection.Point_1, triangle.Point_1, triangle.Point_3);
                            }
                        }
                    }
                }
            }

            double factor_1_Temp = triangle_4_1.GetEquilateralityFactor();

            double factor_Temp_Temp = triangle_5_1.GetEquilateralityFactor();
            if (factor_1_Temp > factor_Temp_Temp)
            {
                factor_1_Temp = factor_Temp_Temp;
            }

            double factor_2_Temp = triangle_4_2.GetEquilateralityFactor();

            factor_Temp_Temp = triangle_5_2.GetEquilateralityFactor();
            if (factor_2_Temp > factor_Temp_Temp)
            {
                factor_2_Temp = factor_Temp_Temp;
            }

            if (factor_1_Temp > factor_2_Temp)
            {
                return new Triangulation3(triangle_1, triangle_2, triangle_3, triangle_4_1, triangle_5_1);
            }
            else
            {
                return new Triangulation3(triangle_1, triangle_2, triangle_3, triangle_4_2, triangle_5_2);
            }

        }
    }
}
