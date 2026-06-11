using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two vectors are oriented in the same half-space or direction within a specified tolerance.
        /// </summary>
        /// <param name="vector_1">The first coordinate vector to evaluate.</param>
        /// <param name="vector_2">The second coordinate vector to evaluate.</param>
        /// <param name="tolerance">The precision threshold used for the comparison.</param>
        /// <returns>True if the vectors are in the same half; otherwise, false.</returns>
        public static bool SameHalf(Coordinate3 vector_1, Coordinate3 vector_2, double tolerance)
        {
            if (vector_1.IsNaN() || vector_2.IsNaN())
            {
                return false;
            }

            // Dot product > 0 means angle < 90°
            double dotProduct = vector_1.GetNormalized(tolerance).DotProduct(vector_2.GetNormalized(tolerance));

            return dotProduct > 0 - tolerance;
        }
    }
}