using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static partial class UInt64Extensions
{
    /// <inheritdoc cref="BitConverter.GetBytes(ulong)"/>
    public static byte[] GetBytes(this ulong value) => BitConverter.GetBytes(value);
}