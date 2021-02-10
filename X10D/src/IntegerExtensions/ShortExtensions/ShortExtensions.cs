using System;

namespace X10D.Performant.ShortExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="short"/>.
    /// </summary>
    public static partial class ShortExtensions
    {
        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this short timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsEven"/>
        public static bool IsEven(this short value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsOdd"/>
        public static bool IsOdd(this short value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.ToBoolean"/>
        public static bool ToBoolean(this short value) => value != 0;
        
        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.IsPrime"/>
        public static bool IsPrime(this short value) => value >= 0 && ULongExtensions.ULongExtensions.IsPrime((ulong)value);
    }
}