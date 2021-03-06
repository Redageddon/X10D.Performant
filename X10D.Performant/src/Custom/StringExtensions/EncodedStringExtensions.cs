using System;
using System.Text;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     Decodes a base-64 encoded <see cref="string"/>.
        /// </summary>
        /// <param name="value">The base-64 <see cref="string"/> to decode.</param>
        /// <param name="encoding">The encoding that the <see cref="string"/> is read into.</param>
        /// <returns>The <see cref="string"/> in plain text.</returns>
        public static string Base64Decode(this string value, Encoding? encoding = null) =>
            (encoding ?? Encoding.Default).GetString(Convert.FromBase64String(value));

        /// <summary>
        ///     Encodes a base-64 encoded <see cref="string"/>.
        /// </summary>
        /// <param name="value">The plain text <see cref="string"/> to decode.</param>
        /// <param name="encoding">The encoding that the <see cref="string"/> is read into.</param>
        /// <returns>The <see cref="string"/> in plain text.</returns>
        public static string Base64Encode(this string value, Encoding? encoding = null) => Convert.ToBase64String(value.GetBytes(encoding));

        /// <summary>
        ///     Converts this <see cref="string"/> from one encoding to another.
        /// </summary>
        /// <param name="value">The input <see cref="string"/>.</param>
        /// <param name="from">The input encoding.</param>
        /// <param name="to">The output encoding.</param>
        /// <returns>A new <see cref="string"/> with its data converted to <paramref name="to"/>.</returns>
        public static string ChangeEncoding(this string value, Encoding from, Encoding to) => to.GetString(value.GetBytes(from));

        /// <inheritdoc cref="Encoding.GetBytes(string)"/>
        public static byte[] GetBytes(this string value, Encoding? encoding = null) => (encoding ?? Encoding.Default).GetBytes(value);
    }
}