using System;

namespace X10D.Performant
{
    public static partial class ULongExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(ulong)"/>
        public static byte[] GetBytes(this ulong value) => BitConverter.GetBytes(value);
    }
}