using System.Threading;
using System.Threading.Tasks;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="WaitHandle" />.
    /// </summary>
    public static partial class WaitHandleExtensions
    {
        /// <summary>
        ///     Returns a <see cref="Task" /> which can be awaited until the current <see cref="WaitHandle" /> receives a signal.
        /// </summary>
        /// <param name="handle">The <see cref="WaitHandle" /> instance.</param>
        /// <returns>A <see cref="Task" /> which wraps <see cref="WaitHandle.WaitOne()" />.</returns>
        public static Task WaitOneAsync(this WaitHandle handle) => new(() => handle.WaitOne());
    }
}