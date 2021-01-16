﻿using X10D.Performant.FloatExtensions;

namespace X10D.Tests.Core
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///     Tests for <see cref="FloatExtensions"/>.
    /// </summary>
    [TestClass]
    public class FloatTests
    {
        /// <summary>
        ///     Tests for <see cref="FloatExtensions.DegreesToRadians"/>.
        /// </summary>
        [TestMethod]
        public void DegreesToRadians()
        {
            Assert.AreEqual(MathF.PI, 180.0f.DegreesToRadians());
            Assert.AreEqual(MathF.PI * 1.5f, 270.0f.DegreesToRadians());
        }

        /// <summary>
        ///     Tests for <see cref="FloatExtensions.GetBytes"/>.
        /// </summary>
        [TestMethod]
        public void GetBytes()
        {
            CollectionAssert.AreEqual(new byte[] { 0xDB, 0xF, 0x49, 0x40}, MathF.PI.GetBytes());
        }

        /// <summary>
        ///     Tests for <see cref="FloatExtensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2.0f.IsEven());
            Assert.IsFalse(1.0f.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="FloatExtensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2.0f.IsOdd());
            Assert.IsTrue(1.0f.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="FloatExtensions.RadiansToDegrees"/>.
        /// </summary>
        [TestMethod]
        public void RadiansToDegrees()
        {
            Assert.AreEqual(180.0f, MathF.PI.RadiansToDegrees());
            Assert.AreEqual(360.0f, (2.0f * MathF.PI).RadiansToDegrees());
        }

        /// <summary>
        ///     Tests for <see cref="FloatExtensions.Round"/>.
        /// </summary>
        [TestMethod]
        public void Round()
        {
            Assert.AreEqual(5.0f, 3.5f.Round(5));
            Assert.AreEqual(5.0f, 7.0f.Round(5));
            Assert.AreEqual(10.0f, 7.5f.Round(5));
        }
    }
}
