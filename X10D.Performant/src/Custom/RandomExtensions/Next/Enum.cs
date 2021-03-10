using System;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Returns a random value that is defined in a specified enum.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <typeparam name="TEnum">An enumeration type.</typeparam>
        /// <returns>
        ///     Returns a random enum value from <typeparamref name="TEnum"/> specified by <paramref name="random"/>.
        /// </returns>
        public static TEnum NextEnum<TEnum>(this Random random)
            where TEnum : struct, Enum
        {
            TEnum[] values = EnumExtensions.EnumMap<TEnum>.Map;

            return values[random.Next(values.Length)];
        }
    }
}