using System;
using System.Collections.Generic;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char})"/>
        public static string Concat(this ReadOnlySpan<char> value, ReadOnlySpan<char> value2) => string.Concat(value, value2);

        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char})"/>
        public static string Concat(this ReadOnlySpan<char> value, ReadOnlySpan<char> value2, ReadOnlySpan<char> value3) =>
            string.Concat(value, value2, value3);

        /// <inheritdoc cref="string.Concat(ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char},ReadOnlySpan{char})"/>
        public static string Concat(this ReadOnlySpan<char> value, ReadOnlySpan<char> value2, ReadOnlySpan<char> value3, ReadOnlySpan<char> value4) =>
            string.Concat(value, value2, value3, value4);

        /// <inheritdoc cref="string.Join{T}(char,IEnumerable{T})"/>
        public static string Join<T>(this char separator, IEnumerable<T> values) => string.Join(separator, values);
        
        /// <inheritdoc cref="string.Join(char,object[])"/>
        public static string Join(this char separator, params object?[] values) => string.Join(separator, values);
        
        /// <inheritdoc cref="string.Join(char,string[])"/>
        public static string Join(this char separator, params string?[] values) => string.Join(separator, values);
        
        /// <inheritdoc cref="string.Join(char,string[],int,int)"/>
        public static string Join(this char separator, string?[] value, int startIndex, int count) => string.Join(separator, value, startIndex, count);

        /// <inheritdoc cref="string.GetHashCode(ReadOnlySpan{char})"/>
        public static int GetHashCode(this ReadOnlySpan<char> value) => string.GetHashCode(value);
        
        /// <inheritdoc cref="string.GetHashCode(ReadOnlySpan{char},StringComparison)"/>
        public static int GetHashCode(this ReadOnlySpan<char> value, StringComparison comparisonType) => string.GetHashCode(value, comparisonType);
    }
}