using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static ReadOnlySpan<T?> Concat<T>(this ReadOnlySpan<T?> part1, ReadOnlySpan<T?> part2) => ConcatInternal(part1, part2);

        public static Span<T?> Concat<T>(this Span<T?> part1, ReadOnlySpan<T?> part2) => ConcatInternal(part1, part2);

        public static void Concat<T>(this ReadOnlySpan<T?> part1, ReadOnlySpan<T?> part2, ref Span<T?> buffer)
        {
            part1.CopyTo(buffer);
            part2.CopyTo(buffer[part1.Length..]);
        }

        public static void Concat<T>(this Span<T?> part1, ReadOnlySpan<T?> part2, ref Span<T?> buffer) => Concat(part1.AsReadOnly(), part2, ref buffer);

        private static Span<T?> ConcatInternal<T>(this ReadOnlySpan<T?> part1, ReadOnlySpan<T?> part2)
        {
            Span<T?> output = new T?[part1.Length + part2.Length];
            Concat(part1, part2, ref output);

            return output;
        }
    }
}