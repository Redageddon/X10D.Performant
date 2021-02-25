using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="Type.MakeGenericMethodParameter(int)" />
        public static Type MakeGenericMethodParameter(this int value) => Type.MakeGenericMethodParameter(value);
    }
}