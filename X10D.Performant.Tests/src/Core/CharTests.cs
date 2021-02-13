using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="CharExtensions"/>.
    /// </summary>
    [TestClass]
    public class CharTests
    {
        /// <summary>
        ///     Tests for <see cref="CharExtensions.Repeat"/>.
        /// </summary>
        [TestMethod]
        public void Repeat()
        {
            Assert.AreEqual("aaaaaaaaaa", 'a'.Repeat(10));
        }
    }
}
