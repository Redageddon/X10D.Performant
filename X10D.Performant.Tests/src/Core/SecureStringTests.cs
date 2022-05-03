using System.Security;
using NUnit.Framework;
using X10D.Performant.SecureStringExtensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="SecureStringExtensions"/>.
/// </summary>
public class SecureStringTests
{
    /// <summary>
    ///     Test for <see cref="SecureStringExtensions.ToNormalString"/>.
    /// </summary>
    [Test]
    public void ToNormalString()
    {
        using SecureString secureString = new();
        secureString.AppendChar('h');
        secureString.AppendChar('a');
        secureString.AppendChar('t');

        Assert.AreEqual("hat", secureString.ToNormalString());
    }
}