using System;
using System.Collections.Generic;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static string Concat(this ReadOnlySpan<char> chars, ReadOnlySpan<char> chars2) => string.Concat(chars, chars2);

        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static string Concat(this Span<char> chars, ReadOnlySpan<char> chars2) => string.Concat(chars, chars2);

        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static string Concat(this ReadOnlySpan<char> chars, ReadOnlySpan<char> chars2, ReadOnlySpan<char> chars3) =>
            string.Concat(chars, chars2, chars3);

        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static string Concat(this Span<char> chars, ReadOnlySpan<char> chars2, ReadOnlySpan<char> chars3) =>
            string.Concat(chars, chars2, chars3);

        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static string Concat(this ReadOnlySpan<char> chars, ReadOnlySpan<char> chars2, ReadOnlySpan<char> chars3, ReadOnlySpan<char> chars4) =>
            string.Concat(chars, chars2, chars3, chars4);

        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char})" />
        public static string Concat(this Span<char> chars, ReadOnlySpan<char> chars2, ReadOnlySpan<char> chars3, ReadOnlySpan<char> chars4) =>
            string.Concat(chars, chars2, chars3, chars4);

        /// <inheritdoc cref="string.GetHashCode(ReadOnlySpan{char})" />
        public static int GetHashCode(this ReadOnlySpan<char> value) => string.GetHashCode(value);

        /// <inheritdoc cref="string.GetHashCode(ReadOnlySpan{char})" />
        public static int GetHashCode(this Span<char> value) => string.GetHashCode(value);

        /// <inheritdoc cref="string.GetHashCode(ReadOnlySpan{char},StringComparison)" />
        public static int GetHashCode(this ReadOnlySpan<char> value, StringComparison comparisonType) => string.GetHashCode(value, comparisonType);

        /// <inheritdoc cref="string.GetHashCode(ReadOnlySpan{char},StringComparison)" />
        public static int GetHashCode(this Span<char> value, StringComparison comparisonType) => string.GetHashCode(value, comparisonType);

        /// <inheritdoc cref="string.Join{T}(char,IEnumerable{T})" />
        public static string Join<T>(this char separator, IEnumerable<T> values) => string.Join(separator, values);

        /// <inheritdoc cref="string.Join(char,object[])" />
        public static string Join(this char separator, params object?[] values) => string.Join(separator, values);

        /// <inheritdoc cref="string.Join(char,string[])" />
        public static string Join(this char separator, params string?[] strings) => string.Join(separator, strings);

        /// <inheritdoc cref="string.Join(char,string[],int,int)" />
        public static string Join(this char separator, string?[] strings, int startIndex, int count) =>
            string.Join(separator, strings, startIndex, count);
    }
}