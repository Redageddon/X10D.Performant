using System;

namespace X10D.Performant.ULongExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="ulong"/>.
    /// </summary>
    public static partial class ULongExtensions
    {
        /// <summary>
        ///     Converts the <paramref name="timestamp"/> to a <see cref="DateTime"/> treating it as a Unix timestamp.
        /// </summary>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="isMillis">
        ///     Whether or not the input value should be treated as milliseconds. Defaults to <see langword="false"/>.
        /// </param>
        /// <returns>A <see cref="DateTime"/> representing <paramref name="timestamp"/> seconds since the Unix epoch.</returns>
        public static DateTime FromUnixTimestamp(this ulong timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds((long)timestamp)
                : DateTimeOffset.FromUnixTimeSeconds((long)timestamp);

            return offset.DateTime;
        }

        /// <summary>
        ///     Determines if the <paramref name="value"/> is even.
        /// </summary>
        /// <param name="value">An unsigned integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is even, <see langword="false"/> otherwise.</returns>
        public static bool IsEven(this ulong value) => value % 2 == 0;

        /// <summary>
        ///     Determines if the <paramref name="value"/> is odd.
        /// </summary>
        /// <param name="value">An unsigned integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is odd, <see langword="false"/> otherwise.</returns>
        public static bool IsOdd(this ulong value) => value % 2 != 0;

        /// <summary>
        ///     Gets a <see cref="bool"/> value that represents this value.
        /// </summary>
        /// <param name="value">An unsigned integer value.</param>
        /// <returns><see langword="false"/> if <paramref name="value"/> is 0, <see langword="true"/> otherwise.</returns>
        public static bool ToBoolean(this ulong value) => value != 0;
    }
}