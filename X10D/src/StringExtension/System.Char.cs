﻿namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="System.Char.Parse(string)"/>
        public static char ToChar(this string value) =>
            char.Parse(value);
        
        /// <inheritdoc cref="System.Char.TryParse(string,out char)"/>
        public static bool TryToChar(this string value, out char result) =>
            char.TryParse(value, out result);
    }
}