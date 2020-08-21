namespace X10D.Tests.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     Tests for <see cref="BooleanExtensions" />.
    /// </summary>
    [TestClass]
    public class BooleanTests
    {
        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.And" />.
        /// </summary>
        [TestMethod]
        public void And()
        {
            const bool a = true;
            const bool b = true;
            const bool c = false;
            const bool d = false;

            Assert.IsTrue(a);
            Assert.IsTrue(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);

            Assert.IsTrue(a.And(b));
            Assert.IsFalse(b.And(c));
            Assert.IsFalse(c.And(d));
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.AndEquals{T}" />.
        /// </summary>
        [TestMethod]
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
        ///     Tests for <see cref="BooleanExtensions.NAnd" />.
        /// </summary>
        [TestMethod]
        public void NAnd()
        {
            const bool a = true;
            const bool b = true;
            const bool c = false;
            const bool d = false;

            Assert.IsTrue(a);
            Assert.IsTrue(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);

            Assert.IsFalse(a.NAnd(b));
            Assert.IsTrue(b.NAnd(c));
            Assert.IsTrue(c.NAnd(d));
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.AndEquals{T}" />.
        /// </summary>
        [TestMethod]
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
        ///     Tests for <see cref="BooleanExtensions.NOr" />.
        /// </summary>
        [TestMethod]
        public void NOr()
        {
            const bool a = true;
            const bool b = true;
            const bool c = false;
            const bool d = false;

            Assert.IsTrue(a);
            Assert.IsTrue(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);

            Assert.IsFalse(a.NOr(b));
            Assert.IsFalse(b.NOr(c));
            Assert.IsTrue(c.NOr(d));
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.NOrEquals{T}" />.
        /// </summary>
        [TestMethod]
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
        ///     Tests for <see cref="BooleanExtensions.Not" />.
        /// </summary>
        [TestMethod]
        public void Not()
        {
            const bool a = true;
            const bool b = false;

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.IsFalse(a.Not());
            Assert.IsTrue(b.Not());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.Or" />.
        /// </summary>
        [TestMethod]
        public void Or()
        {
            const bool a = true;
            const bool b = true;
            const bool c = false;
            const bool d = false;

            Assert.IsTrue(a);
            Assert.IsTrue(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);

            Assert.IsTrue(a.Or(b));
            Assert.IsTrue(b.Or(c));
            Assert.IsFalse(c.Or(d));
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.OrEquals{T}" />.
        /// </summary>
        [TestMethod]
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
        ///     Tests for <see cref="BooleanExtensions.ToByte" />.
        /// </summary>
        [TestMethod]
        public void ToByte()
        {
            const bool a = true;
            const bool b = false;
            const byte c = 1;
            const byte d = 0;

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.AreEqual(c, a.ToByte());
            Assert.AreEqual(d, b.ToByte());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToInt16" />.
        /// </summary>
        [TestMethod]
        public void ToInt16()
        {
            const bool a = true;
            const bool b = false;

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.AreEqual(1, a.ToInt16());
            Assert.AreEqual(0, b.ToInt16());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToInt32" />.
        /// </summary>
        [TestMethod]
        public void ToInt32()
        {
            const bool a = true;
            const bool b = false;

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.AreEqual(1, a.ToInt32());
            Assert.AreEqual(0, b.ToInt32());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.ToInt64" />.
        /// </summary>
        [TestMethod]
        public void ToInt64()
        {
            const bool a = true;
            const bool b = false;

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.AreEqual(1L, a.ToInt64());
            Assert.AreEqual(0L, b.ToInt64());
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.XNOr" />.
        /// </summary>
        [TestMethod]
        public void XNOr()
        {
            const bool a = true;
            const bool b = true;
            const bool c = false;
            const bool d = false;

            Assert.IsTrue(a);
            Assert.IsTrue(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);

            Assert.IsTrue(a.XNOr(b));
            Assert.IsFalse(b.XNOr(c));
            Assert.IsTrue(c.XNOr(d));
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.XNOrEquals{T}" />.
        /// </summary>
        [TestMethod]
        public void XNOrEquals()
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
        ///     Tests for <see cref="BooleanExtensions.XOr" />.
        /// </summary>
        [TestMethod]
        public void XOr()
        {
            const bool a = true;
            const bool b = true;
            const bool c = false;
            const bool d = false;

            Assert.IsTrue(a);
            Assert.IsTrue(b);
            Assert.IsFalse(c);
            Assert.IsFalse(d);

            Assert.IsFalse(a.XOr(b));
            Assert.IsTrue(b.XOr(c));
            Assert.IsFalse(c.XOr(d));
        }

        /// <summary>
        ///     Tests for <see cref="BooleanExtensions.XOrEquals{T}" />.
        /// </summary>
        [TestMethod]
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
    }
}
