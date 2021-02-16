using System;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="DoubleExtensions"/>.
    /// </summary>
    public class DoubleTests
    {
        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.DegreesToGradians"/>.
        /// </summary>
        [Test]
        public void DegreesToGradians()
        {
            Assert.AreEqual(100, 90.0.DegreesToGradians());
            Assert.AreEqual(150, 135.0.DegreesToGradians());
        }

        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.DegreesToRadians"/>.
        /// </summary>
        [Test]
        public void DegreesToRadians()
        {
            Assert.AreEqual(Math.PI, 180.0.DegreesToRadians());
            Assert.AreEqual(Math.PI * 1.5, 270.0.DegreesToRadians());
        }

        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.GradiansToDegrees"/>.
        /// </summary>
        [Test]
        public void GradiansToDegrees()
        {
            Assert.AreEqual(90, 100.0.GradiansToDegrees());
            Assert.AreEqual(135, 150.0.GradiansToDegrees());
        }
        
        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.GradiansToRadians"/>.
        /// </summary>
        [Test]
        public void GradiansToRadians()
        {
            Assert.AreEqual(Math.PI, 200.0.GradiansToRadians());
            Assert.AreEqual(1, (200/Math.PI).GradiansToRadians());
        }       
        
        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.InverseSqrt"/>.
        /// </summary>
        [Test]
        public void InverseSqrt()
        {
            Assert.AreEqual(1, 1.0.InverseSqrt());
            Assert.AreEqual(0.5, 4.0.InverseSqrt());
        }
        
        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.IsEven"/>.
        /// </summary>
        [Test]
        public void IsEven()
        {
            Assert.IsTrue(2.0.IsEven());
            Assert.IsFalse(1.0.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOdd()
        {
            Assert.IsFalse(2.0.IsOdd());
            Assert.IsTrue(1.0.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.RadiansToDegrees"/>.
        /// </summary>
        [Test]
        public void RadiansToDegrees()
        {
            Assert.AreEqual(180.0, Math.PI.RadiansToDegrees());
            Assert.AreEqual(360.0, (2.0 * Math.PI).RadiansToDegrees());
        }

        /// <summary>
        ///     Tests for <see cref="DoubleExtensions.RadiansToGradians"/>.
        /// </summary>
        [Test]
        public void RadiansToGradians()
        {
            Assert.AreEqual(200.0, Math.PI.RadiansToGradians());
            Assert.AreEqual(400.0, (2.0 * Math.PI).RadiansToGradians());
        }
    }
}