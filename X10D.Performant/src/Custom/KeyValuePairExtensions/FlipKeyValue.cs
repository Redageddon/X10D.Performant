namespace X10D.Performant.KeyValuePairExtensions;

public static partial class KeyValuePairExtensions
{
    /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="FlipKeyValue"]'/>
    public static KeyValuePair<TValue?, TKey?> FlipKeyValue<TKey, TValue>(this KeyValuePair<TKey?, TValue?> keyValuePair) =>
        new(keyValuePair.Value, keyValuePair.Key);

    /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="FlipKeyValues"]'/>
    [SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
    public static IEnumerable<KeyValuePair<TValue?, TKey?>?> FlipKeyValues<TKey, TValue>(this IEnumerable<KeyValuePair<TKey?, TValue?>> keyValuePairs)
    {
        foreach (KeyValuePair<TKey?, TValue?> keyValuePair in keyValuePairs)
        {
            yield return keyValuePair.FlipKeyValue();
        }
    }
}