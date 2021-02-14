using System;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="StringExtensions"/>.
    /// </summary>
    [TestClass]
    public class StringTests
    {
        /// <summary>
        ///     Tests for <see cref="StringExtensions.Base64Decode(string)"/>.
        /// </summary>
        [TestMethod]
        public void Base64Decode()
        {
            Assert.AreEqual("hello", "aGVsbG8=".Base64Decode());
        }      
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.Base64Encode(string)"/>.
        /// </summary>
        [TestMethod]
        public void Base64Encode()
        {
            Assert.AreEqual("aGVsbG8=", "hello".Base64Encode());
        }       
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.ChangeEncoding(string, Encoding, Encoding)"/>.
        /// </summary>
        [TestMethod]
        public void ChangeEncoding()
        {
            Assert.AreEqual("HELLO", "ĤĚĻĻŎ".ChangeEncoding(Encoding.Latin1, Encoding.ASCII));
        }
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.ToEnum{T}(string,bool)"/>.
        /// </summary>
        [TestMethod]
        public void EnumParse()
        {
            Assert.AreEqual(Alphabet.A, "0".ToEnum<Alphabet>());
            Assert.AreEqual(Alphabet.A, "A".ToEnum<Alphabet>());
        }
        
        private enum Alphabet
        {
            A,
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.GetBytes(string,Encoding)"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes()
        {
            CollectionAssert.AreEqual(new byte[]{84, 101, 115, 116},"Test".GetBytes());
        }     
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsLower(string)"/>.
        /// </summary>
        [TestMethod]
        public void IsLower()
        {
            Assert.IsFalse("AB1234CD".IsLower());
            Assert.IsTrue("ab1234cd".IsLower());
            Assert.IsFalse("AB1234cd".IsLower());
            Assert.IsFalse("ab1234CD".IsLower());
        }     
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsUpper(string)"/>.
        /// </summary>
        [TestMethod]
        public void IsUpper()
        {
            Assert.IsTrue("AB1234CD".IsUpper());
            Assert.IsFalse("ab1234cd".IsUpper());
            Assert.IsFalse("AB1234cd".IsUpper());
            Assert.IsFalse("ab1234CD".IsUpper());
        }       
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsAlpha(string)"/>.
        /// </summary>
        [TestMethod]
        public void IsAlpha()
        {
            Assert.IsTrue("ABCD".IsAlpha());
            Assert.IsTrue("abcd".IsAlpha());
            Assert.IsFalse("AB12".IsAlpha());
            Assert.IsFalse("1234".IsAlpha());
        }        
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.IsNumerical(string)"/>.
        /// </summary>
        [TestMethod]
        public void IsNumerical()
        {
            Assert.IsFalse("ABCD".IsNumerical());
            Assert.IsFalse("abcd".IsNumerical());
            Assert.IsFalse("AB12".IsNumerical());
            Assert.IsTrue("1234".IsNumerical());
        }
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.Repeat"/>.
        /// </summary>
        [TestMethod]
        public void Repeat()
        {
            Assert.AreEqual("", "abc".Repeat(0));
            Assert.AreEqual("abc", "abc".Repeat(1));
            Assert.AreEqual("abcabc", "abc".Repeat(2));
            Assert.AreEqual("abcabca", "abc".Repeat(2.3));
            Assert.AreEqual("abcabcab", "abc".Repeat(2.6));
            Assert.AreEqual("abcdabcdab", "abcd".Repeat(2.5));
        }

        /// <summary>
        ///     Tests for <see cref="StringExtensions.Shuffle"/>.
        /// </summary>
        [TestMethod]
        public void Shuffle()
        {
            Assert.AreNotEqual("abcdefg", "abcdefg".Shuffle());
        }
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.Split"/>.
        /// </summary>
        [TestMethod]
        public void Split()
        {
            const string str = "Hello World";
            string[] arr = str.Split(2).ToArray();
            CollectionAssert.AreEqual(new[] { "He", "ll", "o ", "Wo", "rl", "d" }, arr);
        }        
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.ToSecureString"/>.
        /// </summary>
        [TestMethod]
        public void ToSecureString()
        {
            Assert.AreEqual(4, "Test".ToSecureString().Length);
        }
        
        /// <summary>
        ///     Tests for <see cref="StringExtensions.ToTimeSpan"/>.
        /// </summary>
        [TestMethod]
        public void TestParser()
        {
            Assert.AreEqual(TimeSpan.FromHours(3), "3h".ToTimeSpan());
            Assert.AreEqual(TimeSpan.FromMinutes(2.5), "2.5m".ToTimeSpan());
            Assert.AreEqual(TimeSpan.FromHours(1), "60m".ToTimeSpan());
            Assert.AreEqual(TimeSpan.FromDays(1), "1d".ToTimeSpan());
            Assert.AreEqual(TimeSpan.FromDays(8), "1w 1d".ToTimeSpan());
            Assert.AreEqual(TimeSpan.FromDays(8), "1w1d".ToTimeSpan());
        }
    }
}