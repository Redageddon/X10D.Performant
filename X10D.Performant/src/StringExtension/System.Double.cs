using System;
using System.Globalization;

namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="double.Parse(string,NumberStyles,IFormatProvider)"/>
        public static double ToDouble(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            double.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="double.TryParse(string,NumberStyles,IFormatProvider,out double)"/>
        public static bool TryToDouble(
            this string value,
            out double result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            double.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}