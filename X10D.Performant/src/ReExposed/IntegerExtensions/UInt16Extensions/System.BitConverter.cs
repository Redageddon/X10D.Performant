using System;

namespace X10D.Performant.ReExposed
{
    public static partial class UInt16Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(ushort)" />
        [CLSCompliant(false)]
        public static byte[] GetBytes(this ushort value) => BitConverter.GetBytes(value);
    }
}