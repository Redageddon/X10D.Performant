using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.KeyValuePairExtensions
{
    public static partial class KeyValuePairExtensions
    {
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
    }
}