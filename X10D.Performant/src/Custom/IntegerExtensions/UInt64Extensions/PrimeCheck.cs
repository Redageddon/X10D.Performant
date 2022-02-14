using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using X10D.Performant.ByteExtensions;
using X10D.Performant.UInt16Extensions;

namespace X10D.Performant.UInt64Extensions;

public static partial class UInt64Extensions
{
    internal static readonly HashSet<ulong> Primes = new();
    internal static readonly HashSet<ulong> NonPrimes = new();

    private static readonly ulong[] Lt18446744073709551616 = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
    private static readonly ulong[] Lt3825123056546413051 = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
    private static readonly ulong[] Lt341550071728321 = { 2, 3, 5, 7, 11, 13, 17 };
    private static readonly ulong[] Lt3474749660383 = { 2, 3, 5, 7, 11, 13 };
    private static readonly ulong[] Lt2152302898747 = { 2, 3, 5, 7, 11 };
    private static readonly ulong[] Lt1122004669633 = { 2, 13, 23, 1662803 };
    private static readonly ulong[] Lt4759123141 = { 2, 7, 61 };
    private static readonly ulong[] Lt3215031751 = { 2, 3, 5, 7 };
    private static readonly ulong[] Lt25326001 = { 2, 3, 5 };
    private static readonly ulong[] Lt9080191 = { 31, 73 };
    private static readonly ulong[] Lt1373653 = { 2, 3 };

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
    private static bool MillerTest(ulong probablePrime, ulong[] witnesses)
    {
        ulong exponent = probablePrime >> 1;
        ulong trailingZeroCount = 1UL + (ulong)BitOperations.TrailingZeroCount(exponent);
        exponent >>= (int)(trailingZeroCount - 1);

        return witnesses.AsParallel().All(witness => CheckPrimality(witness, exponent, probablePrime, trailingZeroCount));
    }

    private static bool CheckPrimality(ulong witness, ulong d, ulong probablePrime, ulong trailingZeroCount)
    {
        ulong oneLessValue = probablePrime - 1UL;
        ulong x = ModPow(witness, d, probablePrime);

        if (x == 1UL)
        {
            return true;
        }

        for (ulong r = 1UL; x != oneLessValue && r < trailingZeroCount; r++)
        {
            x = x <= uint.MaxValue
                ? (x * x).Mod(probablePrime)
                : ModMul(x, x, probablePrime);

            if (x == 1UL)
            {
                return false;
            }
        }

        return x == oneLessValue;
    }
}