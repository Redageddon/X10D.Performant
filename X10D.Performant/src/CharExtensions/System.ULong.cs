using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="UInt64.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static ulong ToULong(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            ulong.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="UInt64.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out ulong)"/>
        public static bool TryToULong(
            this ReadOnlySpan<char> value,
            out ulong result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            ulong.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}