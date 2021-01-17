﻿using System;

namespace X10D.Performant.ShortExtensions
{
    public static partial class ShortExtensions
    {
        /// <inheritdoc cref="Math.Abs(short)"/>
        public static short Abs(this short value) => Math.Abs(value);
        
        /// <inheritdoc cref="Math.Sign(short)"/>
        public static int Sign(this short value) => Math.Sign(value);
        
        /// <inheritdoc cref="Math.Min(short,short)"/>
        public static short Min(this short value, short value2) => Math.Min(value, value2);
        
        /// <inheritdoc cref="Math.Max(short,short)"/>
        public static short Max(this short value, short value2) => Math.Max(value, value2);
        
        /// <inheritdoc cref="Math.Clamp(short,short,short)"/>
        public static short Clamp(this short value, short min, short max) => Math.Clamp(value, min, max);
    }
}