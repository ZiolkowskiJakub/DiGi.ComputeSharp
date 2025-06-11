namespace DiGi.ComputeSharp.Core.Classes
{
    public struct Bool
    {
        public readonly int Value = 0;

        public Bool(bool value)
        {
            this.Value = value ? 0 : 1;
        }

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

        public bool ToBool()
        {
            return Value == 1;
        }

        public override string ToString()
        {
            return ToBool().ToString();
        }
    }
}
