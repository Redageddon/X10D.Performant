using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="sbyte.Parse(string,NumberStyles,IFormatProvider)"/>
        public static sbyte ToSByte(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            sbyte.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="sbyte.TryParse(string,NumberStyles,IFormatProvider,out sbyte)"/>
        public static bool TryToSByte(
            this string value,
            out sbyte result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            sbyte.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}