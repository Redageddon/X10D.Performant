using System;

namespace X10D.Performant
{
    public static partial class LongExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(long)"/>
        public static byte[] GetBytes(this long value) => BitConverter.GetBytes(value);
    }
}