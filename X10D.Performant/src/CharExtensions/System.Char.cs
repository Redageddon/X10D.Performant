using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="char.ConvertToUtf32(char,char)"/>
        public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate) => char.ConvertToUtf32(highSurrogate, lowSurrogate);

        /// <inheritdoc cref="char.GetNumericValue(char)"/>
        public static double GetNumericValue(this char value) => char.GetNumericValue(value);

        /// <inheritdoc cref="char.GetUnicodeCategory(char)"/>
        public static UnicodeCategory GetUnicodeCategory(this char value) => char.GetUnicodeCategory(value);

        /// <inheritdoc cref="char.IsControl(char)"/>
        public static bool IsControl(this char value) => char.IsControl(value);

        /// <inheritdoc cref="char.IsDigit(char)"/>
        public static bool IsDigit(this char value) => char.IsDigit(value);

        /// <inheritdoc cref="char.IsHighSurrogate(char)"/>
        public static bool IsHighSurrogate(this char value) => char.IsHighSurrogate(value);

        /// <inheritdoc cref="char.IsLetter(char)"/>
        public static bool IsLetter(this char value) => char.IsLetter(value);

        /// <inheritdoc cref="char.IsLetterOrDigit(char)"/>
        public static bool IsLetterOrDigit(this char value) => char.IsLetterOrDigit(value);

        /// <inheritdoc cref="char.IsLower(char)"/>
        public static bool IsLower(this char value) => char.IsLower(value);

        /// <inheritdoc cref="char.IsLowSurrogate(char)"/>
        public static bool IsLowSurrogate(this char value) => char.IsLowSurrogate(value);

        /// <inheritdoc cref="char.IsNumber(char)"/>
        public static bool IsNumber(this char value) => char.IsNumber(value);

        /// <inheritdoc cref="char.IsPunctuation(char)"/>
        public static bool IsPunctuation(this char value) => char.IsPunctuation(value);

        /// <inheritdoc cref="char.IsSeparator(char)"/>
        public static bool IsSeparator(this char value) => char.IsSeparator(value);

        /// <inheritdoc cref="char.IsSurrogate(char)"/>
        public static bool IsSurrogate(this char value) => char.IsSurrogate(value);

        /// <inheritdoc cref="char.IsSurrogatePair(char,char)"/>
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate) => char.IsSurrogatePair(highSurrogate, lowSurrogate);

        /// <inheritdoc cref="char.IsSymbol(char)"/>
        public static bool IsSymbol(this char value) => char.IsSymbol(value);

        /// <inheritdoc cref="char.IsUpper(char)"/>
        public static bool IsUpper(this char value) => char.IsUpper(value);

        /// <inheritdoc cref="char.IsWhiteSpace(char)"/>
        public static bool IsWhiteSpace(this char value) => char.IsWhiteSpace(value);

        /// <inheritdoc cref="char.ToLower(char,CultureInfo)"/>
        public static char ToLower(this char value, CultureInfo? culture = null) => char.ToLower(value, culture ?? CultureInfo.CurrentCulture);

        /// <inheritdoc cref="char.ToLowerInvariant(char)"/>
        public static char ToLowerInvariant(this char value) => char.ToLowerInvariant(value);

        /// <inheritdoc cref="char.ToUpper(char,CultureInfo)"/>
        public static char ToUpper(this char value, CultureInfo? culture = null) => char.ToUpper(value, culture ?? CultureInfo.CurrentCulture);

        /// <inheritdoc cref="char.ToUpperInvariant(char)"/>
        public static char ToUpperInvariant(this char value) => char.ToUpperInvariant(value);
    }
}