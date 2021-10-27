using X10D.Performant.ByteExtensions;

namespace X10D.Performant.Int16Extensions
{
    public static partial class Int16Extensions
    {
        /// <include file='Int16Extensions.copy.xml' path='members/member[@name="IsPrime"]'/>
        public static bool IsPrime(this short value, bool useCache = false)
        {
            switch (value)
            {
                case < 2:             return false;
                case < byte.MaxValue: return ((byte)value).IsPrime();
            }

            if (useCache)
            {
                if (UInt64Extensions.UInt64Extensions.Primes.Contains((ulong)value))
                {
                    return true;
                }

                if (UInt64Extensions.UInt64Extensions.NonPrimes.Contains((ulong)value))
                {
                    return false;
                }
            }

            for (short i = 5; i * i <= value; i += 6)
            {
                if (Mod(value, i++) == 0
                 || Mod(value, ++i) == 0)
                {
                    if (useCache)
                    {
                        UInt64Extensions.UInt64Extensions.NonPrimes.Add((ulong)value);
                    }

                    return false;
                }
            }

            if (useCache)
            {
                UInt64Extensions.UInt64Extensions.Primes.Add((ulong)value);
            }

            return true;
        }
    }
}