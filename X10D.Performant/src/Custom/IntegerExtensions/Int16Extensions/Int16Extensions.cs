using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="short"/>.
    /// </summary>
    public static class Int16Extensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public static DateTime FromUnixTimestamp(this short timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this short value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this short value) => (value & 1) == 1;

        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this short value) => value >= 0 && ((ulong)value).IsPrime();

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static short Mod(this short value, short modulus) =>
            value < modulus
                ? value
                : (short)(value - (value / modulus * modulus));

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this short value) => value != 0;
    }
}