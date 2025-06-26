namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
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

