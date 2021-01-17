using System.Globalization;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="Char.IsControl(char)"/>
        public static bool IsControl(this char value) => char.IsControl(value);

        /// <inheritdoc cref="Char.IsDigit(char)"/>
        public static bool IsDigit(this char value) => char.IsDigit(value);
        
        /// <inheritdoc cref="Char.IsLetter(char)"/>
        public static bool IsLetter(this char value) => char.IsLetter(value);
        
        /// <inheritdoc cref="Char.IsLower(char)"/>
        public static bool IsLower(this char value) => char.IsLower(value);
        
        /// <inheritdoc cref="Char.IsNumber(char)"/>
        public static bool IsNumber(this char value) => char.IsNumber(value);
        
        /// <inheritdoc cref="Char.IsPunctuation(char)"/>
        public static bool IsPunctuation(this char value) => char.IsPunctuation(value);

        /// <inheritdoc cref="Char.IsSeparator(char)"/>
        public static bool IsSeparator(this char value) => char.IsSeparator(value);

        /// <inheritdoc cref="Char.IsSurrogate(char)"/>
        public static bool IsSurrogate(this char value) => char.IsSurrogate(value);
        
        /// <inheritdoc cref="Char.IsSymbol(char)"/>
        public static bool IsSymbol(this char value) => char.IsSymbol(value);
        
        /// <inheritdoc cref="Char.IsUpper(char)"/>
        public static bool IsUpper(this char value) => char.IsUpper(value);
        
        /// <inheritdoc cref="Char.ToLower(char)"/>
        public static char ToLower(this char value, CultureInfo? culture = null) => char.ToLower(value, culture ?? CultureInfo.CurrentCulture);

        /// <inheritdoc cref="Char.ToUpper(char)"/>
        public static char ToUpper(this char value, CultureInfo? culture = null) => char.ToUpper(value, culture ?? CultureInfo.CurrentCulture);

        /// <inheritdoc cref="Char.ConvertToUtf32(char,char)"/>
        public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate) => char.ConvertToUtf32(highSurrogate, lowSurrogate);

        /// <inheritdoc cref="Char.GetNumericValue(char)"/>
        public static double GetNumericValue(this char value) => char.GetNumericValue(value);

        /// <inheritdoc cref="Char.GetUnicodeCategory(char)"/>
        public static UnicodeCategory GetUnicodeCategory(this char value) => char.GetUnicodeCategory(value);

        /// <inheritdoc cref="Char.IsHighSurrogate(char)"/>
        public static bool IsHighSurrogate(this char value) => char.IsHighSurrogate(value);
        
        /// <inheritdoc cref="Char.IsLowSurrogate(char)"/>
        public static bool IsLowSurrogate(this char value) => char.IsLowSurrogate(value);

        /// <inheritdoc cref="Char.IsSurrogatePair(char,char)"/>
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate) => char.IsSurrogatePair(highSurrogate, lowSurrogate);
        
        /// <inheritdoc cref="Char.IsWhiteSpace(char)"/>
        public static bool IsWhiteSpace(this char value) => char.IsWhiteSpace(value);
        
        /// <inheritdoc cref="Char.ToLowerInvariant(char)"/>
        public static char ToLowerInvariant(this char value) => char.ToLowerInvariant(value);
        
        /// <inheritdoc cref="Char.ToUpperInvariant(char)"/>
        public static char ToUpperInvariant(this char value) => char.ToUpperInvariant(value);
        
        /// <inheritdoc cref="Char.IsLetterOrDigit(char)"/>
        public static bool IsLetterOrDigit(this char value) => char.IsLetterOrDigit(value);
    }
}