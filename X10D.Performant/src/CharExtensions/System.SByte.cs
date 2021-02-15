using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="sbyte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)" />
        public static sbyte ToSByte(
            this ReadOnlySpan<char> chars,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            sbyte.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="sbyte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)" />
        public static sbyte ToSByte(this Span<char> chars, NumberStyles style = NumberStyles.Integer, IFormatProvider? formatProvider = null) =>
            sbyte.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="sbyte.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out sbyte)" />
        public static bool TryToSByte(
            this ReadOnlySpan<char> chars,
            out sbyte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            sbyte.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);

        /// <inheritdoc cref="sbyte.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out sbyte)" />
        public static bool TryToSByte(
            this Span<char> chars,
            out sbyte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            sbyte.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}