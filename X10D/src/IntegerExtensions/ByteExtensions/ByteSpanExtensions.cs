using System;
using System.Text;

namespace X10D.Performant.ByteExtensions
{
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})"/>
        public static short ToShort(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})"/>
        public static short ToShort(this Span<byte> bytes) => BitConverter.ToInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})"/>
        public static int ToInt(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})"/>
        public static int ToInt(this Span<byte> bytes) => BitConverter.ToInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})"/>
        public static long ToLong(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt64(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})"/>
        public static long ToLong(this Span<byte> bytes) => BitConverter.ToInt64(bytes);
        
        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})"/>
        public static ushort ToUShort(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})"/>
        public static ushort ToUShort(this Span<byte> bytes) => BitConverter.ToUInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})"/>
        public static uint ToUInt(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})"/>
        public static uint ToUInt(this Span<byte> bytes) => BitConverter.ToUInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})"/>
        public static ulong ToULong(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt64(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})"/>
        public static ulong ToULong(this Span<byte> bytes) => BitConverter.ToUInt64(bytes);

        /// <inheritdoc cref="Encoding.GetString(ReadOnlySpan{byte})"/>
        public static string ToEncodedString(this ReadOnlySpan<byte> bytes, Encoding? encoding = null) =>
            (encoding ?? Encoding.UTF8).GetString(bytes);

        /// <inheritdoc cref="Encoding.GetString(ReadOnlySpan{byte})"/>
        public static string ToEncodedString(this Span<byte> bytes, Encoding? encoding = null) =>
            (encoding ?? Encoding.UTF8).GetString(bytes);
    }
}