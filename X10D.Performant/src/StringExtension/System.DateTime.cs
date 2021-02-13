using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="DateTime.Parse(string,IFormatProvider)"/>
        public static DateTime Parse(this string value, IFormatProvider? provider = null, DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.Parse(value, provider ?? DateTimeFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(string,string,IFormatProvider,DateTimeStyles)"/>
        public static DateTime ParseExact(
            this string value,
            string format,
            IFormatProvider? provider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(value, format, provider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(string,string[],IFormatProvider,DateTimeStyles)"/>
        public static DateTime ParseExact(
            this string value,
            string[] formats,
            IFormatProvider? provider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(value, formats, provider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.TryParse(string,IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryParse(
            this string value,
            out DateTime result,
            IFormatProvider? provider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.TryParse(value, provider ?? NumberFormatInfo.CurrentInfo, style, out result);

        /// <inheritdoc cref="DateTime.TryParseExact(string,string,IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryParseExact(
            this string value,
            out DateTime result,
            string format,
            IFormatProvider? provider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.TryParseExact(value, format, provider ?? NumberFormatInfo.CurrentInfo, style, out result);

        /// <inheritdoc cref="DateTime.TryParseExact(string,string[],IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryParseExact(
            this string value,
            out DateTime result,
            string[] formats,
            IFormatProvider? provider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.TryParseExact(value, formats, provider ?? NumberFormatInfo.CurrentInfo, style, out result);
    }
}