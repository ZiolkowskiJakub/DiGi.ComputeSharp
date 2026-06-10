namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the absolute value of a specified number.
        /// </summary>
        /// <param name="value">The number to get the absolute value of.</param>
        /// <returns>The absolute value of the specified number.</returns>
        public static double Abs(double value)
        {
            return value < 0 ? -value : value;
        }
    }
}