using System;

namespace X10D.Performant.UShortExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="ushort"/>.
    /// </summary>
    public static partial class UShortExtensions
    {
        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this ushort timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.IsEven"/>
        public static bool IsEven(this ushort value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.IsOdd"/>
        public static bool IsOdd(this ushort value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.ToBoolean"/>
        public static bool ToBoolean(this ushort value) => value != 0;
        
        /// <inheritdoc cref="X10D.Performant.ULongExtensions.ULongExtensions.IsPrime"/>
        public static bool IsPrime(this ushort value) => ULongExtensions.ULongExtensions.IsPrime(value);
    }
}