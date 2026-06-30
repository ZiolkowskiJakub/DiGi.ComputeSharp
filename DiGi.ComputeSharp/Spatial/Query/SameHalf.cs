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

            // Same half-space when the angle is below ~90° (dot product positive within tolerance). The sign of
            // the dot product is independent of normalisation, so comparing squared quantities reproduces the
            // normalised "> -tolerance" test without the two square roots of GetNormalized.
            double dotProduct = vector_1.DotProduct(vector_2);
            if (dotProduct > 0)
            {
                return true;
            }

            double squaredThreshold = tolerance * tolerance * vector_1.GetSquaredLength() * vector_2.GetSquaredLength();

            return (dotProduct * dotProduct) < squaredThreshold;
        }
    }
}