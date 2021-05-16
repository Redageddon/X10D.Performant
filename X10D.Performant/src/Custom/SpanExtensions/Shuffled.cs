using System;

namespace X10D.Performant.SpanExtensions
{
    public static partial class SpanExtensions
    {
        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static ReadOnlySpan<T> Shuffled<T>(this ReadOnlySpan<T> values, Random? random = null)
        {
            Span<T> writeableSpan = new T[values.Length];
            values.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }

        /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffled"]'/>
        public static Span<T> Shuffled<T>(this Span<T> values, Random? random = null)
        {
            Span<T> writeableSpan = new T[values.Length];
            values.CopyTo(writeableSpan);
            writeableSpan.Shuffle(random);

            return writeableSpan;
        }
    }
}