using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Enum" /> types.
    /// </summary>
    public static partial class EnumExtensions
    {
        /// <summary>
        ///     Returns the next value in an <see cref="Enum" /> using <paramref name="value" /> as a starting point.
        /// </summary>
        /// <param name="value">An <see cref="Enum" /> value.</param>
        /// <param name="wrap">Whether or not to wrap to the to the start of the <see cref="Enum" />. Defaults to <see langword="true" />.</param>
        /// <typeparam name="TEnum">An <see cref="Enum" />.</typeparam>
        /// <returns>A <typeparamref name="TEnum" /> value.</returns>
        public static TEnum NextEnumDeclaration<TEnum>(this TEnum value, bool wrap = true)
            where TEnum : struct, Enum
        {
            TEnum[] values = EnumMap<TEnum>.Map;
            int i = Array.IndexOf(values, value) + 1;

            return values.Length == i
                ? values[wrap ? 0 : i - 1]
                : values[i];
        }

        /// <summary>
        ///     Returns the previous value in an <see cref="Enum" /> using <paramref name="value" /> as a starting point.
        /// </summary>
        /// <param name="value">An <see cref="Enum" /> value.</param>
        /// <param name="wrap">Whether or not to wrap to the to the end of the <see cref="Enum" />. Defaults to <see langword="true" />.</param>
        /// <typeparam name="TEnum">An <see cref="Enum" />.</typeparam>
        /// <returns>A <typeparamref name="TEnum" /> value.</returns>
        public static TEnum PreviousEnumDeclaration<TEnum>(this TEnum value, bool wrap = true)
            where TEnum : struct, Enum
        {
            TEnum[] values = EnumMap<TEnum>.Map;
            int i = Array.IndexOf(values, value) - 1;

            return i < 0
                ? values[wrap ? values.Length - 1 : 0]
                : values[i];
        }

        private static class EnumMap<TEnum>
            where TEnum : struct, Enum
        {
            public static TEnum[] Map { get; } = Enum.GetValues<TEnum>();
        }
    }
}