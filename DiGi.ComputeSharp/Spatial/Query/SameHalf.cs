using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static bool SameHalf(Coordinate3 vector_1, Coordinate3 vector_2, double tolerance)
        {
            if(vector_1.IsNaN() || vector_2.IsNaN())
            {
                return false;
            }

            // Dot product > 0 means angle < 90°
            double dotProduct = vector_1.GetNormalized(tolerance).DotProduct(vector_2.GetNormalized(tolerance));

            return dotProduct > 0 - tolerance;
        }
    }

}

