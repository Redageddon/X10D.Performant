using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="UInt32.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static uint ToUInt(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            uint.Parse(value, styles, provider);
        
        /// <inheritdoc cref="UInt32.TryParse(ReadOnlySpan{char},out uint)"/>
        public static bool TryToUInt(this ReadOnlySpan<char> value, out uint result) =>
            uint.TryParse(value, out result);
    }
}