using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static partial class Int64Extensions
{
    /// <inheritdoc cref="BitConverter.GetBytes(long)"/>
    public static byte[] GetBytes(this long value) => BitConverter.GetBytes(value);
}