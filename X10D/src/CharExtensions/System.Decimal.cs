using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Decimal.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static decimal ToDecimal(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            decimal.Parse(value, styles, provider);
        
        /// <inheritdoc cref="Decimal.TryParse(ReadOnlySpan{char},out decimal)"/>
        public static bool TryToDecimal(this ReadOnlySpan<char> value, out decimal result) =>
            decimal.TryParse(value, out result);
    }
}