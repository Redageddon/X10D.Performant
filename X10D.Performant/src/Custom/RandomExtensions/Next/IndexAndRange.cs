using System;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Returns a new random <see cref="Index"/>.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the range.</param>
        /// <param name="maxValue">The exclusive upper bound of the range.</param>
        /// <param name="fromEnd">Indicating if the index is from the start or from the end.</param>
        /// <returns>A new <see cref="Index"/> with supplied values.</returns>
        public static Index NextIndex(this Random random, int minValue, int maxValue, bool fromEnd = false) =>
            new(random.Next(minValue, maxValue), fromEnd);

        /// <summary>
        ///     Returns a new random <see cref="Index"/>.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the range.</param>
        /// <param name="fromEnd">Indicating if the index is from the start or from the end.</param>
        /// <returns>A new <see cref="Index"/> with supplied values.</returns>
        public static Index NextIndex(this Random random, int maxValue, bool fromEnd = false) =>
            new(random.Next(maxValue), fromEnd);

        /// <summary>
        ///     Returns a new random <see cref="Range"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="indexStartMinValue">The inclusive lower bound of the starting index.</param>
        /// <param name="indexStartMaxValue">The exclusive upper bound of the starting index.</param>
        /// <param name="indexEndMinValue">The inclusive lower bound of the ending index.</param>
        /// <param name="indexEndMaxValue">The exclusive upper bound of the ending index.</param>
        /// <param name="indexStartFromEnd">Indicating if the starting index is from the start or from the end.</param>
        /// <param name="indexEndFromEnd">Indicating if the ending index is from the start or from the end.</param>
        /// <param name="ensureOneNextCall">If true <paramref name="random"/> only has <see cref="System.Random.Next()"/> called once.</param>
        /// <returns>A new <see cref="Range"/> with supplied values.</returns>
        public static Range NextRange(this Random random,
                                      int indexStartMinValue,
                                      int indexStartMaxValue,
                                      int indexEndMinValue,
                                      int indexEndMaxValue,
                                      bool indexStartFromEnd = false,
                                      bool indexEndFromEnd = false,
                                      bool ensureOneNextCall = false)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Range(delegatedRandom.NextIndex(indexStartMinValue, indexStartMaxValue, indexStartFromEnd),
                                 delegatedRandom.NextIndex(indexEndMinValue, indexEndMaxValue, indexEndFromEnd));
            }

            return new Range(random.NextIndex(indexStartMinValue, indexStartMaxValue, indexStartFromEnd),
                             random.NextIndex(indexEndMinValue, indexEndMaxValue, indexEndFromEnd));
        }

        /// <summary>
        ///     Returns a new random <see cref="Range"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="indexStartMaxValue">The exclusive upper bound of the starting index.</param>
        /// <param name="indexEndMaxValue">The exclusive upper bound of the ending index.</param>
        /// <param name="indexStartFromEnd">Indicating if the starting index is from the start or from the end.</param>
        /// <param name="indexEndFromEnd">Indicating if the ending index is from the start or from the end.</param>
        /// <param name="ensureOneNextCall">If <see langword="true"/> <paramref name="random"/> only has <see cref="System.Random.Next()"/> called once.</param>
        /// <returns>A new <see cref="Range"/> with supplied values.</returns>
        public static Range NextRange(this Random random,
                                      int indexStartMaxValue,
                                      int indexEndMaxValue,
                                      bool indexStartFromEnd = false,
                                      bool indexEndFromEnd = false,
                                      bool ensureOneNextCall = false)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Range(delegatedRandom.NextIndex(indexStartMaxValue, indexStartFromEnd),
                                 delegatedRandom.NextIndex(indexEndMaxValue, indexEndFromEnd));
            }

            return new Range(random.NextIndex(indexStartMaxValue, indexStartFromEnd),
                             random.NextIndex(indexEndMaxValue, indexEndFromEnd));
        }
    }
}