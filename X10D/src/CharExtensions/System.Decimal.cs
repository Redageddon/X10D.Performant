using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Decimal.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static decimal ToDecimal(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            decimal.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="Decimal.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out decimal)"/>
        public static bool TryToDecimal(
            ReadOnlySpan<char> value,
            out decimal result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            decimal.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}