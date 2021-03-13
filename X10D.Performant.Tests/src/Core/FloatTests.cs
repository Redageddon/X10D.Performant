using System;
using NUnit.Framework;
using X10D.Performant.DoubleExtensions;
using X10D.Performant.SingleExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="SingleExtensions"/>.
    /// </summary>
    public class SingleTests
    {
        /// <summary>
        ///     Tests for <see cref="SingleExtensions.DegreesToGradians"/>.
        /// </summary>
        [Test]
        public void DegreesToGradians()
        {
            Assert.AreEqual(100, 90.0F.DegreesToGradians());
            Assert.AreEqual(150, 135.0F.DegreesToGradians());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.DegreesToRadians"/>.
        /// </summary>
        [Test]
        public void DegreesToRadians()
        {
            Assert.AreEqual(MathF.PI, 180.0F.DegreesToRadians());
            Assert.AreEqual(MathF.PI * 1.5F, 270.0F.DegreesToRadians());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.GradiansToDegrees"/>.
        /// </summary>
        [Test]
        public void GradiansToDegrees()
        {
            Assert.AreEqual(90, 100.0F.GradiansToDegrees());
            Assert.AreEqual(135, 150.0F.GradiansToDegrees());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.GradiansToRadians"/>.
        /// </summary>
        [Test]
        public void GradiansToRadians()
        {
            Assert.AreEqual(MathF.PI, 200.0F.GradiansToRadians());
            Assert.AreEqual(1, (200F / Math.PI).GradiansToRadians());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.InverseSqrt"/>.
        /// </summary>
        [Test]
        public void InverseSqrt()
        {
            Assert.AreEqual(1, 1.0F.InverseSqrt());
            Assert.AreEqual(0.5, 4.0F.InverseSqrt());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.IsEven"/>.
        /// </summary>
        [Test]
        public void IsEven()
        {
            Assert.IsTrue(2.0F.IsEven());
            Assert.IsFalse(1.0F.IsEven());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.IsOdd"/>.
        /// </summary>
        [Test]
        public void IsOdd()
        {
            Assert.IsFalse(2.0F.IsOdd());
            Assert.IsTrue(1.0F.IsOdd());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.Lerp"/>.
        /// </summary>
        [Test]
        public void Lerp()
        {
            Assert.AreEqual(0, 0.25f.Lerp(0, 0));
            Assert.AreEqual(0, 0.5f.Lerp(0, 0));
            Assert.AreEqual(0, 0.75f.Lerp(0, 0));
            Assert.AreEqual(0, -0.25f.Lerp(0, 0));
            Assert.AreEqual(0, -0.5f.Lerp(0, 0));
            Assert.AreEqual(0, -0.75f.Lerp(0, 0));

            Assert.AreEqual(0.25, 0.25f.Lerp(0, 1));
            Assert.AreEqual(0.5, 0.5f.Lerp(0, 1));
            Assert.AreEqual(0.75, 0.75f.Lerp(0, 1));
            Assert.AreEqual(25, 0.25f.Lerp(0, 100));
            Assert.AreEqual(50, 0.5f.Lerp(0, 100));
            Assert.AreEqual(75, 0.75f.Lerp(0, 100));

            Assert.AreEqual(-0.25, -0.25f.Lerp(0, 1));
            Assert.AreEqual(-0.5, -0.5f.Lerp(0, 1));
            Assert.AreEqual(-0.75, -0.75f.Lerp(0, 1));
            Assert.AreEqual(-25, -0.25f.Lerp(0, 100));
            Assert.AreEqual(-50, -0.5f.Lerp(0, 100));
            Assert.AreEqual(-75, -0.75f.Lerp(0, 100));

            Assert.AreEqual(0.75, 0.25f.Lerp(1, 0));
            Assert.AreEqual(0.5, 0.5f.Lerp(1, 0));
            Assert.AreEqual(0.25, 0.75f.Lerp(1, 0));
            Assert.AreEqual(75, 0.25f.Lerp(100, 0));
            Assert.AreEqual(50, 0.5f.Lerp(100, 0));
            Assert.AreEqual(25, 0.75f.Lerp(100, 0));

            Assert.AreEqual(-0.75, -0.25f.Lerp(1, 0));
            Assert.AreEqual(-0.5, -0.5f.Lerp(1, 0));
            Assert.AreEqual(-0.25, -0.75f.Lerp(1, 0));
            Assert.AreEqual(-75, -0.25f.Lerp(100, 0));
            Assert.AreEqual(-50, -0.5f.Lerp(100, 0));
            Assert.AreEqual(-25, -0.75f.Lerp(100, 0));
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.RadiansToDegrees"/>.
        /// </summary>
        [Test]
        public void RadiansToDegrees()
        {
            Assert.AreEqual(180.0F, MathF.PI.RadiansToDegrees());
            Assert.AreEqual(360.0F, (2.0F * MathF.PI).RadiansToDegrees());
        }

        /// <summary>
        ///     Tests for <see cref="SingleExtensions.RadiansToGradians"/>.
        /// </summary>
        [Test]
        public void RadiansToGradians()
        {
            Assert.AreEqual(200.0F, MathF.PI.RadiansToGradians());
            Assert.AreEqual(400.0F, (2.0F * MathF.PI).RadiansToGradians());
        }
    }
}