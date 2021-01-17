using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="UInt64.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static ulong ToULong(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            ulong.Parse(value, styles, provider);
        
        /// <inheritdoc cref="UInt64.TryParse(ReadOnlySpan{char},out ulong)"/>
        public static bool TryToULong(this ReadOnlySpan<char> value, out ulong result) =>
            ulong.TryParse(value, out result);
    }
}