using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="EquatableExtensions"/>.
    /// </summary>
    public class EquatableTests
    {
        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.AndEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void AndEquals()
        {
            Assert.IsFalse(1.AndEquals(0, 0, 0));
            Assert.IsFalse(1.AndEquals(1, 0, 0));
            Assert.IsFalse(1.AndEquals(0, 1, 0));
            Assert.IsFalse(1.AndEquals(1, 1, 0));
            Assert.IsFalse(1.AndEquals(0, 0, 1));
            Assert.IsFalse(1.AndEquals(1, 0, 1));
            Assert.IsFalse(1.AndEquals(0, 1, 1));
            Assert.IsTrue(1.AndEquals(1, 1, 1));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.AndEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void AndEqualsComparison()
        {
            Assert.IsFalse(1.AndEquals(new[] { 0, 0, 0 }));
            Assert.IsFalse(1.AndEquals(new[] { 1, 0, 0 }));
            Assert.IsFalse(1.AndEquals(new[] { 0, 1, 0 }));
            Assert.IsFalse(1.AndEquals(new[] { 1, 1, 0 }));
            Assert.IsFalse(1.AndEquals(new[] { 0, 0, 1 }));
            Assert.IsFalse(1.AndEquals(new[] { 1, 0, 1 }));
            Assert.IsFalse(1.AndEquals(new[] { 0, 1, 1 }));
            Assert.IsTrue(1.AndEquals(new[] { 1, 1, 1 }));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.NAndEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void NAndEquals()
        {
            Assert.IsTrue(1.NAndEquals(0, 0, 0));
            Assert.IsTrue(1.NAndEquals(1, 0, 0));
            Assert.IsTrue(1.NAndEquals(0, 1, 0));
            Assert.IsTrue(1.NAndEquals(1, 1, 0));
            Assert.IsFalse(1.NAndEquals(0, 0, 1));
            Assert.IsFalse(1.NAndEquals(1, 0, 1));
            Assert.IsFalse(1.NAndEquals(0, 1, 1));
            Assert.IsTrue(1.NAndEquals(1, 1, 1));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.NAndEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void NAndEqualsComparison()
        {
            Assert.IsTrue(1.NAndEquals(new[] { 0, 0, 0 }));
            Assert.IsTrue(1.NAndEquals(new[] { 1, 0, 0 }));
            Assert.IsTrue(1.NAndEquals(new[] { 0, 1, 0 }));
            Assert.IsTrue(1.NAndEquals(new[] { 1, 1, 0 }));
            Assert.IsFalse(1.NAndEquals(new[] { 0, 0, 1 }));
            Assert.IsFalse(1.NAndEquals(new[] { 1, 0, 1 }));
            Assert.IsFalse(1.NAndEquals(new[] { 0, 1, 1 }));
            Assert.IsTrue(1.NAndEquals(new[] { 1, 1, 1 }));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.NOrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void NOrEquals()
        {
            Assert.IsFalse(1.NOrEquals(0, 0, 0));
            Assert.IsTrue(1.NOrEquals(1, 0, 0));
            Assert.IsTrue(1.NOrEquals(0, 1, 0));
            Assert.IsTrue(1.NOrEquals(1, 1, 0));
            Assert.IsFalse(1.NOrEquals(0, 0, 1));
            Assert.IsFalse(1.NOrEquals(1, 0, 1));
            Assert.IsFalse(1.NOrEquals(0, 1, 1));
            Assert.IsFalse(1.NOrEquals(1, 1, 1));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.NOrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void NOrEqualsComparison()
        {
            Assert.IsFalse(1.NOrEquals(new[] { 0, 0, 0 }));
            Assert.IsTrue(1.NOrEquals(new[] { 1, 0, 0 }));
            Assert.IsTrue(1.NOrEquals(new[] { 0, 1, 0 }));
            Assert.IsTrue(1.NOrEquals(new[] { 1, 1, 0 }));
            Assert.IsFalse(1.NOrEquals(new[] { 0, 0, 1 }));
            Assert.IsFalse(1.NOrEquals(new[] { 1, 0, 1 }));
            Assert.IsFalse(1.NOrEquals(new[] { 0, 1, 1 }));
            Assert.IsFalse(1.NOrEquals(new[] { 1, 1, 1 }));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.OrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void OrEquals()
        {
            Assert.IsFalse(1.OrEquals(0, 0, 0));
            Assert.IsTrue(1.OrEquals(1, 0, 0));
            Assert.IsTrue(1.OrEquals(0, 1, 0));
            Assert.IsTrue(1.OrEquals(1, 1, 0));
            Assert.IsTrue(1.OrEquals(0, 0, 1));
            Assert.IsTrue(1.OrEquals(1, 0, 1));
            Assert.IsTrue(1.OrEquals(0, 1, 1));
            Assert.IsTrue(1.OrEquals(1, 1, 1));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.OrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void OrEqualsComparison()
        {
            Assert.IsFalse(1.OrEquals(new[] { 0, 0, 0 }));
            Assert.IsTrue(1.OrEquals(new[] { 1, 0, 0 }));
            Assert.IsTrue(1.OrEquals(new[] { 0, 1, 0 }));
            Assert.IsTrue(1.OrEquals(new[] { 1, 1, 0 }));
            Assert.IsTrue(1.OrEquals(new[] { 0, 0, 1 }));
            Assert.IsTrue(1.OrEquals(new[] { 1, 0, 1 }));
            Assert.IsTrue(1.OrEquals(new[] { 0, 1, 1 }));
            Assert.IsTrue(1.OrEquals(new[] { 1, 1, 1 }));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.XNOrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void XnOrEquals()
        {
            Assert.IsFalse(1.XNOrEquals(0, 0, 0));
            Assert.IsTrue(1.XNOrEquals(1, 0, 0));
            Assert.IsTrue(1.XNOrEquals(0, 1, 0));
            Assert.IsFalse(1.XNOrEquals(1, 1, 0));
            Assert.IsTrue(1.XNOrEquals(0, 0, 1));
            Assert.IsFalse(1.XNOrEquals(1, 0, 1));
            Assert.IsFalse(1.XNOrEquals(0, 1, 1));
            Assert.IsTrue(1.XNOrEquals(1, 1, 1));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.XNOrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void XnOrEqualsComparison()
        {
            Assert.IsFalse(1.XNOrEquals(new[] { 0, 0, 0 }));
            Assert.IsTrue(1.XNOrEquals(new[] { 1, 0, 0 }));
            Assert.IsTrue(1.XNOrEquals(new[] { 0, 1, 0 }));
            Assert.IsFalse(1.XNOrEquals(new[] { 1, 1, 0 }));
            Assert.IsTrue(1.XNOrEquals(new[] { 0, 0, 1 }));
            Assert.IsFalse(1.XNOrEquals(new[] { 1, 0, 1 }));
            Assert.IsFalse(1.XNOrEquals(new[] { 0, 1, 1 }));
            Assert.IsTrue(1.XNOrEquals(new[] { 1, 1, 1 }));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.XOrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void XOrEquals()
        {
            Assert.IsFalse(1.XOrEquals(0, 0, 0));
            Assert.IsTrue(1.XOrEquals(1, 0, 0));
            Assert.IsTrue(1.XOrEquals(0, 1, 0));
            Assert.IsFalse(1.XOrEquals(1, 1, 0));
            Assert.IsTrue(1.XOrEquals(0, 0, 1));
            Assert.IsFalse(1.XOrEquals(1, 0, 1));
            Assert.IsFalse(1.XOrEquals(0, 1, 1));
            Assert.IsTrue(1.XOrEquals(1, 1, 1));
        }

        /// <summary>
        ///     Tests for <see cref="EquatableExtensions.XOrEquals{T}(T,T,T)"/>.
        /// </summary>
        [Test]
        public void XOrEqualsComparison()
        {
            Assert.IsFalse(1.XOrEquals(new[] { 0, 0, 0 }));
            Assert.IsTrue(1.XOrEquals(new[] { 1, 0, 0 }));
            Assert.IsTrue(1.XOrEquals(new[] { 0, 1, 0 }));
            Assert.IsFalse(1.XOrEquals(new[] { 1, 1, 0 }));
            Assert.IsTrue(1.XOrEquals(new[] { 0, 0, 1 }));
            Assert.IsFalse(1.XOrEquals(new[] { 1, 0, 1 }));
            Assert.IsFalse(1.XOrEquals(new[] { 0, 1, 1 }));
            Assert.IsTrue(1.XOrEquals(new[] { 1, 1, 1 }));
        }
    }
}