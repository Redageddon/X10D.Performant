using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="BooleanExtensions" />.
    /// </summary>
    [TestClass]
    public class BooleanTests
    {
        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToByte" />.
        /// </summary>
        [TestMethod]
        public void ToByte()
        {
            const bool a = true;
            const bool b = false;
            const byte c = 1;
            const byte d = 0;

            Assert.AreEqual(c, a.ToByte());
            Assert.AreEqual(d, b.ToByte());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToDecimal" />.
        /// </summary>
        [TestMethod]
        public void ToDecimal()
        {
            const bool a = true;
            const bool b = false;
            const decimal c = 1;
            const decimal d = 0;

            Assert.AreEqual(c, a.ToDecimal());
            Assert.AreEqual(d, b.ToDecimal());
        }      
        
        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToDouble" />.
        /// </summary>
        [TestMethod]
        public void ToDouble()
        {
            const bool a = true;
            const bool b = false;
            const decimal c = 1;
            const decimal d = 0;

            Assert.AreEqual(c, a.ToDouble());
            Assert.AreEqual(d, b.ToDouble());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToInt16" />.
        /// </summary>
        [TestMethod]
        public void ToInt16()
        {
            const bool a = true;
            const bool b = false;
            const short c = 1;
            const short d = 0;

            Assert.AreEqual(c, a.ToInt16());
            Assert.AreEqual(d, b.ToInt16());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToInt32" />.
        /// </summary>
        [TestMethod]
        public void ToInt32()
        {
            const bool a = true;
            const bool b = false;
            const int c = 1;
            const int d = 0;

            Assert.AreEqual(c, a.ToInt32());
            Assert.AreEqual(d, b.ToInt32());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToInt64" />.
        /// </summary>
        [TestMethod]
        public void ToInt64()
        {
            const bool a = true;
            const bool b = false;
            const long c = 1;
            const long d = 0;

            Assert.AreEqual(c, a.ToInt64());
            Assert.AreEqual(d, b.ToInt64());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToSByte" />.
        /// </summary>
        [TestMethod]
        public void ToSByte()
        {
            const bool a = true;
            const bool b = false;
            const sbyte c = 1;
            const sbyte d = 0;

            Assert.AreEqual(c, a.ToSByte());
            Assert.AreEqual(d, b.ToSByte());
        }      
        
        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToSingle" />.
        /// </summary>
        [TestMethod]
        public void ToFloat()
        {
            const bool a = true;
            const bool b = false;
            const float c = 1.0f;
            const float d = 0.0f;

            Assert.AreEqual(c, a.ToSingle());
            Assert.AreEqual(d, b.ToSingle());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToUInt16" />.
        /// </summary>
        [TestMethod]
        public void ToUInt16()
        {
            const bool a = true;
            const bool b = false;
            const ushort c = 1;
            const ushort d = 0;

            Assert.AreEqual(c, a.ToUInt16());
            Assert.AreEqual(d, b.ToUInt16());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToUInt32" />.
        /// </summary>
        [TestMethod]
        public void ToUInt32()
        {
            const bool a = true;
            const bool b = false;
            const uint c = 1;
            const uint d = 0;

            Assert.AreEqual(c, a.ToUInt32());
            Assert.AreEqual(d, b.ToUInt32());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToUInt64" />.
        /// </summary>
        [TestMethod]
        public void ToUInt64()
        {
            const bool a = true;
            const bool b = false;
            const ulong c = 1;
            const ulong d = 0;

            Assert.AreEqual(c, a.ToUInt64());
            Assert.AreEqual(d, b.ToUInt64());
        }
    }
}