using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static ReadOnlySpan<T> Shuffled<T>(this ReadOnlySpan<T> values, Random? random = null) => ShuffledInternal(values, random);

        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static Span<T> Shuffled<T>(this Span<T> values, Random? random = null) => ShuffledInternal((ReadOnlySpan<T>)values, random);

        public static void Shuffled<T>(this ReadOnlySpan<T> values, ref Span<T> buffer, Random? random = null)
        {
            values.CopyTo(buffer);
            buffer.Shuffle(random);
        }

        public static void Shuffled<T>(this Span<T> values, ref Span<T> buffer, Random? random = null) =>
            Shuffled((ReadOnlySpan<T>)values, ref buffer, random);

        private static Span<T> ShuffledInternal<T>(ReadOnlySpan<T> values, Random? random)
        {
            Span<T> writeableSpan = new T[values.Length];
            Shuffled(values, ref writeableSpan, random);

            return writeableSpan;
        }
    }
}