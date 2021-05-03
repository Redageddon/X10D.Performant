using X10D.Performant.Int32Extensions;

namespace X10D.Performant.CharExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="char"/>.
    /// </summary>
    public static class CharExtensions
    {
        /// <include file='CharExtensions.xml' path='members/member[@name="GetNextLetter"]'/>
        public static char GetNextLetter(this char value, int amount = 1, bool wrap = false, bool isUpper = false)
        {
            const char lowerChar = 'a';
            const char higherChar = 'z';
            const int alphabetCount = higherChar - lowerChar + 1;

            value = char.ToLower(value);

            // in this case, it is faster than calling the Mod extension
            amount %= alphabetCount;
            int offset = amount + value;

            if (wrap)
            {
                if (amount == 0)
                {
                    return isUpper
                        ? char.ToUpper(value)
                        : value;
                }

                value = (char)(lowerChar + (offset - lowerChar).Mod(alphabetCount));
            }
            else
            {
                if (offset >= higherChar)
                {
                    value = higherChar;
                }
                else if (offset <= lowerChar)
                {
                    value = lowerChar;
                }
                else if (amount == 1)
                {
                    value++;
                }
                else
                {
                    value = (char)offset;
                }
            }

            return isUpper
                ? char.ToUpper(value)
                : value;
        }

        /// <include file='CharExtensions.xml' path='members/member[@name="Repeat"]'/>
        public static string Repeat(this char value, int count) => new(value, count);
    }
}