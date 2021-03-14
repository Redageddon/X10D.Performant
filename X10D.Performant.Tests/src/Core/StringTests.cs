using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using NUnit.Framework;
using X10D.Performant.StringExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="StringExtensions"/>.
    /// </summary>
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class StringTests
    {
        /// <summary>
        ///     Tests for <see cref="StringExtensions.Base64Decode(string, Encoding)"/>.
        /// </summary>
        [Test]
        public void Base64Decode() => Assert.AreEqual("hello", "aGVsbG8=".Base64Decode());

        /// <summary>
        ///     Tests for <see cref="StringExtensions.Base64Encode(string, Encoding)"/>.
        /// </summary>
        [Test]
        public void Base64Encode() => Assert.AreEqual("aGVsbG8=", "hello".Base64Encode());

        /// <summary>
        ///     Tests for <see cref="StringExtensions.ChangeEncoding(string, Encoding, Encoding)"/>.
        /// </summary>
        [Test]
        public void ChangeEncoding() => Assert.AreEqual("HELLO", "ĤĚĻĻŎ".ChangeEncoding(Encoding.Latin1, Encoding.ASCII));

        /// <summary>
        ///     Tests for <see cref="StringExtensions.GetBytes(string,Encoding)"/>.
        /// </summary>
        [Test]
        public void GetBytes() => CollectionAssert.AreEqual(new byte[] { 84, 101, 115, 116 }, ReExposed.StringExtensions.GetBytes("Test"));

        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsAlpha(string)"/>.
        /// </summary>
        [Test]
        public void IsAlpha()
        {
            Assert.IsTrue("ABCD".IsAlpha());
            Assert.IsTrue("abcd".IsAlpha());
            Assert.IsFalse("AB12".IsAlpha());
            Assert.IsFalse("1234".IsAlpha());
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsLower(string)"/>.
        /// </summary>
        [Test]
        public void IsLower()
        {
            Assert.IsFalse("AB1234CD".IsLower());
            Assert.IsTrue("ab1234cd".IsLower());
            Assert.IsFalse("AB1234cd".IsLower());
            Assert.IsFalse("ab1234CD".IsLower());
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsNumerical(string)"/>.
        /// </summary>
        [Test]
        public void IsNumerical()
        {
            Assert.IsFalse("ABCD".IsNumerical());
            Assert.IsFalse("abcd".IsNumerical());
            Assert.IsFalse("AB12".IsNumerical());
            Assert.IsTrue("1234".IsNumerical());
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsUpper(string)"/>.
        /// </summary>
        [Test]
        public void IsUpper()
        {
            Assert.IsTrue("AB1234CD".IsUpper());
            Assert.IsFalse("ab1234cd".IsUpper());
            Assert.IsFalse("AB1234cd".IsUpper());
            Assert.IsFalse("ab1234CD".IsUpper());
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.Repeat"/>.
        /// </summary>
        [Test]
        public void Repeat()
        {
            Assert.AreEqual("", "abc".Repeat(-1));
            Assert.AreEqual("", "abc".Repeat(0));
            Assert.AreEqual("abc", "abc".Repeat(1));
            Assert.AreEqual("abcabc", "abc".Repeat(2));
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.Shuffle"/>.
        /// </summary>
        [Test]
        public void Shuffle() => Assert.AreNotEqual("abcdefg", "abcdefg".Shuffle());

        /// <summary>
        ///     Tests for <see cref="StringExtensions.Split"/>.
        /// </summary>
        [Test]
        public void Split()
        {
            const string str = "Hello World";
            string[] arr = str.Split(2).ToArray();
            CollectionAssert.AreEqual(new[] { "He", "ll", "o ", "Wo", "rl", "d" }, arr);
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.ShortHandParse"/>.
        /// </summary>
        [Test]
        public void TestParser()
        {
            Assert.AreEqual(TimeSpan.FromDays(7), "1w".ShortHandParse());
            Assert.AreEqual(TimeSpan.FromDays(1), "1d".ShortHandParse());
            Assert.AreEqual(TimeSpan.FromHours(1), "1h".ShortHandParse());
            Assert.AreEqual(TimeSpan.FromMinutes(1), "1m".ShortHandParse());
            Assert.AreEqual(TimeSpan.FromSeconds(1), "1s".ShortHandParse());
            Assert.AreEqual(TimeSpan.FromMilliseconds(1), "1ms".ShortHandParse());
            Assert.AreEqual(TimeSpan.FromDays(8), "1w 1d".ShortHandParse());
            Assert.AreEqual(TimeSpan.FromDays(8), "1w1d".ShortHandParse());
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.ToSecureString"/>.
        /// </summary>
        [Test]
        public void ToSecureString() => Assert.AreEqual(4, "Test".ToSecureString().Length);
    }
}