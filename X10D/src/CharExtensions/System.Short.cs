using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Int16.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static short ToShort(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            short.Parse(value, styles, provider);
        
        /// <inheritdoc cref="Int16.TryParse(ReadOnlySpan{char},out short)"/>
        public static bool TryToShort(this ReadOnlySpan<char> value, out short result) =>
            short.TryParse(value, out result);
    }
}