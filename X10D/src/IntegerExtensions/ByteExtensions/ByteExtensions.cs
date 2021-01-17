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

        /// <summary>
        ///     Converts the <see cref="T:byte[]"/> to an <see cref="short"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>Returns an <see cref="short"/>.</returns>
        public static short BitsAsShort(this byte[] bytes) => BitConverter.ToInt16(bytes, 0);

        /// <summary>
        ///     Converts the <see cref="T:byte[]"/> to an <see cref="int"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>Returns an <see cref="int"/>.</returns>
        public static int BitsAsInt(this byte[] bytes) => BitConverter.ToInt32(bytes, 0);

        /// <summary>
        ///     Converts the <see cref="T:byte[]"/> to an <see cref="long"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>Returns an <see cref="long"/>.</returns>
        public static long BitsAsLong(this byte[] bytes) => BitConverter.ToInt64(bytes, 0);

        /// <summary>
        ///     Gets a <see cref="string"/> literally representing the raw values in the <see cref="T:byte[]"/>.
        /// </summary>
        /// <param name="bytes">The bytes to get.</param>
        /// <returns>Returns a <see cref="string"/>.</returns>
        public static string BitsAsString(this byte[] bytes) => BitConverter.ToString(bytes);

        /// <summary>
        ///     Gets a <see cref="string"/> representing the value the <see cref="T:byte[]"/> with <see cref="Encoding.UTF8"/> encoding.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>Returns a <see cref="string"/>.</returns>
        public static string GetUtf8String(this byte[] bytes) => Encoding.UTF8.GetString(bytes);
    }
}