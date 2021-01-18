using System;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Guid.Parse(ReadOnlySpan{char})"/>
        public static Guid ToGuid(this ReadOnlySpan<char> value) => Guid.Parse(value);

        /// <inheritdoc cref="Guid.ParseExact(ReadOnlySpan{char},ReadOnlySpan{char})"/>
        public static Guid ToGuid(this ReadOnlySpan<char> value, ReadOnlySpan<char> format) => Guid.ParseExact(value, format);

        /// <inheritdoc cref="Guid.TryParse(ReadOnlySpan{char},out Guid)"/>
        public static bool TryToGuid(this ReadOnlySpan<char> value, out Guid result) => Guid.TryParse(value, out result);

        /// <inheritdoc cref="Guid.TryParseExact(ReadOnlySpan{char},ReadOnlySpan{char},out Guid)"/>
        public static bool ToGuid(this ReadOnlySpan<char> value, ReadOnlySpan<char> format, out Guid result) =>
            Guid.TryParseExact(value, format, out result);
    }
}