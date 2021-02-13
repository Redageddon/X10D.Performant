using System;
using System.Globalization;

namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="float.Parse(string,NumberStyles,IFormatProvider)"/>
        public static float ToFloat(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            float.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="float.TryParse(string,NumberStyles,IFormatProvider,out float)"/>
        public static bool TryToFloat(
            this string value,
            out float result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            float.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}