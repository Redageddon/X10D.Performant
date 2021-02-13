using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="ulong.Parse(string,NumberStyles,IFormatProvider)"/>
        public static ulong ToULong(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            ulong.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="ulong.TryParse(string,NumberStyles,IFormatProvider,out ulong)"/>
        public static bool TryToULong(
            this string value,
            out ulong result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            ulong.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}