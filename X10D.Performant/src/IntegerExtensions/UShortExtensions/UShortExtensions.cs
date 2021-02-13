using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="ushort"/>.
    /// </summary>
    public static partial class UShortExtensions
    {
        /// <inheritdoc cref="ULongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this ushort timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="ULongExtensions.IsEven"/>
        public static bool IsEven(this ushort value) => value % 2 == 0;

        /// <inheritdoc cref="ULongExtensions.IsOdd"/>
        public static bool IsOdd(this ushort value) => value % 2 != 0;

        /// <inheritdoc cref="ULongExtensions.ToBoolean"/>
        public static bool ToBoolean(this ushort value) => value != 0;
        
        /// <inheritdoc cref="ULongExtensions.IsPrime"/>
        public static bool IsPrime(this ushort value) => ULongExtensions.IsPrime(value);
    }
}