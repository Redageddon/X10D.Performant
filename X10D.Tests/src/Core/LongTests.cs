using X10D.Performant.LongExtensions;

namespace X10D.Tests.Core
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     Tests for <see cref="LongExtensions"/>.
    /// </summary>
    [TestClass]
    public class LongTests
    {
        /// <summary>
        ///     Tests for <see cref="LongExtensions.GetBytes(long)"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0, 0, 0, 0, 0 }, ((long)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="LongExtensions.IsEven(long)"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2L.IsEven());
            Assert.IsFalse(1L.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="LongExtensions.IsOdd(long)"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2L.IsOdd());
            Assert.IsTrue(1L.IsOdd());
        }      
        
        /// <summary>
        ///     Tests for <see cref="LongExtensions.ToBoolean(long)"/>.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(2L.ToBoolean());
            Assert.IsTrue(1L.ToBoolean());
            Assert.IsFalse(0L.ToBoolean());
        }        
        
        /// <summary>
        ///     Tests for <see cref="LongExtensions.IsPrime(long)"/>.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {         
            Assert.Fail();
        }

        /// <summary>
        ///     Tests for <see cref="ULongExtensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytesU()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0, 0, 0, 0, 0}, ((ulong)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="ULongExtensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEvenU()
        {
            Assert.IsTrue(2ul.IsEven());
            Assert.IsFalse(1ul.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="ULongExtensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOddU()
        {
            Assert.IsFalse(2ul.IsOdd());
            Assert.IsTrue(1ul.IsOdd());
        }
        
        /// <summary>
        ///     Tests for <see cref="ULongExtensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBoolU()
        {
            Assert.IsFalse(0ul.ToBoolean());
            Assert.IsTrue(1ul.ToBoolean());
            Assert.IsTrue(2ul.ToBoolean());
        }
        
        /// <summary>
        ///     Tests for <see cref="ULongExtensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeU()
        {
            Assert.Fail();
        }
    }
}
