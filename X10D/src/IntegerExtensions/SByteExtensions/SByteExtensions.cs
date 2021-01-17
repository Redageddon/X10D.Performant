using System;
using X10D.Performant.ULongExtensions;

namespace X10D.Performant.SByteExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="sbyte"/>.
    /// </summary>
    public static partial class SByteExtensions
    {
        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this ushort timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsEven"/>
        public static bool IsEven(this ushort value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsOdd"/>
        public static bool IsOdd(this ushort value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.ToBoolean"/>
        public static bool ToBoolean(this ushort value) => value != 0;

        /// <summary>
        ///     Converts the <see cref="T:byte[]"/> to a <see cref="ushort"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>An <see cref="ushort"/>.</returns>
        public static ushort BitsAsUShort(this byte[] bytes) => BitConverter.ToUInt16(bytes, 0);

        /// <summary>
        ///     Converts the <see cref="T:byte[]"/> to an <see cref="uint"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>An <see cref="uint"/>.</returns>
        public static uint BitsAsUInt(this byte[] bytes) => BitConverter.ToUInt32(bytes, 0);

        /// <summary>
        ///     Converts the <see cref="T:byte[]"/> to an <see cref="ulong"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>An <see cref="ulong"/>.</returns>
        public static ulong BitsAsULong(this byte[] bytes) => BitConverter.ToUInt64(bytes, 0);
        
        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsPrime"/>
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