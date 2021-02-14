using System.Collections.Generic;

namespace X10D.Performant
{
    public static partial class EnumerableExtensions
    {
        /// <inheritdoc cref="string.Concat{T}(IEnumerable{T})" />
        public static string Concat<T>(this IEnumerable<T> values) => string.Concat(values);

        /// <inheritdoc cref="string.Concat(IEnumerable{string})" />
        public static string Concat(this IEnumerable<string?> strings) => string.Concat(strings);
    }
}