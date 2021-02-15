using System;

namespace X10D.Performant
{
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="BitConverter.ToInt16(byte[],int)"/>
        public static short ToInt16(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt16(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt32(byte[],int)"/>
        public static int ToInt32(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt32(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt64(byte[],int)"/>
        public static long ToInt64(this byte[] bytes, int startIndex = 0) => BitConverter.ToInt64(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToString(byte[],int)"/>
        public static string ToSting(this byte[] bytes, int startIndex = 0) => BitConverter.ToString(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt16(byte[],int)"/>
        [CLSCompliant(false)]
        public static ushort ToUInt16(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt16(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt32(byte[],int)"/>
        [CLSCompliant(false)]
        public static uint ToUInt32(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt32(bytes, startIndex);

        /// <inheritdoc cref="BitConverter.ToInt64(byte[],int)"/>
        [CLSCompliant(false)]
        public static ulong ToUInt64(this byte[] bytes, int startIndex = 0) => BitConverter.ToUInt64(bytes, startIndex);
    }
}