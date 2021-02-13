using System;
using System.Text;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="byte"/>.
    /// </summary>
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="LongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this byte timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="LongExtensions.IsEven"/>
        public static bool IsEven(this byte value) => value % 2 == 0;

        /// <inheritdoc cref="LongExtensions.IsOdd"/>
        public static bool IsOdd(this byte value) => value % 2 != 0;

        /// <inheritdoc cref="LongExtensions.ToBoolean"/>
        public static bool ToBoolean(this byte value) => value != 0;
        
        /// <inheritdoc cref="LongExtensions.IsPrime"/>
        public static bool IsPrime(this byte value)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3:
                case 5:
                case 7:
                case 11:
                case 13: return true;

                default:
                    return value % 2 != 0 &&
                           value % 3 != 0 &&
                           value % 5 != 0 &&
                           value % 7 != 0 &&
                           value % 11 != 0 &&
                           value % 13 != 0;
            }
        }

        /// <inheritdoc cref="Encoding.GetString(byte[])"/>
        public static string ToEncodedString(this byte[] bytes, Encoding? encoding = null) => (encoding ?? Encoding.UTF8).GetString(bytes);
    }
}