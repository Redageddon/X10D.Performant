using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    /// <summary>
    ///     Extension methods for<see cref="IEnumerable{T}" />.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static class EnumerableExtensions
    {
        /// <inheritdoc cref="string.Concat{T}(IEnumerable{T})" />
        public static string Concat<T>(this IEnumerable<T> values) => string.Concat(values);

        /// <inheritdoc cref="string.Concat(IEnumerable{string})" />
        public static string Concat(this IEnumerable<string?> strings) => string.Concat(strings);
    }
}