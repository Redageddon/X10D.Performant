using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="decimal.TryParse(string,NumberStyles,IFormatProvider,out decimal)"/>
        public static decimal ToDecimal(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            decimal.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="decimal.TryParse(string,NumberStyles,IFormatProvider,out decimal)"/>
        public static bool TryToDouble(
            this string value,
            out decimal result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            decimal.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}