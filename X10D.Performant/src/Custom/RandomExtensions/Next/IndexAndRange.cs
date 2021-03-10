using System;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Creates a new random <see cref="Index"/> with the supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the range.</param>
        /// <param name="maxValue">The exclusive upper bound of the range.</param>
        /// <param name="fromEnd">Indicating if the index is from the start or from the end.</param>
        /// <returns>A new <see cref="Index"/> with supplied values.</returns>
        public static Index NextIndex(this Random random, int minValue, int maxValue, bool fromEnd = false) =>
            new(random.Next(minValue, maxValue), fromEnd);

        /// <summary>
        ///     Creates a new random <see cref="Index"/> with the supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the range.</param>
        /// <param name="fromEnd">Indicating if the index is from the start or from the end.</param>
        /// <returns>A new <see cref="Index"/> with supplied values.</returns>
        public static Index NextIndex(this Random random, int maxValue, bool fromEnd = false) =>
            new(random.Next(maxValue), fromEnd);

        /// <summary>
        ///     Creates a new random <see cref="Range"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="indexStartMin">The inclusive lower bound of the starting index.</param>
        /// <param name="indexStartMax">The exclusive upper bound of the starting index.</param>
        /// <param name="indexEndMin">The inclusive lower bound of the ending index.</param>
        /// <param name="indexEndMax">The exclusive upper bound of the ending index.</param>
        /// <param name="indexStartFromEnd">Indicating if the starting index is from the start or from the end.</param>
        /// <param name="indexEndFromEnd">Indicating if the ending index is from the start or from the end.</param>
        /// <param name="ensureOneNextCall">
        ///     If <see langword="true"/> <paramref name="random"/> has <see cref="System.Random.Next()"/> called only one time.
        /// </param>
        /// <returns>A new <see cref="Range"/> with supplied values.</returns>
        public static Range NextRange(this Random random,
                                      int indexStartMin,
                                      int indexStartMax,
                                      int indexEndMin,
                                      int indexEndMax,
                                      bool indexStartFromEnd = false,
                                      bool indexEndFromEnd = false,
                                      bool ensureOneNextCall = false)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Range(delegatedRandom.NextIndex(indexStartMin, indexStartMax, indexStartFromEnd),
                                 delegatedRandom.NextIndex(indexEndMin, indexEndMax, indexEndFromEnd));
            }

            return new Range(random.NextIndex(indexStartMin, indexStartMax, indexStartFromEnd),
                             random.NextIndex(indexEndMin, indexEndMax, indexEndFromEnd));
        }

        /// <summary>
        ///     Creates a new random <see cref="Range"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="indexStartMax">The exclusive upper bound of the starting index.</param>
        /// <param name="indexEndMax">The exclusive upper bound of the ending index.</param>
        /// <param name="indexStartFromEnd">Indicating if the starting index is from the start or from the end.</param>
        /// <param name="indexEndFromEnd">Indicating if the ending index is from the start or from the end.</param>
        /// <param name="ensureOneNextCall">
        ///     If <see langword="true"/> <paramref name="random"/> has <see cref="System.Random.Next()"/> called only one time.
        /// </param>
        /// <returns>A new <see cref="Range"/> with supplied values.</returns>
        public static Range NextRange(this Random random,
                                      int indexStartMax,
                                      int indexEndMax,
                                      bool indexStartFromEnd = false,
                                      bool indexEndFromEnd = false,
                                      bool ensureOneNextCall = false)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Range(delegatedRandom.NextIndex(indexStartMax, indexStartFromEnd),
                                 delegatedRandom.NextIndex(indexEndMax, indexEndFromEnd));
            }

            return new Range(random.NextIndex(indexStartMax, indexStartFromEnd),
                             random.NextIndex(indexEndMax, indexEndFromEnd));
        }
    }
}