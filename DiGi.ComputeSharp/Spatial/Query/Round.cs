namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        public static double Round(double value, double tolerance)
        {
            double scaled = value / tolerance;

            double roundedScaled = scaled >= 0 ? (int)(scaled + 0.5f) : (int)(scaled - 0.5f);

            return roundedScaled * tolerance;
        }
    }

}

