﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="double.Parse(string,NumberStyles,IFormatProvider)" />
        public static double ToDouble(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
            double.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="double.TryParse(string,NumberStyles,IFormatProvider,out double)" />
        public static bool TryToDouble(
            this string value,
            out double result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            double.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}