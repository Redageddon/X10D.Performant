using System;
using System.Collections.Generic;
using System.Linq;
using X10D.Performant.IListExtensions;

namespace X10D.Performant.IEnumerableExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Splits <paramref name="values"/> into chunks of size <paramref name="chunkSize"/>.
        /// </summary>
        /// <param name="values">The values to chunk.</param>
        /// <param name="chunkSize">The maximum length of the nested <see cref="IEnumerable{T}"/> collection.</param>
        /// <typeparam name="T">Any type.</typeparam>
        /// <returns>
        ///     Returns an <see cref="IEnumerable{T}"/> of <see cref="IEnumerable{T}"/> of <typeparamref name="T"/> from <paramref name="values"/> split into chunks of size
        ///     <paramref name="chunkSize"/>.
        /// </returns>
        public static IEnumerable<IEnumerable<T>> LazyChunk<T>(this IEnumerable<T> values, int chunkSize)
        {
            T[] source = values as T[] ?? values.ToArray();
            int chunks = source.Length / chunkSize;
            int leftOver = source.Length % chunkSize;
            int offset = 0;

            for (int i = 0; i < chunks; i++)
            {
                yield return new ArraySegment<T>(source, offset, chunkSize);
                offset += chunkSize;
            }

            if (leftOver > 0)
            {
                yield return new ArraySegment<T>(source, offset, leftOver);
            }
        }

        /// <summary>
        ///     Lazily generates a new random <see cref="IEnumerable{T}"/> by filling it with values found in <paramref name="values"/>.
        /// </summary>
        /// <param name="values">The values to pull.</param>
        /// <param name="count">The amount of items to be returned.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        /// <returns>An <see cref="IEnumerable{T}"/> containing <paramref name="count"/> values.</returns>
        public static IEnumerable<T> LazyRandom<T>(this IEnumerable<T> values, int count, Random? random = null)
        {
            random ??= RandomExtensions.RandomExtensions.Random;
            IList<T> array = values as IList<T> ?? values.ToArray();

            for (int i = 0; i < count; i++)
            {
                yield return array[random.Next(0, array.Count)];
            }
        }

        /// <summary>
        ///     Shuffles <paramref name="source"/>.
        /// </summary>
        /// <param name="source">The collection to shuffle.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">The collection type.</typeparam>
        /// <returns><paramref name="source"/> shuffled.</returns>
        public static IEnumerable<T> Shuffled<T>(this IEnumerable<T> source, Random? random = null)
        {
            List<T> list = new(source);
            list.Shuffle(random);

            return list;
        }
    }
}