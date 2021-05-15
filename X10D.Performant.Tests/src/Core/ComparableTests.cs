using NUnit.Framework;
using X10D.Performant.IComparableExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ComparableExtensions"/>.
    /// </summary>
    public class ComparableTests
    {
        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Between{T}"/>.
        /// </summary>
        [Test]
        public void Between()
        {
            Assert.IsFalse(1.Between(2, 4));
            Assert.IsTrue(3.Between(2, 4));
            Assert.IsFalse(5.Between(2, 4));
        }

        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Clamp{T}"/>.
        /// </summary>
        [Test]
        public void Clamp()
        {
            Assert.AreEqual(2, 1.Clamp(2, 4));
            Assert.AreEqual(3, 3.Clamp(2, 4));
            Assert.AreEqual(4, 5.Clamp(2, 4));
        }

        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.GreaterThan{T}"/>.
        /// </summary>
        [Test]
        public void GreaterThan()
        {
            Assert.IsTrue(2.GreaterThan(1));
            Assert.IsFalse(1.GreaterThan(2));
        }

        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.LessThan{T}"/>.
        /// </summary>
        [Test]
        public void LessThan()
        {
            Assert.IsTrue(1.LessThan(2));
            Assert.IsFalse(2.LessThan(1));
        }

        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Max{T}"/>.
        /// </summary>
        [Test]
        public void Max()
        {
            Assert.AreEqual(2, 1.Max(2));
            Assert.AreEqual(2, 2.Max(1));
        }

        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Min{T}"/>.
        /// </summary>
        [Test]
        public void Min()
        {
            Assert.AreEqual(1, 1.Min(2));
            Assert.AreEqual(1, 2.Min(1));
        }

        /// <summary>
        ///     Tests for <see cref="ComparableExtensions.Outside{T}"/>.
        /// </summary>
        [Test]
        public void Outside()
        {
            Assert.IsTrue(1.Outside(2, 4));
            Assert.IsFalse(3.Outside(2, 4));
            Assert.IsTrue(5.Outside(2, 4));
        }
    }
}