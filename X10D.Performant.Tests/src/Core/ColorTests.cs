using System;
using System.Diagnostics;
using System.Drawing;
using NUnit.Framework;
using X10D.Performant.ColorExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ColorExtensions"/>.
    /// </summary>
    public class ColorTests
    {
        /// <summary>
        ///     Tests for <see cref="ColorExtensions.And"/>.
        /// </summary>
        [Test]
        public void And()
        {
            Color color1 = Color.FromArgb(0b00000000_00000000_00000001_00000001);
            Color color2 = Color.FromArgb(0b00000000_00000001_00000000_00000001);

            Assert.AreEqual(Color.FromArgb(0, 0, 0, 1), color1.And(color2));
        }

        /// <summary>
        ///     Tests for <see cref="ColorExtensions.With(Color,byte?,float?,float?,float?)"/>.
        /// </summary>
        [Test]
        public void ColorWithHsb()
        {
            // 0 brightness
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 0.0f, 0f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 60.0f, 0f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 120.0f, 0f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 180.0f, 0f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 240.0f, 0f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 300.0f, 0f, 0.0f));

            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 0.0f, 0.25f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 60.0f, 0.25f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 120.0f, 0.25f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 180.0f, 0.25f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 240.0f, 0.25f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 300.0f, 0.25f, 0.0f));

            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 0.0f, 0.5f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 60.0f, 0.5f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 120.0f, 0.5f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 180.0f, 0.5f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 240.0f, 0.5f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 300.0f, 0.5f, 0.0f));

            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 0.0f, 0.75f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 60.0f, 0.75f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 120.0f, 0.75f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 180.0f, 0.75f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 240.0f, 0.75f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 300.0f, 0.75f, 0.0f));

            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 0.0f, 1f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 60.0f, 1f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 120.0f, 1f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 180.0f, 1f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 240.0f, 1f, 0.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 300.0f, 1f, 0.0f));

            // 1 brightness
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 0.0f, 0f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 60.0f, 0f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 120.0f, 0f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 180.0f, 0f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 240.0f, 0f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 300.0f, 0f, 1f));

            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 0.0f, 0.25f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 60.0f, 0.25f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 120.0f, 0.25f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 180.0f, 0.25f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 240.0f, 0.25f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 300.0f, 0.25f, 1f));

            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 0.0f, 0.5f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 60.0f, 0.5f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 120.0f, 0.5f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 180.0f, 0.5f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 240.0f, 0.5f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 300.0f, 0.5f, 1f));

            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 0.0f, 0.75f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 60.0f, 0.75f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 120.0f, 0.75f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 180.0f, 0.75f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 240.0f, 0.75f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 300.0f, 0.75f, 1f));

            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 0.0f, 1f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 60.0f, 1f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 120.0f, 1f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 180.0f, 1f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 240.0f, 1f, 1f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 300.0f, 1f, 1f));

            // 0 saturation
            Assert.AreEqual(Color.FromArgb(255, 128, 128, 128), Color.Transparent.With(255, 0.0f, 0f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 128, 128, 128), Color.Transparent.With(255, 60.0f, 0f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 128, 128, 128), Color.Transparent.With(255, 120.0f, 0f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 128, 128, 128), Color.Transparent.With(255, 180.0f, 0f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 128, 128, 128), Color.Transparent.With(255, 240.0f, 0f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 128, 128, 128), Color.Transparent.With(255, 300.0f, 0f, 0.5f));

            // 0.25 saturation
            Assert.AreEqual(Color.FromArgb(255, 159, 96, 96), Color.Transparent.With(255, 0.0f, 0.25f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 159, 159, 96), Color.Transparent.With(255, 60.0f, 0.25f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 96, 159, 96), Color.Transparent.With(255, 120.0f, 0.25f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 96, 159, 159), Color.Transparent.With(255, 180.0f, 0.25f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 96, 96, 159), Color.Transparent.With(255, 240.0f, 0.25f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 159, 96, 159), Color.Transparent.With(255, 300.0f, 0.25f, 0.5f));

            // 0.5 saturation
            Assert.AreEqual(Color.FromArgb(255, 191, 64, 64), Color.Transparent.With(255, 0.0f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 191, 191, 64), Color.Transparent.With(255, 60.0f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 64, 191, 64), Color.Transparent.With(255, 120.0f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 64, 191, 191), Color.Transparent.With(255, 180.0f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 64, 64, 191), Color.Transparent.With(255, 240.0f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 191, 64, 191), Color.Transparent.With(255, 300.0f, 0.5f, 0.5f));

            // 0.75 saturation
            Assert.AreEqual(Color.FromArgb(255, 223, 32, 32), Color.Transparent.With(255, 0.0f, 0.75f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 223, 223, 32), Color.Transparent.With(255, 60.0f, 0.75f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 32, 223, 32), Color.Transparent.With(255, 120.0f, 0.75f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 32, 223, 223), Color.Transparent.With(255, 180.0f, 0.75f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 32, 32, 223), Color.Transparent.With(255, 240.0f, 0.75f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 223, 32, 223), Color.Transparent.With(255, 300.0f, 0.75f, 0.5f));

            // 1 saturation
            Assert.AreEqual(Color.FromArgb(255, 255, 0, 0), Color.Transparent.With(255, 0.0f, 1f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 0), Color.Transparent.With(255, 60.0f, 1f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 0, 255, 0), Color.Transparent.With(255, 120.0f, 1f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 0, 255, 255), Color.Transparent.With(255, 180.0f, 1f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 255), Color.Transparent.With(255, 240.0f, 1f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 255, 0, 255), Color.Transparent.With(255, 300.0f, 1f, 0.5f));
        }

        /// <summary>
        ///     Tests for <see cref="ColorExtensions.With(Color,byte?,byte?,byte?,byte?)"/>.
        /// </summary>
        [Test]
        public void ColorWithRgb()
        {
            Random random = new(0);

            for (int i = 0; i < 255; i++)
            {
                byte a = (byte)random.Next();
                byte r = (byte)random.Next();
                byte g = (byte)random.Next();
                byte b = (byte)random.Next();

                Color normalConstruction = Color.FromArgb(a, r, g, b);
                Color withConstruction = Color.Transparent.With(a, r, g, b);

                Trace.WriteLineIf(normalConstruction != withConstruction, i);
                Assert.AreEqual(normalConstruction, withConstruction);
            }
        }

        /// <summary>
        ///     Tests for <see cref="ColorExtensions.Or"/>.
        /// </summary>
        [Test]
        public void Or()
        {
            Color color1 = Color.FromArgb(0b00000000_00000000_00000001_00000001);
            Color color2 = Color.FromArgb(0b00000000_00000001_00000000_00000001);

            Assert.AreEqual(Color.FromArgb(0, 1, 1, 1), color1.Or(color2));
        }

        /// <summary>
        ///     Tests for <see cref="ColorExtensions.XOr"/>.
        /// </summary>
        [Test]
        public void XOr()
        {
            Color color1 = Color.FromArgb(0b00000000_00000000_00000001_00000001);
            Color color2 = Color.FromArgb(0b00000000_00000001_00000000_00000001);

            Assert.AreEqual(Color.FromArgb(0, 1, 1, 0), color1.XOr(color2));
        }
    }
}