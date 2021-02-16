using System.Net;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="EndPointExtensions"/>
    /// </summary>
    public class EndpointTests
    {
        /// <summary>
        ///     Tests for <see cref="EndPointExtensions.GetHostName"/>
        /// </summary>
        [Test]
        public void GetHostName()
        {
            EndPoint e = new DnsEndPoint("Name", 123);
            Assert.AreEqual("Name", e.GetHostName());
        }

        /// <summary>
        ///     Tests for <see cref="EndPointExtensions.GetPort"/>
        /// </summary>
        [Test]
        public void GetPort()
        {
            EndPoint e = new DnsEndPoint("Name", 123);
            Assert.AreEqual(123, e.GetPort());
        }
    }
}