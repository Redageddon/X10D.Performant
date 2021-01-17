using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="UInt16.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static ushort ToUShort(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            ushort.Parse(value, styles, provider);
        
        /// <inheritdoc cref="UInt16.TryParse(ReadOnlySpan{char},out ushort)"/>
        public static bool TryToUShort(this ReadOnlySpan<char> value, out ushort result) =>
            ushort.TryParse(value, out result);
    }
}