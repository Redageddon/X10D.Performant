using System.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="SecureStringExtensions" />.
    /// </summary>
    [TestClass]
    public class SecureStringTests
    {
        /// <summary>
        ///     Test for <see cref="SecureStringExtensions.ToNormalString" />.
        /// </summary>
        [TestMethod]
        public void ToNormalString()
        {
            SecureString secureString = new();
            secureString.AppendChar('h');
            secureString.AppendChar('a');
            secureString.AppendChar('t');
            
            Assert.AreEqual("hat", secureString.ToNormalString());
        }
    }
}