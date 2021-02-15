using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="long.Parse(string,NumberStyles,IFormatProvider)" />
        public static long ToInt64(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
            long.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="long.TryParse(string,NumberStyles,IFormatProvider,out long)" />
        public static bool TryToInt64(
            this string value,
            out long result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            long.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}