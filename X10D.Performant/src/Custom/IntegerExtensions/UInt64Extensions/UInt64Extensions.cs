using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="ulong"/>.
    /// </summary>
    [CLSCompliant(false)]
    public static partial class UInt64Extensions
    {
        /// <summary>
        ///     Converts the <paramref name="timestamp"/> to a <see cref="DateTime"/> treating it as a Unix timestamp.
        /// </summary>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="isMilliseconds">
        ///     Whether or not the input value should be treated as milliseconds. Defaults to <see langword="false"/>.
        /// </param>
        /// <returns>A <see cref="DateTime"/> representing <paramref name="timestamp"/> seconds since the Unix epoch.</returns>
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public static DateTime FromUnixTimestamp(this ulong timestamp, bool isMilliseconds = false) => ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <summary>
        ///     Determines if the <paramref name="value"/> is even.
        /// </summary>
        /// <param name="value">An unsigned integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is even, <see langword="false"/> otherwise.</returns>
        public static bool IsEven(this ulong value) => (value & 1UL) == 0UL;

        /// <summary>
        ///     Determines if the <paramref name="value"/> is odd.
        /// </summary>
        /// <param name="value">An unsigned integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is odd, <see langword="false"/> otherwise.</returns>
        public static bool IsOdd(this ulong value) => (value & 1UL) == 1UL;

        /// <summary>
        ///     Returns the remainder of <paramref name="value"/> / <paramref name="modulus"/>.
        /// </summary>
        /// <param name="value">The dividend.</param>
        /// <param name="modulus">The divisor.</param>
        /// <returns>The remainder of <paramref name="value"/> / <paramref name="modulus"/>.</returns>
        /// <remarks>
        ///     TODO https://github.com/dotnet/runtime/issues/5213:
        ///     Restore to using % and / when the JIT is able to eliminate one of the idivs.
        ///     In the meantime, a * and - is measurably faster than an extra /.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ulong Mod(this ulong value, ulong modulus) =>
            value < modulus
                ? value
                : value - (value / modulus * modulus);

        /// <summary>
        ///     Gets a <see cref="bool"/> value that represents this value.
        /// </summary>
        /// <param name="value">An unsigned integer value.</param>
        /// <returns><see langword="false"/> if <paramref name="value"/> is 0, <see langword="true"/> otherwise.</returns>
        public static bool ToBoolean(this ulong value) => value != 0UL;
    }
}