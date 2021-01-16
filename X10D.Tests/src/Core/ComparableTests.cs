using X10D.Performant.IComparableExtensions;

namespace X10D.Tests.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     Tests for <see cref="ComparableExtensions"/>.
    /// </summary>
    [TestClass]
    public class ComparableTests
    {
        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Between{T}"/>.
        /// </summary>
        [TestMethod]
        public void Between()
        {
            Assert.IsFalse(1.Between(2, 4));
            Assert.IsTrue(3.Between(2, 4));
            Assert.IsFalse(5.Between(2, 4));
        }

        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Outside{T}"/>.
        /// </summary>
        [TestMethod]
        public void Outside()
        {
            Assert.IsTrue(1.Outside(2, 4));
            Assert.IsFalse(3.Outside(2, 4));
            Assert.IsTrue(5.Outside(2, 4));
        }       
        
        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Max{T}"/>.
        /// </summary>
        [TestMethod]
        public void Max()
        {
            Assert.AreEqual(2, 1.Max(2));
            Assert.AreEqual(5, 5.Max(2));
        }
        
        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Min{T}"/>.
        /// </summary>
        [TestMethod]
        public void Min()
        {
            Assert.AreEqual(1, 1.Min(2));
            Assert.AreEqual(2, 5.Min(2));
        }
        
        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Clamp{T}"/>.
        /// </summary>
        [TestMethod]
        public void Clamp()
        {
            Assert.AreEqual(2, 1.Clamp(2, 4));
            Assert.AreEqual(4, 5.Clamp(2, 4));
            Assert.AreEqual(3, 3.Clamp(2, 4));
        }
    }
}
