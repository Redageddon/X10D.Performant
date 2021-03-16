using System;
using X10D.Performant.Int64Extensions;

namespace X10D.Performant.Int32Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="int"/>.
    /// </summary>
    public static partial class Int32Extensions
    {
        /// <include file='Int32Extensions.copy.xml' path='members/member[@name="FromUnixTimestamp"]'/>
        public static DateTime FromUnixTimestamp(this int timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);
    }
}