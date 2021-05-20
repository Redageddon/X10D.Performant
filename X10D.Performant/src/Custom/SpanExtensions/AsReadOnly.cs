using System;

namespace X10D.Performant.SpanExtensions
{
    public static partial class SpanExtensions
    {
        /// <summary>
        ///     Converts a <see cref="Span{T}"/> to a <see cref="ReadOnlySpan{T}"/> in a more explicit way.
        /// </summary>
        /// <param name="values">The initial values.</param>
        /// <typeparam name="T">Any type.</typeparam>
        /// <returns>A read only version of <paramref name="values"/>.</returns>
        public static ReadOnlySpan<T> AsReadOnly<T>(this Span<T> values) => values;
    }
}