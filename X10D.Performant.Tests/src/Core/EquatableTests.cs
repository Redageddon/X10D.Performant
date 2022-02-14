using NUnit.Framework;
using X10D.Performant.IEquatableExtensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="IEquatableExtensions.EquatableExtensions"/>.
/// </summary>
public class EquatableTests
{
    /// <summary>
    ///     Tests for <see cref="IEquatableExtensions.EquatableExtensions.AndEquals{T}(T,T,T)"/>.
    /// </summary>
    [Test]
    public void AndEqualsComparison()
    {
        Assert.IsTrue(1.AndEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsTrue(0.AndEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsFalse(1.AndEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsFalse(0.AndEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsFalse(1.AndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(1.AndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.AndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(0.AndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.AndEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsFalse(1.AndEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsFalse(0.AndEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsFalse(1.AndEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsFalse(0.AndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(0.AndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(1.AndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(1.AndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
    }

    /// <summary>
    ///     Tests for <see cref="IEquatableExtensions.EquatableExtensions.NAndEquals{T}(T,T,T)"/>.
    /// </summary>
    [Test]
    public void NAndEqualsComparison()
    {
        Assert.IsTrue(1.NAndEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsTrue(0.NAndEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsTrue(1.NAndEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsTrue(0.NAndEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsFalse(1.NAndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(1.NAndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsTrue(0.NAndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(0.NAndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsTrue(0.NAndEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsTrue(1.NAndEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsFalse(0.NAndEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsFalse(1.NAndEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsTrue(0.NAndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(0.NAndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(1.NAndEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(1.NAndEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
    }

    /// <summary>
    ///     Tests for <see cref="IEquatableExtensions.EquatableExtensions.NOrEquals{T}(T,T,T)"/>.
    /// </summary>
    [Test]
    public void NOrEqualsComparison()
    {
        Assert.IsFalse(1.NOrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsFalse(0.NOrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsTrue(1.NOrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsTrue(0.NOrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsFalse(1.NOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(1.NOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsTrue(0.NOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(0.NOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.NOrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsFalse(1.NOrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsFalse(0.NOrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsFalse(1.NOrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsTrue(0.NOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(0.NOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(1.NOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(1.NOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
    }

    /// <summary>
    ///     Tests for <see cref="IEquatableExtensions.EquatableExtensions.OrEquals{T}(T,T,T)"/>.
    /// </summary>
    [Test]
    public void OrEqualsComparison()
    {
        Assert.IsTrue(1.OrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsTrue(0.OrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsTrue(1.OrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsTrue(0.OrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsTrue(1.OrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(1.OrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsTrue(0.OrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(0.OrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.OrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsFalse(1.OrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsTrue(0.OrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsTrue(1.OrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsTrue(0.OrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(0.OrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsTrue(1.OrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(1.OrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
    }

    /// <summary>
    ///     Tests for <see cref="IEquatableExtensions.EquatableExtensions.XNOrEquals{T}(T,T,T)"/>.
    /// </summary>
    [Test]
    public void XnOrEqualsComparison()
    {
        Assert.IsTrue(1.XNOrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsTrue(0.XNOrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsTrue(1.XNOrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsTrue(0.XNOrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsTrue(1.XNOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(1.XNOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.XNOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(0.XNOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.XNOrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsFalse(1.XNOrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsFalse(0.XNOrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsFalse(1.XNOrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsFalse(0.XNOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(0.XNOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsTrue(1.XNOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(1.XNOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
    }

    /// <summary>
    ///     Tests for <see cref="IEquatableExtensions.EquatableExtensions.XOrEquals{T}(T,T,T)"/>.
    /// </summary>
    [Test]
    public void XOrEqualsComparison()
    {
        Assert.IsTrue(1.XOrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsTrue(0.XOrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsTrue(1.XOrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsTrue(0.XOrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsTrue(1.XOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(1.XOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.XOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(0.XOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsFalse(0.XOrEquals(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Assert.IsFalse(1.XOrEquals(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
        Assert.IsFalse(0.XOrEquals(new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }));
        Assert.IsFalse(1.XOrEquals(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }));
        Assert.IsFalse(0.XOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsTrue(0.XOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
        Assert.IsTrue(1.XOrEquals(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }));
        Assert.IsFalse(1.XOrEquals(new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0 }));
    }
}