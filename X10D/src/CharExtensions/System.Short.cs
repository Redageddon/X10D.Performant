using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Int16.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static short ToShort(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            short.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="Int16.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out short)"/>
        public static bool TryToShort(
            this ReadOnlySpan<char> value,
            out short result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            short.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}