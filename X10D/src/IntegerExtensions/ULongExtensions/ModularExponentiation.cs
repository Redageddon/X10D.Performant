using System;
using System.Numerics;

namespace X10D.Performant.ULongExtensions
{
    public static partial class ULongExtensions
    {
        /// <summary>
        ///     Performs a fast and overflow proof modular exponentiation.
        /// </summary>
        /// <param name="value">The value being raised.</param>
        /// <param name="exponent">The value that is raising.</param>
        /// <param name="modulus">The modulo to be applied to the result.</param>
        /// <returns><see cref="value"/> raised by <see cref="exponent"/> and then modded by <see cref="modulus"/>.</returns>
        public static ulong ModPow(ulong value, ulong exponent, ulong modulus)
        {
            value = FastMod(value, modulus);
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
                    value = FastMod(value, modulus);
                }
                else
                {
                    value = Mod(Math.BigMul(value, value, out ulong lowBits), lowBits, modulus);
                }
                
                if ((exponent & 1) == 1)
                {
                    if (value < uint.MaxValue && result < uint.MaxValue)
                    {
                        result *= value;
                        result = FastMod(result, modulus);
                    }
                    else
                    {
                        result = Mod(Math.BigMul(value, result, out ulong lowBits), lowBits, modulus);
                    }
                }
            }
            return result;
        }
        
        private static ulong Mod(ulong highBits, ulong lowBits, ulong modulus)
        {
            if (highBits >= modulus)
            {
                highBits = FastMod(highBits, modulus);
            }

            if (highBits == 0)
            {
                return FastMod(lowBits, modulus);
            }
            
            int shift = 0;

            if (modulus >> 63 == 0)
            {
                if (modulus >> 62 != 0)
                {
                    shift = 1;
                }
                else if (modulus >> 61 != 0)
                {
                    shift = 2;
                }
                else if (modulus >> 60 != 0)
                {
                    shift = 3;
                }
                else
                {
                    shift = BitOperations.LeadingZeroCount(modulus >> 32);
                }
                
                highBits = (highBits << shift) | (lowBits >> (64 - shift));
                lowBits <<= shift;
                modulus <<= shift;
            }

            uint lowerLowBits = (uint)lowBits;
            ulong upperLowBits = lowBits >> 32;
            
            ulong lowerHighBits = (highBits << 32) + upperLowBits;
            
            ulong modulusLowBits = (uint)modulus;
            ulong modulusHighBits = modulus >> 32;
            
            ulong dividedHighBits = highBits / modulusHighBits;
            ulong moddedHighBits, left, right;
            
            if (dividedHighBits != 0)
            {
                moddedHighBits = FastMod(highBits, modulusHighBits);
                right = (moddedHighBits << 32) | upperLowBits;
                left = dividedHighBits * modulusLowBits;

                ulong truncatedHighBits = (uint)dividedHighBits;
                ulong truncatedModdedHighBits = (uint)moddedHighBits;
                while (dividedHighBits != truncatedHighBits || left > right)
                {
                    dividedHighBits--;
                    moddedHighBits += modulusHighBits;

                    if (moddedHighBits != truncatedModdedHighBits)
                    {
                        break;
                    }

                    right = (moddedHighBits << 32) | upperLowBits;
                    left -= modulusLowBits;
                }

                lowerHighBits -= dividedHighBits * modulus;
            }

            ulong quotientLow = lowerHighBits / modulusHighBits;
            moddedHighBits = FastMod(lowerHighBits, modulusHighBits);
            right = (moddedHighBits << 32) | lowerLowBits;
            left = quotientLow * modulusLowBits;

            ulong truncatedQuotientLow = (uint)quotientLow;
            while (quotientLow != truncatedQuotientLow || left > right)
            {
                quotientLow--;
                moddedHighBits += modulusHighBits;

                if (moddedHighBits != (uint)moddedHighBits)
                {
                    break;
                }

                right = (moddedHighBits << 32) | lowerLowBits;
                left -= modulusLowBits;
            }

            return ((lowerHighBits << 32) + (lowerLowBits - (quotientLow * modulus))) >> shift;
        }
    }
}