using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="SByte.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        public static sbyte ToSByte(this ReadOnlySpan<char> value, NumberStyles styles, IFormatProvider provider) =>
            sbyte.Parse(value, styles, provider);
        
        /// <inheritdoc cref="SByte.TryParse(ReadOnlySpan{char},out sbyte)"/>
        public static bool TryToSByte(this ReadOnlySpan<char> value, out sbyte result) =>
            sbyte.TryParse(value, out result);
    }
}