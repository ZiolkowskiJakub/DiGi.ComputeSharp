namespace DiGi.ComputeSharp.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Gets the ComputeSharp default graphics device when the DiGi.ComputeSharp shaders can run on it.
        /// <para>Only a device passing <see cref="Query.IsSupported(global::ComputeSharp.GraphicsDevice?)"/> is returned: hardware-accelerated and supporting double precision.
        /// The WARP software device, which ComputeSharp returns as the default on a machine without a hardware adapter, is never returned.</para>
        /// <para>The returned device is shared by ComputeSharp and must not be disposed by the caller: disposing it resets ComputeSharp's default device cache
        /// and invalidates the device held by every other caller in the process (ZiolkowskiJakub/DiGi.ComputeSharp#2).</para>
        /// </summary>
        /// <returns>The ComputeSharp default device; <see langword="null"/> when no device can be created or the default device is not supported.</returns>
        public static global::ComputeSharp.GraphicsDevice? GraphicsDevice()
        {
            global::ComputeSharp.GraphicsDevice result;
            try
            {
                result = global::ComputeSharp.GraphicsDevice.GetDefault();
            }
            catch (NotSupportedException)
            {
                return null;
            }
            catch (InvalidOperationException)
            {
                return null;
            }

            if (!result.IsSupported())
            {
                return null;
            }

            return result;
        }
    }
}
