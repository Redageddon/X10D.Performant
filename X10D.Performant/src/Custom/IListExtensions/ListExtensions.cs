using System;
using System.Collections.Generic;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="IList{T}"/>
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        ///     Returns a random element from <paramref name="values"/> using the <see cref="Random"/> instance.
        /// </summary>
        /// <param name="values">The <see cref="IList{T}"/> being pulled from.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        /// <returns>A random element of type <typeparamref name="T"/> from <paramref name="values"/>.</returns>
        public static T OneOf<T>(this IList<T> values, Random? random = null) => values[(random ?? RandomExtensions.Random).Next(values.Count)];

        /// <summary>
        ///     Fills <paramref name="buffer"/> randomly with values found in <paramref name="values"/>.
        /// </summary>
        /// <param name="values">The <see cref="IList{T}"/> being pulled from.</param>
        /// <param name="buffer">The <see cref="IList{T}"/> being filled.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <typeparam name="T">Any type.</typeparam>
        public static void Random<T>(this IList<T> values, IList<T> buffer, Random? random = null)
        {
            random ??= RandomExtensions.Random;

            for (int i = 0; i < buffer.Count; i++)
            {
                buffer[i] = values[random.Next(0, values.Count)];
            }
        }

        /// <summary>
        ///     Shuffles <paramref name="values"/>.
        /// </summary>
        /// <typeparam name="T">The collection type.</typeparam>
        /// <param name="values">The <see cref="IList{T}"/> to shuffle.</param>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        public static void Shuffle<T>(this IList<T> values, Random? random = null)
        {
            random ??= RandomExtensions.Random;

            int count = values.Count;

            while (count > 0)
            {
                int index = random.Next(count--);

                T temp = values[count];
                values[count] = values[index];
                values[index] = temp;
            }
        }
    }
}