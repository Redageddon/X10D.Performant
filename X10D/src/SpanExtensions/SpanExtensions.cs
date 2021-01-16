using System;

namespace X10D.Performant.SpanExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Span{T}"/>.
    /// </summary>
    public static class SpanExtensions
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

        /// <inheritdoc cref="Random{T}(ReadOnlySpan{T},Span{T},Random?)"/>
        public static void Random<T>(this Span<T> values, Span<T> buffer, Random? random = null) => Random((ReadOnlySpan<T>)values, buffer, random);

        /// <summary>
        ///     Generates a new random <see cref="Span{T}"/> by filling it with values found in <see param="values"/>.
        /// </summary>
        /// <param name="values">The values being pulled.</param>
        /// <param name="count">The amount of items to be returned.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        /// <returns>Returns a <see cref="Span{T}"/> containing <paramref name="count"/> amount of <typeparamref name="T"/>.</returns>
        public static Span<T> Random<T>(this Span<T> values, int count, Random? random = null)
        {
            random ??= RandomExtensions.RandomExtensions.Random;
            Span<T> buffer = new(new T[count]);

            for (int i = 0; i < count; i++)
            {
                buffer[i] = values[random.Next(0, values.Length)];
            }

            return buffer;
        }

        /// <summary>
        ///     Shuffles a <see cref="Span{T}"/>.
        /// </summary>
        /// <param name="source">The <see cref="Span{T}"/> to shuffle.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        public static void Shuffle<T>(this Span<T> source, Random? random = null)
        {
            random ??= RandomExtensions.RandomExtensions.Random;

            int count = source.Length;

            while (count > 0)
            {
                int index = random.Next(count--);

                T temp = source[count];
                source[count] = source[index];
                source[index] = temp;
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

        /// <inheritdoc cref="Shuffled{T}(ReadOnlySpan{T},Random?)"/>
        public static Span<T> Shuffled<T>(this Span<T> source, Random? random = null)
        {
            Span<T> writeableSpan = new(new T[source.Length]);
            source.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }
    }
}