using System;

namespace X10D.Performant.SpanExtensions
{
    public static partial class SpanExtensions
    {
        /// <include file='SpanExtensions.xml' path='members/member[@name="RandomReadOnly"]'/>
        public static void Random<T>(this Span<T> values, Span<T> buffer, Random? random = null) => Random((ReadOnlySpan<T>)values, buffer, random);

        /// <include file='SpanExtensions.xml' path='members/member[@name="RandomNew"]'/>
        public static Span<T> Random<T>(this Span<T> values, int count, Random? random = null)
        {
            Span<T> buffer = new T[count];
            Random((ReadOnlySpan<T>)values, buffer, random);

            return buffer;
        }

        /// <include file='SpanExtensions.xml' path='members/member[@name="RandomReadOnly"]'/>
        public static void Random<T>(this ReadOnlySpan<T> values, Span<T> buffer, Random? random = null)
        {
            random ??= RandomExtensions.RandomExtensions.Random;

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = values[random.Next(0, values.Length)];
            }
        }
    }
}