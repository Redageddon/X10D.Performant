using System;
using System.Collections.Generic;
using System.Security;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="string"/>.
    /// </summary>
    public static partial class StringExtensions
    {
        /// <summary>
        ///     Repeats a <see cref="string"/> a specified number of times.
        /// </summary>
        /// <param name="value">The string to repeat.</param>
        /// <param name="count">The repeat count.</param>
        /// <returns>A <see cref="string"/> whose value is <paramref name="value"/> repeated <paramref name="count"/> times.</returns>
        public static string Repeat(this string value, int count)
        {
            if (value.Length == 0
             || count <= 0)
            {
                return string.Empty;
            }

            int size = value.Length * count;
            Span<char> span = stackalloc char[size];

            int p = 0;
            int i = 0;

            while (i < size)
            {
                if (p == value.Length)
                {
                    p = 0;
                }

                span[i++] = value[p++];
            }

            return new string(span);
        }

        /// <summary>
        ///     Shuffles the characters in the <see cref="string"/>.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to shuffle.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <returns>A <see cref="string"/> containing the characters in <paramref name="value"/>, rearranged.</returns>
        public static string Shuffle(this string value, Random? random = null) => new(value.AsSpan().Shuffled(random));

        /// <summary>
        ///     Splits the <see cref="string"/> into chunks that are no greater than <paramref name="chunkSize"/> in length.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to split.</param>
        /// <param name="chunkSize">The maximum length of each <see cref="string"/> in the returned result.</param>
        /// <returns>
        ///     An <see cref="IEnumerable{T}"/> containing <see cref="string"/> instances which are no greater than
        ///     <paramref name="chunkSize"/> in length.
        /// </returns>
        public static IEnumerable<string> Split(this string value, int chunkSize)
        {
            for (int i = 0; i < value.Length; i += chunkSize)
            {
                yield return value.Substring(i, Math.Min(chunkSize, value.Length - i));
            }
        }

        /// <summary>
        ///     Converts a <see cref="string"/> to a <see cref="SecureString"/>.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to convert.</param>
        /// <returns>A <see cref="SecureString"/>.</returns>
        public static SecureString ToSecureString(this string value)
        {
            SecureString result = new();

            foreach (char c in value)
            {
                result.AppendChar(c);
            }

            return result;
        }
    }
}