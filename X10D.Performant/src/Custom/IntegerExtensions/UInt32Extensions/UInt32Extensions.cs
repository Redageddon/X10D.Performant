using System;
using System.Runtime.CompilerServices;
using X10D.Performant.Int64Extensions;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.UInt32Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="uint"/>.
    /// </summary>
    public static partial class UInt32Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this uint timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint Mod(this uint value, uint modulus) =>
            value < modulus
                ? value
                : value - (value / modulus * modulus);
    }
}