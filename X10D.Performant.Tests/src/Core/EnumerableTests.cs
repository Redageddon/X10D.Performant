using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NUnit.Framework;
using X10D.Performant.IEnumerableExtensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="IEnumerableExtensions.EnumerableExtensions"/>.
/// </summary>
public class EnumerableTests
{
    /// <summary>
    ///     Tests for <see cref="IEnumerableExtensions.Consume"/>.
    /// </summary>
    [Test]
    public void Consume()
    {
        const int count = 10;
        int i = 0;
        int e = 0;

        Enumerable.Repeat(0, count).ForEach(() => i++).Consume();
        Enumerable.Repeat(0, count).ForEach(() => e++).Consume(count / 2);
        Assert.AreEqual(count, i);
        Assert.AreEqual(count / 2, e);
    }

    /// <summary>
    ///     Tests for <see cref="IEnumerableExtensions.DistinctBy{TSource,TValue}"/>.
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
    ///     Tests for <see cref="IEnumerableExtensions.EnumerableExtensions.ForEach{T}(IEnumerable{T},Action{T})"/>.
    /// </summary>
    [Test]
    public void ForEach0()
    {
        int i = 0;
        int e = 0;

        int[] arr = { 1, 2, 3 };
        arr.ForEach(() => i++).Consume();
        arr.ForEach(() => e++).Consume(arr.Length - 1);

        Assert.AreEqual(3, i);
        Assert.AreEqual(2, e);
    }

    /// <summary>
    ///     Tests for <see cref="IEnumerableExtensions.EnumerableExtensions.ForEach{T}(IEnumerable{T},Action)"/>.
    /// </summary>
    [Test]
    public void ForEach1()
    {
        int i = 0;
        int e = 0;

        int[] arr = { 1, 2, 3 };
        arr.ForEach(f => i += f).Consume();
        arr.ForEach(f => e += f).Consume(arr.Length - 1);

        Assert.AreEqual(6, i);
        Assert.AreEqual(3, e);
    }

    /// <summary>
    ///     Tests for <see cref="IEnumerableExtensions.EnumerableExtensions.SelectWhere{T}"/>.
    /// </summary>
    [Test]
    public void SelectWhere()
    {
        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        CollectionAssert.AreEqual(new[] { 0, 4, 8, 12, 16 }, array.SelectWhere(e => e * 2, e => e % 2 == 0));
        CollectionAssert.AreEqual(new[] { 0, 0, 0, 0 }, array.SelectWhere(e => e * 0, e => e % 3 == 0));
    }
}