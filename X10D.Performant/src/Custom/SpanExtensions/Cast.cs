using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static ReadOnlySpan<TResult?> Cast<T, TResult>(this in ReadOnlySpan<T?> values) => CastInternal<T?, TResult?>(values);

        public static Span<TResult?> Cast<T, TResult>(this in Span<T?> values) => CastInternal<T?, TResult?>(values);

        public static void Cast<T, TResult>(this in ReadOnlySpan<T?> values, ref Span<TResult?> buffer)
        {
            for (int i = 0; i < values.Length; i++)
            {
                buffer[i] = (TResult?)(object?)values[i];
            }
        }

        public static void Cast<T, TResult>(this in Span<T?> values, ref Span<TResult?> buffer) => Cast(values.AsReadOnly(), ref buffer);

        private static Span<TResult?> CastInternal<T, TResult>(in ReadOnlySpan<T?> values)
        {
            Span<TResult?> result = new TResult?[values.Length];
            Cast<T?, TResult?>(values, ref result);

            return result;
        }
    }
}