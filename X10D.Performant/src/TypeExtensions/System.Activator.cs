using System;
using System.Globalization;
using System.Reflection;

namespace X10D.Performant.TypeExtensions
{
    public static partial class ReflectionExtensions
    {
        /// <inheritdoc cref="Activator.CreateInstance(Type,BindingFlags,Binder,object[],CultureInfo,object[])"/>
        public static object? CreateInstance(
            this Type type,
            BindingFlags bindingAttr,
            Binder? binder = null,
            object?[]? args = null,
            CultureInfo? culture = null,
            object?[]? activationAttributes = null) =>
            Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);

        /// <inheritdoc cref="Activator.CreateInstance(Type,bool)"/>
        public static object? CreateInstance(this Type type, bool nonPublic) => Activator.CreateInstance(type, nonPublic);
    }
}