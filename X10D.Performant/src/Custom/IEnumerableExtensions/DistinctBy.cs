using System;
using System.Collections.Generic;

namespace X10D.Performant.IEnumerableExtensions
{
    public static partial class EnumerableExtensions
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
    }
}