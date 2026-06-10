namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified double-precision floating-point value is valid and finite.
        /// </summary>
        /// <param name="value">The double-precision floating-point number to validate.</param>
        /// <returns>True if the value is valid; otherwise, false.</returns>
        public static bool IsValid(double value)
        {
            return value + 1.0 > value;
        }
    }
}