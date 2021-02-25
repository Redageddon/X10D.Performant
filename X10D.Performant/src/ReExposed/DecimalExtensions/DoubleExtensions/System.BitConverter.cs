using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class DoubleExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(double)" />
        public static byte[] GetBytes(this double value) => BitConverter.GetBytes(value);
    }
}