using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="char.Parse(string)" />
        public static char ToChar(this string value) => char.Parse(value);

        /// <inheritdoc cref="char.TryParse(string,out char)" />
        public static bool TryToChar(this string value, out char result) => char.TryParse(value, out result);
    }
}