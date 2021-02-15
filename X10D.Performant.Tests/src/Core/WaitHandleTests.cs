using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="WaitHandleExtensions"/>
    /// </summary>
    [TestClass]
    public class WaitHandleTests
    {
        /// <summary>
        ///     Tests for <see cref="WaitHandleExtensions.WaitOneAsync"/>
        /// </summary>
        [TestMethod]
        public void WaitOneAsync()
        {
            Inner();
            static async void Inner()
            {
                WaitHandle waitHandle = new ManualResetEvent(true);
                Assert.IsTrue(await waitHandle.WaitOneAsync());
                WaitHandle waitHandle2 = new ManualResetEvent(false);
                Assert.IsFalse(await waitHandle2.WaitOneAsync());
            }
        }
    }
}