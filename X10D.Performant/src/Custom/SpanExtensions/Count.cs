namespace X10D.Performant.SpanExtensions;

//TODO: DOCUMENT
//TODO: TEST
public static partial class SpanExtensions
{
    public static int Count<T>(this in ReadOnlySpan<T?> values, Predicate<T?> predicate)
    {
        int count = 0;

        foreach (T? value in values)
        {
            if (predicate(value))
            {
                count++;
            }
        }

        return count;
    }

    public static int Count<T>(this in Span<T?> values, Predicate<T?> predicate) => Count(values.AsReadOnly(), predicate);
}