using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="byte"/>.
    /// </summary>
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this byte timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this byte value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this byte value) => (value & 1) != 0;

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static byte Mod(this byte value, byte modulus) =>
            value < modulus && value > 0
                ? value
                : (byte)(value - (value / modulus * modulus));

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this byte value) => value != 0;
    }
}