﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    public static partial class UInt16Extensions
    {
        private static readonly HashSet<ushort> Primes = new();
        private static readonly HashSet<ushort> NonPrimes = new();

        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPrime(this ushort value, bool useCache = false)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3:
                case 5:
                case 7:
                case 11:
                case 13:
                case 17:
                case 19:
                case 23:
                case 29:
                case 31:
                case 37:
                case 41:
                case 43:
                case 47:
                case 53:
                case 59:
                case 61:
                case 67:
                case 71:
                case 73:
                case 79:
                case 83:
                case 89:
                case 97:
                case 101:
                case 103:
                case 107:
                case 109:
                case 113:
                case 127:
                case 131:
                case 137:
                case 139:
                case 149:
                case 151:
                case 157:
                case 163:
                case 167:
                case 173:
                case 179:
                case 181:
                case 191:
                case 193:
                case 197:
                case 199:
                case 211:
                case 223:
                case 227:
                case 229:
                case 233:
                case 239:
                case 241:
                case 251: return true;
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