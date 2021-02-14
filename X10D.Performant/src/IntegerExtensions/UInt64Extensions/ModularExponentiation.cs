using System;

namespace X10D.Performant
{
    public static partial class UInt64Extensions
    {
        /// <summary>
        ///     Performs a fast and overflow proof modular exponentiation.
        /// </summary>
        /// <param name="value">The value being raised.</param>
        /// <param name="exponent">The value that is raising.</param>
        /// <param name="modulus">The modulo to be applied to the result.</param>
        /// <returns><paramref name="value"/> raised by <paramref name="exponent"/> and then modded by <paramref name="modulus"/>.</returns>
        public static ulong ModPow(this ulong value, ulong exponent, ulong modulus)
        {
            value = Mod(value, modulus);
            ulong result = 1;

            if ((exponent & 1) == 1)
            {
                result = value;
            }

            while (exponent != 0)
            {
                exponent >>= 1;

                if (value < uint.MaxValue)
                {
                    value *= value;
                    value = Mod(value, modulus);
                }
                else
                {
                    value = Mod128By63(Math.BigMul(value, value, out ulong lowBits), lowBits, modulus);
                }

                if ((exponent & 1) == 1)
                {
                    if (value < uint.MaxValue &&
                        result < uint.MaxValue)
                    {
                        result *= value;
                        result = Mod(result, modulus);
                    }
                    else
                    {
                        result = Mod128By63(Math.BigMul(value, result, out ulong lowBits), lowBits, modulus);
                    }
                }
            }

            return result;
        }

        private static ulong Mod128By63(ulong highBits, ulong lowBits, ulong modulus)
        {
            ulong result = 0UL;
            ulong a = (ulong.MaxValue % modulus) + 1UL;
            highBits = Mod(highBits, modulus);

            while (highBits != 0UL)
            {
                if ((highBits & 1UL) == 1UL)
                {
                    result += a;

                    if (result >= modulus)
                    {
                        result -= modulus;
                    }
                }

                a <<= 1;

                if (a >= modulus)
                {
                    a -= modulus;
                }

                highBits >>= 1;
            }

            if (lowBits > modulus)
            {
                lowBits -= modulus;
            }

            return Mod(lowBits + result, modulus);
        }
    }
}