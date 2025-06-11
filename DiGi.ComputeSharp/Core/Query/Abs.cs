namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        public static float Abs(float value)
        {
            return value < 0 ? -value : value;
        }
    }
}

