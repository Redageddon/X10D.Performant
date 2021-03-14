using System;
using System.Runtime.CompilerServices;
using X10D.Performant.Int64Extensions;
using X10D.Performant.UInt64Extensions;

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

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Mod(this int value, int modulus) =>
            value < modulus && value > 0
                ? value
                : value - (value / modulus * modulus);
    }
}