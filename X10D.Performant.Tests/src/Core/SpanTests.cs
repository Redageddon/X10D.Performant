using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using X10D.Performant.SpanExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="SpanExtensions"/>
    /// </summary>
    [TestClass]
    public class SpanTests
    {
        /// <summary>
        ///     Tests for <see cref="SpanExtensions.Random{T}(ReadOnlySpan{T},Span{T},System.Random?)"/>
        /// </summary>
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void Shuffled()
        {
            Span<int> span = stackalloc int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            Span<int> buffer = span.Shuffled();

            CollectionAssert.AreNotEqual(span.ToArray(), buffer.ToArray());
        }
    }
}