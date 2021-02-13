using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="UInt16.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static ushort ToUInt16(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            ushort.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="UInt16.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out ushort)"/>
        public static bool TryToUInt16(
            this ReadOnlySpan<char> value,
            out ushort result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            ushort.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}