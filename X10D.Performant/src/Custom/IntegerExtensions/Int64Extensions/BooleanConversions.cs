﻿namespace X10D.Performant.Int64Extensions
{
    public static partial class Int64Extensions
    {
        /// <include file='Int64Extensions.xml' path='members/member[@name="IsEven"]'/>
        public static bool IsEven(this long value) => (value & 1L) == 0L;

        /// <include file='Int64Extensions.xml' path='members/member[@name="IsOdd"]'/>
        public static bool IsOdd(this long value) => (value & 1L) == 1L;

        /// <include file='Int64Extensions.xml' path='members/member[@name="ToBoolean"]'/>
        public static bool ToBoolean(this long value) => value != 0L;
    }
}