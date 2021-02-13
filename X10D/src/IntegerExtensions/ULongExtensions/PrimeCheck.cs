namespace X10D.Performant.ULongExtensions
{
    public static partial class ULongExtensions
    {
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

        /// <summary>
        ///     Determines if the <paramref name="value"/> is a prime value.
        /// </summary>
        /// <param name="value">An integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is prime, <see langword="false"/> otherwise.</returns>
        public static bool IsPrime(ulong value)
        {
            switch (value)
            {
                case < 2: return false;
                case < 4: return true;
            }

            if ((value & 1) == 0 ||
                Mod(value, 3) == 0)
            {
                return false;
            }

            if (Mod(value + 1, 6) != 0 &&
                Mod(value - 1, 6) != 0)
            {
                return false;
            }

            return value < ushort.MaxValue
                ? IsPrimeSieve(value)
                : IsPrimeMiller(value);
        }

        private static bool IsPrimeSieve(ulong value)
        {
            for (ulong i = 5; i * i <= value; i += 6)
            {
                if (Mod(value, i) == 0 ||
                    Mod(value, i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

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
                var _                       => MillerTest(value, Lt18446744073709551616),
            };

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
                ulong x = ModPow(witnesses[i], d, value);
                if (x == 1UL)
                {
                    continue;
                }

                for (ulong r = 1UL; x != oneLessValue && r < s; r++)
                {
                    x = Mod(x * x, value);

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