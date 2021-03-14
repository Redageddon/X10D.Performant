using System;
using System.Runtime.CompilerServices;
using X10D.Performant.Int64Extensions;

namespace X10D.Performant.UInt64Extensions
{
    /// <summary>
    ///     Extension methods for <see cref="ulong"/>.
    /// </summary>
    public static partial class UInt64Extensions
    {
        /// <include file='UInt64Extensions.xml' path='members/member[@name="FromUnixTimestamp"]'/>
        public static DateTime FromUnixTimestamp(this ulong timestamp, bool isMilliseconds = false) =>
            ((long)timestamp).FromUnixTimestamp(isMilliseconds);

        /// <include file='UInt64Extensions.xml' path='members/member[@name="IsEven"]'/>
        public static bool IsEven(this ulong value) => (value & 1UL) == 0UL;

        /// <include file='UInt64Extensions.xml' path='members/member[@name="IsOdd"]'/>
        public static bool IsOdd(this ulong value) => (value & 1UL) == 1UL;

        /// <include file='UInt64Extensions.xml' path='members/member[@name="Mod"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ulong Mod(this ulong value, ulong modulus) =>
            value < modulus
                ? value
                : value - (value / modulus * modulus);

        /// <include file='UInt64Extensions.xml' path='members/member[@name="ToBoolean"]'/>
        public static bool ToBoolean(this ulong value) => value != 0UL;
    }
}