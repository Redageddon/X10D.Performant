using System.Threading;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="WaitHandleExtensions"/>
    /// </summary>
    public class WaitHandleTests
    {
        /// <summary>
        ///     Tests for <see cref="WaitHandleExtensions.WaitOneAsync"/>
        /// </summary>
        [Test]
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