using System;
using System.Text;

namespace X10D.Performant.ByteExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="byte"/>.
    /// </summary>
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this byte timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsEven"/>
        public static bool IsEven(this byte value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsOdd"/>
        public static bool IsOdd(this byte value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.ToBoolean"/>
        public static bool ToBoolean(this byte value) => value != 0;
        
        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsPrime"/>
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

        /// <inheritdoc cref="BitConverter.ToInt16(byte[],int)"/>
        public static short ToShort(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt16(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt32(byte[],int)"/>
        public static int ToInt(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt32(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt64(byte[],int)"/>
        public static long ToLong(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt64(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToString(byte[])"/>
        public static string ToSting(this byte[] bytes) => BitConverter.ToString(bytes);

        /// <inheritdoc cref="Encoding.GetString(byte[])"/>
        public static string ToEncodedString(this byte[] bytes, Encoding? encoding = null) => (encoding ?? Encoding.UTF8).GetString(bytes);
    }
}