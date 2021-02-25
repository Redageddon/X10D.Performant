using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="bool.Parse(ReadOnlySpan{char})" />
        public static bool ToBool(this ReadOnlySpan<char> chars) => bool.Parse(chars);

        /// <inheritdoc cref="bool.Parse(ReadOnlySpan{char})" />
        public static bool ToBool(this Span<char> chars) => bool.Parse(chars);

        /// <inheritdoc cref="bool.TryParse(ReadOnlySpan{char},out bool)" />
        public static bool TryToBool(this ReadOnlySpan<char> chars, out bool result) => bool.TryParse(chars, out result);

        /// <inheritdoc cref="bool.TryParse(ReadOnlySpan{char},out bool)" />
        public static bool TryToBool(this Span<char> chars, out bool result) => bool.TryParse(chars, out result);
    }
}