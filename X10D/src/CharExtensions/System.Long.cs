using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Int64.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static long ToLong(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            long.Parse(value, styles, provider);
        
        /// <inheritdoc cref="Int64.TryParse(ReadOnlySpan{char},out long)"/>
        public static bool TryToLong(this ReadOnlySpan<char> value, out long result) =>
            long.TryParse(value, out result);
    }
}