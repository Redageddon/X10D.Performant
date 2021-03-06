﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using X10D.Performant.ByteExtensions;

namespace X10D.Performant.UInt16Extensions
{
    public static partial class UInt16Extensions
    {
        private static readonly HashSet<ushort> Primes = new();
        private static readonly HashSet<ushort> NonPrimes = new();

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
                if (Primes.Contains(value))
                {
                    return true;
                }

                if (NonPrimes.Contains(value))
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