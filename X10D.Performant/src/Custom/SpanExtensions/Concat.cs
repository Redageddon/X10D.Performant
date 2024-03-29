﻿namespace X10D.Performant.SpanExtensions;

//TODO: DOCUMENT
//TODO: TEST
public static partial class SpanExtensions
{
    public static ReadOnlySpan<T?> Concat<T>(this in ReadOnlySpan<T?> part1, ReadOnlySpan<T?> part2) => ConcatInternal(part1, part2);

    public static Span<T?> Concat<T>(this in Span<T?> part1, ReadOnlySpan<T?> part2) => ConcatInternal(part1, part2);

    public static void Concat<T>(this in ReadOnlySpan<T?> part1, ReadOnlySpan<T?> part2, ref Span<T?> buffer)
    {
        part1.CopyTo(buffer);
        part2.CopyTo(buffer[part1.Length..]);
    }

    public static void Concat<T>(this in Span<T?> part1, ReadOnlySpan<T?> part2, ref Span<T?> buffer) => Concat(part1.AsReadOnly(), part2, ref buffer);

    private static Span<T?> ConcatInternal<T>(scoped in ReadOnlySpan<T?> part1, ReadOnlySpan<T?> part2)
    {
        Span<T?> result = new T?[part1.Length + part2.Length];
        Concat(part1, part2, ref result);

        return result;
    }
}