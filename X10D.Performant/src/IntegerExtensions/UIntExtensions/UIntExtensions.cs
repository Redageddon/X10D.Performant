using System;

namespace X10D.Performant.UIntExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="uint"/>.
    /// </summary>
    public static partial class UIntExtensions
    {
        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this uint timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.IsEven"/>
        public static bool IsEven(this uint value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.IsOdd"/>
        public static bool IsOdd(this uint value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.ToBoolean"/>
        public static bool ToBoolean(this uint value) => value != 0;

        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.IsPrime"/>
        public static bool IsPrime(this uint value) => ULongExtensions.ULongExtensions.IsPrime(value);
    }
}