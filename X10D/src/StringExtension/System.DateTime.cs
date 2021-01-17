﻿using System;
using System.Globalization;

namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="DateTime.Parse(string)"/>
        public static DateTime Parse(this string value) =>
            DateTime.Parse(value);

        /// <inheritdoc cref="DateTime.Parse(string,IFormatProvider)"/>
        public static DateTime Parse(this string value, IFormatProvider? provider) =>
            DateTime.Parse(value, provider);

        /// <inheritdoc cref="DateTime.Parse(string,IFormatProvider)"/>
        public static DateTime Parse(this string value, IFormatProvider? provider, DateTimeStyles styles) =>
            DateTime.Parse(value, provider, styles);
        
        /// <inheritdoc cref="DateTime.ParseExact(string,string,IFormatProvider)"/>
        public static DateTime ParseExact(this string value, string format, IFormatProvider? provider) =>
            DateTime.ParseExact(value, format, provider);

        /// <inheritdoc cref="DateTime.ParseExact(string,string,IFormatProvider,DateTimeStyles)"/>
        public static DateTime ParseExact(this string value, string format, IFormatProvider? provider, DateTimeStyles style) =>
            DateTime.ParseExact(value, format, provider, style);        
        
        /// <inheritdoc cref="DateTime.ParseExact(string,string[],IFormatProvider,DateTimeStyles)"/>
        public static DateTime ParseExact(this string value, string[] formats, IFormatProvider? provider, DateTimeStyles style) =>
            DateTime.ParseExact(value, formats, provider, style); 
        
        /// <inheritdoc cref="DateTime.TryParse(string,out DateTime)"/>
        public static bool TryParse(this string value, out DateTime result) =>
            DateTime.TryParse(value, out result);

        /// <inheritdoc cref="DateTime.TryParse(string,IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryParse(this string value, IFormatProvider? provider, DateTimeStyles styles, out DateTime result) =>
            DateTime.TryParse(value, provider, styles, out result);
        
        /// <inheritdoc cref="DateTime.TryParseExact(string,string,IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryParseExact(this string value, string format, IFormatProvider? provider, DateTimeStyles style, out DateTime result) =>
            DateTime.TryParseExact(value, format, provider, style, out result);        

        /// <inheritdoc cref="DateTime.TryParseExact(string,string[],IFormatProvider,DateTimeStyles,out DateTime)"/>
        public static bool TryParseExact(this string value, string[] formats, IFormatProvider? provider, DateTimeStyles style, out DateTime result) =>
            DateTime.TryParseExact(value, formats, provider, style, out result);
    }
}