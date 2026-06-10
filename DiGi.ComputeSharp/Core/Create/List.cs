using ComputeSharp;

namespace DiGi.ComputeSharp.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Converts the contents of a <see cref="global::ComputeSharp.Resources.Buffer{T}"/> into a managed <see cref="List{T}"/>,
        /// optionally filtering elements based on the provided predicate.
        /// </summary>
        /// <typeparam name="T">The unmanaged type of the elements contained in the buffer.</typeparam>
        /// <param name="buffer">The source ComputeSharp buffer to convert.</param>
        /// <param name="func">An optional predicate used to determine whether an element should be included in the resulting list.</param>
        /// <returns>A list containing the elements from the buffer that satisfy the predicate, or <see langword="null"/> if the source buffer is null.</returns>
        public static List<T>? List<T>(this global::ComputeSharp.Resources.Buffer<T> buffer, Func<T?, bool>? func = null) where T : unmanaged
        {
            if (buffer == null)
            {
                return null;
            }

            int length = buffer.Length;
            if (length == 0)
            {
                return [];
            }

            T[] ts = new T[length];

            buffer.CopyTo(ts);

            List<T> result = [];
            for (int i = 0; i < length; i++)
            {
                T t = ts[i];
                if (func != null && !func.Invoke(t))
                {
                    continue;
                }

                result.Add(t);
            }

            return result;
        }
    }
}