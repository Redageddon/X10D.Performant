using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class ObjectExtensions
    {
        /// <inheritdoc cref="Type.GetTypeArray(object[])"/>
        public static Type[] GetTypeArray(this object[] values) => Type.GetTypeArray(values);

        /// <inheritdoc cref="Type.GetTypeHandle(object)"/>
        public static RuntimeTypeHandle GetTypeHandle(this object value) => Type.GetTypeHandle(value);
    }
}