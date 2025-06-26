namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        public static bool IsValid(double value)
        {
            return value + 1.0 > value;
        }
    }
}

