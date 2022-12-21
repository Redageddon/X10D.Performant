namespace X10D.Performant.SpanExtensions;

public static partial class SpanExtensions
{
    /// <include file='SpanExtensions.xml' path='members/member[@name="RandomNew"]'/>
    public static ReadOnlySpan<T?> Random<T>(this in ReadOnlySpan<T?> values, int count, Random? random = null) =>
        RandomInternal(values, count, random);

    /// <include file='SpanExtensions.xml' path='members/member[@name="RandomNew"]'/>
    public static Span<T?> Random<T>(this in Span<T?> values, int count, Random? random = null) => RandomInternal(values.AsReadOnly(), count, random);

    /// <include file='SpanExtensions.xml' path='members/member[@name="RandomReadOnly"]'/>
    public static void Random<T>(this in ReadOnlySpan<T?> values, ref Span<T?> buffer, Random? random = null)
    {
        random ??= RandomExtensions.RandomExtensions.Random;

        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = values[random.Next(0, values.Length)];
        }
    }

    /// <include file='SpanExtensions.xml' path='members/member[@name="RandomReadOnly"]'/>
    public static void Random<T>(this in Span<T?> values, ref Span<T?> buffer, Random? random = null) => Random(values.AsReadOnly(), ref buffer, random);

    private static Span<T?> RandomInternal<T>(scoped in ReadOnlySpan<T?> values, int count, Random? random)
    {
        random ??= RandomExtensions.RandomExtensions.Random;

        Span<T?> result = new T?[count];
        Random(values, ref result, random);

        return result;
    }
}