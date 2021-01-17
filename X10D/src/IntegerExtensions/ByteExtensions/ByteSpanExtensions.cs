using System;
using System.Text;

namespace X10D.Performant.ByteExtensions
{
    public static partial class ByteExtensions
    {
        /// <summary>
        ///     Converts the ReadOnlySpan <see cref="byte"/> to an <see cref="short"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>An <see cref="short"/>.</returns>
        public static short BitsAsShort(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt16(bytes);

        /// <inheritdoc cref="BitsAsShort(ReadOnlySpan{byte})"/>
        public static short BitsAsShort(this Span<byte> bytes) => BitsAsShort((ReadOnlySpan<byte>)bytes);

        /// <summary>
        ///     Converts the ReadOnlySpan <see cref="byte"/> to an <see cref="int"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>An <see cref="int"/>.</returns>
        public static int BitsAsInt(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt32(bytes);

        /// <inheritdoc cref="BitsAsInt(ReadOnlySpan{byte})"/>
        public static int BitsAsInt(this Span<byte> bytes) => BitsAsInt((ReadOnlySpan<byte>)bytes);

        /// <summary>
        ///     Converts the IEnumerable <see cref="byte"/> to an <see cref="long"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>An <see cref="long"/>.</returns>
        public static long BitsAsLong(this ReadOnlySpan<byte> bytes) => BitConverter.ToInt64(bytes);

        /// <inheritdoc cref="BitsAsLong(ReadOnlySpan{byte})"/>
        public static long BitsAsLong(this Span<byte> bytes) => BitsAsLong((ReadOnlySpan<byte>)bytes);

        /// <summary>
        ///     Gets a <see cref="string"/> representing the value the ReadOnlySpan <see cref="byte"/> with <see cref="Encoding.UTF8"/> encoding.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>A <see cref="string"/>.</returns>
        public static string GetUtf8String(this ReadOnlySpan<byte> bytes) => Encoding.UTF8.GetString(bytes);

        /// <inheritdoc cref="GetUtf8String(ReadOnlySpan{byte})"/>
        public static string GetUtf8String(this Span<byte> bytes) => GetUtf8String((ReadOnlySpan<byte>)bytes);
    }
}