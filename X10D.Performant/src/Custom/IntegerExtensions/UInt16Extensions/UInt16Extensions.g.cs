/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

using X10D.Performant.Int64Extensions;

namespace X10D.Performant.UInt16Extensions;

/// <summary>
///     Extension methods for <see cref="ushort"/>.
/// </summary>
public static partial class UInt16Extensions
{
    /// <include file='UInt16Extensions.g.xml' path='members/member[@name="FromUnixTimestamp"]'/>
    public static DateTime FromUnixTimestamp(this ushort timestamp, bool isMilliseconds = false) =>
        ((long)timestamp).FromUnixTimestamp(isMilliseconds);
}