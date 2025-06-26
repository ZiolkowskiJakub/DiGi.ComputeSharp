using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Classes;
using System.Drawing;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        internal static void Sort_Old(Plane plane, ref Coordinate3 point_1, ref Coordinate3 point_2, ref Coordinate3 point_3, ref Coordinate3 point_4, ref Coordinate3 point_5, ref Coordinate3 point_6, float tolerance)
        {
            Coordinate2 point2D_1 = plane.Convert_Point(point_1, tolerance), 
                point2D_2 = plane.Convert_Point(point_2, tolerance), 
                point2D_3 = plane.Convert_Point(point_3, tolerance), 
                point2D_4 = plane.Convert_Point(point_4, tolerance), 
                point2D_5 = plane.Convert_Point(point_5, tolerance), 
                point2D_6 = plane.Convert_Point(point_6, tolerance);

            Coordinate2 centroid = Planar.Query.Centroid(point2D_1, point2D_2, point2D_3, point2D_4, point2D_5, point2D_6);

            Coordinate2 vector_1 = new Coordinate2(centroid, point2D_1), 
                vector_2 = new Coordinate2(centroid, point2D_2), 
                vector_3 = new Coordinate2(centroid, point2D_3), 
                vector_4 = new Coordinate2(centroid, point2D_4), 
                vector_5 = new Coordinate2(centroid, point2D_5), 
                vector_6 = new Coordinate2(centroid, point2D_6);

            int index_1 = 1, 
                index_2 = 2, 
                index_3 = 3, 
                index_4 = 4, 
                index_5 = 5, 
                index_6 = 6;

            Planar.Modify.SwapIfCrossProductNegative(ref index_1, ref index_2, vector_1, vector_2);
            Planar.Modify.SwapIfCrossProductNegative(ref index_1, ref index_3, vector_1, vector_3);
            Planar.Modify.SwapIfCrossProductNegative(ref index_1, ref index_4, vector_1, vector_4);
            Planar.Modify.SwapIfCrossProductNegative(ref index_1, ref index_5, vector_1, vector_5);
            Planar.Modify.SwapIfCrossProductNegative(ref index_1, ref index_6, vector_1, vector_6);

            Planar.Modify.SwapIfCrossProductNegative(ref index_2, ref index_3, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_2),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_3));
            Planar.Modify.SwapIfCrossProductNegative(ref index_2, ref index_4, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_2), 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_4));
            Planar.Modify.SwapIfCrossProductNegative(ref index_2, ref index_5, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_2), 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_5));
            Planar.Modify.SwapIfCrossProductNegative(ref index_2, ref index_6, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_2),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_6));

            Planar.Modify.SwapIfCrossProductNegative(ref index_3, ref index_4, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_3),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_4));
            Planar.Modify.SwapIfCrossProductNegative(ref index_3, ref index_5, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_3),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_5));
            Planar.Modify.SwapIfCrossProductNegative(ref index_3, ref index_6, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_3),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_6));

            Planar.Modify.SwapIfCrossProductNegative(ref index_4, ref index_5, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_4),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_5));
            Planar.Modify.SwapIfCrossProductNegative(ref index_4, ref index_6, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_4),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_6));

            Planar.Modify.SwapIfCrossProductNegative(ref index_5, ref index_6, 
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_5),
                Planar.Query.Coordinate2(ref vector_1, ref vector_2, ref vector_3, ref vector_4, ref vector_5, ref vector_6, index_6));

            Coordinate3 point_1_Temp = point_1,
                point_2_Temp = point_2,
                point_3_Temp = point_3,
                point_4_Temp = point_4,
                point_5_Temp = point_5,
                point_6_Temp = point_6;

            point_1 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_1);
            point_2 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_2);
            point_3 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_3);
            point_4 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_4);
            point_5 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_5);
            point_6 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_6);
        }

        internal static void Sort(Plane plane, ref Coordinate3 point_1, ref Coordinate3 point_2, ref Coordinate3 point_3, ref Coordinate3 point_4, ref Coordinate3 point_5, ref Coordinate3 point_6, float tolerance)
        {
            Coordinate2 point2D_1 = plane.Convert_Point(point_1, tolerance),
                point2D_2 = plane.Convert_Point(point_2, tolerance),
                point2D_3 = plane.Convert_Point(point_3, tolerance),
                point2D_4 = plane.Convert_Point(point_4, tolerance),
                point2D_5 = plane.Convert_Point(point_5, tolerance),
                point2D_6 = plane.Convert_Point(point_6, tolerance);

            Coordinate2 centroid = Planar.Query.Centroid(point2D_1, point2D_2, point2D_3, point2D_4, point2D_5, point2D_6);

            int index_1 = 1,
                index_2 = 2,
                index_3 = 3,
                index_4 = 4,
                index_5 = 5,
                index_6 = 6;



            Swap(centroid, ref point2D_1, ref point2D_2, ref index_1, ref index_2);
            Swap(centroid, ref point2D_1, ref point2D_3, ref index_1, ref index_3);
            Swap(centroid, ref point2D_1, ref point2D_4, ref index_1, ref index_4);
            Swap(centroid, ref point2D_1, ref point2D_5, ref index_1, ref index_5);
            Swap(centroid, ref point2D_1, ref point2D_6, ref index_1, ref index_6);

            Swap(centroid, ref point2D_2, ref point2D_3, ref index_2, ref index_3);
            Swap(centroid, ref point2D_2, ref point2D_4, ref index_2, ref index_4);
            Swap(centroid, ref point2D_2, ref point2D_5, ref index_2, ref index_5);
            Swap(centroid, ref point2D_2, ref point2D_6, ref index_2, ref index_6);

            Swap(centroid, ref point2D_3, ref point2D_4, ref index_3, ref index_4);
            Swap(centroid, ref point2D_3, ref point2D_5, ref index_3, ref index_5);
            Swap(centroid, ref point2D_3, ref point2D_6, ref index_3, ref index_6);

            Swap(centroid, ref point2D_4, ref point2D_5, ref index_4, ref index_5);
            Swap(centroid, ref point2D_4, ref point2D_6, ref index_4, ref index_6);

            Swap(centroid, ref point2D_5, ref point2D_6, ref index_5, ref index_6);

            Coordinate3 point_1_Temp = point_1,
                point_2_Temp = point_2,
                point_3_Temp = point_3,
                point_4_Temp = point_4,
                point_5_Temp = point_5,
                point_6_Temp = point_6;

            point_1 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_1);
            point_2 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_2);
            point_3 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_3);
            point_4 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_4);
            point_5 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_5);
            point_6 = Coordinate3(ref point_1_Temp, ref point_2_Temp, ref point_3_Temp, ref point_4_Temp, ref point_5_Temp, ref point_6_Temp, index_6);

        }

        internal static void Swap(Coordinate2 point, ref Coordinate2 point_1, ref Coordinate2 point_2, ref int index_1, ref int index_2)
        {
            if (CompareClockwise(point_1, point_2, point) >= 0)
            {
                return;
            }

            int index_Temp = index_1;
            index_1 = index_2;
            index_2 = index_Temp;

            Coordinate2 point_Temp = point_1;
            point_1 = point_2;
            point_2 = point_Temp;
        }

        internal static int CompareClockwise(Coordinate2 a, Coordinate2 b, Coordinate2 c)
        {
            float ax = a.X - c.X;
            float ay = a.Y - c.Y;
            float bx = b.X - c.X;
            float by = b.Y - c.Y;

            // Check which side of the vector b is with respect to a
            float cross = ax * by - ay * bx;

            if (cross < 0) return -1;  // a is clockwise from b
            if (cross > 0) return 1;   // a is counter-clockwise from b

            // If colinear, sort by distance to center (closer first)
            float da = ax * ax + ay * ay;
            float db = bx * bx + by * by;
            return da < db ? -1 : (da > db ? 1 : 0);
        }
    }

}

