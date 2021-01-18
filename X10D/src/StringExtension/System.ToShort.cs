using System;
using System.Globalization;

namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="short.Parse(string,NumberStyles,IFormatProvider)"/>
        public static short ToShort(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            short.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="short.TryParse(string,NumberStyles,IFormatProvider,out short)"/>
        public static bool TryToShort(
            this string value,
            out short result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            short.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}