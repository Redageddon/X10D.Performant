﻿using System;
using System.Globalization;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="uint.Parse(string,NumberStyles,IFormatProvider)"/>
        public static uint ToUInt32(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
            uint.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="uint.TryParse(string,NumberStyles,IFormatProvider,out uint)"/>
        public static bool TryToUInt32(
            this string value,
            out uint result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? provider = null) =>
            uint.TryParse(value, style, provider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}