using System;
using System.Collections.Generic;
using System.Drawing;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Random"/>.
    /// </summary>
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Gets the <see cref="Random"/> instance to which other extension methods may refer, when one is needed but not provided.
        /// </summary>
        internal static Random Random { get; } = new();

        /// <summary>
        ///     Returns a random element from <paramref name="values"/> using the <see cref="Random"/> instance.
        /// </summary>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <param name="values">The collection from which to draw.</param>
        /// <typeparam name="T">The collection type.</typeparam>
        /// <returns>A random element of type <typeparamref name="T"/> from <paramref name="values"/>.</returns>
        public static T OneOf<T>(this Random random, params T[] values) => random.OneOf((IList<T>)values);

        /// <summary>
        ///     Returns a random element from <paramref name="values"/> using the <see cref="Random"/> instance.
        /// </summary>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <param name="values">The collection from which to draw.</param>
        /// <typeparam name="T">The collection type.</typeparam>
        /// <returns>A random element of type <typeparamref name="T"/> from <paramref name="values"/>.</returns>
        public static T OneOf<T>(this Random random, IList<T> values) => values[random.Next(values.Count)];
    }
}