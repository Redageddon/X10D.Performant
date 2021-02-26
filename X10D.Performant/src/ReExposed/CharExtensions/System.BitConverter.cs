using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this char value) => BitConverter.GetBytes(value);
    }
}