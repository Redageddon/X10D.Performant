using System;
using X10D.Performant.ByteExtensions;

namespace X10D.Tests.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     Tests for <see cref="ByteExtensions"/>.
    /// </summary>
    [TestClass]
    public class ByteTests
    {
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(((byte)2).IsEven());
            Assert.IsFalse(((byte)1).IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(((byte)2).IsOdd());
            Assert.IsTrue(((byte)1).IsOdd());
        }      
        
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(((byte)2).ToBoolean());
            Assert.IsTrue(((byte)1).ToBoolean());
            Assert.IsFalse(((byte)0).ToBoolean());
        }       
        
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {
            Assert.Fail();
        }
        
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.BitsAsString"/>.
        /// </summary>
        [TestMethod]
        public void AsString()
        {
            byte[] a = { 0x00, 0x73, 0xc6, 0xff };
            Assert.AreEqual("00-73-C6-FF", a.BitsAsString());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.BitsAsShort(byte[])"/>.
        /// </summary>
        [TestMethod]
        public void BitsAsShort()
        {
            byte[] a = { 0xF3, 0x3F };
            Assert.AreEqual(16371, a.BitsAsShort());
            Assert.AreEqual(16371, a.AsSpan().BitsAsShort());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.BitsAsInt(byte[])"/>.
        /// </summary>
        [TestMethod]
        public void BitsAsInt()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x5F };
            Assert.AreEqual(1595083696, a.BitsAsInt());
            Assert.AreEqual(1595083696, a.AsSpan().BitsAsInt());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.BitsAsLong(byte[])"/>.
        /// </summary>
        [TestMethod]
        public void BitsAsLong()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x50, 0x05, 0x31, 0xB0, 0x0B };
            Assert.AreEqual(842227029206305712L, a.BitsAsLong());
            Assert.AreEqual(842227029206305712L, a.AsSpan().BitsAsLong());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.GetUtf8String(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetUtf8String()
        {
            byte[] a = { 0x48, 0xc3, 0xa9, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };
            Assert.AreEqual("H\u00e9llo World", a.GetUtf8String());
            Assert.AreEqual("H\u00e9llo World", a.AsSpan().GetUtf8String());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.GetUtf8String(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetStringAscii()
        {
            byte[] a = { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };
            Assert.AreEqual("Hello World", a.GetUtf8String());
            Assert.AreEqual("Hello World", a.AsSpan().GetUtf8String());
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.BitsAsUShort(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt16()
        {
            byte[] a = { 0xF3, 0x3F };
            Assert.AreEqual(16371, a.BitsAsUShort());
            Assert.AreEqual(16371, a.AsSpan().BitsAsUShort());
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.BitsAsUInt(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt32()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x5F };
            Assert.AreEqual(1595083696U, a.BitsAsUInt());
            Assert.AreEqual(1595083696U, a.AsSpan().BitsAsUInt());
        }

        /// <summary>
        ///     Tests for <see cref="SByteExtensions.BitsAsULong(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt64()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x50, 0x05, 0x31, 0xB0, 0x0B };
            Assert.AreEqual(842227029206305712UL, a.BitsAsULong());
            Assert.AreEqual(842227029206305712UL, a.AsSpan().BitsAsULong());
        }
        
        /// <summary>
        ///     Tests for <see cref="SByteExtensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeSigned()
        {
            Assert.Fail();
        }
    }
}
