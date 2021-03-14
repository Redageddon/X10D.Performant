using System;

namespace X10D.Performant.SpanExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Span{T}"/>.
    /// </summary>
    public static partial class SpanExtensions
    {
        /// <inheritdoc cref="Random{T}(ReadOnlySpan{T},Span{T},Random)"/>
        public static void Random<T>(this Span<T> values, Span<T> buffer, Random? random = null) => Random((ReadOnlySpan<T>)values, buffer, random);

        /// <include file='SpanExtensions.xml' path='members/member[@name="RandomNew"]'/>
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

        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffle"]'/>
        public static void Shuffle<T>(this Span<T> values, Random? random = null)
        {
            random ??= RandomExtensions.RandomExtensions.Random;

            int count = values.Length;

            while (count > 0)
            {
                int index = random.Next(count--);

                T temp = values[count];
                values[count] = values[index];
                values[index] = temp;
            }
        }

        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static Span<T> Shuffled<T>(this Span<T> values, Random? random = null)
        {
            Span<T> writeableSpan = new(new T[values.Length]);
            values.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }
    }
}