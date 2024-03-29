﻿namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static partial class UInt16Extensions
{
    /// <inheritdoc cref="Math.Clamp(ushort,ushort,ushort)"/>
    public static ushort Clamp(this ushort value, ushort min, ushort max) => Math.Clamp(value, min, max);

    /// <inheritdoc cref="Math.Max(ushort,ushort)"/>
    public static ushort Max(this ushort value, ushort value2) => Math.Max(value, value2);

    /// <inheritdoc cref="Math.Min(ushort,ushort)"/>
    public static ushort Min(this ushort value, ushort value2) => Math.Min(value, value2);
}