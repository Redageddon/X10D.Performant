using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class UInt32Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(uint)" />
        public static byte[] GetBytes(this uint value) => BitConverter.GetBytes(value);
    }
}