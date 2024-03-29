﻿namespace X10D.Performant.ReExposed;

/// <summary>
///     Extension methods for<see cref="WaitHandle"/>.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static class WaitHandleExtensions
{
    /// <inheritdoc cref="WaitHandle.SignalAndWait(WaitHandle,WaitHandle,TimeSpan,bool)"/>
    public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext = false) =>
        WaitHandle.SignalAndWait(handle, toWaitOn, timeout, exitContext);

    /// <inheritdoc cref="WaitHandle.SignalAndWait(WaitHandle,WaitHandle,int,bool)"/>
    public static bool SignalAndWait(this WaitHandle handle, WaitHandle toWaitOn, int millisecondsTimeout = -1, bool exitContext = false) =>
        WaitHandle.SignalAndWait(handle, toWaitOn, millisecondsTimeout, exitContext);

    /// <inheritdoc cref="WaitHandle.WaitAll(WaitHandle[],int,bool)"/>
    public static bool WaitAll(this WaitHandle[] waitHandles, int millisecondsTimeout = -1, bool exitContext = false) =>
        WaitHandle.WaitAll(waitHandles, millisecondsTimeout, exitContext);

    /// <inheritdoc cref="WaitHandle.WaitAll(WaitHandle[],TimeSpan,bool)"/>
    public static bool WaitAll(this WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext = false) =>
        WaitHandle.WaitAll(waitHandles, timeout, exitContext);

    /// <inheritdoc cref="WaitHandle.WaitAny(WaitHandle[],int,bool)"/>
    public static int WaitAny(this WaitHandle[] waitHandles, int millisecondsTimeout = -1, bool exitContext = false) =>
        WaitHandle.WaitAny(waitHandles, millisecondsTimeout, exitContext);

    /// <inheritdoc cref="WaitHandle.WaitAny(WaitHandle[],TimeSpan,bool)"/>
    public static int WaitAny(this WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext = false) =>
        WaitHandle.WaitAny(waitHandles, timeout, exitContext);
}