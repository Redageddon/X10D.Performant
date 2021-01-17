using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="System.Single.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static float ToFloat(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            float.Parse(value, styles, provider);
        
        /// <inheritdoc cref="System.Single.TryParse(ReadOnlySpan{char},out float)"/>
        public static bool TryToFloat(this ReadOnlySpan<char> value, out float result) =>
            float.TryParse(value, out result);
    }
}