using System;

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

        /// <inheritdoc cref="BitConverter.ToUInt16(byte[],int)"/>
        public static ushort ToUShort(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt16(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToUInt32(byte[],int)"/>
        public static uint ToUInt(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt32(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToUInt64(byte[],int)"/>
        public static ulong ToULong(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt64(bytes, startIndex);
        
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