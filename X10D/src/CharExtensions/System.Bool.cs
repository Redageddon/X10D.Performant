﻿using System;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="System.Boolean.Parse(ReadOnlySpan{char})"/>
        public static bool ToBool(this ReadOnlySpan<char> value) =>
            bool.Parse(value);
        
        /// <inheritdoc cref="System.Boolean.TryParse(ReadOnlySpan{char},out bool)"/>
        public static bool TryToBool(this ReadOnlySpan<char> value, out bool result) =>
            bool.TryParse(value, out result);
    }
}