using System;
using System.Collections.Generic;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static ReadOnlySpan<T?> Distinct<T>(this in ReadOnlySpan<T?> values, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed) =>
            DistinctInternal(values, comparer, cutOffLength);

        public static Span<T?> Distinct<T>(this in Span<T?> values, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed) =>
            DistinctInternal(values, comparer, cutOffLength);

        public static void Distinct<T>(this in ReadOnlySpan<T?> values, ref Span<T?> buffer, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed)
        {
            HashSet<T?> set = new(values.Length, comparer);
            int bufferIndex = 0;
            int valueIndex = 0;

            while (valueIndex < values.Length
                && bufferIndex < buffer.Length
                && bufferIndex != cutOffLength)
            {
                T? value = values[valueIndex];

                if (set.Add(value))
                {
                    buffer[bufferIndex++] = value;
                }

                valueIndex++;
            }

            buffer = buffer[..bufferIndex];
        }

        public static void Distinct<T>(this in Span<T?> values, ref Span<T?> buffer, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed) =>
            Distinct(values.AsReadOnly(), ref buffer, comparer, cutOffLength);

        private static Span<T?> DistinctInternal<T>(in ReadOnlySpan<T?> values, IEqualityComparer<T?>? comparer, int cutOffLength)
        {
            Span<T?> result = new T?[values.Length];
            Distinct(values, ref result, comparer, cutOffLength);

            return result;
        }
    }
}