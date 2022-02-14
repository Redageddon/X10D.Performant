using System;
using System.Numerics;

namespace X10D.Performant.UInt64Extensions;

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
    public static ulong ModMul(ulong a, ulong b, ulong modulo)
    {
        ulong high = Math.BigMul(a, b, out ulong low);

        return high switch
        {
            0             => low % modulo,
            <= 0xFFFFFFFF => (ulong)((decimal)a * b % modulo),
            _             => (ulong)((BigInteger)a * b % modulo),
        };
    }
}