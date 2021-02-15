using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Span{T}"/>.
    /// </summary>
    public static partial class SpanExtensions
    {
        /// <inheritdoc cref="Random{T}(ReadOnlySpan{T},Span{T},Random?)"/>
        public static void Random<T>(this Span<T> values, Span<T> buffer, Random? random = null) => Random((ReadOnlySpan<T>)values, buffer, random);

        /// <summary>
        ///     Generates a new random <see cref="Span{T}"/> by filling it with values found in <see param="values"/>.
        /// </summary>
        /// <param name="values">The values being pulled.</param>
        /// <param name="count">The amount of items to be returned.</param>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        /// <returns>A <see cref="Span{T}"/> containing <paramref name="count"/> amount of <typeparamref name="T"/>.</returns>
        public static Span<T> Random<T>(this Span<T> values, int count, Random? random = null)
        {
            random ??= RandomExtensions.Random;
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
        /// <param name="values">The <see cref="Span{T}"/> to shuffle.</param>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        public static void Shuffle<T>(this Span<T> values, Random? random = null)
        {
            random ??= RandomExtensions.Random;

            int count = values.Length;

            while (count > 0)
            {
                int index = random.Next(count--);

                T temp = values[count];
                values[count] = values[index];
                values[index] = temp;
            }
        }

        /// <inheritdoc cref="Shuffled{T}(ReadOnlySpan{T},Random?)"/>
        public static Span<T> Shuffled<T>(this Span<T> values, Random? random = null)
        {
            Span<T> writeableSpan = new(new T[values.Length]);
            values.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }
    }
}