namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        public static bool IsValid(float value)
        {
            return value + 1.0f > value;
        }
    }
}

