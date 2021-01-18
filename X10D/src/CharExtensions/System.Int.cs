using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Int32.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)" />
        public static int ToInt(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            int.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="Int32.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out int)" />
        public static bool TryToInt(
            this ReadOnlySpan<char> value,
            out int result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            int.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}