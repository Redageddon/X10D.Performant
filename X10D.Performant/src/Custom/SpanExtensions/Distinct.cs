using System;
using System.Collections.Generic;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static ReadOnlySpan<T?> Distinct<T>(this ReadOnlySpan<T?> values, IEqualityComparer<T?>? comparer = null) =>
            DistinctInternal(values, comparer);

        public static Span<T?> Distinct<T>(this Span<T?> values, IEqualityComparer<T?>? comparer = null) =>
            DistinctInternal(values, comparer);

        public static void Distinct<T>(this ReadOnlySpan<T?> values, ref Span<T?> buffer, IEqualityComparer<T?>? comparer = null)
        {
            HashSet<T?> set = new(values.Length, comparer);
            int index = 0;

            foreach (T? value in values)
            {
                if (set.Add(value))
                {
                    buffer[index++] = value;
                }
            }

            buffer = buffer[..index];
        }

        public static void Distinct<T>(this Span<T?> values, ref Span<T?> buffer, IEqualityComparer<T?>? comparer = null) =>
            Distinct(values.AsReadOnly(), ref buffer, comparer);

        private static Span<T?> DistinctInternal<T>(ReadOnlySpan<T?> values, IEqualityComparer<T?>? comparer = null)
        {
            Span<T?> result = new T?[values.Length];
            Distinct(result.AsReadOnly(), ref result, comparer);

            return result;
        }
    }
}