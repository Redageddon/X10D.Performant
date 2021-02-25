using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Guid.Parse(ReadOnlySpan{char})" />
        public static Guid ToGuid(this ReadOnlySpan<char> chars) => Guid.Parse(chars);

        /// <inheritdoc cref="Guid.Parse(ReadOnlySpan{char})" />
        public static Guid ToGuid(this Span<char> chars) => Guid.Parse(chars);

        /// <inheritdoc cref="Guid.ParseExact(ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static Guid ToGuidExact(this ReadOnlySpan<char> chars, ReadOnlySpan<char> format) => Guid.ParseExact(chars, format);

        /// <inheritdoc cref="Guid.ParseExact(ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static Guid ToGuidExact(this Span<char> chars, ReadOnlySpan<char> format) => Guid.ParseExact(chars, format);

        /// <inheritdoc cref="Guid.TryParse(ReadOnlySpan{char},out Guid)" />
        public static bool TryToGuid(this ReadOnlySpan<char> chars, out Guid result) => Guid.TryParse(chars, out result);

        /// <inheritdoc cref="Guid.TryParse(ReadOnlySpan{char},out Guid)" />
        public static bool TryToGuid(this Span<char> chars, out Guid result) => Guid.TryParse(chars, out result);

        /// <inheritdoc cref="Guid.TryParseExact(ReadOnlySpan{char},ReadOnlySpan{char},out Guid)" />
        public static bool TryToGuidExact(this ReadOnlySpan<char> chars, ReadOnlySpan<char> format, out Guid result) =>
            Guid.TryParseExact(chars, format, out result);

        /// <inheritdoc cref="Guid.TryParseExact(ReadOnlySpan{char},ReadOnlySpan{char},out Guid)" />
        public static bool TryToGuidExact(this Span<char> chars, ReadOnlySpan<char> format, out Guid result) =>
            Guid.TryParseExact(chars, format, out result);
    }
}