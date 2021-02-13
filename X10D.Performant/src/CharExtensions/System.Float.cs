using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Single.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static float ToFloat(
            this ReadOnlySpan<char> value,
            NumberStyles style = NumberStyles.Float | NumberStyles.AllowThousands,
            IFormatProvider? provider = null) =>
            float.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="Single.TryParse(ReadOnlySpan{char},out float)"/>
        public static bool TryToFloat(
            this ReadOnlySpan<char> value,
            out float result,
            NumberStyles style = NumberStyles.Float | NumberStyles.AllowThousands,
            IFormatProvider? provider = null) =>
            float.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}