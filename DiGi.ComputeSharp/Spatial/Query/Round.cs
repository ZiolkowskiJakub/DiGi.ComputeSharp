namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static float Round(float value, float tolerance)
        {
            float scaled = value / tolerance;

            float roundedScaled = scaled >= 0 ? (int)(scaled + 0.5f) : (int)(scaled - 0.5f);

            return roundedScaled * tolerance;
        }
    }

}

