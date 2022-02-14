using System.Net;
using System.Net.Sockets;
using NUnit.Framework;
using X10D.Performant.EndpointExtensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="EndPointExtensions"/>
/// </summary>
public class EndpointTests
{
    private readonly EndPoint dns = new DnsEndPoint("Name", byte.MaxValue);
    private readonly EndPoint ip = new IPEndPoint(int.MaxValue, byte.MaxValue);
    private readonly EndPoint other = new UnixDomainSocketEndPoint("Test");

    /// <summary>
    ///     Tests for <see cref="EndPointExtensions.GetHostName"/>
    /// </summary>
    [Test]
    public void GetHostName()
    {
        Assert.AreEqual("Name", this.dns.GetHostName());
        Assert.AreEqual("255.255.255.127", this.ip.GetHostName());
        Assert.AreEqual(string.Empty, this.other.GetHostName());
    }

    /// <summary>
    ///     Tests for <see cref="EndPointExtensions.GetPort"/>
    /// </summary>
    [Test]
    public void GetPort()
    {
        Assert.AreEqual(255, this.dns.GetPort());
        Assert.AreEqual(255, this.ip.GetPort());
        Assert.AreEqual(0, this.other.GetPort());
    }
}