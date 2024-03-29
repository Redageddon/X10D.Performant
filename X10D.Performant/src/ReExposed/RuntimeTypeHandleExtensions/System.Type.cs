﻿namespace X10D.Performant.ReExposed;

/// <summary>
///     Extension methods for <see cref="RuntimeTypeHandle"/>.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static class RuntimeTypeHandleExtensions
{
    /// <inheritdoc cref="Type.GetTypeFromHandle(RuntimeTypeHandle)"/>
    public static Type GetTypeFromHandle(this RuntimeTypeHandle handle) => Type.GetTypeFromHandle(handle);
}