using System;
using System.Runtime.CompilerServices;
using X10D.Performant.Int64Extensions;
using X10D.Performant.UInt64Extensions;

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

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static short Mod(this short value, short modulus) =>
            value < modulus && value > 0
                ? value
                : (short)(value - (value / modulus * modulus));
    }
}