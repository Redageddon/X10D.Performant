using System;

namespace X10D.Performant.TypeExtensions
{
    public static partial class ReflectionExtensions
    {
        /// <inheritdoc cref="Enum.Format(Type,object,string)"/>
        public static string Format(this Type enumType, object value, string format) => Enum.Format(enumType, value, format);

        /// <inheritdoc cref="Enum.Parse(Type,string,bool)"/>
        public static object Parse(this Type enumType, string value, bool ignoreCase = false) => Enum.Parse(enumType, value, ignoreCase);

        /// <inheritdoc cref="Enum.GetNames(Type)"/>
        public static string[] GetNames(this Type enumType) => Enum.GetNames(enumType);

        /// <inheritdoc cref="Enum.GetValues{T}"/>
        public static Array GetValues(this Type enumType) => Enum.GetValues(enumType);

        /// <inheritdoc cref="Enum.IsDefined(Type,object)"/>
        public static bool IsDefined(this Type enumType, object value) => Enum.IsDefined(enumType, value);

        /// <inheritdoc cref="Enum.TryParse(Type,string,bool,out object)"/>
        public static bool TryParse(this Type enumType, string value, out object? result, bool ignoreCase = false) =>
            Enum.TryParse(enumType, value, ignoreCase, out result);
        
        /// <inheritdoc cref="Enum.GetUnderlyingType(Type)"/>
        public static Type GetUnderlyingType(this Type enumType) => Enum.GetUnderlyingType(enumType);
    }
}