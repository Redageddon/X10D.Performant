using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="System.Byte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static byte ToByte(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            byte.Parse(value, styles, provider);
        
        /// <inheritdoc cref="System.Byte.TryParse(ReadOnlySpan{char},out byte)"/>
        public static bool TryToByte(this ReadOnlySpan<char> value, out byte result) =>
            byte.TryParse(value, out result);
    }
}