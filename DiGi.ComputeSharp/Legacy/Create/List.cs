using ComputeSharp;

namespace DiGi.ComputeSharp
{
    public static partial class Create
    {
        public static List<T> List<T>(this global::ComputeSharp.Resources.Buffer<T> buffer, Func<T, bool> func = null) where T : unmanaged
        {
            if(buffer == null)
            {
                return null;
            }

            int length = buffer.Length;
            if(length == 0)
            {
                return new List<T>();
            }

            T[] ts = new T[length];

            buffer.CopyTo(ts);

            List<T> result = new List<T>();
            for(int i=0; i < length; i++)
            {
                T t = ts[i];
                if(func != null && !func.Invoke(t))
                {
                    continue;
                }

                result.Add(t);
            }

            return result;
        }
    }
}
