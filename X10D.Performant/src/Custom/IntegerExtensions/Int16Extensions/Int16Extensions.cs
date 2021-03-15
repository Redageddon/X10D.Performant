using System;
using X10D.Performant.Int64Extensions;

namespace X10D.Performant.Int16Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="short"/>.
    /// </summary>
    public static partial class Int16Extensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this short timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);
    }
}