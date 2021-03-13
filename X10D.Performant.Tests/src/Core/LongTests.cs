using System;
using System.Diagnostics;
using NUnit.Framework;
using X10D.Performant.Int64Extensions;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Int64Extensions"/>.
    /// </summary>
    public class LongTests
    {
        /// <summary>
        ///     Tests for <see cref="Int64Extensions.FromUnixTimestamp"/>.
        /// </summary>
        [Test]
        public void FromUnixTimestamp()
        {
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:20:34"), 1234L.FromUnixTimestamp());
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:01.234"), 1234L.FromUnixTimestamp(true));
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.FromUnixTimestamp"/>.
        /// </summary>
        [Test]
        public void FromUnixTimestampU()
        {
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:20:34"), 1234UL.FromUnixTimestamp());
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:01.234"), 1234UL.FromUnixTimestamp(true));
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsEven"/>.
        /// </summary>
        [Test]
        public void IsEven()
        {
            Assert.IsTrue(2L.IsEven());
            Assert.IsFalse(1L.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsEven"/>.
        /// </summary>
        [Test]
        public void IsEvenU()
        {
            Assert.IsTrue(2ul.IsEven());
            Assert.IsFalse(1ul.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOdd()
        {
            Assert.IsFalse(2L.IsOdd());
            Assert.IsTrue(1L.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOddU()
        {
            Assert.IsFalse(2ul.IsOdd());
            Assert.IsTrue(1ul.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsPrime"/>.
        /// </summary>
        [Test]
        public void IsPrime()
        {
            long[] primes =
            {
                1_372_051, 9_040_861, 25_122_011, 3_211_891_519, 4_734_234_247, 1_116_295_198_451, 2_090_609_914_951, 3_278_744_415_797,
                333_555_577_577_777, 3_441_173_392_933_731_913,
            };

            for (long i = 0; i < primes.Length; i++)
            {
                bool isPrime = primes[i].IsPrime();
                Trace.WriteLineIf(!isPrime, primes[i]);
                Assert.IsTrue(isPrime);
            }

            long[] nonPrimes =
            {
                -1_000_000_007, -100_000_007, -10_000_019, -1_003_001, -100_001, -10_007, -1_009, -101, -11, -2, -1, 0, 1, 4, 29_001,
            };

            for (long i = 0; i < nonPrimes.Length; i++)
            {
                bool isPrime = nonPrimes[i].IsPrime();
                Trace.WriteLineIf(isPrime, nonPrimes[i]);
                Assert.IsFalse(isPrime);
            }
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsPrime"/>.
        /// </summary>
        [Test]
        public void IsPrimeU()
        {
            ulong[] primes =
            {
                2, 1_372_051, 9_040_861, 25_122_011, 3_211_891_519, 4_734_234_247, 1_116_295_198_451, 2_090_609_914_951, 3_278_744_415_797,
                333_555_577_577_777, 3_441_173_392_933_731_913, 10_089_886_811_898_868_001,
            };

            for (long i = 0; i < primes.Length; i++)
            {
                bool isPrime = primes[i].IsPrime();
                Trace.WriteLineIf(!isPrime, primes[i]);
                Assert.IsTrue(isPrime);
            }

            ulong[] nonPrimes = { 0, 1, 4, 6, 25, 65545, 75361 };

            for (int i = 0; i < nonPrimes.Length; i++)
            {
                bool isPrime = nonPrimes[i].IsPrime();
                Trace.WriteLineIf(isPrime, nonPrimes[i]);
                Assert.IsFalse(isPrime);
            }
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.Mod"/>.
        /// </summary>
        [Test]
        public void Mod()
        {
            for (long i = -100; i < 100; i++)
            {
                for (long j = -100; j < 100; j++)
                {
                    if (j == 0)
                    {
                        continue;
                    }

                    Assert.AreEqual(i % j, i.Mod(j));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.Mod"/>.
        /// </summary>
        [Test]
        public void ModU()
        {
            for (ulong i = 1; i < 200; i++)
            {
                for (ulong j = 1; j < 200; j++)
                {
                    Assert.AreEqual(i % j, i.Mod(j));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.ToBoolean"/>.
        /// </summary>
        [Test]
        public void ToBool()
        {
            Assert.IsTrue(2L.ToBoolean());
            Assert.IsTrue(1L.ToBoolean());
            Assert.IsFalse(0L.ToBoolean());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.ToBoolean"/>.
        /// </summary>
        [Test]
        public void ToBoolU()
        {
            Assert.IsFalse(0ul.ToBoolean());
            Assert.IsTrue(1ul.ToBoolean());
            Assert.IsTrue(2ul.ToBoolean());
        }
    }
}