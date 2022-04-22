/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

using X10D.Performant.Int64Extensions;

namespace X10D.Performant.Int32Extensions;

/// <summary>
///     Extension methods for <see cref="int"/>.
/// </summary>
public static partial class Int32Extensions
{
    /// <include file='Int32Extensions.g.xml' path='members/member[@name="FromUnixTimestamp"]'/>
    public static DateTime FromUnixTimestamp(this int timestamp, bool isMilliseconds = false) =>
        ((long)timestamp).FromUnixTimestamp(isMilliseconds);
}