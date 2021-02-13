using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="long.Parse(string,NumberStyles,IFormatProvider)"/>
        public static long ToInt64(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            long.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="long.TryParse(string,NumberStyles,IFormatProvider,out long)"/>
        public static bool TryToInt64(
            this string value,
            out long result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            long.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}