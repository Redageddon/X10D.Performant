using System;

namespace X10D.Performant.SpanExtensions
{
    public static partial class SpanExtensions
    {
        /// <include file='SpanExtensions.xml' path='members/member[@name="RandomReadOnly"]'/>
        public static void Random<T>(this ReadOnlySpan<T> values, Span<T> buffer, Random? random = null)
        {
            random ??= RandomExtensions.RandomExtensions.Random;

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = values[random.Next(0, values.Length)];
            }
        }

        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static ReadOnlySpan<T> Shuffled<T>(this ReadOnlySpan<T> values, Random? random = null)
        {
            Span<T> writeableSpan = new(new T[values.Length]);
            values.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }
    }
}