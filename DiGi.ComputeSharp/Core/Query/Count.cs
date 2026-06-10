namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Counts how many of the provided boolean values match a specified target value.
        /// </summary>
        /// <param name="value">The target boolean value to compare against.</param>
        /// <param name="value_1">The first boolean value to evaluate.</param>
        /// <param name="value_2">The second boolean value to evaluate.</param>
        /// <param name="value_3">The third boolean value to evaluate.</param>
        /// <param name="value_4">The fourth boolean value to evaluate.</param>
        /// <param name="value_5">The fifth boolean value to evaluate.</param>
        /// <param name="value_6">The sixth boolean value to evaluate.</param>
        /// <returns>The number of values among the six provided that are equal to the target value.</returns>
        public static int Count(bool value, bool value_1, bool value_2, bool value_3, bool value_4, bool value_5, bool value_6)
        {
            int result = 0;
            if (value_1 == value)
            {
                result++;
            }

            if (value_2 == value)
            {
                result++;
            }

            if (value_3 == value)
            {
                result++;
            }

            if (value_4 == value)
            {
                result++;
            }

            if (value_5 == value)
            {
                result++;
            }

            if (value_6 == value)
            {
                result++;
            }

            return result;
        }
    }
}