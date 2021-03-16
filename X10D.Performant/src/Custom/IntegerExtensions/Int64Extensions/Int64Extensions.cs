using System;

namespace X10D.Performant.Int64Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="long"/>.
    /// </summary>
    public static partial class Int64Extensions
    {
        /// <include file='Int64Extensions.copy.xml' path='members/member[@name="FromUnixTimestamp"]'/>
        public static DateTime FromUnixTimestamp(this long timestamp, bool isMilliseconds = false)
        {
            DateTimeOffset offset = isMilliseconds
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }
    }
}