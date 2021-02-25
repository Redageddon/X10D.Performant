using System;

namespace X10D.Performant.ReExposed
{
    public static partial class Int16Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(short)" />
        public static byte[] GetBytes(this short value) => BitConverter.GetBytes(value);
    }
}