using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Int64Extensions"/>.
    /// </summary>
    [TestClass]
    public class LongTests
    {
        /// <summary>
        ///     Tests for <see cref="Int64Extensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0, 0, 0, 0, 0 }, ((long)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2L.IsEven());
            Assert.IsFalse(1L.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2L.IsOdd());
            Assert.IsTrue(1L.IsOdd());
        }      
        
        /// <summary>
        ///     Tests for <see cref="Int64Extensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(2L.ToBoolean());
            Assert.IsTrue(1L.ToBoolean());
            Assert.IsFalse(0L.ToBoolean());
        }        
        
        /// <summary>
        ///     Tests for <see cref="Int64Extensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {         
            // Todo: implement this test
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytesU()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0, 0, 0, 0, 0}, ((ulong)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEvenU()
        {
            Assert.IsTrue(2ul.IsEven());
            Assert.IsFalse(1ul.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOddU()
        {
            Assert.IsFalse(2ul.IsOdd());
            Assert.IsTrue(1ul.IsOdd());
        }
        
        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBoolU()
        {
            Assert.IsFalse(0ul.ToBoolean());
            Assert.IsTrue(1ul.ToBoolean());
            Assert.IsTrue(2ul.ToBoolean());
        }
        
        /// <summary>
        ///     Tests for <see cref="UInt64Extensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeU()
        {
            // Todo: implement this test
        }
    }
}
