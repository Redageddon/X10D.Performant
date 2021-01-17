using System;

namespace X10D.Performant.SpanExtensions
{
    public static partial class SpanExtensions
    {
        /// <summary>
        ///     Fills a buffer randomly with values found in <paramref name="buffer"/>.
        /// </summary>
        /// <param name="values">The values being pulled.</param>
        /// <param name="buffer">The buffer being filled.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        public static void Random<T>(this ReadOnlySpan<T> values, Span<T> buffer, Random? random = null)
        {
            random ??= RandomExtensions.RandomExtensions.Random;

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = values[random.Next(0, values.Length)];
            }
        }
        
        /// <summary>
        ///     Shuffles a <see cref="Span{T}"/>.
        /// </summary>
        /// <param name="source">The <see cref="Span{T}"/> to shuffle.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        public static ReadOnlySpan<T> Shuffled<T>(this ReadOnlySpan<T> source, Random? random = null)
        {
            Span<T> writeableSpan = new(new T[source.Length]);
            source.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }
    }
}