using System;
using System.Text;

namespace X10D.Performant.RandomExtensions
{
    public static partial class RandomExtensions
    {
        private static readonly StringBuilder StringBuilder = new();

        /// <summary>
        ///     Creates a new <see cref="string"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="charCount">The amount of chars in the string.</param>
        /// <param name="startingChar">The inclusive lower bound.</param>
        /// <param name="endingChar">The exclusive upper bound.</param>
        /// <param name="ensureOneNextCall">
        ///     If <see langword="true"/> <paramref name="random"/> has <see cref="System.Random.Next()"/> called only one time.
        /// </param>
        /// <returns>A new random <see cref="string"/>.</returns>
        public static string NextString(this Random random, int charCount, char startingChar = 'a', char endingChar = '{', bool ensureOneNextCall = false)
        {
            StringBuilder.Clear();
            StringBuilder.Capacity = charCount;

            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                for (int i = 0; i < charCount; i++)
                {
                    StringBuilder.Append(delegatedRandom.NextChar(startingChar, endingChar));
                }

                return StringBuilder.ToString();
            }

            for (int i = 0; i < charCount; i++)
            {
                StringBuilder.Append(random.NextChar(startingChar, endingChar));
            }

            return StringBuilder.ToString();
        }
    }
}