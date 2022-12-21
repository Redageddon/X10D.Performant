namespace X10D.Performant.SpanExtensions;

//TODO: DOCUMENT
//TODO: TEST
public static partial class SpanExtensions
{
    public static ReadOnlySpan<T?> Append<T>(this in ReadOnlySpan<T?> values, T? value) => AppendInternal(values, value);

    public static Span<T?> Append<T>(this in Span<T?> values, T? value) => AppendInternal(values, value);

    public static void Append<T>(this in ReadOnlySpan<T?> values, T? value, ref Span<T?> buffer)
    {
        values.CopyTo(buffer);
        buffer[values.Length + 1] = value;
    }

    public static void Append<T>(this in Span<T?> values, T? value, ref Span<T?> buffer) => Append(values.AsReadOnly(), value, ref buffer);

    private static Span<T?> AppendInternal<T>(scoped in ReadOnlySpan<T?> values2, T? value)
    {
        Span<T?> result = new T?[values2.Length + 1];
        Append(values2, value, ref result);

        return result;
    }
}