using System;
using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="RandomExtensions"/>.
    /// </summary>
    public class RandomTests
    {
        /// <summary>
        ///     Tests for <see cref="RandomExtensions.NextBool"/>.
        /// </summary>
        [Test]
        public void NextBool()
        {
            Random random = new(1);

            Assert.IsFalse(random.NextBool());
            Assert.IsFalse(random.NextBool());
            Assert.IsFalse(random.NextBool());
            Assert.IsTrue(random.NextBool());
            Assert.IsTrue(random.NextBool());
            Assert.IsFalse(random.NextBool());
            Assert.IsFalse(random.NextBool());
        }

        /// <summary>
        ///     Tests for <see cref="RandomExtensions.NextColorAhsb"/>.
        /// </summary>
        [Test]
        public void NextColorAhsb()
        {
            Random random = new(1);

            Assert.AreEqual(Color.FromArgb(63, 223, 169, 169), random.NextColorAhsb());
            Assert.AreEqual(Color.FromArgb(167, 245, 235, 235), random.NextColorAhsb());
            Assert.AreEqual(Color.FromArgb(25, 65, 61, 61), random.NextColorAhsb());

            Assert.AreEqual(Color.FromArgb(255, 255, 255, 255), random.NextColorAhsb(255, minBrightness: 1));
            Assert.AreEqual(Color.FromArgb(255, 0, 0, 0), random.NextColorAhsb(255, maxBrightness: 0));
        }

        /// <summary>
        ///     Tests for <see cref="RandomExtensions.NextColorArgb"/>.
        /// </summary>
        [Test]
        public void NextColorArgb()
        {
            Random random = new(1);

            Assert.AreEqual(Color.FromArgb(63, 28, 119, 196), random.NextColorArgb());
            Assert.AreEqual(Color.FromArgb(167, 110, 90, 240), random.NextColorArgb());
            Assert.AreEqual(Color.FromArgb(25, 163, 7, 63), random.NextColorArgb());
        }

        /// <summary>
        ///     Tests for <see cref="RandomExtensions.OneOf{T}(System.Random,T[])"/>
        /// </summary>
        [Test]
        public void OneOf()
        {
            Random random = new();

            IList<int> list = new List<int>
            {
                11,
                23,
                234,
                436,
                57,
                3246,
                547,
                235,
                7345,
                2467,
                135,
                2436234,
                624,
                6,
                246,
                2,
            };

            Assert.IsTrue(list.Contains(random.OneOf(2, 6, 11)));
        }

        /// <summary>
        ///     Tests for <see cref="RandomExtensions.OneOf{T}(System.Random,IList{T})"/>
        /// </summary>
        [Test]
        public void OneOf2()
        {
            Random random = new();

            IList<int> list = new List<int>
            {
                11,
                23,
                234,
                436,
                57,
                3246,
                547,
                235,
                7345,
                2467,
                135,
                2436234,
                624,
                6,
                246,
                2,
            };

            Assert.IsTrue(list.Contains(random.OneOf(list)));
        }
    }
}