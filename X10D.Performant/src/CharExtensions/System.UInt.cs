using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="UInt32.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static uint ToUInt(this ReadOnlySpan<char> value, NumberStyles style = NumberStyles.Integer, IFormatProvider? provider = null) =>
            uint.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="UInt32.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out uint)"/>
        public static bool TryToUInt(
            this ReadOnlySpan<char> value,
            out uint result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? provider = null) =>
            uint.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}