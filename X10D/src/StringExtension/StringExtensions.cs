using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using X10D.Performant.ByteExtensions;
using X10D.Performant.SpanExtensions;

namespace X10D.Performant.StringExtension
{
    /// <summary>
    ///     Extension methods for <see cref="string"/>.
    /// </summary>
    public static partial class StringExtensions
    {
        /// <summary>
        ///     Decodes a base-64 encoded <see cref="string"/>.
        /// </summary>
        /// <param name="value">The base-64 <see cref="string"/> to decode.</param>
        /// <returns>Returns the <see cref="string"/> in plain text.</returns>
        public static string Base64Decode(this string value) => Convert.FromBase64String(value).GetUtf8String();

        /// <summary>
        ///     Encodes a base-64 encoded <see cref="string"/>.
        /// </summary>
        /// <param name="value">The plain text <see cref="string"/> to decode.</param>
        /// <returns>Returns the <see cref="string"/> in plain text.</returns>
        public static string Base64Encode(this string value) => Convert.ToBase64String(value.GetBytes());

        /// <summary>
        ///     Converts this <see cref="string"/> from one encoding to another.
        /// </summary>
        /// <param name="value">The input <see cref="string"/>.</param>
        /// <param name="from">The input encoding.</param>
        /// <param name="to">The output encoding.</param>
        /// <returns>Returns a new <see cref="string"/> with its data converted to <paramref name="to"/>.</returns>
        public static string ChangeEncoding(this string value, Encoding from, Encoding to) => to.GetString(value.GetBytes(from));

        /// <summary>
        ///     Parses a <see cref="string"/> into an <see cref="Enum"/>.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="Enum"/>.</typeparam>
        /// <param name="value">The <see cref="string"/> value to parse.</param>
        /// <param name="ignoreCase">Whether or not to ignore casing.</param>
        /// <returns>The <see cref="Enum"/> value corresponding to the <see cref="string"/>.</returns>
        public static T EnumParse<T>(this string value, bool ignoreCase = false)
            where T : struct, Enum =>
            Enum.Parse<T>(value, ignoreCase);

        /// <summary>
        ///     Gets a <see cref="T:byte[]"/> representing the value the <see cref="string"/> with the provided encoding.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to convert.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>Returns a <see cref="T:byte[]"/>.</returns>
        public static byte[] GetBytes(this string value, Encoding? encoding = null)
        {
            encoding ??= Encoding.UTF8;

            return encoding.GetBytes(value);
        }

        /// <summary>
        ///     Determines if all alpha characters in this <see cref="string"/> are considered lowercase.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns>Returns <see langword="true"/> if all alphabetical characters are lowercase, <see langword="false"/> otherwise.</returns>
        public static bool IsLower(this string value)
        {
            // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
            foreach (char t in value)
            {
                if (char.IsLetter(t) &&
                    !char.IsLower(t))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///     Determines if all alpha characters in this <see cref="string"/> are considered uppercase.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns>Returns <see langword="true"/> if all alphabetical characters are uppercase, <see langword="false"/> otherwise.</returns>
        public static bool IsUpper(this string value)
        {
            // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
            foreach (char t in value)
            {
                if (char.IsLetter(t) &&
                    !char.IsUpper(t))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///     Repeats a <see cref="string"/> a specified number of times.
        /// </summary>
        /// <param name="value">The string to repeat.</param>
        /// <param name="count">The repeat count.</param>
        /// <returns>Returns a <see cref="string"/> whose value is <paramref name="value"/> repeated <paramref name="count"/> times.</returns>
        public static string Repeat(this string value, double count)
        {
            if (value.Length == 0)
            {
                return string.Empty;
            }

            int size = (int)Math.Ceiling(value.Length * count);
            Span<char> span = stackalloc char[size];

            for (int i = 0; i < size; i++)
            {
                span[i] = value[i % value.Length];
            }

            return new string(span);
        }

        /// <summary>
        ///     Shuffles the characters in the <see cref="string"/>.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to shuffle.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <returns>Returns a <see cref="string"/> containing the characters in <paramref name="value"/>, rearranged.</returns>
        public static string Shuffle(this string value, Random? random = null) => new(value.AsSpan().Shuffled(random));

        /// <summary>
        ///     Splits the <see cref="string"/> into chunks that are no greater than <paramref name="chunkSize"/> in length.
        /// </summary>
        /// <param name="value">The <see cref="string"/> to split.</param>
        /// <param name="chunkSize">The maximum length of each <see cref="string"/> in the returned result.</param>
        /// <returns>
        ///     Returns an <see cref="IEnumerable{T}"/> containing <see cref="string"/> instances which are no greater than
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
        /// <returns>Returns a <see cref="SecureString"/>.</returns>
        public static SecureString ToSecureString(this string value)
        {
            SecureString result = new();

            foreach (char c in value)
            {
                result.AppendChar(c);
            }

            return result;
        }

        /// <summary>
        ///     Parses a shorthand time span <see cref="string"/> (e.g. 3w 2d 1.5h) and converts it to an instance of <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns>Returns an instance of <see cref="TimeSpan"/>.</returns>
        public static TimeSpan ToTimeSpan(this string value) => ShortHandParse(value);
    }
}