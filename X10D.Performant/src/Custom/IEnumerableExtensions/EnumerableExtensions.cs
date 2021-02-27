using System;
using System.Collections;
using System.Collections.Generic;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Gets each unique object from <paramref name="values"/> determined by <paramref name="selector"/> and compared with <see cref="Comparer{T}"/>
        ///     if
        ///     passed.
        /// </summary>
        /// <param name="values">The initial values being iterated through.</param>
        /// <param name="selector">The function that determines whether an element in <paramref name="values"/> should be returned.</param>
        /// <param name="comparer">Passes a generic <see cref="IEqualityComparer"/>.</param>
        /// <typeparam name="TSource">The type of the contained element in the <paramref name="values"/> being read from.</typeparam>
        /// <typeparam name="TKey">The type being selected distinctly from.</typeparam>
        /// <returns>A collection of values that are specific to a selector.</returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> values,
                                                                     Func<TSource, TKey> selector,
                                                                     IEqualityComparer<TKey>? comparer = null)
        {
            HashSet<TKey> knownKeys = new(comparer);

            foreach (TSource element in values)
            {
                if (knownKeys.Add(selector(element)))
                {
                    yield return element;
                }
            }
        }

        /// <summary>
        ///     Splits <paramref name="values"/> into chunks of size <paramref name="chunkSize"/>.
        /// </summary>
        /// <param name="values">The values to chunk.</param>
        /// <param name="chunkSize">The maximum length of the nested <see cref="IEnumerable{T}"/> collection.</param>
        /// <typeparam name="TSource">Any type.</typeparam>
        /// <returns>
        ///     Returns an <see cref="IEnumerable{T}"/> of <see cref="IEnumerable{T}"/> of <typeparamref name="TSource"/> from
        ///     <paramref name="values"/> split int chunks of size <paramref name="chunkSize"/>.
        /// </returns>
        public static IEnumerable<IEnumerable<TSource>> LazyChunk<TSource>(this IEnumerable<TSource> values, int chunkSize)
        {
            TSource[]? array = null;
            int count = 0;

            foreach (TSource item in values)
            {
                array ??= new TSource[chunkSize];

                array[count++] = item;

                if (count == chunkSize)
                {
                    yield return array;
                    array = null;
                    count = 0;
                }
            }

            if (array != null && count > 0)
            {
                yield return array;
            }
        }
    }
}