﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using X10D.Performant.ByteExtensions;
using X10D.Performant.UInt16Extensions;

namespace X10D.Performant.UInt64Extensions
{
    public static partial class UInt64Extensions
    {
        private static readonly HashSet<ulong> Primes = new();
        private static readonly HashSet<ulong> NonPrimes = new();

        private static readonly ulong[] Lt18446744073709551616 = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
        private static readonly ulong[] Lt3825123056546413051 = Lt18446744073709551616[..9];
        private static readonly ulong[] Lt341550071728321 = Lt18446744073709551616[..7];
        private static readonly ulong[] Lt3474749660383 = Lt18446744073709551616[..6];
        private static readonly ulong[] Lt2152302898747 = Lt18446744073709551616[..5];
        private static readonly ulong[] Lt1122004669633 = { 2, 13, 23, 1662803 };
        private static readonly ulong[] Lt4759123141 = { 2, 7, 61 };
        private static readonly ulong[] Lt3215031751 = Lt18446744073709551616[..4];
        private static readonly ulong[] Lt25326001 = Lt18446744073709551616[..3];
        private static readonly ulong[] Lt9080191 = { 31, 73 };
        private static readonly ulong[] Lt1373653 = Lt18446744073709551616[..2];

        /// <include file='UInt64Extensions.xml' path='members/member[@name="IsPrime"]'/>
        public static bool IsPrime(this ulong value, bool useCache = false)
        {
            switch (value)
            {
                case < 2:               return false;
                case < byte.MaxValue:   return ((byte)value).IsPrime();
                case < ushort.MaxValue: return ((ushort)value).IsPrime(useCache);
            }

            if (useCache)
            {
                if (IsPrimeMiller(value))
                {
                    Primes.Add(value);

                    return true;
                }

                NonPrimes.Add(value);

                return false;
            }

            return IsPrimeMiller(value);
        }

        // Miller test is probabilistic, but provided enough of the right parameters it can become deterministic
        private static bool IsPrimeMiller(ulong value) =>
            value switch
            {
                < 1_373_653                 => MillerTest(value, Lt1373653),
                < 9_080_191                 => MillerTest(value, Lt9080191),
                < 25_326_001                => MillerTest(value, Lt25326001),
                < 3_215_031_751             => MillerTest(value, Lt3215031751),
                < 4_759_123_141             => MillerTest(value, Lt4759123141),
                < 1_122_004_669_633         => MillerTest(value, Lt1122004669633),
                < 2_152_302_898_747         => MillerTest(value, Lt2152302898747),
                < 3_474_749_660_383         => MillerTest(value, Lt3474749660383),
                < 341_550_071_728_321       => MillerTest(value, Lt341550071728321),
                < 3_825_123_056_546_413_051 => MillerTest(value, Lt3825123056546413051),
                _                           => MillerTest(value, Lt18446744073709551616),
            };

        // TODO: remove big int dependencies
        [SuppressMessage("ReSharper", "ForCanBeConvertedToForeach")]
        [SuppressMessage("ReSharper", "SuggestBaseTypeForParameter")]
        private static bool MillerTest(ulong value, ulong[] witnesses)
        {
            ulong oneLessValue = value - 1UL;
            ulong d = value >> 1;
            ulong s = 1UL;

            while ((d & 1) == 0)
            {
                d >>= 1;
                ++s;
            }

            for (int i = 0; i < witnesses.Length; i++)
            {
                ulong x = value > long.MaxValue
                    ? (ulong)BigInteger.ModPow(witnesses[i], d, value)
                    : ModPow(witnesses[i], d, value);

                if (x == 1UL)
                {
                    continue;
                }

                for (ulong r = 1UL; x != oneLessValue && r < s; r++)
                {
                    if (x < uint.MaxValue)
                    {
                        x = Mod(x * x, value);
                    }
                    else if (value > long.MaxValue)
                    {
                        BigInteger bigX = x;
                        BigInteger bigValue = value;
                        x = (ulong)(bigX * bigX % bigValue);
                    }
                    else if (x < long.MaxValue)
                    {
                        x = Mod128By63(Math.BigMul(x, x, out ulong lowBits), lowBits, value);
                    }

                    if (x == 1UL)
                    {
                        return false;
                    }
                }

                if (x != oneLessValue)
                {
                    return false;
                }
            }

            return true;
        }
    }
}