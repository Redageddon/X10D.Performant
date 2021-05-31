using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static ReadOnlySpan<T?> Shuffled<T>(this in ReadOnlySpan<T?> values, Random? random = null) => ShuffledInternal(values, random);

        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static Span<T?> Shuffled<T>(this in Span<T?> values, Random? random = null) => ShuffledInternal(values.AsReadOnly(), random);

        public static void Shuffled<T>(this in ReadOnlySpan<T?> values, ref Span<T?> buffer, Random? random = null)
        {
            values.CopyTo(buffer);
            buffer.Shuffle(random);
        }

        public static void Shuffled<T>(this in Span<T?> values, ref Span<T?> buffer, Random? random = null) =>
            Shuffled(values.AsReadOnly(), ref buffer, random);

        private static Span<T?> ShuffledInternal<T>(in ReadOnlySpan<T?> values, Random? random)
        {
            Span<T?> result = new T?[values.Length];
            Shuffled(values, ref result, random);

            return result;
        }
    }
}