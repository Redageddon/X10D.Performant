using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace X10D.Performant.KeyValuePairExtensions
{
    /// <summary>
    ///     A set of extension methods for <see cref="KeyValuePair{TKey,TValue}"/>.
    /// </summary>
    public static class KeyValuePairExtensions
    {
        /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="FlipKeyValues"]'/>
        public static IEnumerable<KeyValuePair<TValue, TKey>> FlipKeyValues<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            foreach ((TKey key, TValue value) in keyValuePairs)
            {
                yield return new KeyValuePair<TValue, TKey>(value, key);
            }
        }

        /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="ToConnectionString"]'/>
        [SuppressMessage("ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator")]
        public static string ToConnectionString<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            static string? SanitizeValue(TValue value)
            {
                if (value is null)
                {
                    return string.Empty;
                }

                if (value is string str)
                {
                    foreach (char t in str)
                    {
                        if (char.IsWhiteSpace(t))
                        {
                            return $"\"{str}\"";
                        }
                    }
                }

                return value.ToString();
            }

            IEnumerable<string> InternalIterator()
            {
                foreach ((TKey key, TValue value) in keyValuePairs)
                {
                    yield return $"{key}={SanitizeValue(value)}";
                }
            }

            return string.Join(";", InternalIterator());
        }

        /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="ToGetParameters"]'/>
        public static string ToGetParameters<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            IEnumerable<string> InternalIterator()
            {
                foreach ((TKey key, TValue value) in keyValuePairs)
                {
                    string? k = HttpUtility.UrlEncode(key?.ToString());
                    string? v = HttpUtility.UrlEncode(value?.ToString());

                    yield return $"{k}={v}";
                }
            }

            return string.Join("&", InternalIterator());
        }

        /// <include file='KeyValuePairExtensions.xml' path='members/member[@name="ToGetParametersSeparators"]'/>
        public static string ToGetParameters<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs, params string[] separators)
            where TValue : IEnumerable
        {
            IEnumerable<string> InternalIterator()
            {
                int index = 0;
                int separatorsLength = separators.Length - 1;

                foreach ((TKey key, TValue value) in keyValuePairs)
                {
                    string? k = HttpUtility.UrlEncode(key?.ToString());

                    string v = HttpUtility.UrlEncode(string.Join(separators[index > separatorsLength ? separatorsLength : index++],
                                                                 value.OfType<object>()));

                    yield return $"{k}={v}";
                }
            }

            return string.Join("&", InternalIterator());
        }
    }
}