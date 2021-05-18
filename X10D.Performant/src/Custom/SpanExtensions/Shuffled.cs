using System;

namespace X10D.Performant.SpanExtensions
{
    public static partial class SpanExtensions
    {
        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static ReadOnlySpan<T> Shuffled<T>(this ReadOnlySpan<T> values, Random? random = null) => ShuffledInternal(values, random);

        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static Span<T> Shuffled<T>(this Span<T> values, Random? random = null) => ShuffledInternal((ReadOnlySpan<T>)values, random);

        private static Span<T> ShuffledInternal<T>(ReadOnlySpan<T> values, Random? random)
        {
            Span<T> writeableSpan = new T[values.Length];
            values.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }
    }
}