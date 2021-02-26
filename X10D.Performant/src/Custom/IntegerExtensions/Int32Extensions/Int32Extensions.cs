using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="int"/>.
    /// </summary>
    public static class Int32Extensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public static DateTime FromUnixTimestamp(this int timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this int value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this int value) => (value & 1) == 1;

        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        [CLSCompliant(false)]
        public static bool IsPrime(this int value) => value >= 0 && ((ulong)value).IsPrime();

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Mod(this int value, int modulus) =>
            value < modulus
                ? value
                : value - (value / modulus * modulus);

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this int value) => value != 0;
    }
}