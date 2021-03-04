using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ByteExtensions"/>.
    /// </summary>
    public class ByteTests
    {
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.FromUnixTimestamp"/>.
        /// </summary>
        [Test]
        public void FromUnixTimestamp()
        {
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:04:15"), ((byte)255).FromUnixTimestamp());
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:00.255"), ((byte)255).FromUnixTimestamp(true));
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.FromUnixTimestamp"/>.
        /// </summary>
        [Test]
        public void FromUnixTimestampU()
        {
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:02:07"), ((sbyte)127).FromUnixTimestamp());
            Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:00.127"), ((sbyte)127).FromUnixTimestamp(true));
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.IsEven"/>.
        /// </summary>
        [Test]
        public void IsEven()
        {
            Assert.IsTrue(((byte)2).IsEven());
            Assert.IsFalse(((byte)1).IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.IsEven"/>.
        /// </summary>
        [Test]
        public void IsEvenS()
        {
            Assert.IsTrue(((sbyte)2).IsEven());
            Assert.IsFalse(((sbyte)1).IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOdd()
        {
            Assert.IsFalse(((byte)2).IsOdd());
            Assert.IsTrue(((byte)1).IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOddS()
        {
            Assert.IsFalse(((sbyte)2).IsOdd());
            Assert.IsTrue(((sbyte)1).IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.IsPrime"/>.
        /// </summary>
        [Test]
        public void IsPrime()
        {
            byte[] primes =
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131,
                137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251,
            };

            for (byte i = 0; i < byte.MaxValue; i++)
            {
                Trace.WriteLineIf(i.IsPrime() != primes.Contains(i), i);
                Assert.AreEqual(i.IsPrime(), primes.Contains(i));
            }
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.IsPrime"/>.
        /// </summary>
        [Test]
        public void IsPrimeS()
        {
            sbyte[] primes =
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127,
            };

            for (sbyte i = sbyte.MinValue; i < sbyte.MaxValue; i++)
            {
                Trace.WriteLineIf(i.IsPrime() != primes.Contains(i), i);
                Assert.AreEqual(i.IsPrime(), primes.Contains(i));
            }
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.Mod"/>.
        /// </summary>
        [Test]
        public void Mod()
        {
            for (byte i = 100; i < 200; i++)
            {
                for (byte j = 100; j < 200; j++)
                {
                    Assert.AreEqual(i % j, i.Mod(j));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.Mod"/>.
        /// </summary>
        [Test]
        public void ModS()
        {
            for (sbyte i = -100; i < 100; i++)
            {
                for (sbyte j = -100; j < 100; j++)
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
        ///     Tests for <see cref="ByteExtensions.ToBoolean"/>.
        /// </summary>
        [Test]
        public void ToBool()
        {
            Assert.IsTrue(((byte)2).ToBoolean());
            Assert.IsTrue(((byte)1).ToBoolean());
            Assert.IsFalse(((byte)0).ToBoolean());
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.ToBoolean"/>.
        /// </summary>
        [Test]
        public void ToBoolS()
        {
            Assert.IsTrue(((sbyte)2).ToBoolean());
            Assert.IsTrue(((sbyte)1).ToBoolean());
            Assert.IsFalse(((sbyte)0).ToBoolean());
        }
    }
}