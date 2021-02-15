using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static partial class EnumerableExtensions
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
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
            this IEnumerable<TSource> values,
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
        ///     Returns an <see cref="IEnumerable{T}"/> of <see cref="IEnumerable{T}"/> of <typeparamref name="TSource"/> from <paramref name="values"/> split into
        ///     chunks of size
        ///     <paramref name="chunkSize"/>.
        /// </returns>
        public static IEnumerable<IList<TSource>> LazyChunk<TSource>(this IEnumerable<TSource> values, int chunkSize)
        {
            TSource[] source = values as TSource[] ?? values.ToArray();
            int chunks = source.Length / chunkSize;
            int leftOver = source.Length % chunkSize;
            int offset = 0;

            for (int i = 0; i < chunks; i++)
            {
                yield return new ArraySegment<TSource>(source, offset, chunkSize);
                offset += chunkSize;
            }

            if (leftOver > 0)
            {
                yield return new ArraySegment<TSource>(source, offset, leftOver);
            }
        }

        /// <summary>
        ///     Lazily generates a new random <see cref="IEnumerable{T}"/> by filling it with values found in <paramref name="values"/>.
        /// </summary>
        /// <param name="values">The values to pull.</param>
        /// <param name="count">The amount of items to be returned.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="TSource">Any type.</typeparam>
        /// <returns>An <see cref="IEnumerable{T}"/> containing <paramref name="count"/> values.</returns>
        public static IEnumerable<TSource> LazyRandom<TSource>(this IEnumerable<TSource> values, int count, Random? random = null)
        {
            random ??= RandomExtensions.Random;
            IList<TSource> array = values as IList<TSource> ?? values.ToArray();

            for (int i = 0; i < count; i++)
            {
                yield return array[random.Next(0, array.Count)];
            }
        }

        /// <summary>
        ///     Shuffles <paramref name="values"/>.
        /// </summary>
        /// <param name="values">The collection to shuffle.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="TSource">The collection type.</typeparam>
        /// <returns><paramref name="values"/> shuffled.</returns>
        public static IEnumerable<TSource> Shuffled<TSource>(this IEnumerable<TSource> values, Random? random = null)
        {
            List<TSource> list = new(values);
            list.Shuffle(random);

            return list;
        }
    }
}