using System.Threading;
using System.Threading.Tasks;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="WaitHandle"/>.
    /// </summary>
    public static partial class WaitHandleExtensions
    {
        /// <summary>
        ///     Returns a <see cref="Task"/> which can be awaited until the current <see cref="WaitHandle"/> receives a signal.
        /// </summary>
        /// <param name="handle">The <see cref="WaitHandle"/> instance.</param>
        /// <param name="milliseconds">The amount of milliseconds to wait.</param>
        /// <returns>A <see cref="Task"/> which wraps <see cref="WaitHandle.WaitOne()"/>.</returns>
        public static Task<bool> WaitOneAsync(this WaitHandle handle, int milliseconds = -1) =>
            new(() => handle.WaitOne(milliseconds));
    }
}