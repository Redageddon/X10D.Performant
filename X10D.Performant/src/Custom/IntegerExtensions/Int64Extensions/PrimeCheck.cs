using X10D.Performant.UInt16Extensions;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.Int64Extensions;

public static partial class Int64Extensions
{
    /// <include file='Int64Extensions.g.xml' path='members/member[@name="IsPrime"]'/>
    public static bool IsPrime(this long value, bool useCache = false) =>
        value switch
        {
            < 2               => false,
            < byte.MaxValue   => ((byte)value).IsPrime(),
            < ushort.MaxValue => ((ushort)value).IsPrime(useCache),
            _                 => ((ulong)value).IsPrime(useCache),
        };
}