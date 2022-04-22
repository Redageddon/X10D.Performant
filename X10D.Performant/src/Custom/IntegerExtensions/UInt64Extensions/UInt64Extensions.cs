using X10D.Performant.Int64Extensions;

namespace X10D.Performant.UInt64Extensions;

/// <summary>
///     Extension methods for <see cref="ulong"/>.
/// </summary>
public static partial class UInt64Extensions
{
    /// <include file='UInt64Extensions.xml' path='members/member[@name="FromUnixTimestamp"]'/>
    public static DateTime FromUnixTimestamp(this ulong timestamp, bool isMilliseconds = false) =>
        ((long)timestamp).FromUnixTimestamp(isMilliseconds);
}