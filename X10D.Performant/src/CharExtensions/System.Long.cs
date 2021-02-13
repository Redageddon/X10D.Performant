using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Int64.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static long ToInt64(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            long.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="Int64.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out long)"/>
        public static bool TryToInt64(
            this ReadOnlySpan<char> value,
            out long result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            long.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}