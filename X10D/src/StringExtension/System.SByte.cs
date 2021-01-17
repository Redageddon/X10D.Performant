﻿namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="System.SByte.Parse(string)"/>
        public static sbyte ToSByte(this string value) =>
            sbyte.Parse(value);
        
        /// <inheritdoc cref="System.SByte.TryParse(string,out sbyte)"/>
        public static bool TryToSByte(this string value, out sbyte result) =>
            sbyte.TryParse(value, out result);
    }
}