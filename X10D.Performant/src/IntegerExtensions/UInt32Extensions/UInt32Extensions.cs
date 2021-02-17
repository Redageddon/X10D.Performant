using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="uint"/>.
    /// </summary>
    [CLSCompliant(false)]
    public static partial class UInt32Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this uint timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="UInt64Extensions.IsEven"/>
        public static bool IsEven(this uint value) => (value & 1) == 0;

        /// <inheritdoc cref="UInt64Extensions.IsOdd"/>
        public static bool IsOdd(this uint value) => (value & 1) == 1;

        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this uint value) => UInt64Extensions.IsPrime(value);

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint Mod(this uint value, uint modulus) =>
            value < modulus
                ? value
                : value - (value / modulus * modulus);

        /// <inheritdoc cref="UInt64Extensions.ToBoolean"/>
        public static bool ToBoolean(this uint value) => value != 0;
        
        /// <summary>
        ///     Converts this uint into a color based on the bytes.
        /// </summary>
        /// <param name="value">The value containing the color bytes.</param>
        /// <returns>A new color.</returns>
        public static Color ToColor(this uint value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            return Color.FromArgb(bytes[3], bytes[2], bytes[1], bytes[0]);
        }
    }
}