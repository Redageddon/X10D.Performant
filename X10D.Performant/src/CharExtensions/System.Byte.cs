using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Byte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static byte ToByte(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            byte.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="Byte.TryParse(ReadOnlySpan{char},out byte)"/>
        public static bool TryToByte(
            this ReadOnlySpan<char> value,
            out byte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            byte.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}