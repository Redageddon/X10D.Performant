using X10D.Performant.CharExtensions;

namespace X10D.Tests.Core
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
