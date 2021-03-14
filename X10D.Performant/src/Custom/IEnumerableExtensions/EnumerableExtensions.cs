using System;
using System.Collections;
using System.Collections.Generic;

namespace X10D.Performant.IEnumerableExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <include file='EnumerableExtensions.xml' path='members/member[@name="DistinctBy"]'/>
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

        /// <include file='EnumerableExtensions.xml' path='members/member[@name="LazyChunk"]'/>
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

            if (array != null
             && count > 0)
            {
                yield return array;
            }
        }
    }
}