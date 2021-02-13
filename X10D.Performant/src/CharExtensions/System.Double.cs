using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Double.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static double ToDouble(
            this ReadOnlySpan<char> value,
            NumberStyles style = NumberStyles.Float | NumberStyles.AllowThousands,
            IFormatProvider? provider = null) =>
            double.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="Double.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out double)"/>
        public static bool TryToFloat(
            this ReadOnlySpan<char> value,
            out double result,
            NumberStyles style = NumberStyles.Float | NumberStyles.AllowThousands,
            IFormatProvider? provider = null) =>
            double.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}