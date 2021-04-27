using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NUnit.Framework;
using X10D.Performant.IEnumerableExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="EnumerableExtensions"/>.
    /// </summary>
    public class EnumerableTests
    {
        /// <summary>
        ///     Tests for <see cref="EnumerableExtensions.DistinctBy{TSource,TValue}"/>.
        /// </summary>
        [Test]
        public void DistinctBy()
        {
            List<Point> points = new()
            {
                new Point(1, 1),
                new Point(1, 2),
                new Point(1, 3),
                new Point(1, 4),
                new Point(2, 5),
                new Point(3, 5),
                new Point(4, 5),
                new Point(5, 5),
            };

            List<Point> xs = new()
            {
                new Point(1, 1),
                new Point(2, 5),
                new Point(3, 5),
                new Point(4, 5),
                new Point(5, 5),
            };

            List<Point> ys = new()
            {
                new Point(1, 1),
                new Point(1, 2),
                new Point(1, 3),
                new Point(1, 4),
                new Point(2, 5),
            };

            CollectionAssert.AreEqual(xs, points.DistinctBy(e => e.X).ToList());
            CollectionAssert.AreEqual(ys, points.DistinctBy(e => e.Y).ToList());
        }

        /// <summary>
        ///     Tests for <see cref="EnumerableExtensions.LazyChunk{T}"/>.
        /// </summary>
        [Test]
        public void LazyChunk()
        {
            byte[] foo = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
            IEnumerable<IEnumerable<byte>> chunks = foo.LazyChunk(2).ToArray();

            Assert.AreEqual(4, chunks.Count());
            CollectionAssert.AreEqual(new byte[] { 0x01, 0x02 }, chunks.ElementAt(0).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x03, 0x04 }, chunks.ElementAt(1).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x05, 0x06 }, chunks.ElementAt(2).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x07, 0x08 }, chunks.ElementAt(3).ToList());

            IEnumerable<IEnumerable<byte>> chunks2 = foo.LazyChunk(3).ToArray();

            Assert.AreEqual(3, chunks2.Count());
            CollectionAssert.AreEqual(new byte[] { 0x01, 0x02, 0x03 }, chunks2.ElementAt(0).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x04, 0x05, 0x06 }, chunks2.ElementAt(1).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x07, 0x08, 0x00 }, chunks2.ElementAt(2).ToList());
        }

        /// <summary>
        ///     Tests for <see cref="EnumerableExtensions.SelectWhere{T}"/>.
        /// </summary>
        [Test]
        public void SelectWhere()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            CollectionAssert.AreEqual(new[] { 0, 4, 8, 12, 16 }, array.SelectWhere(e => e * 2, e => e % 2 == 0));
            CollectionAssert.AreEqual(new[] { 0, 0, 0, 0 }, array.SelectWhere(e => e * 0, e => e % 3 == 0));
        }
    }
}