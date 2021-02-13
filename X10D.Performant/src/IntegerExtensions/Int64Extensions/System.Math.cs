using System;

namespace X10D.Performant
{
    public static partial class Int64Extensions
    {
        /// <inheritdoc cref="Math.Abs(long)"/>
        public static long Abs(this long value) => Math.Abs(value);
        
        /// <inheritdoc cref="Math.DivRem(long,long,out long)"/>
        public static long DivRem(this long value, long value2, out long result) => Math.DivRem(value, value, out result);
        
        /// <inheritdoc cref="Math.BigMul(long,long,out long)"/>
        public static long BigMul(this long value, long value2, out long result) => Math.BigMul(value, value2, out result);
        
        /// <inheritdoc cref="Math.Sign(long)"/>
        public static int Sign(this long value) => Math.Sign(value);
        
        /// <inheritdoc cref="Math.Min(long,long)"/>
        public static long Min(this long value, long value2) => Math.Min(value, value2);
        
        /// <inheritdoc cref="Math.Max(long,long)"/>
        public static long Max(this long value, long value2) => Math.Max(value, value2);
        
        /// <inheritdoc cref="Math.Clamp(long,long,long)"/>
        public static long Clamp(this long value, long min, long max) => Math.Clamp(value, min, max);
    }
}