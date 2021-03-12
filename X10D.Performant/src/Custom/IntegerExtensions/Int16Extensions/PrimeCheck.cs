﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    public static partial class Int16Extensions
    {
        private static readonly HashSet<short> Primes = new();
        private static readonly HashSet<short> NonPrimes = new();

        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPrime(this short value, bool useCache = false)
        {
            switch (value)
            {
                case < 2:             return false;
                case < byte.MaxValue: return ((byte)value).IsPrime();
            }

            if (useCache)
            {
                if (Primes.Contains(value))
                {
                    return true;
                }

                if (NonPrimes.Contains(value))
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
                        NonPrimes.Add(value);
                    }

                    return false;
                }
            }

            if (useCache)
            {
                Primes.Add(value);
            }

            return true;
        }
    }
}