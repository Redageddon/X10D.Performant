using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="short.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)" />
        public static short ToInt16(
            this ReadOnlySpan<char> chars,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            short.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="short.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)" />
        public static short ToInt16(this Span<char> chars, NumberStyles style = NumberStyles.Integer, IFormatProvider? formatProvider = null) =>
            short.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="short.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out short)" />
        public static bool TryToInt16(
            this ReadOnlySpan<char> chars,
            out short result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            short.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);

        /// <inheritdoc cref="short.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out short)" />
        public static bool TryToInt16(
            this Span<char> chars,
            out short result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            short.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}