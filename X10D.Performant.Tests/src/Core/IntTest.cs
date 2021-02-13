using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Int32Extensions"/>.
    /// </summary>
    [TestClass]
    public class IntTests
    {
        /// <summary>
        ///     Tests for <see cref="Int32Extensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0 }, ((int)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="Int32Extensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2.IsEven());
            Assert.IsFalse(1.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="Int32Extensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2.IsOdd());
            Assert.IsTrue(1.IsOdd());
        }      
        
        /// <summary>
        ///     Tests for <see cref="Int32Extensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(2.ToBoolean());
            Assert.IsTrue(1.ToBoolean());
            Assert.IsFalse(0.ToBoolean());
        }        
        
        /// <summary>
        ///     Tests for <see cref="Int32Extensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {
            // Todo: implement this test
        }

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytesU()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0 }, ((uint)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEvenU()
        {
            Assert.IsTrue(2u.IsEven());
            Assert.IsFalse(1u.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOddU()
        {
            Assert.IsFalse(2u.IsOdd());
            Assert.IsTrue(1u.IsOdd());
        }
        
        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBoolU()
        {
            Assert.IsFalse(0u.ToBoolean());
            Assert.IsTrue(1u.ToBoolean());
            Assert.IsTrue(2u.ToBoolean());
        }
        
        /// <summary>
        ///     Tests for <see cref="UInt32Extensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeU()
        {
            // Todo: implement this test
        }
    }
}
