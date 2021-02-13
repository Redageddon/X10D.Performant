using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="byte.Parse(string,NumberStyles,IFormatProvider)"/>
        public static short ToByte(this string value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            byte.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="byte.TryParse(string,NumberStyles,IFormatProvider,out byte)"/>
        public static bool TryToByte(
            this string value,
            out byte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            byte.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}