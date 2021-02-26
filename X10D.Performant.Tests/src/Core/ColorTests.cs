using System;
using System.Diagnostics;
using System.Drawing;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ColorExtensions"/>.
    /// </summary>
    public class ColorTests
    {
        /// <summary>
        ///     Tests for <see cref="ColorExtensions.With(Color,byte?,float?,float?,float?)"/>.
        /// </summary>
        [Test]
        public void ColorWithHsb()
        {
            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), Color.Transparent.With(255, 0.0f, 0.0f, 1.0f));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), Color.Transparent.With(255, 0.0f, 0.0f, 0.0f));
            Assert.AreEqual(Color.FromArgb(0, 255, 255, 255), Color.Transparent.With(0, 0.0f, 0.0f, 1.0f));
            Assert.AreEqual(Color.FromArgb(0, 0, 0, 0), Color.Transparent.With(0, 0.0f, 0.0f, 0.0f));

            Assert.AreEqual(Color.FromArgb(255, 63, 79, 47), Color.Transparent.With(255, 90f, 0.25f, 0.25f));
            Assert.AreEqual(Color.FromArgb(255, 127, 191, 63), Color.Transparent.With(255, 90f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 191, 239, 143), Color.Transparent.With(255, 90f, 0.75f, 0.75f));

            Assert.AreEqual(Color.FromArgb(255, 47, 79, 79), Color.Transparent.With(255, 180f, 0.25f, 0.25f));
            Assert.AreEqual(Color.FromArgb(255, 63, 191, 191), Color.Transparent.With(255, 180f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 143, 239, 239), Color.Transparent.With(255, 180f, 0.75f, 0.75f));

            Assert.AreEqual(Color.FromArgb(255, 63, 47, 79), Color.Transparent.With(255, 270f, 0.25f, 0.25f));
            Assert.AreEqual(Color.FromArgb(255, 127, 63, 191), Color.Transparent.With(255, 270f, 0.5f, 0.5f));
            Assert.AreEqual(Color.FromArgb(255, 191, 143, 239), Color.Transparent.With(255, 270f, 0.75f, 0.75f));
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
    }
}