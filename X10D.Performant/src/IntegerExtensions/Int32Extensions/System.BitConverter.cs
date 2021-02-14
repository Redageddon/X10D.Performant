using System;

namespace X10D.Performant
{
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(long)" />
        public static byte[] GetBytes(this int value) => BitConverter.GetBytes(value);
    }
}