using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ListExtensions"/>
    /// </summary>
    public class ListTests
    {
        /// <summary>
        ///     Tests for <see cref="ListExtensions.OneOf{T}"/>
        /// </summary>
        [Test]
        public void OneOf()
        {
            List<int> list = new()
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

            Assert.IsTrue(list.Contains(list.OneOf()));
            Assert.IsTrue(list.Contains(new[] { 11, 2, 6 }.OneOf()));
        }

        /// <summary>
        ///     Tests for <see cref="ListExtensions.Random{T}(IList{T},IList{T},System.Random?)"/>
        /// </summary>
        [Test]
        public void Random()
        {
            int[] array = { 1, 2, 3 };
            int[] buffer = new int[20];
            array.Random(buffer);

            Assert.IsTrue(buffer.Contains(1));
            Assert.IsTrue(buffer.Contains(2));
            Assert.IsTrue(buffer.Contains(3));
        }

        /// <summary>
        ///     Tests for <see cref="ListExtensions.Shuffle{T}(IList{T},System.Random?)"/>
        /// </summary>
        [Test]
        public void Shuffle()
        {
            int[] array = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            int[] buffer = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            array.Shuffle();

            CollectionAssert.AreNotEqual(array, buffer);
        }
    }
}