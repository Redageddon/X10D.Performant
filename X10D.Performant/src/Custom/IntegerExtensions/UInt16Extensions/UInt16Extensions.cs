using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="ushort"/>.
    /// </summary>
    public static partial class UInt16Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this ushort timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <inheritdoc cref="UInt64Extensions.IsEven"/>
        public static bool IsEven(this ushort value) => (value & 1) == 0;

        /// <inheritdoc cref="UInt64Extensions.IsOdd"/>
        public static bool IsOdd(this ushort value) => (value & 1) != 0;

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ushort Mod(this ushort value, ushort modulus) =>
            value < modulus
                ? value
                : (ushort)(value - (value / modulus * modulus));

        /// <inheritdoc cref="UInt64Extensions.ToBoolean"/>
        public static bool ToBoolean(this ushort value) => value != 0;
    }
}