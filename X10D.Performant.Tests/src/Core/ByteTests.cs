using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ByteExtensions"/>.
    /// </summary>
    public class ByteTests
    {
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToEncodedString(byte[],Encoding)"/>.
        /// </summary>
        [Test]
        public void GetUtf8String()
        {
            byte[] a = { 0x48, 0xc3, 0xa9, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };
            Assert.AreEqual("H\u00e9llo World", a.ToEncodedString());
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
        ///     Tests for <see cref="ByteExtensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOdd()
        {
            Assert.IsFalse(((byte)2).IsOdd());
            Assert.IsTrue(((byte)1).IsOdd());
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
        public void IsPrimeSigned()
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
        ///     Tests for <see cref="ByteExtensions.ToBoolean"/>.
        /// </summary>
        [Test]
        public void ToBool()
        {
            Assert.IsTrue(((byte)2).ToBoolean());
            Assert.IsTrue(((byte)1).ToBoolean());
            Assert.IsFalse(((byte)0).ToBoolean());
        }
    }
}