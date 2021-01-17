using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Double.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static double ToDouble(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            double.Parse(value, styles, provider);
        
        /// <inheritdoc cref="Double.TryParse(ReadOnlySpan{char},out double)"/>
        public static bool TryToFloat(this ReadOnlySpan<char> value, out double result) =>
            double.TryParse(value, out result);
    }
}