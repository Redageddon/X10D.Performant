using System;

namespace X10D.Performant.GenericExtensions
{
    public static partial class GenericExtensions
    {
        /// <inheritdoc cref="Activator.CreateInstance{T}"/>
        public static T CreateInstance<T>() => Activator.CreateInstance<T>();
    }
}