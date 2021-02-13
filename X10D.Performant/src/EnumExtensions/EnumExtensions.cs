using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Enum"/> types.
    /// </summary>
    public static partial class EnumExtensions
    {
        /// <summary>
        ///     Returns the next value in an <see cref="Enum"/> using <paramref name="value"/> as a starting point.
        /// </summary>
        /// <param name="value">An <see cref="Enum"/> value.</param>
        /// <param name="wrap">Whether or not to wrap to the to the start of the <see cref="Enum"/>. Defaults to <see langword="true"/>.</param>
        /// <typeparam name="T">An <see cref="Enum"/>.</typeparam>
        /// <returns>A <typeparamref name="T"/> value.</returns>
        public static T NextEnumDeclaration<T>(this T value, bool wrap = true)
            where T : struct, Enum
        {
            T[] values = EnumMap<T>.Map;
            int i = Array.IndexOf(values, value) + 1;

            return values.Length == i
                ? values[wrap ? 0 : i - 1]
                : values[i];
        }

        /// <summary>
        ///     Returns the previous value in an <see cref="Enum"/> using <paramref name="value"/> as a starting point.
        /// </summary>
        /// <param name="value">An <see cref="Enum"/> value.</param>
        /// <param name="wrap">Whether or not to wrap to the to the end of the <see cref="Enum"/>. Defaults to <see langword="true"/>.</param>
        /// <typeparam name="T">An <see cref="Enum"/>.</typeparam>
        /// <returns>A <typeparamref name="T"/> value.</returns>
        public static T PreviousEnumDeclaration<T>(this T value, bool wrap = true)
            where T : struct, Enum
        {
            T[] values = EnumMap<T>.Map;
            int i = Array.IndexOf(values, value) - 1;

            return i < 0
                ? values[wrap ? values.Length - 1 : 0]
                : values[i];
        }
        
        private static class EnumMap<T>
            where T : struct, Enum
        {
            public static T[] Map { get; } = Enum.GetValues<T>();
        }
    }
}