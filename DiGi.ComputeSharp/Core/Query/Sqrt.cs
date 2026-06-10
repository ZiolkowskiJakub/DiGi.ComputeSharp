namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the square root of a specified value using an iterative approximation method until the result is within the given tolerance.
        /// </summary>
        /// <param name="value">The number to calculate the square root of.</param>
        /// <param name="tolerance">The maximum allowable difference between the squared result and the original value for convergence.</param>
        /// <returns>The approximate square root of the value, or <see cref="double.NaN"/> if the value is negative.</returns>
        public static double Sqrt(double value, double tolerance)
        {
            if (value < 0)
            {
                return double.NaN;
            }

            if (value == 0 || value == 1)
            {
                return value;
            }

            double result = value / 2f;
            while (Abs(result * result - value) > tolerance)
            {
                double temp = (result + value / result) / 2f;
                if (temp == result)
                {
                    break;
                }

                result = temp;
            }

            return result;
        }
    }
}