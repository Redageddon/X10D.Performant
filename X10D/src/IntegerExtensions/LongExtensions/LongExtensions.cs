using System;

namespace X10D.Performant.LongExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="long"/>.
    /// </summary>
    public static partial class LongExtensions
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

        /// <inheritdoc cref="BitConverter.GetBytes(long)"/>
        public static byte[] GetBytes(this long value) => BitConverter.GetBytes(value);

        /// <summary>
        ///     Determines if the <paramref name="value"/> is even.
        /// </summary>
        /// <param name="value">An integral value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is even, <see langword="false"/> otherwise.</returns>
        public static bool IsEven(this long value) => value % 2 == 0;

        /// <summary>
        ///     Determines if the <paramref name="value"/> is odd.
        /// </summary>
        /// <param name="value">An integral value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is odd, <see langword="false"/> otherwise.</returns>
        public static bool IsOdd(this long value) => value % 2 != 0;

        /// <summary>
        ///     Gets a <see cref="bool"/> value that represents this value.
        /// </summary>
        /// <param name="value">An integral value.</param>
        /// <returns><see langword="false"/> if <paramref name="value"/> is 0, <see langword="true"/> otherwise.</returns>
        public static bool ToBoolean(this long value) => value != 0;
        
        /// <summary>
        ///     Determines if the <paramref name="value"/> is a prime value.
        /// </summary>
        /// <param name="value">An integral value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is prime, <see langword="false"/> otherwise.</returns>
        public static bool IsPrime(this long value)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3: return true;
            }

            if (value % 2 == 0 ||
                value % 3 == 0)
            {
                return false;
            }

            if ((value + 1) % 6 != 0 &&
                (value - 1) % 6 != 0)
            {
                return false;
            }

            for (long i = 5; i * i <= value; i += 6)
            {
                if (value % i == 0 ||
                    value % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}