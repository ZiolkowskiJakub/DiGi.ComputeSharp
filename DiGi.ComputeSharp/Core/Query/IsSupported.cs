namespace DiGi.ComputeSharp.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the DiGi.ComputeSharp shaders can run on the specified graphics device: the device must be hardware-accelerated and support double precision.
        /// <para>Every shader in this library requires double precision, which many GPUs (for example many arm64 GPUs) lack. The WARP software device is rejected even though it reports double precision as available:
        /// it loses shadows cast between buildings and needs about 16 minutes to create a shading pipeline (ZiolkowskiJakub/DiGi.Solar#10).</para>
        /// </summary>
        /// <param name="graphicsDevice">The graphics device to check.</param>
        /// <returns>True if the device is hardware-accelerated and supports double precision; otherwise, false (including for a null device).</returns>
        public static bool IsSupported(this global::ComputeSharp.GraphicsDevice? graphicsDevice)
        {
            if (graphicsDevice == null)
            {
                return false;
            }

            return graphicsDevice.IsHardwareAccelerated && graphicsDevice.IsDoublePrecisionSupportAvailable();
        }
    }
}
