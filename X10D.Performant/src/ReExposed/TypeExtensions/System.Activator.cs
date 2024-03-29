﻿namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static partial class TypeExtensions
{
    /// <inheritdoc cref="Activator.CreateInstance(Type,BindingFlags,Binder,object[],CultureInfo,object[])"/>
    public static object? CreateInstance(this Type type,
                                         BindingFlags bindingFlags,
                                         Binder? binder = null,
                                         object?[]? args = null,
                                         CultureInfo? culture = null,
                                         object?[]? activationAttributes = null) =>
        Activator.CreateInstance(type, bindingFlags, binder, args, culture, activationAttributes);

    /// <inheritdoc cref="Activator.CreateInstance(Type,bool)"/>
    public static object? CreateInstance(this Type type, bool nonPublic) => Activator.CreateInstance(type, nonPublic);
}