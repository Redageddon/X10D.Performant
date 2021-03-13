namespace X10D.Performant
{
    public static partial class Int64Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this long value, bool useCache = false) =>
            value switch
            {
                < 2               => false,
                < byte.MaxValue   => ((byte)value).IsPrime(),
                < ushort.MaxValue => ((ushort)value).IsPrime(useCache),
                _                 => ((ulong)value).IsPrime(useCache),
            };
    }
}