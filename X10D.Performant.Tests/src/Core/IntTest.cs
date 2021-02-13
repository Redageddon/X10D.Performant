using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using X10D.Performant.IntExtensions;
using X10D.Performant.UIntExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="IntExtensions"/>.
    /// </summary>
    [TestClass]
    public class IntTests
    {
        /// <summary>
        ///     Tests for <see cref="IntExtensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0 }, ((int)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="IntExtensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2.IsEven());
            Assert.IsFalse(1.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="IntExtensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2.IsOdd());
            Assert.IsTrue(1.IsOdd());
        }      
        
        /// <summary>
        ///     Tests for <see cref="IntExtensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBool()
        {
            Assert.IsTrue(2.ToBoolean());
            Assert.IsTrue(1.ToBoolean());
            Assert.IsFalse(0.ToBoolean());
        }        
        
        /// <summary>
        ///     Tests for <see cref="IntExtensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrime()
        {
            // Todo: implement this test
        }

        /// <summary>
        ///     Tests for <see cref="UIntExtensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytesU()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 0, 0, 0 }, ((uint)Math.PI).GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="UIntExtensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEvenU()
        {
            Assert.IsTrue(2u.IsEven());
            Assert.IsFalse(1u.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="UIntExtensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOddU()
        {
            Assert.IsFalse(2u.IsOdd());
            Assert.IsTrue(1u.IsOdd());
        }
        
        /// <summary>
        ///     Tests for <see cref="UIntExtensions.ToBoolean"/>.
        /// </summary>
        [TestMethod]
        public void ToBoolU()
        {
            Assert.IsFalse(0u.ToBoolean());
            Assert.IsTrue(1u.ToBoolean());
            Assert.IsTrue(2u.ToBoolean());
        }
        
        /// <summary>
        ///     Tests for <see cref="UIntExtensions.IsPrime"/>.
        /// </summary>
        [TestMethod]
        public void IsPrimeU()
        {
            // Todo: implement this test
        }
    }
}
