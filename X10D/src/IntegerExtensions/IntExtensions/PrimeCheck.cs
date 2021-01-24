namespace X10D.Performant.IntExtensions
{
    public static partial class IntExtensions
    {
        /// <summary>
        ///     Determines if the <paramref name="value"/> is a prime value.
        /// </summary>
        /// <param name="value">An integer value.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is prime, <see langword="false"/> otherwise.</returns>
        public static bool IsPrime(int value)
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

        private static bool IsPrimeSieve(int value)
        {
            for (int i = 5; i * i <= value; i += 6)
            {
                if (value % i == 0 ||
                    value % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static readonly int[] Lt1373653 = { 2, 3 };
        private static readonly int[] Lt9080191 = { 31, 73 };
        private static readonly int[] Lt25326001 = { 2, 3, 5 };
        private static readonly int[] Lt3215031751 = { 2, 3, 5, 7 };

        private static bool IsPrimeMiller(int value) =>
            value switch
            {
                < 1_373_653  => MillerTest(value, Lt1373653),
                < 9_080_191  => MillerTest(value, Lt9080191),
                < 25_326_001 => MillerTest(value, Lt25326001),
                var _        => MillerTest(value, Lt3215031751), 
            };

        private static bool MillerTest(int value, int[] witnesses)
        {
            int valueMinusOne = value - 1;
            int d = valueMinusOne / 2;
            byte s = 1;

            while ((d & 1) == 0)
            {
                d /= 2;
                s++;
            }

            for (int i = 0; i < witnesses.Length; i++)
            {
                int witness = witnesses[i];

                if ((witness >= value && witness % value < 2) ||
                    witness == valueMinusOne)
                {
                    continue;
                }

                int x = ModPow(witness, d, value);

                if (x == 1)
                {
                    continue;
                }

                for (int r = 1; x != valueMinusOne && r < s; r++)
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
        
        private static int ModPow(int value, int exponent, int modulus)
        {
            int result = 1;

            while (exponent > 0)
            {
                if ((exponent & 1) == 1)
                {
                    result = result * value % modulus;
                }

                exponent >>= 1;
                value = value * value % modulus;
            }

            return result;
        }
    }
}