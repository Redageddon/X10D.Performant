using System;
using X10D.Performant.Int64Extensions;

namespace X10D.Performant.Int32Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="int"/>.
    /// </summary>
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this int timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);
    }
}