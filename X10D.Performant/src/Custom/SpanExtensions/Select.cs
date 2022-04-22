namespace X10D.Performant.SpanExtensions;

//TODO: DOCUMENT
public static partial class SpanExtensions
{
    public static ReadOnlySpan<TResult?> Select<T, TResult>(this in ReadOnlySpan<T?> values,
                                                            Func<T?, TResult?> selector,
                                                            int cutOffLength = NoValuePassed) =>
        SelectInternal(values, selector, cutOffLength);

    public static Span<TResult?> Select<T, TResult>(this in Span<T?> values, Func<T?, TResult?> selector, int cutOffLength = NoValuePassed) =>
        SelectInternal(values, selector, cutOffLength);

    public static void Select<T, TResult>(this in ReadOnlySpan<T?> values,
                                          Func<T?, TResult?> selector,
                                          ref Span<TResult?> buffer,
                                          int cutOffLength = NoValuePassed)
    {
        int index = 0;

        while (index < values.Length
            && index < buffer.Length
            && index != cutOffLength)
        {
            T? value = values[index];
            buffer[index] = selector(value);
            index++;
        }

        buffer = buffer[..index];
    }

    public static void Select<T, TResult>(this in Span<T?> values,
                                          Func<T?, TResult?> selector,
                                          ref Span<TResult?> buffer,
                                          int cutOffLength = NoValuePassed) =>
        Select(values.AsReadOnly(), selector, ref buffer, cutOffLength);

    private static Span<TResult?> SelectInternal<T, TResult>(in ReadOnlySpan<T?> values, Func<T?, TResult?> selector, int cutOffLength)
    {
        if (cutOffLength == NoValuePassed)
        {
            cutOffLength = values.Length;
        }

        Span<TResult?> result = new TResult?[cutOffLength];
        Select(values, selector, ref result, cutOffLength);

        return result;
    }
}