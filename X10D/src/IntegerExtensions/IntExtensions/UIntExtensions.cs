﻿using System;

namespace X10D.Performant.IntExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="uint"/>.
    /// </summary>
    public static class UIntExtensions
    {
        /// <inheritdoc cref="X10D.Performant.LongExtensions.ULongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this uint timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="X10D.Performant.LongExtensions.ULongExtensions.GetBytes"/>
        public static byte[] GetBytes(this uint value) => BitConverter.GetBytes(value);

        /// <inheritdoc cref="X10D.Performant.LongExtensions.ULongExtensions.IsEven"/>
        public static bool IsEven(this uint value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.ULongExtensions.IsOdd"/>
        public static bool IsOdd(this uint value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.ULongExtensions.ToBoolean"/>
        public static bool ToBoolean(this uint value) => value != 0;
        
        /// <inheritdoc cref="X10D.Performant.LongExtensions.ULongExtensions.IsPrime"/>
        public static bool IsPrime(this uint value)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3: return true;
            }

            if (value % 2 == 0 ||
                value % 3 == 0)
            {
                return false;
            }

            if ((value + 1) % 6 != 0 &&
                (value - 1) % 6 != 0)
            {
                return false;
            }

            for (uint i = 5; i * i <= value; i += 6)
            {
                if (value % i == 0 ||
                    value % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}