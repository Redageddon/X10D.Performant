using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class Int16Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(short)"/>
        public static byte[] GetBytes(this short value) => BitConverter.GetBytes(value);
    }
}