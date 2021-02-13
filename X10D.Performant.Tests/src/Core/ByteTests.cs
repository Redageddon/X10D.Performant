using System;
using System.Text;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ByteExtensions"/>.
    /// </summary>
    [TestClass]
    public class ByteTests
    {
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.JsonTo{T}(ReadOnlySpan{byte},JsonSerializerOptions)"/>.
        /// </summary>
        [TestMethod]
        public void JsonTo()
        {
            // Todo: implement this test
        }  
        
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
            // Todo: implement this test
        }
        
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToSting"/>.
        /// </summary>
        [TestMethod]
        public void AsString()
        {
            byte[] a = { 0x00, 0x73, 0xc6, 0xff };
            Assert.AreEqual("00-73-C6-FF", a.ToSting());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToInt16(byte[],int)"/>.
        /// </summary>
        [TestMethod]
        public void BitsAsShort()
        {
            byte[] a = { 0xF3, 0x3F };
            Assert.AreEqual(16371, a.ToInt16());
            Assert.AreEqual(16371, a.AsSpan().ToInt16());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToInt32(byte[],int)"/>.
        /// </summary>
        [TestMethod]
        public void BitsAsInt()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x5F };
            Assert.AreEqual(1595083696, a.ToInt32());
            Assert.AreEqual(1595083696, a.AsSpan().ToInt32());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToInt64(byte[],int)"/>.
        /// </summary>
        [TestMethod]
        public void BitsAsLong()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x50, 0x05, 0x31, 0xB0, 0x0B };
            Assert.AreEqual(842227029206305712L, a.ToInt64());
            Assert.AreEqual(842227029206305712L, a.AsSpan().ToInt64());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToEncodedString(byte[],Encoding)"/>.
        /// </summary>
        [TestMethod]
        public void GetUtf8String()
        {
            byte[] a = { 0x48, 0xc3, 0xa9, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };
            Assert.AreEqual("H\u00e9llo World", a.ToEncodedString());
        }
        
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToEncodedString(System.Span{byte},Encoding)"/>.
        /// </summary>
        [TestMethod]
        public void GetUtf8Span()
        {
            byte[] a = { 0x48, 0xc3, 0xa9, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };
            Assert.AreEqual("H\u00e9llo World", a.AsSpan().ToEncodedString());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToEncodedString(byte[],Encoding)"/>.
        /// </summary>
        [TestMethod]
        public void GetStringAscii()
        {
            byte[] a = { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };
            Assert.AreEqual("Hello World", a.ToEncodedString());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToEncodedString(System.Span{byte},Encoding)"/>.
        /// </summary>
        [TestMethod]
        public void GetStringAsciiSpan()
        {
            byte[] a = { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x20, 0x57, 0x6f, 0x72, 0x6c, 0x64 };
            Assert.AreEqual("Hello World", a.AsSpan().ToEncodedString());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToUInt16(byte[],int)"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt16()
        {
            byte[] a = { 0xF3, 0x3F };
            Assert.AreEqual(16371, a.ToUInt16());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToUInt16(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt16Span()
        {
            byte[] a = { 0xF3, 0x3F };
            Assert.AreEqual(16371, a.AsSpan().ToUInt16());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToUInt32(byte[],int)"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt32()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x5F };
            Assert.AreEqual(1595083696U, a.ToUInt32());
        }
        
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToUInt32(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt32Span()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x5F };
            Assert.AreEqual(1595083696U, a.AsSpan().ToUInt32());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToUInt64(byte[],int)"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt64()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x50, 0x05, 0x31, 0xB0, 0x0B };
            Assert.AreEqual(842227029206305712UL, a.ToUInt64());
        }

        /// <summary>
        ///     Tests for <see cref="ByteExtensions.ToUInt64(ReadOnlySpan{byte})"/>.
        /// </summary>
        [TestMethod]
        public void GetUInt64Span()
        {
            byte[] a = { 0xB0, 0x0B, 0x13, 0x50, 0x05, 0x31, 0xB0, 0x0B };
            Assert.AreEqual(842227029206305712UL, a.AsSpan().ToUInt64());
        }
        
        /// <summary>
        ///     Tests for <see cref="ByteExtensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeSigned()
        {
            // Todo: implement this test
        }
    }
}
