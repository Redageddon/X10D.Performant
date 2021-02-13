using System;

namespace X10D.Performant
{
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="BitConverter.ToInt16(byte[],int)"/>
        public static short ToShort(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt16(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt32(byte[],int)"/>
        public static int ToInt(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt32(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt64(byte[],int)"/>
        public static long ToLong(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt64(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt16(byte[],int)"/>
        public static ushort ToUShort(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt16(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt32(byte[],int)"/>
        public static uint ToUInt(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt32(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt64(byte[],int)"/>
        public static ulong ToULong(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt64(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToString(byte[],int)"/>
        public static string ToSting(this byte[] bytes, int startIndex = 0) => BitConverter.ToString(bytes, startIndex);
    }
}