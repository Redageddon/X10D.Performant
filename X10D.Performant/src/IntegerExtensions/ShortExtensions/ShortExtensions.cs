using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="short"/>.
    /// </summary>
    public static partial class ShortExtensions
    {
        /// <inheritdoc cref="LongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this short timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="LongExtensions.IsEven"/>
        public static bool IsEven(this short value) => value % 2 == 0;

        /// <inheritdoc cref="LongExtensions.IsOdd"/>
        public static bool IsOdd(this short value) => value % 2 != 0;

        /// <inheritdoc cref="LongExtensions.ToBoolean"/>
        public static bool ToBoolean(this short value) => value != 0;
        
        /// <inheritdoc cref="ULongExtensions.IsPrime"/>
        public static bool IsPrime(this short value) => value >= 0 && ULongExtensions.IsPrime((ulong)value);
    }
}