using System;
using System.Text;

namespace X10D.Performant.RandomExtensions
{
    public static partial class RandomExtensions
    {
        private static readonly StringBuilder StringBuilder = new();

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextString"]'/>
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