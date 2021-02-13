using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="int"/>.
    /// </summary>
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this int timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this int value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this int value) => (value & 1) == 1;

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this int value) => value != 0;
        
        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this int value) => value >= 0 && UInt64Extensions.IsPrime((ulong)value);
        
        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Mod(this int value, int modulus) =>
            value < modulus
                ? value
                : value - (value / modulus * modulus);
    }
}