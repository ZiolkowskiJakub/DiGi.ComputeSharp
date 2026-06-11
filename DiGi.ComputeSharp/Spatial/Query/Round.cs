namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Rounds a double-precision floating-point number to the nearest multiple of the specified tolerance.
        /// </summary>
        /// <param name="value">The numeric value to round.</param>
        /// <param name="tolerance">The precision or step size used for rounding.</param>
        /// <returns>The rounded double-precision floating-point number.</returns>
        public static double Round(double value, double tolerance)
        {
            double scaled = value / tolerance;

            double roundedScaled = scaled >= 0 ? (int)(scaled + 0.5f) : (int)(scaled - 0.5f);

            return roundedScaled * tolerance;
        }
    }
}