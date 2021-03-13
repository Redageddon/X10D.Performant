using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.StringExtensions
{
    [SuppressMessage("ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator")]
    public static partial class StringExtensions
    {
        /// <summary>
        ///     Determines if all alphabetical characters in this <see cref="string"/> are considered letters.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns><see langword="true"/> if all alphabetical characters are uppercase, <see langword="false"/> otherwise.</returns>
        public static bool IsAlpha(this string value)
        {
            foreach (char t in value)
            {
                if (!char.IsLetter(t))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///     Determines if all alphabetical characters in this <see cref="string"/> are considered lowercase.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns><see langword="true"/> if all alphabetical characters are lowercase, <see langword="false"/> otherwise.</returns>
        public static bool IsLower(this string value)
        {
            foreach (char t in value)
            {
                if (char.IsLetter(t)
                 && !char.IsLower(t))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///     Determines if all alphabetical characters in this <see cref="string"/> are considered numbers.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns><see langword="true"/> if all alphabetical characters are uppercase, <see langword="false"/> otherwise.</returns>
        public static bool IsNumerical(this string value)
        {
            foreach (char t in value)
            {
                if (!char.IsNumber(t))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///     Determines if all alphabetical characters in this <see cref="string"/> are considered uppercase.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns><see langword="true"/> if all alphabetical characters are uppercase, <see langword="false"/> otherwise.</returns>
        public static bool IsUpper(this string value)
        {
            foreach (char t in value)
            {
                if (char.IsLetter(t)
                 && !char.IsUpper(t))
                {
                    return false;
                }
            }

            return true;
        }
    }
}