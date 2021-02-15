using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Enum.Parse{T}(string,bool)"/>
        public static T ToEnum<T>(this string value, bool ignoreCase = false)
            where T : struct, Enum =>
            Enum.Parse<T>(value, ignoreCase);

        /// <inheritdoc cref="Enum.TryParse{T}(string,bool,out T)"/>
        public static bool TryToEnum<T>(this string value, out T result, bool ignoreCase = false)
            where T : struct, Enum =>
            Enum.TryParse(value, ignoreCase, out result);
    }
}