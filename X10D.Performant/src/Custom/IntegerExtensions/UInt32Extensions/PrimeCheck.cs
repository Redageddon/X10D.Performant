using X10D.Performant.ByteExtensions;
using X10D.Performant.UInt16Extensions;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.UInt32Extensions;

public static partial class UInt32Extensions
{
    /// <include file='UInt32Extensions.copy.xml' path='members/member[@name="IsPrime"]'/>
    public static bool IsPrime(this uint value, bool useCache = false) =>
        value switch
        {
            < 2               => false,
            < byte.MaxValue   => ((byte)value).IsPrime(),
            < ushort.MaxValue => ((ushort)value).IsPrime(useCache),
            _                 => ((ulong)value).IsPrime(useCache),
        };
}