using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Int32.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static int ToInt(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            int.Parse(value, styles, provider);
        
        /// <inheritdoc cref="Int32.TryParse(ReadOnlySpan{char},out int)"/>
        public static bool TryToInt(this ReadOnlySpan<char> value, out int result) =>
            int.TryParse(value, out result);
    }
}