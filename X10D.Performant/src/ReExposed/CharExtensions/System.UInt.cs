using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="uint.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        [CLSCompliant(false)]
        public static uint ToUInt32(this ReadOnlySpan<char> chars,
                                    NumberStyles style = NumberStyles.Integer,
                                    IFormatProvider? formatProvider = null) =>
            uint.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="uint.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        [CLSCompliant(false)]
        public static uint ToUInt32(this Span<char> chars, NumberStyles style = NumberStyles.Integer, IFormatProvider? formatProvider = null) =>
            uint.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="uint.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out uint)"/>
        [CLSCompliant(false)]
        public static bool TryToUInt32(this ReadOnlySpan<char> chars,
                                       out uint result,
                                       NumberStyles style = NumberStyles.Integer,
                                       IFormatProvider? formatProvider = null) =>
            uint.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);

        /// <inheritdoc cref="uint.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out uint)"/>
        [CLSCompliant(false)]
        public static bool TryToUInt32(this Span<char> chars,
                                       out uint result,
                                       NumberStyles style = NumberStyles.Integer,
                                       IFormatProvider? formatProvider = null) =>
            uint.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}