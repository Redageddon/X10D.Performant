using System;
using System.Collections.Generic;
using System.Linq;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static ReadOnlySpan<T?> Intersect<T>(this in ReadOnlySpan<T?> first, in ReadOnlySpan<T?> second, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed) =>
            IntersectInternal(first, second, comparer, cutOffLength);

        public static Span<T?> Intersect<T>(this in Span<T?> first, in ReadOnlySpan<T?> second, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed) =>
            IntersectInternal(first, second, comparer, cutOffLength);

        public static void Intersect<T>(this in ReadOnlySpan<T?> first, in ReadOnlySpan<T?> second, ref Span<T?> buffer, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed)
        {
            HashSet<T?> set = new(comparer);
            int bufferIndex = 0;
            int valueIndex = 0;

            foreach (T? item in second)
            {
                set.Add(item);
            }

            while (valueIndex < first.Length
                && bufferIndex < buffer.Length
                && bufferIndex != cutOffLength)
            {
                T? value = first[valueIndex];

                if (set.Remove(value))
                {
                    buffer[bufferIndex++] = value;
                }

                valueIndex++;
            }

            buffer = buffer[..bufferIndex];
        }

        public static void Intersect<T>(this in Span<T?> first, in ReadOnlySpan<T?> second, ref Span<T?> buffer, IEqualityComparer<T?>? comparer = null, int cutOffLength = NoValuePassed) =>
            Intersect(first.AsReadOnly(), second, ref buffer, comparer, cutOffLength);

        private static Span<T?> IntersectInternal<T>(in ReadOnlySpan<T?> first, in ReadOnlySpan<T?> second, IEqualityComparer<T?>? comparer, int cutOffLength)
        {
            Span<T?> result = new T?[Math.Min(first.Length, second.Length)];
            Intersect(first, second, ref result, comparer, cutOffLength);

            return result;
        }
    }
}