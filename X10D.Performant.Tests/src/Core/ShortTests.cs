using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Int16Extensions"/>.
    /// </summary>
    [TestClass]
    public class ShortTests
    {
        /// <summary>
        ///     Tests for <see cref="Int16Extensions.GetBytes(short)"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0 }, ((short)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="Int16Extensions.IsEven(short)"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(((short)2).IsEven());
            Assert.IsFalse(((short)1).IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="Int16Extensions.IsOdd(short)"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(((short)2).IsOdd());
            Assert.IsTrue(((short)1).IsOdd());
        }      
        
        /// <summary>
        ///     Tests for <see cref="Int16Extensions.ToBoolean(short)"/>.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(((short)2).ToBoolean());
            Assert.IsTrue(((short)1).ToBoolean());
            Assert.IsFalse(((short)0).ToBoolean());
        }        
        
        /// <summary>
        ///     Tests for <see cref="Int16Extensions.IsPrime(short)"/>.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {         
            // Todo: implement this test
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytesU()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0}, ((ushort)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEvenU()
        {
            Assert.IsTrue(((ushort)2).IsEven());
            Assert.IsFalse(((ushort)1).IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOddU()
        {
            Assert.IsFalse(((ushort)2).IsOdd());
            Assert.IsTrue(((ushort)1).IsOdd());
        }
        
        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBoolU()
        {
            Assert.IsFalse(((ushort)0).ToBoolean());
            Assert.IsTrue(((ushort)1).ToBoolean());
            Assert.IsTrue(((ushort)2).ToBoolean());
        }
        
        /// <summary>
        ///     Tests for <see cref="UInt16Extensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeU()
        {
            // Todo: implement this test
        }
    }
}
