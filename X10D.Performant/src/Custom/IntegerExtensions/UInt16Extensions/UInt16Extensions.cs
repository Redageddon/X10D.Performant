using System;
using X10D.Performant.Int64Extensions;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.UInt16Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="ushort"/>.
    /// </summary>
    public static partial class UInt16Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this ushort timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);
    }
}