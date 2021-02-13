using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="int.Parse(string,NumberStyles,IFormatProvider)"/>
        public static int ToInt32(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            int.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="int.TryParse(string,NumberStyles,IFormatProvider,out int)"/>
        public static bool TryToInt32(
            this string value,
            out int result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            int.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}