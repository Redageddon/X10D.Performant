using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    public static partial class SpanExtensions
    {
        public static ReadOnlySpan<T?> Where<T>(this ReadOnlySpan<T?> values, Predicate<T?> predicate, int cutOffLength = NoValuePassed) =>
            WhereInternal(values, predicate, cutOffLength);

        public static Span<T?> Where<T>(this Span<T?> values, Predicate<T?> predicate, int cutOffLength = NoValuePassed) =>
            WhereInternal(values, predicate, cutOffLength);

        public static void Where<T>(this ReadOnlySpan<T?> values, Predicate<T?> predicate, ref Span<T?> buffer, int cutOffLength = NoValuePassed)
        {
            int bufferIndex = 0;
            int valueIndex = 0;

            while (valueIndex < values.Length
                && bufferIndex < buffer.Length
                && bufferIndex != cutOffLength)
            {
                T? current = values[valueIndex];

                if (predicate(current))
                {
                    buffer[bufferIndex++] = current;
                }

                valueIndex++;
            }

            buffer = buffer[..bufferIndex];
        }

        public static void Where<T>(this Span<T?> values, Predicate<T?> predicate, ref Span<T?> buffer, int cutOffLength = NoValuePassed) =>
            Where(values.AsReadOnly(), predicate, ref buffer, cutOffLength);

        private static Span<T?> WhereInternal<T>(ReadOnlySpan<T?> values, Predicate<T?> predicate, int cutOffLength)
        {
            if (cutOffLength == NoValuePassed)
            {
                cutOffLength = values.Length;
            }

            Span<T?> result = new T[cutOffLength];
            Where(values, predicate, ref result, cutOffLength);

            return result;
        }
    }
}