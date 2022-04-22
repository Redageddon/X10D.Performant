/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

using X10D.Performant.Int64Extensions;

namespace X10D.Performant.SByteExtensions;

/// <summary>
///     Extension methods for <see cref="sbyte"/>.
/// </summary>
public static partial class SByteExtensions
{
    /// <include file='SByteExtensions.g.xml' path='members/member[@name="FromUnixTimestamp"]'/>
    public static DateTime FromUnixTimestamp(this sbyte timestamp, bool isMilliseconds = false) =>
        ((long)timestamp).FromUnixTimestamp(isMilliseconds);
}