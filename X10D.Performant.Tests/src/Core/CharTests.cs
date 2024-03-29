using NUnit.Framework;
using X10D.Performant.CharExtensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="CharExtensions"/>.
/// </summary>
public class CharTests
{
    /// <summary>
    ///     Tests for <see cref="CharExtensions.GetNextLetter"/>.
    /// </summary>
    [Test]
    public void GetNextLetter()
    {
        Assert.AreEqual('b', 'a'.GetNextLetter());
        Assert.AreEqual('a', 'a'.GetNextLetter(0));
        Assert.AreEqual('c', 'a'.GetNextLetter(2));
        Assert.AreEqual('z', 'a'.GetNextLetter(25));
        Assert.AreEqual('a', 'a'.GetNextLetter(26, true));
        Assert.AreEqual('b', 'a'.GetNextLetter(27, true));
        Assert.AreEqual('B', 'a'.GetNextLetter(isUpper: true));
        Assert.AreEqual('C', 'a'.GetNextLetter(2, isUpper: true));
        Assert.AreEqual('Z', 'a'.GetNextLetter(25, isUpper: true));
        Assert.AreEqual('A', 'a'.GetNextLetter(26, true, true));
        Assert.AreEqual('B', 'a'.GetNextLetter(27, true, true));
        Assert.AreEqual('z', 'z'.GetNextLetter(-0));
        Assert.AreEqual('y', 'z'.GetNextLetter(-1));
        Assert.AreEqual('x', 'z'.GetNextLetter(-2));
        Assert.AreEqual('a', 'z'.GetNextLetter(-25));
        Assert.AreEqual('z', 'z'.GetNextLetter(-26, true));
        Assert.AreEqual('y', 'z'.GetNextLetter(-27, true));
        Assert.AreEqual('Y', 'z'.GetNextLetter(-1, isUpper: true));
        Assert.AreEqual('X', 'z'.GetNextLetter(-2, isUpper: true));
        Assert.AreEqual('A', 'z'.GetNextLetter(-25, isUpper: true));
        Assert.AreEqual('Z', 'z'.GetNextLetter(-26, true, true));
        Assert.AreEqual('Y', 'z'.GetNextLetter(-27, true, true));
    }

    /// <summary>
    ///     Tests for <see cref="CharExtensions.Repeat"/>.
    /// </summary>
    [Test]
    public void Repeat() => Assert.AreEqual("aaaaaaaaaa", 'a'.Repeat(10));
}