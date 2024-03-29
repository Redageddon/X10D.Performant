﻿namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static partial class SingleExtensions
{
    /// <inheritdoc cref="Vector2.Lerp"/>
    public static Vector2 LerpTo(this float amount, Vector2 value1, Vector2 value2) => Vector2.Lerp(value1, value2, amount);
}