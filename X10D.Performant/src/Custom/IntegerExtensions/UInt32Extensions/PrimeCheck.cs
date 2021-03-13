namespace X10D.Performant
{
    public static partial class UInt32Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this uint value, bool useCache = false) =>
            value switch
            {
                < 2              => false,
                < byte.MaxValue  => ((byte)value).IsPrime(),
                < ushort.MaxValue => ((ushort)value).IsPrime(useCache),
                _                => ((ulong)value).IsPrime(useCache),
            };
    }
}