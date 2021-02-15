﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="ushort.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        [CLSCompliant(false)]
        public static ushort ToUInt16(
            this ReadOnlySpan<char> chars,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            ushort.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="ushort.Parse(ReadOnlySpan{char},NumberStyles,IFormatProvider)"/>
        [CLSCompliant(false)]
        public static ushort ToUInt16(this Span<char> chars, NumberStyles style = NumberStyles.Integer, IFormatProvider? formatProvider = null) =>
            ushort.Parse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="ushort.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out ushort)"/>
        [CLSCompliant(false)]
        public static bool TryToUInt16(
            this ReadOnlySpan<char> chars,
            out ushort result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            ushort.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);

        /// <inheritdoc cref="ushort.TryParse(ReadOnlySpan{char},NumberStyles,IFormatProvider,out ushort)"/>
        [CLSCompliant(false)]
        public static bool TryToUInt16(
            this Span<char> chars,
            out ushort result,
            NumberStyles style = NumberStyles.Integer,
            IFormatProvider? formatProvider = null) =>
            ushort.TryParse(chars, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}