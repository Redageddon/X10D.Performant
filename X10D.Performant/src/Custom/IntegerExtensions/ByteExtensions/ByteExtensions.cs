﻿using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="byte"/>.
    /// </summary>
    public static class ByteExtensions
    {
        /// <inheritdoc cref="Int64Extensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this byte timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this byte value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this byte value) => (value & 1) != 0;

        /// <inheritdoc cref="Int64Extensions.IsPrime"/>
        public static bool IsPrime(this byte value)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3:
                case 5:
                case 7:
                case 11:
                case 13: return true;

                default:
                    return Mod(value, 2) != 0
                        && Mod(value, 3) != 0
                        && Mod(value, 5) != 0
                        && Mod(value, 7) != 0
                        && Mod(value, 11) != 0
                        && Mod(value, 13) != 0;
            }
        }

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static byte Mod(this byte value, byte modulus) =>
            value < modulus && value > 0
                ? value
                : (byte)(value - (value / modulus * modulus));

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this byte value) => value != 0;
    }
}