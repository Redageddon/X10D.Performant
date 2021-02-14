using System;

namespace X10D.Performant
{
    public static partial class EnumExtensions
    {
        /// <inheritdoc cref="Enum.GetName{T}(T)" />
        public static string? GetName<T>(this T value)
            where T : struct, Enum =>
            Enum.GetName(value);

        /// <inheritdoc cref="Enum.GetNames{T}" />
        public static string[] GetNames<T>()
            where T : struct, Enum =>
            Enum.GetNames<T>();

        /// <inheritdoc cref="Enum.IsDefined{T}(T)" />
        public static bool IsDefined<T>(this T value)
            where T : struct, Enum =>
            Enum.IsDefined(value);
    }
}