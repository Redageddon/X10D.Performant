using System.Numerics;

namespace X10D.Performant.LongExtensions
{
    public static partial class LongExtensions
    {
        /// <summary>
        ///     Determines if the <paramref name="value"/> is a prime value.
        /// </summary>
        /// <param name="value">An integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is prime, <see langword="false"/> otherwise.</returns>
        public static bool IsPrime(long value)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3: return true;
            }

            if (value % 2 == 0 ||
                value % 3 == 0)
            {
                return false;
            }

            if ((value + 1) % 6 != 0 &&
                (value - 1) % 6 != 0)
            {
                return false;
            }

            return value < ushort.MaxValue
                ? IsPrimeSieve(value)
                : IsPrimeMiller(value);
        }

        private static bool IsPrimeSieve(long value)
        {
            for (long i = 5; i * i <= value; i += 6)
            {
                if (value % i == 0 ||
                    value % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static readonly long[] Lt1373653 = { 2, 3 };
        private static readonly long[] Lt9080191 = { 31, 73 };
        private static readonly long[] Lt25326001 = { 2, 3, 5 };
        private static readonly long[] Lt3215031751 = { 2, 3, 5, 7 };
        private static readonly long[] Lt4759123141 = { 2, 7, 61 };
        private static readonly long[] Lt1122004669633 = { 2, 13, 23, 1662803 };
        private static readonly long[] Lt2152302898747 = { 2, 3, 5, 7, 11 };
        private static readonly long[] Lt3474749660383 = { 2, 3, 5, 7, 11, 13 };
        private static readonly long[] Lt341550071728321 = { 2, 3, 5, 7, 11, 13, 17 };
        private static readonly long[] Lt3825123056546413051 = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
        private static readonly long[] Lt18446744073709551616 = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };

        private static bool IsPrimeMiller(long value) =>
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
                var _                       => MillerTest(value, Lt18446744073709551616),
            };

        private static bool MillerTest(long value, long[] witnesses)
        {
            long valueMinusOne = value - 1;
            long d = valueMinusOne / 2;
            byte s = 1;

            while ((d & 1) == 0)
            {
                d /= 2;
                s++;
            }

            for (long i = 0; i < witnesses.Length; i++)
            {
                long witness = witnesses[i];

                if ((witness >= value && witness % value < 2) ||
                    witness == valueMinusOne)
                {
                    continue;
                }

                long x = (long)BigInteger.ModPow(witness, d, value);

                if (x == 1)
                {
                    continue;
                }

                for (long r = 1; x != valueMinusOne && r < s; r++)
                {
                    x = x * x % value;

                    if (x == 1)
                    {
                        return false;
                    }
                }

                if (x != valueMinusOne)
                {
                    return false;
                }
            }

            return true;
        }
    }
}