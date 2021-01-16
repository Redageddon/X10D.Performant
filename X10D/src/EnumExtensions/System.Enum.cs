using System;

namespace X10D.Performant.EnumExtensions
{
    public static  partial class EnumExtensions
    {
        /// <summary>
        ///     Retrieves the name of the constant in the specified enumeration that has the specified value.
        /// </summary>
        /// <param name="value">The value of a particular enumerated constant in terms of its underlying type.</param>
        /// <typeparam name="T">An enumeration type.</typeparam>
        /// <returns>
        ///     A <see cref="string"/> containing the name of the enumerated constant in enumType whose value is <paramref name="value"/>;
        ///     or <see langword="null"/> if no such constant is found.
        /// </returns>
        public static string? GetName<T>(this T value)
            where T : struct, Enum =>
            Enum.GetName(value);

        /// <summary>
        ///     Retrieves an array of the names of the constants in a specified enumeration.
        /// </summary>
        /// <typeparam name="T">An enumeration type.</typeparam>
        /// <returns>A string array of the names of the constants in <typeparamref name="T"/>.</returns>
        public static string[] GetNames<T>()
            where T : struct, Enum =>
            Enum.GetNames<T>();

        /// <summary>
        ///     Retrieves an array of the values of the constants in a specified enumeration.
        /// </summary>
        /// <typeparam name="T">An enumeration type.</typeparam>
        /// <returns>An array that contains the values of the constants in <typeparamref name="T"/>.</returns>
        public static T[] GetValues<T>()
            where T : struct, Enum =>
            Enum.GetValues<T>();

        /// <summary>
        ///     Returns a Boolean telling whether a given integral value, or its name as a string, exists in a specified enumeration.
        /// </summary>
        /// <typeparam name="T">An enumeration type.</typeparam>
        /// <returns>
        ///     <see langword="true"/> if a constant in <typeparamref name="T"/> has a value equal to <paramref name="value"/>; otherwise,
        ///     <see langword="false"/>.
        /// </returns>
        public static bool IsDefined<T>(this T value)
            where T : struct, Enum =>
            Enum.IsDefined(value);
    }
}