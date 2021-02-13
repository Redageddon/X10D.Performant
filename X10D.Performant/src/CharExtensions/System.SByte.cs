using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="SByte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static sbyte ToSByte(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            sbyte.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="SByte.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out sbyte)"/>
        public static bool TryToSByte(
            this ReadOnlySpan<char> value,
            out sbyte result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            sbyte.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}