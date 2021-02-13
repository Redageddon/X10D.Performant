using System;

namespace X10D.Performant.IFormatProviderExtensions
{
    public static partial class FormatProviderExtensions
    {
        /// <inheritdoc cref="string.Format(IFormatProvider,string,object)"/>
        public static string Format(this IFormatProvider provider, string format, object value) => string.Format(provider, format, value);

        /// <inheritdoc cref="string.Format(IFormatProvider,string,object,object)"/>
        public static string Format(this IFormatProvider provider, string format, object value, object value2) =>
            string.Format(provider, format, value, value2);
        
        /// <inheritdoc cref="string.Format(IFormatProvider,string,object,object,object)"/>
        public static string Format(this IFormatProvider provider, string format, object value, object value2, object value3) =>
            string.Format(provider, format, value, value2, value3);
        
        /// <inheritdoc cref="string.Format(IFormatProvider,string,object[])"/>
        public static string Format(this IFormatProvider provider, string format, params object[] values) => string.Format(provider, format, values);
        
        /// <inheritdoc cref="string.Format(string,object)"/>
        public static string Format(this string format, object value) => string.Format(format, value);

        /// <inheritdoc cref="string.Format(string,object,object)"/>
        public static string Format(this string format, object value, object value2) =>
            string.Format(format, value, value2);
        
        /// <inheritdoc cref="string.Format(string,object,object,object)"/>
        public static string Format(this string format, object value, object value2, object value3) =>
            string.Format(format, value, value2, value3);
        
        /// <inheritdoc cref="string.Format(string,object[])"/>
        public static string Format(this string format, params object[] values) => string.Format(format, values);
    }
}