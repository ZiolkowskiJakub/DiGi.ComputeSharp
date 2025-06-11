using DiGi.ComputeSharp.Planar.Classes;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        internal static void Sort(Plane plane, ref Coordinate3 point_1, ref Coordinate3 point_2, ref Coordinate3 point_3, ref Coordinate3 point_4, ref Coordinate3 point_5, ref Coordinate3 point_6)
        {
            Coordinate2 point2D_1 = plane.Convert_Point(point_1), 
                point2D_2 = plane.Convert_Point(point_2), 
                point2D_3 = plane.Convert_Point(point_3), 
                point2D_4 = plane.Convert_Point(point_4), 
                point2D_5 = plane.Convert_Point(point_5), 
                point2D_6 = plane.Convert_Point(point_6);

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
    }

}

