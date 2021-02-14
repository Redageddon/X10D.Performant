using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="ulong.Parse(string,NumberStyles,IFormatProvider)" />
        public static ulong ToUInt64(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
            ulong.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="ulong.TryParse(string,NumberStyles,IFormatProvider,out ulong)" />
        public static bool TryToUInt64(
            this string value,
            out ulong result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            ulong.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}