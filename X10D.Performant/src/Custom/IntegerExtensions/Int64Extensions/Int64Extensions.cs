using System;
using System.Runtime.CompilerServices;
using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.Int64Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="long"/>.
    /// </summary>
    public static partial class Int64Extensions
    {
        /// <include file='Int64Extensions.xml' path='members/member[@name="FromUnixTimestamp"]'/>
        public static DateTime FromUnixTimestamp(this long timestamp, bool isMilliseconds = false)
        {
            DateTimeOffset offset = isMilliseconds
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <include file='Int64Extensions.xml' path='members/member[@name="IsEven"]'/>
        public static bool IsEven(this long value) => (value & 1L) == 0L;

        /// <include file='Int64Extensions.xml' path='members/member[@name="IsOdd"]'/>
        public static bool IsOdd(this long value) => (value & 1L) == 1L;

        /// <inheritdoc cref="UInt64Extensions.Mod"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static long Mod(this long value, long modulus) =>
            value < modulus && value > 0
                ? value
                : value - (value / modulus * modulus);

        /// <include file='Int64Extensions.xml' path='members/member[@name="ToBoolean"]'/>
        public static bool ToBoolean(this long value) => value != 0L;
    }
}