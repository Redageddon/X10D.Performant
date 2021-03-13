using System;

namespace X10D.Performant.RandomExtensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Creates a new <see cref="System.Random"/> from an already existing <see cref="System.Random"/>.
        /// </summary>
        /// <param name="random">The random instance getting the seed.</param>
        /// <returns>A new <see cref="System.Random"/> instance with the seed provided by <paramref name="random"/>.</returns>
        public static Random NextRandom(this Random random) => new(random.Next());
    }
}