using System;
using System.Globalization;

namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="ushort.Parse(string,NumberStyles,IFormatProvider)"/>
        public static ushort ToUShort(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            ushort.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="ushort.TryParse(string,NumberStyles,IFormatProvider,out ushort)"/>
        public static bool TryToUShort(
            this string value,
            out ushort result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            ushort.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}