using System;
using System.Threading;

namespace X10D.Performant.WaitHandleExtensions
{
    public static partial class WaitHandleExtensions
    {
        /// <summary>
        ///     Signals one <see cref="WaitHandle"/> and waits on another.
        /// </summary>
        /// <param name="handle">The <see cref="WaitHandle"/> to signal.</param>
        /// <param name="toWaitOn">The <see cref="WaitHandle"/> to wait on.</param>
        /// <returns>
        ///     <see langword="true"/> if both the signal and the wait complete successfully; if the wait does not complete, the method does not 
        ///     return.
        /// </returns>
        public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn) =>
            WaitHandle.SignalAndWait(handle, toWaitOn);

        /// <summary>
        ///     Signals one <see cref="WaitHandle"/> and waits on another, specifying the time-out interval as a <see cref="TimeSpan"/> and
        ///     specifying whether to exit the synchronization domain for the context before entering the wait.
        /// </summary>
        /// <param name="handle">The <see cref="WaitHandle"/> to signal.</param>
        /// <param name="toWaitOn">The <see cref="WaitHandle"/> to wait on.</param>
        /// <param name="timeout">A <see cref="TimeSpan"/> that represents the interval to wait. If the value is -1, the wait is infinite.</param>
        /// <param name="exitContext">
        ///     <see langword="true"/> to exit the synchronization domain for the context before the wait (if in a synchronized context), and
        ///     reacquire it afterward; otherwise, <see langword="false"/>.
        /// </param>
        /// <returns>
        ///     <see langword="true"/> if both the signal and the wait completed successfully, or <see langword="false"/> if the signal completed but the wait timed out.
        /// </returns>
        public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext) =>
            WaitHandle.SignalAndWait(handle, toWaitOn, timeout, exitContext);

        /// <summary>
        ///     Signals one <see cref="WaitHandle"/> and waits on another, specifying a time-out interval as an <see cref="int"/> and specifying
        ///     whether to exit the synchronization domain for the context before entering the wait.
        /// </summary>
        /// <param name="handle">The <see cref="WaitHandle"/> to signal.</param>
        /// <param name="toWaitOn">The <see cref="WaitHandle"/> to wait on.</param>
        /// <param name="millisecondsTimeout">
        ///     An integer that represents the interval to wait. If the value is <see cref="Timeout.Infinite"/>, that
        ///     is, -1, the wait is infinite.
        /// </param>
        /// <param name="exitContext">
        ///     <see langword="true"/> to exit the synchronization domain for the context before the wait (if in a synchronized context), and
        ///     reacquire it afterward; otherwise, <see langword="false"/>.
        /// </param>
        /// <returns>
        ///     <see langword="true"/> if both the signal and the wait completed successfully, or <see langword="false"/> if the signal completed but
        ///     the wait timed out.
        /// </returns>
        public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext) =>
            WaitHandle.SignalAndWait(handle, toWaitOn, millisecondsTimeout, exitContext);
    }
}