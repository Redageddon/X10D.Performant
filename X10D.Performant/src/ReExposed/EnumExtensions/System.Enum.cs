using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    /// <summary>
    ///     Extension methods for <see cref="Enum"/>.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static class EnumExtensions
    {
        /// <inheritdoc cref="Enum.GetName{TEnum}(TEnum)"/>
        public static string? GetName<TEnum>(this TEnum value)
            where TEnum : struct, Enum =>
            Enum.GetName(value);

        /// <inheritdoc cref="Enum.GetNames{TEnum}"/>
        public static string[] GetNames<TEnum>()
            where TEnum : struct, Enum =>
            Enum.GetNames<TEnum>();

        /// <inheritdoc cref="Enum.IsDefined{TEnum}(TEnum)"/>
        public static bool IsDefined<TEnum>(this TEnum value)
            where TEnum : struct, Enum =>
            Enum.IsDefined(value);
    }
}