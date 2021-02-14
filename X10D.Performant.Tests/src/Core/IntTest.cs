using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Int32Extensions" />.
    /// </summary>
    [TestClass]
    public class IntTests
    {
        /// <summary>
        ///     Tests for <see cref="Int32Extensions.GetBytes" />.
        /// </summary>
        [TestMethod]
        public void GetBytes() => CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0 }, ((int)Math.PI).GetBytes());

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.GetBytes" />.
        /// </summary>
        [TestMethod]
        public void GetBytesU() => CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0 }, ((uint)Math.PI).GetBytes());

        /// <summary>
        ///     Tests for <see cref="Int32Extensions.IsEven" />.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2.IsEven());
            Assert.IsFalse(1.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.IsEven" />.
        /// </summary>
        [TestMethod]
        public void IsEvenU()
        {
            Assert.IsTrue(2u.IsEven());
            Assert.IsFalse(1u.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="Int32Extensions.IsOdd" />.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2.IsOdd());
            Assert.IsTrue(1.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.IsOdd" />.
        /// </summary>
        [TestMethod]
        public void IsOddU()
        {
            Assert.IsFalse(2u.IsOdd());
            Assert.IsTrue(1u.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="Int32Extensions.IsPrime" />.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {
            int[] primes = { 2, 11, 101, 1_009, 10_007, 100_003, 1_003_001, 10_000_019, 100_000_007, 1_000_000_007 };

            for (int i = 0; i < primes.Length; i++)
            {
                Trace.WriteLineIf(!primes[i].IsPrime(), primes[i]);
                Assert.IsTrue(primes[i].IsPrime());
            }

            int[] nonPrimes =
            {
                -1_000_000_007, -100_000_007, -10_000_019, -1_003_001, -100_001, -10_007, -1_009, -101, -11, -2, -1, 0, 1, 4, 29_001,
            };

            for (int i = 0; i < nonPrimes.Length; i++)
            {
                Trace.WriteLineIf(nonPrimes[i].IsPrime(), nonPrimes[i]);
                Assert.IsFalse(nonPrimes[i].IsPrime());
            }
        }

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.IsPrime" />.
        /// </summary>
        [TestMethod]
        public void IsPrimeU()
        {
            uint[] primes = { 2, 11, 101, 1_009, 10_007, 100_003, 1_003_001, 10_000_019, 100_000_007, 1_000_000_007, 4_294_967_291 };

            for (uint i = 0; i < primes.Length; i++)
            {
                Trace.WriteLineIf(!primes[i].IsPrime(), primes[i]);
                Assert.IsTrue(primes[i].IsPrime());
            }

            uint[] nonPrimes = { 0, 1, 4, 29_001 };

            for (uint i = 0; i < nonPrimes.Length; i++)
            {
                Trace.WriteLineIf(nonPrimes[i].IsPrime(), nonPrimes[i]);
                Assert.IsFalse(nonPrimes[i].IsPrime());
            }
        }

        /// <summary>
        ///     Tests for <see cref="Int32Extensions.ToBoolean" />.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(2.ToBoolean());
            Assert.IsTrue(1.ToBoolean());
            Assert.IsFalse(0.ToBoolean());
        }

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.ToBoolean" />.
        /// </summary>
        [TestMethod]
        public void ToBoolU()
        {
            Assert.IsFalse(0u.ToBoolean());
            Assert.IsTrue(1u.ToBoolean());
            Assert.IsTrue(2u.ToBoolean());
        }
    }
}