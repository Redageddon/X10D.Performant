namespace X10D.Performant.UInt64Extensions
{
    public static partial class UInt64Extensions
    {
        /// <include file='UInt64Extensions.xml' path='members/member[@name="ModPow"]'/>
        public static ulong ModPow(this ulong value, ulong exponent, ulong modulus)
        {
            value = value.Mod(modulus);
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
                    value = value.Mod(modulus);
                }
                else
                {
                    value = ModMul(value, value, modulus);
                }

                if ((exponent & 1) == 1)
                {
                    if (value < uint.MaxValue
                     && result < uint.MaxValue)
                    {
                        result *= value;
                        result = result.Mod(modulus);
                    }
                    else
                    {
                        result = ModMul(value, result, modulus);
                    }
                }
            }

            return result;
        }

        /// <include file='UInt64Extensions.xml' path='members/member[@name="ModMul"]'/>
        public static ulong ModMul(ulong a, ulong b, ulong modulus)
        {
            ulong result = 0UL;

            if (b >= modulus)
            {
                if (modulus > 0x7FFFFFFFFFFFFFFF)
                {
                    b -= modulus;
                }
                else
                {
                    b %= modulus;
                }
            }

            while (a != 0UL)
            {
                if ((a & 1UL) != 0UL)
                {
                    if (b >= modulus - result)
                    {
                        result -= modulus;
                    }

                    result += b;
                }

                a >>= 1;

                ulong temp = b;

                if (b >= modulus - b)
                {
                    temp -= modulus;
                }

                b += temp;
            }

            return result;
        }
    }
}