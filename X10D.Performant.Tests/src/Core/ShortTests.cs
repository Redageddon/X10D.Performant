using System;
using System.Diagnostics;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Int16Extensions"/>.
    /// </summary>
    public class ShortTests
    {
        /// <summary>
        ///     Tests for <see cref="Int16Extensions.FromUnixTimestamp"/>.
        /// </summary>
        [Test]
        public void FromUnixTimestamp()
        {
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:20:34"), ((short)1234).FromUnixTimestamp());
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:01.234"), ((short)1234).FromUnixTimestamp(true));
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.FromUnixTimestamp"/>.
        /// </summary>
        [Test]
        public void FromUnixTimestampU()
        {
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:20:34"), ((ushort)1234U).FromUnixTimestamp());
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:01.234"), ((ushort)1234U).FromUnixTimestamp(true));
        }

        /// <summary>
        ///     Tests for <see cref="Int16Extensions.IsEven(short)"/>.
        /// </summary>
        [Test]
        public void IsEven()
        {
            Assert.IsTrue(((short)2).IsEven());
            Assert.IsFalse(((short)1).IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.IsEven"/>.
        /// </summary>
        [Test]
        public void IsEvenU()
        {
            Assert.IsTrue(((ushort)2).IsEven());
            Assert.IsFalse(((ushort)1).IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="Int16Extensions.IsOdd(short)"/>.
        /// </summary>
        [Test]
        public void IsOdd()
        {
            Assert.IsFalse(((short)2).IsOdd());
            Assert.IsTrue(((short)1).IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOddU()
        {
            Assert.IsFalse(((ushort)2).IsOdd());
            Assert.IsTrue(((ushort)1).IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="Int16Extensions.IsPrime"/>.
        /// </summary>
        [Test]
        public void IsPrime()
        {
            short[] primes = { 2, 11, 101, 1_009, 10_007 };

            for (int i = 0; i < primes.Length; i++)
            {
                if (!primes[i].IsPrime())
                {
                    Console.WriteLine(primes[i]);
                }

                Assert.IsTrue(primes[i].IsPrime());
            }

            short[] nonPrimes = { -10_007, -1_009, -101, -11, -2, -1, 0, 1, 4, 29_001 };

            for (int i = 0; i < nonPrimes.Length; i++)
            {
                if (nonPrimes[i].IsPrime())
                {
                    Console.WriteLine(nonPrimes[i]);
                }

                Assert.IsFalse(nonPrimes[i].IsPrime());
            }
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.IsPrime"/>.
        /// </summary>
        [Test]
        public void IsPrimeU()
        {
            ushort[] primes = { 2, 11, 101, 1_009, 10_007 };

            for (int i = 0; i < primes.Length; i++)
            {
                if (!primes[i].IsPrime())
                {
                    Console.WriteLine(primes[i]);
                }

                Assert.IsTrue(primes[i].IsPrime());
            }

            ushort[] nonPrimes = { 0, 1, 4, 29_001 };

            for (int i = 0; i < nonPrimes.Length; i++)
            {
                if (nonPrimes[i].IsPrime())
                {
                    Console.WriteLine(nonPrimes[i]);
                }

                Assert.IsFalse(nonPrimes[i].IsPrime());
            }
        }

        /// <summary>
        ///     Tests for <see cref="Int16Extensions.Mod"/>.
        /// </summary>
        [Test]
        public void Mod()
        {
            for (short i = -100; i < 100; i++)
            {
                for (short j = -100; j < 100; j++)
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
        ///     Tests for <see cref="UInt16Extensions.Mod"/>.
        /// </summary>
        [Test]
        public void ModU()
        {
            for (ushort i = 1; i < 200; i++)
            {
                for (ushort j = 1; j < 200; j++)
                {
                    Assert.AreEqual(i % j, i.Mod(j));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="Int16Extensions.ToBoolean(short)"/>.
        /// </summary>
        [Test]
        public void ToBool()
        {
            Assert.IsTrue(((short)2).ToBoolean());
            Assert.IsTrue(((short)1).ToBoolean());
            Assert.IsFalse(((short)0).ToBoolean());
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.ToBoolean"/>.
        /// </summary>
        [Test]
        public void ToBoolU()
        {
            Assert.IsFalse(((ushort)0).ToBoolean());
            Assert.IsTrue(((ushort)1).ToBoolean());
            Assert.IsTrue(((ushort)2).ToBoolean());
        }
    }
}