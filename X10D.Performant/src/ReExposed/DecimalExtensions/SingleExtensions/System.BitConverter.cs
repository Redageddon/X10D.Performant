using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(float)" />
        public static byte[] GetBytes(this float value) => BitConverter.GetBytes(value);
    }
}