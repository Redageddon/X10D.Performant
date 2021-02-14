﻿using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="long"/>.
    /// </summary>
    public static partial class Int64Extensions
    {
        /// <summary>
        ///     Converts the <paramref name="timestamp"/> to a <see cref="DateTime"/> treating it as a Unix timestamp.
        /// </summary>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="isMillis">
        ///     Whether or not the input value should be treated as milliseconds. Defaults to <see langword="false"/>.
        /// </param>
        /// <returns>A <see cref="DateTime"/> representing <paramref name="timestamp"/> seconds since the Unix epoch.</returns>
        public static DateTime FromUnixTimestamp(this long timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <summary>
        ///     Determines if the <paramref name="value"/> is even.
        /// </summary>
        /// <param name="value">An integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is even, <see langword="false"/> otherwise.</returns>
        public static bool IsEven(this long value) => (value & 1L) == 0L;

        /// <summary>
        ///     Determines if the <paramref name="value"/> is odd.
        /// </summary>
        /// <param name="value">An integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is odd, <see langword="false"/> otherwise.</returns>
        public static bool IsOdd(this long value) => (value & 1L) == 1L;

        /// <summary>
        ///     Gets a <see cref="bool"/> value that represents this value.
        /// </summary>
        /// <param name="value">An integer value.</param>
        /// <returns><see langword="false"/> if <paramref name="value"/> is 0, <see langword="true"/> otherwise.</returns>
        public static bool ToBoolean(this long value) => value != 0L;

        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this long value) => value >= 0L && ((ulong)value).IsPrime();

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static long Mod(this long value, long modulus) =>
            value < modulus
                ? value
                : value - (value / modulus * modulus);
    }
}