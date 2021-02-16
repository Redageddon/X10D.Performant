using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="char"/>.
    /// </summary>
    public static partial class CharExtensions
    {
        /// <summary>
        ///     Repeats a <see cref="char"/> a specified number of times.
        /// </summary>
        /// <param name="value">The <see cref="char"/> to repeat.</param>
        /// <param name="count">The amount of times to repeat.</param>
        /// <returns>A <see cref="string"/> whose value is <paramref name="value"/> repeated <paramref name="count"/> times.</returns>
        public static string Repeat(this char value, int count) => new(value, count);

        /// <summary>
        ///     Gets the next or previous letter by a specified amount.
        /// </summary>
        /// <param name="value">The base character.</param>
        /// <param name="amount">The amount to shift left or right.</param>
        /// <param name="wrap">Whether or not the character should wrap around the alphabet.</param>
        /// <param name="isUpper">If the returned value should be uppercase.</param>
        /// <returns>The cycled letter.</returns>
        /// <exception cref="ArgumentException">If <paramref name="value"/> is not a character.</exception>
        public static char GetNextLetter(this char value, int amount = 1, bool wrap = false, bool isUpper = false)
        {
            value = value.ToLower();
            if (value < 97 || value > 122)
            {
                throw new ArgumentException($"{nameof(value)} should be a letter");
            }
            
            amount %= 26;
            
            if (wrap)
            {
                if (amount == 0)
                {
                    return isUpper
                        ? value.ToUpper()
                        : value;
                }

                value = (char)(96 + ((value - 96 + amount) % 26));
            }
            else
            {
                if (value + amount >= 122)
                {
                    value = 'z';
                }
                else if (value + amount <= 97)
                {
                    value = 'a';
                }
                else if (amount == 1)
                {
                    value++;
                }
                else
                {
                    value = (char)(value + amount);
                }
            }

            if (isUpper)
            {
                value = value.ToUpper();
            }

            return value;
        }
    }
}