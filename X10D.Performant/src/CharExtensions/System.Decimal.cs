using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="decimal.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static decimal ToDecimal(
            this ReadOnlySpan<char> chars,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            decimal.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="decimal.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static decimal ToDecimal(this Span<char> chars, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
            decimal.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="decimal.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out decimal)"/>
        public static bool TryToDecimal(
            ReadOnlySpan<char> chars,
            out decimal result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            decimal.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);

        /// <inheritdoc cref="decimal.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out decimal)"/>
        public static bool TryToDecimal(
            Span<char> chars,
            out decimal result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            decimal.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}