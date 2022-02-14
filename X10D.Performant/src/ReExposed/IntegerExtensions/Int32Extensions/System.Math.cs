using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static partial class Int32Extensions
{
    /// <inheritdoc cref="Math.Abs(int)"/>
    public static int Abs(this int value) => Math.Abs(value);

    /// <inheritdoc cref="Math.BigMul(int,int)"/>
    public static long BigMul(this int value, int value2) => Math.BigMul(value, value2);

    /// <inheritdoc cref="Math.Clamp(int,int,int)"/>
    public static int Clamp(this int value, int min, int max) => Math.Clamp(value, min, max);

    /// <inheritdoc cref="Math.DivRem(int,int,out int)"/>
    public static int DivRem(this int value, int value2, out int result) => Math.DivRem(value, value2, out result);

    /// <inheritdoc cref="Math.Max(int,int)"/>
    public static int Mac(this int value, int value2) => Math.Max(value, value2);

    /// <inheritdoc cref="Math.Min(int,int)"/>
    public static int Min(this int value, int value2) => Math.Min(value, value2);

    /// <inheritdoc cref="Math.Sign(int)"/>
    public static int Sign(this int value) => Math.Sign(value);
}