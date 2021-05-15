using System.Numerics;
using NUnit.Framework;
using X10D.Performant.VectorExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="Vector2Extensions"/>
    /// </summary>
    public class VectorTests
    {
        /// <summary>
        ///     Tests for <see cref="TypeExtensions.ClampedXLerp"/>
        /// </summary>
        [Test]
        public void ClampedXLerp()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, Vector2.Zero.ClampedXLerp(v1, v2));
            Assert.AreEqual(Vector2.One, Vector2.One.ClampedXLerp(v1, v2));

            Assert.AreEqual(Vector2.Zero, new Vector2(-1, 0).ClampedXLerp(v1, v2));

            Assert.AreEqual(Vector2.One, new Vector2(2, 1).ClampedXLerp(v1, v2));

            Assert.AreEqual(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f).ClampedXLerp(v1, v2));
        }

        /// <summary>
        ///     Tests for <see cref="TypeExtensions.ClampedXLerpTo"/>
        /// </summary>
        [Test]
        public void ClampedXLerpTo()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, v1.ClampedXLerpTo(v2, Vector2.Zero));
            Assert.AreEqual(Vector2.One, v1.ClampedXLerpTo(v2, Vector2.One));

            Assert.AreEqual(Vector2.Zero, v1.ClampedXLerpTo(v2, new Vector2(-1, 0)));

            Assert.AreEqual(Vector2.One, v1.ClampedXLerpTo(v2, new Vector2(2, 1)));

            Assert.AreEqual(new Vector2(0.5f, 0.5f), v1.ClampedXLerpTo(v2, new Vector2(0.5f, 0.5f)));
        }

        /// <summary>
        ///     Tests for <see cref="TypeExtensions.ClampedXYLerp"/>
        /// </summary>
        [Test]
        public void ClampedXYLerp()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, Vector2.Zero.ClampedXYLerp(v1, v2));
            Assert.AreEqual(Vector2.One, Vector2.One.ClampedXYLerp(v1, v2));

            Assert.AreEqual(Vector2.Zero, new Vector2(-1, 0).ClampedXYLerp(v1, v2));
            Assert.AreEqual(Vector2.Zero, new Vector2(0, -1).ClampedXYLerp(v1, v2));

            Assert.AreEqual(Vector2.One, new Vector2(2, 1).ClampedXYLerp(v1, v2));
            Assert.AreEqual(Vector2.One, new Vector2(1, 2).ClampedXYLerp(v1, v2));

            Assert.AreEqual(new Vector2(0, 1), new Vector2(-1, 2).ClampedXYLerp(v1, v2));
            Assert.AreEqual(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f).ClampedXYLerp(v1, v2));
        }

        /// <summary>
        ///     Tests for <see cref="TypeExtensions.ClampedXYLerpTo"/>
        /// </summary>
        [Test]
        public void ClampedXYLerpTo()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, v1.ClampedXYLerpTo(v2, Vector2.Zero));
            Assert.AreEqual(Vector2.One, v1.ClampedXYLerpTo(v2, Vector2.One));

            Assert.AreEqual(Vector2.Zero, v1.ClampedXYLerpTo(v2, new Vector2(-1, 0)));
            Assert.AreEqual(Vector2.Zero, v1.ClampedXYLerpTo(v2, new Vector2(0, -1)));

            Assert.AreEqual(Vector2.One, v1.ClampedXYLerpTo(v2, new Vector2(2, 1)));
            Assert.AreEqual(Vector2.One, v1.ClampedXYLerpTo(v2, new Vector2(1, 2)));

            Assert.AreEqual(new Vector2(0, 1), v1.ClampedXYLerpTo(v2, new Vector2(-1, 2)));
            Assert.AreEqual(new Vector2(0.5f, 0.5f), v1.ClampedXYLerpTo(v2, new Vector2(0.5f, 0.5f)));
        }

        /// <summary>
        ///     Tests for <see cref="TypeExtensions.ClampedYLerp"/>
        /// </summary>
        [Test]
        public void ClampedYLerp()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, Vector2.Zero.ClampedYLerp(v1, v2));
            Assert.AreEqual(Vector2.One, Vector2.One.ClampedYLerp(v1, v2));

            Assert.AreEqual(Vector2.Zero, new Vector2(0, -1).ClampedYLerp(v1, v2));
            Assert.AreEqual(Vector2.One, new Vector2(1, 2).ClampedYLerp(v1, v2));

            Assert.AreEqual(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f).ClampedYLerp(v1, v2));
        }

        /// <summary>
        ///     Tests for <see cref="TypeExtensions.ClampedYLerpTo"/>
        /// </summary>
        [Test]
        public void ClampedYLerpTo()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, v1.ClampedYLerpTo(v2, Vector2.Zero));
            Assert.AreEqual(Vector2.One, v1.ClampedYLerpTo(v2, Vector2.One));

            Assert.AreEqual(Vector2.Zero, v1.ClampedYLerpTo(v2, new Vector2(0, -1)));
            Assert.AreEqual(Vector2.One, v1.ClampedYLerpTo(v2, new Vector2(1, 2)));

            Assert.AreEqual(new Vector2(0.5f, 0.5f), v1.ClampedYLerpTo(v2, new Vector2(0.5f, 0.5f)));
        }

        /// <summary>
        ///     Tests for <see cref="TypeExtensions.Lerp"/>
        /// </summary>
        [Test]
        public void Lerp()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, Vector2.Zero.Lerp(v1, v2));
            Assert.AreEqual(Vector2.One, Vector2.One.Lerp(v1, v2));

            Assert.AreEqual(new Vector2(2, 0), new Vector2(2, 0).Lerp(v1, v2));
            Assert.AreEqual(new Vector2(0, 2), new Vector2(0, 2).Lerp(v1, v2));

            Assert.AreEqual(new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f).Lerp(v1, v2));
        }

        /// <summary>
        ///     Tests for <see cref="TypeExtensions.LerpTo"/>
        /// </summary>
        [Test]
        public void LerpTo()
        {
            Vector2 v1 = Vector2.Zero;
            Vector2 v2 = Vector2.One;
            Assert.AreEqual(Vector2.Zero, v1.LerpTo(v2, Vector2.Zero));
            Assert.AreEqual(Vector2.One, v1.LerpTo(v2, Vector2.One));

            Assert.AreEqual(new Vector2(2, 0), v1.LerpTo(v2, new Vector2(2, 0)));
            Assert.AreEqual(new Vector2(0, 2), v1.LerpTo(v2, new Vector2(0, 2)));

            Assert.AreEqual(new Vector2(0.5f, 0.5f), v1.LerpTo(v2, new Vector2(0.5f, 0.5f)));
        }
    }
}