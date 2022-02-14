using System.Runtime.CompilerServices;
using X10D.Performant.ByteExtensions;

namespace X10D.Performant.UInt16Extensions;

public static partial class UInt16Extensions
{
    /// <include file='UInt16Extensions.copy.xml' path='members/member[@name="IsPrime"]'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPrime(this ushort value, bool useCache = false)
    {
        switch (value)
        {
            case < 2:             return false;
            case < byte.MaxValue: return ((byte)value).IsPrime();
        }

        if (useCache)
        {
            if (UInt64Extensions.UInt64Extensions.Primes.Contains(value))
            {
                return true;
            }

            if (UInt64Extensions.UInt64Extensions.NonPrimes.Contains(value))
            {
                return false;
            }
        }

        for (ushort i = 5; i * i <= value; i += 6)
        {
            if (Mod(value, i++) == 0
             || Mod(value, ++i) == 0)
            {
                if (useCache)
                {
                    UInt64Extensions.UInt64Extensions.NonPrimes.Add(value);
                }

                return false;
            }
        }

        if (useCache)
        {
            UInt64Extensions.UInt64Extensions.Primes.Add(value);
        }

        return true;
    }
}