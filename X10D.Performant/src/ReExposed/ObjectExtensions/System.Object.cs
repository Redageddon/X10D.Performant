﻿namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static partial class ObjectExtensions
{
    /// <inheritdoc cref="object.ReferenceEquals(object,object)"/>
    public new static bool ReferenceEquals(this object value, object value2) => object.ReferenceEquals(value, value2);
}