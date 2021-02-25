using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(int)" />
        public static byte[] GetBytes(this int value) => BitConverter.GetBytes(value);
    }
}