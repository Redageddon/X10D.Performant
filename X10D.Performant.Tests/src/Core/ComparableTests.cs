using NUnit.Framework;

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