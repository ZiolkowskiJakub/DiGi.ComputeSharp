namespace DiGi.ComputeSharp.Core.Constants
{
    /// <summary>
    /// Provides tolerance constants used for numerical comparisons and geometric calculations.
    /// </summary>
    public static class Tolerance
    {
        /// <summary>
        /// Distance tolerance.
        /// </summary>
        public const double Distance = 1e-6;

        /// <summary>
        /// Macro distance tolerance.
        /// </summary>
        public const double MacroDistance = 1e-3;

        /// <summary>
        /// Angle tolerance. Equivalent of 2 degrees
        /// </summary>
        public const double Angle = 0.0349066;
    }
}