using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="DateTime.Parse(string,IFormatProvider,DateTimeStyles)"/>
        public static DateTime ToDateTime(this string value, IFormatProvider? formatProvider = null, DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.Parse(value, formatProvider ?? DateTimeFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(string,string,IFormatProvider,DateTimeStyles)"/>
        public static DateTime ToDateTimeExact(
            this string value,
            string format,
            IFormatProvider? formatProvider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(value, format, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(string,string[],IFormatProvider,DateTimeStyles)"/>
        public static DateTime ToDateTimeExact(
            this string value,
            string[] formats,
            IFormatProvider? formatProvider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(value, formats, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.TryParse(string,IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryToDateTime(
            this string value,
            out DateTime result,
            IFormatProvider? formatProvider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.TryParse(value, formatProvider ?? NumberFormatInfo.CurrentInfo, style, out result);

        /// <inheritdoc cref="DateTime.TryParseExact(string,string,IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryToDateTimeExact(
            this string value,
            out DateTime result,
            string format,
            IFormatProvider? formatProvider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.TryParseExact(value, format, formatProvider ?? NumberFormatInfo.CurrentInfo, style, out result);

        /// <inheritdoc cref="DateTime.TryParseExact(string,string[],IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryToDateTimeExact(
            this string value,
            out DateTime result,
            string[] formats,
            IFormatProvider? formatProvider = null,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.TryParseExact(value, formats, formatProvider ?? NumberFormatInfo.CurrentInfo, style, out result);
    }
}