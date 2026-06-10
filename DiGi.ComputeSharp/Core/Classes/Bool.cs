namespace DiGi.ComputeSharp.Core.Classes
{
    /// <summary>
    /// Represents a boolean value stored as an integer, typically used for compatibility with compute shaders or GPU buffers.
    /// </summary>
    public readonly struct Bool
    {
        /// <summary>
        /// The underlying integer representation of the boolean value, where 0 is false and 1 is true.
        /// </summary>
        public readonly int Value = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bool"/> struct using a standard boolean value.
        /// </summary>
        /// <param name="value">The boolean value to convert.</param>
        public Bool(bool value)
        {
            this.Value = value ? 1 : 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bool"/> struct using an integer value.
        /// </summary>
        /// <param name="value">The integer value to convert (1 is treated as true, all other values are false).</param>
        public Bool(int value)
        {
            this.Value = value == 1 ? 1 : 0;
        }

        //public static implicit operator Bool(bool value)
        //{
        //    return new Bool(value);
        //}

        //public static implicit operator bool(Bool value)
        //{
        //    return value.Value == 1;
        //}

        //public static implicit operator Bool(int value)
        //{
        //    return new Bool(value);
        //}

        //public static implicit operator int(Bool value)
        //{
        //    return value.Value == 1 ? 1 : 0;
        //}

        /// <summary>
        /// Converts the internal integer representation back to a standard C# boolean.
        /// </summary>
        /// <returns>True if the internal value is 1; otherwise, false.</returns>
        public bool ToBool()
        {
            return Value == 1;
        }

        /// <summary>
        /// Returns a string representation of the boolean value.
        /// </summary>
        /// <returns>The string "True" or "False".</returns>
        public override string ToString()
        {
            return ToBool().ToString();
        }
    }
}