namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
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

            if(value_4 == value)
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

