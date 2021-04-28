﻿using System;
using System.Collections.Generic;

namespace X10D.Performant.IEnumerableExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <include file='EnumerableExtensions.xml' path='members/member[@name="Consume"]'/>
        public static void Consume<TSource>(this IEnumerable<TSource> values)
        {
            using IEnumerator<TSource> enumerator = values.GetEnumerator();

            while (enumerator.MoveNext()) {}
        }

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

        /// <include file='EnumerableExtensions.xml' path='members/member[@name="ForEach0"]'/>
        public static IEnumerable<TSource> ForEach<TSource>(this IEnumerable<TSource> values, Action<TSource> action)
        {
            using IEnumerator<TSource> iterator = values.GetEnumerator();

            while (iterator.MoveNext())
            {
                action(iterator.Current);

                yield return iterator.Current;
            }
        }

        /// <include file='EnumerableExtensions.xml' path='members/member[@name="ForEach1"]'/>
        public static IEnumerable<TSource> ForEach<TSource>(this IEnumerable<TSource> values, Action action)
        {
            using IEnumerator<TSource> iterator = values.GetEnumerator();

            while (iterator.MoveNext())
            {
                action();

                yield return iterator.Current;
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

        /// <include file='EnumerableExtensions.xml' path='members/member[@name="SelectWhere"]'/>
        public static IEnumerable<TSource> SelectWhere<TSource>(this IEnumerable<TSource> values,
                                                                Func<TSource, TSource> selector,
                                                                Predicate<TSource> predicate)
        {
            foreach (TSource source in values)
            {
                if (predicate(source))
                {
                    yield return selector(source);
                }
            }
        }
    }
}