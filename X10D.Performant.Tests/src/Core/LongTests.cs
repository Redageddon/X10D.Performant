using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Int64Extensions"/>.
    /// </summary>
    [TestClass]
    public class LongTests
    {
        /// <summary>
        ///     Tests for <see cref="Int64Extensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes() => CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0, 0, 0, 0, 0 }, ((long)Math.PI).GetBytes());

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2L.IsEven());
            Assert.IsFalse(1L.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2L.IsOdd());
            Assert.IsTrue(1L.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(2L.ToBoolean());
            Assert.IsTrue(1L.ToBoolean());
            Assert.IsFalse(0L.ToBoolean());
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {
            long[] primes =
            {
                2, 11, 101, 1_009, 10_007, 100_003, 1_003_001, 10_000_019, 100_000_007, 1_000_000_007, 10_000_000_019, 100_123_456_789,
                1_000_000_000_039, 10_000_000_000_283, 100_000_000_105_583, 1_000_000_000_100_011, 10_000_000_002_065_383,
                100_109_100_129_100_151, 1_000_000_000_000_000_003,
            };

            for (long i = 0; i < primes.Length; i++)
            {
                Trace.WriteLineIf(!primes[i].IsPrime(), primes[i]);
                Assert.IsTrue(primes[i].IsPrime());
            }

            long[] nonPrimes =
            {
                -1_000_000_007, -100_000_007, -10_000_019, -1_003_001, -100_001, -10_007, -1_009, -101, -11, -2, -1, 0, 1, 4, 29_001,
            };

            for (long i = 0; i < nonPrimes.Length; i++)
            {
                Trace.WriteLineIf(nonPrimes[i].IsPrime(), nonPrimes[i]);
                Assert.IsFalse(nonPrimes[i].IsPrime());
            }
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytesU() => CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0, 0, 0, 0, 0 }, ((ulong)Math.PI).GetBytes());

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEvenU()
        {
            Assert.IsTrue(2ul.IsEven());
            Assert.IsFalse(1ul.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOddU()
        {
            Assert.IsFalse(2ul.IsOdd());
            Assert.IsTrue(1ul.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBoolU()
        {
            Assert.IsFalse(0ul.ToBoolean());
            Assert.IsTrue(1ul.ToBoolean());
            Assert.IsTrue(2ul.ToBoolean());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeU()
        {
            ulong[] primes =
            {
                2, 11, 101, 1_009, 10_007, 100_003, 1_003_001, 10_000_019, 100_000_007, 1_000_000_007, 10_000_000_019, 100_123_456_789,
                1_000_000_000_039, 10_000_000_000_283, 100_000_000_105_583, 1_000_000_000_100_011, 10_000_000_002_065_383,
                100_109_100_129_100_151, 1_000_000_000_000_000_003, 10_089_886_811_898_868_001,
            };

            10_089_886_811_898_868_001UL.IsPrime();

            for (long i = 0; i < primes.Length; i++)
            {
                Trace.WriteLineIf(!primes[i].IsPrime(), primes[i]);
                Assert.IsTrue(primes[i].IsPrime());
            }

            ulong[] nonPrimes = { 0, 1, 4, 29_001 };

            for (long i = 0; i < nonPrimes.Length; i++)
            {
                Trace.WriteLineIf(nonPrimes[i].IsPrime(), nonPrimes[i]);
                Assert.IsFalse(nonPrimes[i].IsPrime());
            }
        }
    }
}