using System;
using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="DateTime.Parse(ReadOnlySpan{char},IFormatProvider,DateTimeStyles)"/>
        public static DateTime Parse(
            this ReadOnlySpan<char> value, 
            IFormatProvider? formatProvider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.Parse(value, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(ReadOnlySpan{char},ReadOnlySpan{char},IFormatProvider,DateTimeStyles)"/>
        public static DateTime ParseExact(
            this ReadOnlySpan<char> value,
            ReadOnlySpan<char> format,
            IFormatProvider? provider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(value, format, provider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(ReadOnlySpan{char},string[],IFormatProvider,DateTimeStyles)"/>
        public static DateTime ParseExact(
            this ReadOnlySpan<char> value,
            string[] formats,
            IFormatProvider? provider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(value, formats, provider ?? NumberFormatInfo.CurrentInfo, style);
    }
}