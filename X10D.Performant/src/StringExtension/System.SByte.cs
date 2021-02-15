﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="sbyte.Parse(string,NumberStyles,IFormatProvider)" />
        public static sbyte ToSByte(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
            sbyte.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="sbyte.TryParse(string,NumberStyles,IFormatProvider,out sbyte)" />
        public static bool TryToSByte(
            this string value,
            out sbyte result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            sbyte.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}