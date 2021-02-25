using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="DateTime.Parse(ReadOnlySpan{char},IFormatProvider,DateTimeStyles)" />
        public static DateTime ToDateTime(
            this ReadOnlySpan<char> chars,
            IFormatProvider? formatProvider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.Parse(chars, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.Parse(ReadOnlySpan{char},IFormatProvider,DateTimeStyles)" />
        public static DateTime ToDateTime(
            this Span<char> chars,
            IFormatProvider? formatProvider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.Parse(chars, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(ReadOnlySpan{char},ReadOnlySpan{char},IFormatProvider,DateTimeStyles)" />
        public static DateTime ToDateTimeExact(
            this ReadOnlySpan<char> chars,
            ReadOnlySpan<char> format,
            IFormatProvider? formatProvider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(chars, format, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(ReadOnlySpan{char},ReadOnlySpan{char},IFormatProvider,DateTimeStyles)" />
        public static DateTime ToDateTimeExact(
            this Span<char> chars,
            ReadOnlySpan<char> format,
            IFormatProvider? formatProvider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(chars, format, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(ReadOnlySpan{char},string[],IFormatProvider,DateTimeStyles)" />
        public static DateTime ToDateTimeExact(
            this ReadOnlySpan<char> chars,
            string[] formats,
            IFormatProvider? formatProvider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(chars, formats, formatProvider ?? NumberFormatInfo.CurrentInfo, style);

        /// <inheritdoc cref="DateTime.ParseExact(ReadOnlySpan{char},string[],IFormatProvider,DateTimeStyles)" />
        public static DateTime ToDateTimeExact(
            this Span<char> chars,
            string[] formats,
            IFormatProvider? formatProvider,
            DateTimeStyles style = DateTimeStyles.None) =>
            DateTime.ParseExact(chars, formats, formatProvider ?? NumberFormatInfo.CurrentInfo, style);
    }
}