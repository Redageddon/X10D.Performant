using System;
using NUnit.Framework;
using X10D.Performant.SpanExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="SpanExtensions"/>
    /// </summary>
    public class SpanTests
    {
        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Random{T}(ReadOnlySpan{T},Span{T},System.Random?)"/>
        /// </summary>
        [Test]
        public void Random()
        {
            Span<int> span = stackalloc int[] { 1, 2, 3 };
            Span<int> buffer = stackalloc int[20];
            span.Random(buffer);

            Assert.IsTrue(buffer.Contains(1));
            Assert.IsTrue(buffer.Contains(2));
            Assert.IsTrue(buffer.Contains(3));
        }

        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Random{T}(Span{T},int,System.Random?)"/>
        /// </summary>
        [Test]
        public void Random2()
        {
            Span<int> span = stackalloc int[] { 1, 2, 3 };
            Span<int> buffer = span.Random(20);

            Assert.IsTrue(buffer.Contains(1));
            Assert.IsTrue(buffer.Contains(2));
            Assert.IsTrue(buffer.Contains(3));
        }

        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Shuffle{T}(Span{T},System.Random?)"/>
        /// </summary>
        [Test]
        public void Shuffle()
        {
            Span<int> span = stackalloc int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            Span<int> buffer = stackalloc int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            span.Shuffle();

            CollectionAssert.AreNotEqual(span.ToArray(), buffer.ToArray());
        }

        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Shuffled{T}(Span{T},System.Random?)"/>
        /// </summary>
        [Test]
        public void Shuffled()
        {
            Span<int> span = stackalloc int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            Span<int> buffer = span.Shuffled();

            CollectionAssert.AreNotEqual(span.ToArray(), buffer.ToArray());
        }

        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Where{T}(ReadOnlySpan{T},Predicate{T},int)"/>
        /// </summary>
        [Test]
        public void Where()
        {
            ReadOnlySpan<int> span = stackalloc int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8 }, span.Where(e => e % 2 == 0).ToArray());
            CollectionAssert.AreEqual(new[] { 0, 2, 4 }, span.Where(e => e % 2 == 0, 3).ToArray());
        }

        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Where{T}(Span{T},Predicate{T},int)"/>
        /// </summary>
        [Test]
        public void Where2()
        {
            Span<int> span = stackalloc int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8 }, span.Where(e => e % 2 == 0).ToArray());
            CollectionAssert.AreEqual(new[] { 0, 2, 4 }, span.Where(e => e % 2 == 0, 3).ToArray());
        }

        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Where{T}(System.ReadOnlySpan{T},System.Predicate{T},ref System.Span{T},int)"/>
        /// </summary>
        [Test]
        public void Where3()
        {
            ReadOnlySpan<int> span = stackalloc int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Span<int> buffer = stackalloc int[5];
            span.Where(e => e % 2 == 0, ref buffer);
            CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8 }, buffer.ToArray());

            buffer = stackalloc int[5];
            span.Where(e => e % 2 == 0, ref buffer, 3);
            CollectionAssert.AreEqual(new[] { 0, 2, 4 }, buffer.ToArray());

            buffer = stackalloc int[3];
            span.Where(e => e % 2 == 0, ref buffer);
            CollectionAssert.AreEqual(new[] { 0, 2, 4 }, buffer.ToArray());

            buffer = stackalloc int[3];
            span.Where(e => e % 2 == 0, ref buffer, 2);
            CollectionAssert.AreEqual(new[] { 0, 2 }, buffer.ToArray());

            buffer = stackalloc int[3];
            span.Where(e => e % 2 == 0, ref buffer, 4);
            CollectionAssert.AreEqual(new[] { 0, 2, 4 }, buffer.ToArray());
        }

        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Where{T}(Span{T},Predicate{T},ref Span{T},int)"/>
        /// </summary>
        [Test]
        public void Where4()
        {
            Span<int> span = stackalloc int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Span<int> buffer = stackalloc int[5];
            span.Where(e => e % 2 == 0, ref buffer);
            CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8 }, buffer.ToArray());

            span.Where(e => e % 2 == 0, ref buffer, 3);
            CollectionAssert.AreEqual(new[] { 0, 2, 4 }, buffer.ToArray());

            buffer = stackalloc int[3];
            span.Where(e => e % 2 == 0, ref buffer);
            CollectionAssert.AreEqual(new[] { 0, 2, 4 }, buffer.ToArray());

            span.Where(e => e % 2 == 0, ref buffer, 2);
            CollectionAssert.AreEqual(new[] { 0, 2 }, buffer.ToArray());
        }
    }
}