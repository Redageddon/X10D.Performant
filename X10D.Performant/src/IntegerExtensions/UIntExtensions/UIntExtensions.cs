using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="uint"/>.
    /// </summary>
    public static partial class UIntExtensions
    {
        /// <inheritdoc cref="ULongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this uint timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="ULongExtensions.IsEven"/>
        public static bool IsEven(this uint value) => value % 2 == 0;

        /// <inheritdoc cref="ULongExtensions.IsOdd"/>
        public static bool IsOdd(this uint value) => value % 2 != 0;

        /// <inheritdoc cref="ULongExtensions.ToBoolean"/>
        public static bool ToBoolean(this uint value) => value != 0;

        /// <inheritdoc cref="ULongExtensions.IsPrime"/>
        public static bool IsPrime(this uint value) => ULongExtensions.IsPrime(value);
    }
}