namespace X10D.Performant.KeyValuePairExtensions;

public static partial class KeyValuePairExtensions
{
    /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="ToGetParameters"]'/>
    public static string ToGetParameters<TKey, TValue>(this IEnumerable<KeyValuePair<TKey?, TValue?>> keyValuePairs)
    {
        IEnumerable<string> InternalIterator()
        {
            foreach ((TKey? key, TValue? value) in keyValuePairs)
            {
                string? k = HttpUtility.UrlEncode(key?.ToString());
                string? v = HttpUtility.UrlEncode(value?.ToString());

                yield return $"{k}={v}";
            }
        }

        return string.Join("&", InternalIterator());
    }

    /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="ToGetParametersSeparators"]'/>
    public static string ToGetParameters<TKey, TValue>(this IEnumerable<KeyValuePair<TKey?, TValue?>> keyValuePairs, params string[] separators)
        where TValue : IEnumerable
    {
        IEnumerable<string> InternalIterator()
        {
            int index = 0;
            int separatorsLength = separators.Length - 1;

            foreach ((TKey? key, TValue? value) in keyValuePairs)
            {
                string? k = HttpUtility.UrlEncode(key?.ToString());

                string v = HttpUtility.UrlEncode(string.Join(separators[index > separatorsLength ? separatorsLength : index++],
                                                             value?.OfType<object>() ?? Enumerable.Empty<object>()));

                yield return $"{k}={v}";
            }
        }

        return string.Join("&", InternalIterator());
    }
}