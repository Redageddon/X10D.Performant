using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="BooleanExtensions"/>.
    /// </summary>
    [TestClass]
    public class BooleanTests
    {
        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToByte"/>.
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
        ///     Tests for <see cref="BooleanExtensions.ToShort"/>.
        /// </summary>
        [TestMethod]
        public void ToShort()
        {
            const bool a = true;
            const bool b = false;
            const short c = 1;
            const short d = 0;

            Assert.AreEqual(c, a.ToShort());
            Assert.AreEqual(d, b.ToShort());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToInt"/>.
        /// </summary>
        [TestMethod]
        public void ToInt()
        {
            const bool a = true;
            const bool b = false;
            const int c = 1;
            const int d = 0;

            Assert.AreEqual(c, a.ToInt());
            Assert.AreEqual(d, b.ToInt());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToLong"/>.
        /// </summary>
        [TestMethod]
        public void ToLong()
        {
            const bool a = true;
            const bool b = false;
            const long c = 1;
            const long d = 0;

            Assert.AreEqual(c, a.ToLong());
            Assert.AreEqual(d, b.ToLong());
        }        
        
        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToSByte"/>.
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
        ///     Tests for <see cref="BooleanExtensions.ToUShort"/>.
        /// </summary>
        [TestMethod]
        public void ToUShort()
        {
            const bool a = true;
            const bool b = false;
            const ushort c = 1;
            const ushort d = 0;

            Assert.AreEqual(c, a.ToUShort());
            Assert.AreEqual(d, b.ToUShort());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToUInt"/>.
        /// </summary>
        [TestMethod]
        public void ToUInt()
        {
            const bool a = true;
            const bool b = false;
            const uint c = 1;
            const uint d = 0;

            Assert.AreEqual(c, a.ToUInt());
            Assert.AreEqual(d, b.ToUInt());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToULong"/>.
        /// </summary>
        [TestMethod]
        public void ToULong()
        {
            const bool a = true;
            const bool b = false;
            const ulong c = 1;
            const ulong d = 0;

            Assert.AreEqual(c, a.ToULong());
            Assert.AreEqual(d, b.ToULong());
        }
    }
}
