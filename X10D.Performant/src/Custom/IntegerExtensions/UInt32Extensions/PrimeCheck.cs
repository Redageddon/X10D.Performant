using X10D.Performant.ByteExtensions;
using X10D.Performant.UInt16Extensions;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.UInt32Extensions
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