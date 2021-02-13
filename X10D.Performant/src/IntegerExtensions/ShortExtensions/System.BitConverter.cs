using System;

namespace X10D.Performant
{
    public static partial class ShortExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(short)"/>
        public static byte[] GetBytes(this short value) => BitConverter.GetBytes(value);
    }
}