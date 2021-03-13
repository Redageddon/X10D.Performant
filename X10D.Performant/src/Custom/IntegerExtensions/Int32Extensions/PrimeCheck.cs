namespace X10D.Performant
{
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this int value, bool useCache = false) =>
            value switch
            {
                < 2              => false,
                < byte.MaxValue  => ((byte)value).IsPrime(),
                < short.MaxValue => ((short)value).IsPrime(useCache),
                _                => ((ulong)value).IsPrime(useCache),
            };
    }
}