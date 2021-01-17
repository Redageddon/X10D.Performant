using System;

namespace X10D.Performant.SByteExtensions
{
    public static partial class SByteExtensions
    {
        /// <summary>
        ///     Converts the <see cref="ReadOnlySpan{T}"/> of  <see cref="byte"/> to a <see cref="ushort"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>Returns an <see cref="ushort"/>.</returns>
        [CLSCompliant(false)]
        public static ushort BitsAsUShort(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt16(bytes);

        /// <inheritdoc cref="BitsAsUShort(ReadOnlySpan{byte})"/>
        [CLSCompliant(false)]
        public static ushort BitsAsUShort(this Span<byte> bytes) => BitsAsUShort((ReadOnlySpan<byte>)bytes);

        /// <summary>
        ///     Converts the <see cref="ReadOnlySpan{T}"/> of  <see cref="byte"/> to an <see cref="uint"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>Returns an <see cref="uint"/>.</returns>
        [CLSCompliant(false)]
        public static uint BitsAsUInt(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt32(bytes);

        /// <inheritdoc cref="BitsAsUInt(ReadOnlySpan{byte})"/>
        [CLSCompliant(false)]
        public static uint BitsAsUInt(this Span<byte> bytes) => BitsAsUInt((ReadOnlySpan<byte>)bytes);

        /// <summary>
        ///     Converts the <see cref="ReadOnlySpan{T}"/> of  <see cref="byte"/> to an <see cref="ulong"/>.
        /// </summary>
        /// <param name="bytes">The bytes to convert.</param>
        /// <returns>Returns an <see cref="ulong"/>.</returns>
        [CLSCompliant(false)]
        public static ulong BitsAsULong(this ReadOnlySpan<byte> bytes) => BitConverter.ToUInt64(bytes);

        /// <inheritdoc cref="BitsAsULong(ReadOnlySpan{byte})"/>
        [CLSCompliant(false)]
        public static ulong BitsAsULong(this Span<byte> bytes) => BitsAsULong((ReadOnlySpan<byte>)bytes);
    }
}