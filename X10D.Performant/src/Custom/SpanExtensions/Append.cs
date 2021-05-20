using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static ReadOnlySpan<T?> Append<T>(this ReadOnlySpan<T?> values, T? value) => AppendInternal(values, value);

        public static Span<T?> Append<T>(this Span<T?> values, T? value) => AppendInternal(values, value);

        public static void Append<T>(this ReadOnlySpan<T?> values, T? value, ref Span<T?> buffer)
        {
            values.CopyTo(buffer);
            buffer[values.Length + 1] = value;
        }

        public static void Append<T>(this Span<T?> values, T? value, ref Span<T?> buffer) => Append(values.AsReadOnly(), value, ref buffer);

        private static Span<T?> AppendInternal<T>(this ReadOnlySpan<T?> values, T? value)
        {
            Span<T?> output = new T[values.Length + 1];
            Append(values, value, ref output);

            return output;
        }
    }
}