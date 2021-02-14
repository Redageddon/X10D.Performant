using System;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Enum.TryParse{T}(string,bool,out T)"/>
        public static bool TryToEnum<T>(this string value, out T result, bool ignoreCase = false)
            where T : struct, Enum =>
            Enum.TryParse(value, ignoreCase, out result);

        /// <inheritdoc cref="Enum.Parse{T}(string,bool)"/>
        public static T ToEnum<T>(this string value, bool ignoreCase = false)
            where T : struct, Enum =>
            Enum.Parse<T>(value, ignoreCase);
    }
}