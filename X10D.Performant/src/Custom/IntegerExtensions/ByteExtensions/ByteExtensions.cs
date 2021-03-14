using System;
using System.Runtime.CompilerServices;
using X10D.Performant.Int64Extensions;
using X10D.Performant.UInt64Extensions;

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

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static byte Mod(this byte value, byte modulus) =>
            value < modulus && value > 0
                ? value
                : (byte)(value - (value / modulus * modulus));
    }
}