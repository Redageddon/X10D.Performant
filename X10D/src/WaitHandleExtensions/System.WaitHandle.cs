using System;
using System.Threading;

namespace X10D.Performant.WaitHandleExtensions
{
    public static partial class WaitHandleExtensions
    {
        /// <inheritdoc cref="WaitHandle.SignalAndWait(WaitHandle,WaitHandle)"/>
        public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn) =>
            WaitHandle.SignalAndWait(handle, toWaitOn);

        /// <inheritdoc cref="WaitHandle.SignalAndWait(WaitHandle,WaitHandle,TimeSpan,bool)"/>
        public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext) =>
            WaitHandle.SignalAndWait(handle, toWaitOn, timeout, exitContext);

        /// <inheritdoc cref="WaitHandle.SignalAndWait(WaitHandle,WaitHandle,int,bool)"/>
        public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext) =>
            WaitHandle.SignalAndWait(handle, toWaitOn, millisecondsTimeout, exitContext);
    }
}