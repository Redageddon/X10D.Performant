using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="byte.Parse(string,NumberStyles,IFormatProvider)" />
        public static short ToByte(this string value, NumberStyles style = NumberStyles.Integer, IFormatProvider? formatProvider = null) =>
            byte.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="byte.TryParse(string,NumberStyles,IFormatProvider,out byte)" />
        public static bool TryToByte(
            this string value,
            out byte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            byte.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}