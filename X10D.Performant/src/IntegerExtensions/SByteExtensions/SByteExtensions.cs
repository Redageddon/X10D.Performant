using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="sbyte"/>.
    /// </summary>
    public static partial class SByteExtensions
    {
        /// <inheritdoc cref="LongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this sbyte timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="LongExtensions.IsEven"/>
        public static bool IsEven(this sbyte value) => value % 2 == 0;

        /// <inheritdoc cref="LongExtensions.IsOdd"/>
        public static bool IsOdd(this sbyte value) => value % 2 != 0;

        /// <inheritdoc cref="LongExtensions.ToBoolean"/>
        public static bool ToBoolean(this sbyte value) => value != 0;

        /// <inheritdoc cref="ULongExtensions.IsPrime"/>
        public static bool IsPrime(this sbyte value)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3:
                case 5:
                case 7:
                case 11: return true;

                default:
                    return value % 2 != 0 &&
                           value % 3 != 0 &&
                           value % 5 != 0 &&
                           value % 7 != 0 &&
                           value % 11 != 0;
            }
        }
    }
}