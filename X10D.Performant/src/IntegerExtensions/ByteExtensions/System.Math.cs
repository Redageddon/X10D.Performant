using System;

namespace X10D.Performant
{
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="Math.Min(byte,byte)"/>
        public static byte Min(this byte value, byte value2) => Math.Min(value, value2);

        /// <inheritdoc cref="Math.Max(byte,byte)"/>
        public static byte Max(this byte value, byte value2) => Math.Max(value, value2);

        /// <inheritdoc cref="Math.Clamp(byte,byte,byte)"/>
        public static byte Clamp(this byte value, byte min, byte max) => Math.Clamp(value, min, max);
    }
}