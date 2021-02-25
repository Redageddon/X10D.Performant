using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace X10D.Performant
{
    /// <summary>
    ///     A set of extension methods for <see cref="KeyValuePair{TKey,TValue}"/>.
    /// </summary>
    public static class KeyValuePairExtensions
    {
        /// <summary>
        ///     Flips the keys and values ot values and keys.
        /// </summary>
        /// <param name="keyValuePairs">The pairs.</param>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <returns>A collection of <see cref="keyValuePairs"/> that have their values as keys.</returns>
        public static IEnumerable<KeyValuePair<TValue, TKey>> FlipKeyValues<TKey, TValue>(
            this IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            foreach ((TKey key, TValue value) in keyValuePairs)
            {
                yield return new KeyValuePair<TValue, TKey>(value, key);
            }
        }

        /// <summary>
        ///     Converts <paramref name="keyValuePairs"/> to an object-relational-safe connection <see cref="string"/>.
        /// </summary>
        /// <param name="keyValuePairs">The pairs.</param>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <returns>A <see cref="string"/> representing the <see cref="IReadOnlyDictionary{T1,T2}"/> as a key=value; set.</returns>
        [SuppressMessage("ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator")]
        public static string ToConnectionString<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            static string? SanitizeValue<T>(T value)
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
                    yield return $"{key}={SanitizeValue(value?.ToString())}";
                }
            }

            return string.Join(";", InternalIterator());
        }

        /// <summary>
        ///     Converts <paramref name="keyValuePairs"/> to a HTTP GET parameter <see cref="string"/>.
        /// </summary>
        /// <param name="keyValuePairs">The pairs.</param>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <returns>A <see cref="string"/> representing the <see cref="IReadOnlyDictionary{T1,T2}"/> as a key=value; set.</returns>
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

        /// <summary>
        ///     Converts <paramref name="keyValuePairs"/> to a HTTP GET parameter <see cref="string"/> with specific separators.
        /// </summary>
        /// <param name="keyValuePairs">The dictionary.</param>
        /// <param name="separators"> Joins <see name="TValue"/> by the chosen <see cref="string"/> values.</param>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <returns>A <see cref="string"/> representing the <see cref="IReadOnlyDictionary{T1,T2}"/> as a key=value; set.</returns>
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

                    string v = HttpUtility.UrlEncode(
                        string.Join(separators[index > separatorsLength ? separatorsLength : index++], value.OfType<object>()));

                    yield return $"{k}={v}";
                }
            }

            return string.Join("&", InternalIterator());
        }
    }
}