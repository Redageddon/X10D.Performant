using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a control character.
        /// </summary>
        /// <param name="value">The <see cref="char"/> to evaluate.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is a control <see cref="char"/>; otherwise, <see langword="false"/>.</returns>
        public static bool IsControl(this char value) => char.IsControl(value);

        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a decimal digit.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is a decimal digit; otherwise, <see langword="false"/>.</returns>
        public static bool IsDigit(this char value) => char.IsDigit(value);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a Unicode letter.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is a letter; otherwise, false.</returns>
        public static bool IsLetter(this char value) => char.IsLetter(value);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a lowercase letter.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is a lowercase letter; otherwise, false.</returns>
        public static bool IsLower(this char value) => char.IsLower(value);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a number.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is a number; otherwise, false.</returns>
        public static bool IsNumber(this char value) => char.IsNumber(value);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a punctuation mark.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is a punctuation mark; otherwise, false.</returns>
        public static bool IsPunctuation(this char value) => char.IsPunctuation(value);

        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a separator character.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is a separator <see cref="char"/>; otherwise, false.</returns>
        public static bool IsSeparator(this char value) => char.IsSeparator(value);

        /// <summary>
        ///     Indicates whether the specified <see cref="char"/> has a surrogate code unit.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is either a high surrogate or a low surrogate; otherwise, false.</returns>
        public static bool IsSurrogate(this char value) => char.IsSurrogate(value);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a symbol character.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is a symbol character; otherwise, false.</returns>
        public static bool IsSymbol(this char value) => char.IsSymbol(value);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as an uppercase letter.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is an uppercase letter; otherwise, false.</returns>
        public static bool IsUpper(this char value) => char.IsUpper(value);
        
        /// <summary>
        ///     Converts the value of a specified Unicode <see cref="char"/> to its lowercase equivalent using specified culture-specific formatting
        ///     information.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to convert.</param>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>
        ///     The lowercase equivalent of <paramref name="value"/>, modified according to <paramref name="culture"/>, or the unchanged value of
        ///     <paramref name="value"/>, if <paramref name="value"/> is already lowercase or not alphabetic.
        /// </returns>
        public static char ToLower(this char value, CultureInfo? culture = null)
        {
            culture ??= CultureInfo.CurrentCulture;
            return char.ToLower(value, culture);
        }
        
        /// <summary>
        ///     Converts the value of a specified Unicode <see cref="char"/> to its uppercase equivalent using specified culture-specific formatting
        ///     information.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to convert.</param>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>
        ///     The uppercase equivalent of <paramref name="value"/>, modified according to <paramref name="culture"/>, or the unchanged value of
        ///     <paramref name="value"/> if <paramref name="value"/> is already uppercase, has no uppercase equivalent, or is not alphabetic.
        /// </returns>
        public static char ToUpper(this char value, CultureInfo? culture = null)
        {
            culture ??= CultureInfo.CurrentCulture;
            return char.ToUpper(value, culture);
        }

        /// <summary>
        ///     Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
        /// </summary>
        /// <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF).</param>
        /// <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF).</param>
        /// <returns>The 21-bit Unicode code point represented by the <paramref name="highSurrogate"/> and <paramref name="lowSurrogate"/> parameters.</returns>
        public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate) => char.ConvertToUtf32(highSurrogate, lowSurrogate);

        /// <summary>
        ///     Converts the specified numeric <see cref="char"/> to a <see cref="double"/>.
        /// </summary>
        /// <param name="value">The Unicode character to convert.</param>
        /// <returns>The numeric value of the <see cref="char"/>; otherwise, -1.0.</returns>
        public static double GetNumericValue(this char value) => char.GetNumericValue(value);

        /// <summary>
        ///     Categorizes a specified Unicode <see cref="char"/> into a group identified by one of the values.
        /// </summary>
        /// <param name="value">The <see cref="char"/> to categorize.</param>
        /// <returns>A value that identifies the group that contains.</returns>
        public static UnicodeCategory GetUnicodeCategory(this char value) => char.GetUnicodeCategory(value);

        /// <summary>
        ///     Indicates whether the specified <see cref="char"/> object is a high surrogate.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>
        ///     <see langword="true"/> if the numeric value of the <paramref name="value"/> parameter ranges from U+D800 through U+DBFF; otherwise,
        ///     <see langword="false"/>.
        /// </returns>
        public static bool IsHighSurrogate(this char value) => char.IsHighSurrogate(value);
        
        /// <summary>
        ///     Indicates whether the specified <see cref="char"/> object is a low surrogate.
        /// </summary>
        /// <param name="value">The <see cref="char"/> to evaluate.</param>
        /// <returns>true if the numeric value of the <paramref name="value"/> parameter ranges from U+DC00 through U+DFFF; otherwise, false.</returns>
        public static bool IsLowSurrogate(this char value) => char.IsLowSurrogate(value);

        /// <summary>
        ///     Indicates whether the two specified <see cref="char"/> objects form a surrogate pair.
        /// </summary>
        /// <param name="highSurrogate">The <see cref="char"/> to evaluate as the high surrogate of a surrogate pair.</param>
        /// <param name="lowSurrogate">The <see cref="char"/> to evaluate as the low surrogate of a surrogate pair.</param>
        /// <returns>
        ///     true if the numeric value of the  parameter ranges from U+D800 through U+DBFF, and the numeric value of the
        ///     parameter ranges from U+DC00 through U+DFFF; otherwise, false.
        /// </returns>
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate) => char.IsSurrogatePair(highSurrogate, lowSurrogate);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as white space.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is white space; otherwise, false.</returns>
        public static bool IsWhiteSpace(this char value) => char.IsWhiteSpace(value);
        
        /// <summary>
        ///     Converts the value of a Unicode <see cref="char"/> to its lowercase equivalent using the casing rules of the invariant culture.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to convert.</param>
        /// <returns>
        ///     The lowercase equivalent of the <see cref="char"/> parameter, or the unchanged value of <paramref name="value"/>, if
        ///     <paramref name="value"/> is already lowercase or not alphabetic.
        /// </returns>
        public static char ToLowerInvariant(this char value) => char.ToLowerInvariant(value);
        
        /// <summary>
        ///     Converts the value of a Unicode <see cref="char"/> to its uppercase equivalent using the casing rules of the invariant
        ///     culture.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to convert.</param>
        /// <returns>
        ///     The uppercase equivalent of the <see cref="char"/> parameter, or the unchanged value of <paramref name="value"/>, if
        ///     <paramref name="value"/> is already uppercase or not alphabetic.
        /// </returns>
        public static char ToUpperInvariant(this char value) => char.ToUpperInvariant(value);
        
        /// <summary>
        ///     Indicates whether the specified Unicode <see cref="char"/> is categorized as a letter or a decimal digit.
        /// </summary>
        /// <param name="value">The Unicode <see cref="char"/> to evaluate.</param>
        /// <returns>true if <paramref name="value"/> is a letter or a decimal digit; otherwise, false.</returns>
        public static bool IsLetterOrDigit(this char value) => char.IsLetterOrDigit(value);
    }
}