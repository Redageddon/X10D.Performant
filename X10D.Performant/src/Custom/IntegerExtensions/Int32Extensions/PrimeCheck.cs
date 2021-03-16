using X10D.Performant.ByteExtensions;
using X10D.Performant.Int16Extensions;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.Int32Extensions
{
    public static partial class Int32Extensions
    {
        /// <include file='Int32Extensions.copy.xml' path='members/member[@name="IsPrime"]'/>
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