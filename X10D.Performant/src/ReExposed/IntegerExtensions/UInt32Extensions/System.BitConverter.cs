using System;

namespace X10D.Performant.ReExposed
{
    public static partial class UInt32Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(uint)" />
        public static byte[] GetBytes(this uint value) => BitConverter.GetBytes(value);
    }
}