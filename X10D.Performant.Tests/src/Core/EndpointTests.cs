using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="EndPointExtensions"/>
    /// </summary>
    [TestClass]
    public class EndpointTests
    {
        /// <summary>
        ///     Tests for <see cref="EndPointExtensions.GetHostName"/>
        /// </summary>
        [TestMethod]
        public void GetHostName()
        {
            EndPoint e = new DnsEndPoint("Name", 123);
            Assert.AreEqual("Name", e.GetHostName());
        }

        /// <summary>
        ///     Tests for <see cref="EndPointExtensions.GetPort"/>
        /// </summary>
        [TestMethod]
        public void GetPort()
        {
            EndPoint e = new DnsEndPoint("Name", 123);
            Assert.AreEqual(123, e.GetPort());
        }
    }
}