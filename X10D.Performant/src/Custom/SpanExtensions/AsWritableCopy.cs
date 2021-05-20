using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static Span<T> AsWritableCopy<T>(this ReadOnlySpan<T> values)
        {
            Span<T> copy = new T[values.Length];
            values.CopyTo(copy);

            return copy;
        }
    }
}