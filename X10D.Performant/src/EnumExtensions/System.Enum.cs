using System;

namespace X10D.Performant
{
    public static partial class EnumExtensions
    {
        /// <inheritdoc cref="Enum.GetName{TEnum}(TEnum)" />
        public static string? GetName<TEnum>(this TEnum value)
            where TEnum : struct, Enum =>
            Enum.GetName(value);

        /// <inheritdoc cref="Enum.GetNames{TEnum}" />
        public static string[] GetNames<TEnum>()
            where TEnum : struct, Enum =>
            Enum.GetNames<TEnum>();

        /// <inheritdoc cref="Enum.IsDefined{TEnum}(TEnum)" />
        public static bool IsDefined<TEnum>(this TEnum value)
            where TEnum : struct, Enum =>
            Enum.IsDefined(value);
    }
}