using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="byte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)" />
        public static byte ToByte(
            this ReadOnlySpan<char> readOnlySpan,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            byte.Parse(readOnlySpan, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="byte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)" />
        public static byte ToByte(this Span<char> readOnlySpan, NumberStyles style = NumberStyles.Integer, IFormatProvider? formatProvider = null) =>
            byte.Parse(readOnlySpan, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="byte.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out byte)" />
        public static bool TryToByte(
            this ReadOnlySpan<char> chars,
            out byte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            byte.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);

        /// <inheritdoc cref="byte.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out byte)" />
        public static bool TryToByte(
            this Span<char> chars,
            out byte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            byte.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}