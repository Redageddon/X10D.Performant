using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class DoubleExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(double)"/>
        public static byte[] GetBytes(this double value) => BitConverter.GetBytes(value);
    }
}