namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        public static float Sqrt(float value, float tolerance)
        {
            if (value < 0)
            {
                return float.NaN;
            }

            if (value == 0 || value == 1)
            {
                return value;
            }

            float result = value / 2f;
            while (Abs(result * result - value) > tolerance)
            {
                float temp = (result + value / result) / 2f;
                if(temp == result)
                {
                    break;
                }

                result = temp;
            }

            return result;
        }
    }

}

