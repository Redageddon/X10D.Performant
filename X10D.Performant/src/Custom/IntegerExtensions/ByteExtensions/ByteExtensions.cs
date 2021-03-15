using System;
using X10D.Performant.Int64Extensions;

namespace X10D.Performant.ByteExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="byte"/>.
    /// </summary>
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this byte timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);
    }
}