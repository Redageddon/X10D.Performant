﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="Encoding.GetString(ReadOnlySpan{byte})" />
        public static string ToEncodedString(this ReadOnlySpan<byte> bytes, Encoding? encoding = null) =>
            (encoding ?? Encoding.UTF8).GetString(bytes);

        /// <inheritdoc cref="Encoding.GetString(ReadOnlySpan{byte})" />
        public static string ToEncodedString(this Span<byte> bytes, Encoding? encoding = null) => (encoding ?? Encoding.UTF8).GetString(bytes);

        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})" />
        public static short ToInt16(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})" />
        public static short ToInt16(this Span<byte> bytes) => BitConverter.ToInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})" />
        public static int ToInt32(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})" />
        public static int ToInt32(this Span<byte> bytes) => BitConverter.ToInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})" />
        public static long ToInt64(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt64(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})" />
        public static long ToInt64(this Span<byte> bytes) => BitConverter.ToInt64(bytes);

        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})" />
        [CLSCompliant(false)]
        public static ushort ToUInt16(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt16(ReadOnlySpan{byte})" />
        [CLSCompliant(false)]
        public static ushort ToUInt16(this Span<byte> bytes) => BitConverter.ToUInt16(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})" />
        [CLSCompliant(false)]
        public static uint ToUInt32(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt32(ReadOnlySpan{byte})" />
        [CLSCompliant(false)]
        public static uint ToUInt32(this Span<byte> bytes) => BitConverter.ToUInt32(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})" />
        [CLSCompliant(false)]
        public static ulong ToUInt64(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt64(bytes);

        /// <inheritdoc cref="BitConverter.ToInt64(ReadOnlySpan{byte})" />
        [CLSCompliant(false)]
        public static ulong ToUInt64(this Span<byte> bytes) => BitConverter.ToUInt64(bytes);
    }
}