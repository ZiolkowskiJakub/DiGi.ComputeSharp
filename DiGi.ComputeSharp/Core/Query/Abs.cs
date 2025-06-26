namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        public static double Abs(double value)
        {
            return value < 0 ? -value : value;
        }
    }
}

