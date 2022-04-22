namespace X10D.Performant.IEnumerableExtensions;

public static partial class EnumerableExtensions
{
    /// <include file='EnumerableExtensions.xml' path='members/member[@name="Consume"]'/>
    public static void Consume<TSource>(this IEnumerable<TSource?> values, int consumeCount = int.MaxValue)
    {
        using IEnumerator<TSource?> enumerator = values.GetEnumerator();

        while (consumeCount-- > 0 && enumerator.MoveNext()) {}
    }
}