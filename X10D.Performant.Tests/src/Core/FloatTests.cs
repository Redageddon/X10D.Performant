using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="SingleExtensions"/>.
    /// </summary>
    [TestClass]
    public class SingleTests
    {
        /// <summary>
        ///     Tests for <see cref="SingleExtensions.DegreesToGradians"/>.
        /// </summary>
        [TestMethod]
        public void DegreesToGradians()
        {
            Assert.AreEqual(100, 90.0F.DegreesToGradians());
            Assert.AreEqual(150, 135.0F.DegreesToGradians());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.DegreesToRadians"/>.
        /// </summary>
        [TestMethod]
        public void DegreesToRadians()
        {
            Assert.AreEqual(MathF.PI, 180.0F.DegreesToRadians());
            Assert.AreEqual(MathF.PI * 1.5F, 270.0F.DegreesToRadians());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.GradiansToDegrees"/>.
        /// </summary>
        [TestMethod]
        public void GradiansToDegrees()
        {
            Assert.AreEqual(90, 100.0F.GradiansToDegrees());
            Assert.AreEqual(135, 150.0F.GradiansToDegrees());
        }
        
        /// <summary>
        ///     Tests for <see cref="SingleExtensions.GradiansToRadians"/>.
        /// </summary>
        [TestMethod]
        public void GradiansToRadians()
        {
            Assert.AreEqual(MathF.PI, 200.0F.GradiansToRadians());
            Assert.AreEqual(1, (200F/Math.PI).GradiansToRadians());
        }       
        
        /// <summary>
        ///     Tests for <see cref="SingleExtensions.InverseSqrt"/>.
        /// </summary>
        [TestMethod]
        public void InverseSqrt()
        {
            Assert.AreEqual(1, 1.0F.InverseSqrt());
            Assert.AreEqual(0.5, 4.0F.InverseSqrt());
        }
        
        /// <summary>
        ///     Tests for <see cref="SingleExtensions.IsEven"/>.
        /// </summary>
        [TestMethod]
        public void IsEven()
        {
            Assert.IsTrue(2.0F.IsEven());
            Assert.IsFalse(1.0F.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.IsOdd"/>.
        /// </summary>
        [TestMethod]
        public void IsOdd()
        {
            Assert.IsFalse(2.0F.IsOdd());
            Assert.IsTrue(1.0F.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.RadiansToDegrees"/>.
        /// </summary>
        [TestMethod]
        public void RadiansToDegrees()
        {
            Assert.AreEqual(180.0F, MathF.PI.RadiansToDegrees());
            Assert.AreEqual(360.0F, (2.0F * MathF.PI).RadiansToDegrees());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.RadiansToGradians"/>.
        /// </summary>
        [TestMethod]
        public void RadiansToGradians()
        {
            Assert.AreEqual(200.0F, MathF.PI.RadiansToGradians());
            Assert.AreEqual(400.0F, (2.0F * MathF.PI).RadiansToGradians());
        }
    }
}