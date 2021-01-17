using System;

namespace X10D.Performant.DecimalExtensions
{
    public static partial class DecimalExtensions
    {
        /// <inheritdoc cref="Math.Abs(decimal)"/>
        public static decimal Abs(this decimal value) => Math.Abs(value);
        
        /// <inheritdoc cref="Math.Ceiling(decimal)"/>
        public static decimal Ceiling(this decimal value) => Math.Ceiling(value);
        
        /// <inheritdoc cref="Math.Floor(decimal)"/>
        public static decimal Floor(this decimal value) => Math.Floor(value);
        
        /// <inheritdoc cref="Math.Round(decimal)"/>
        public static decimal Round(this decimal value) => Math.Round(value);
        
        /// <inheritdoc cref="Math.Round(decimal,MidpointRounding)"/>
        public static decimal Round(this decimal value, MidpointRounding mode) => Math.Round(value, mode);
        
        /// <inheritdoc cref="Math.Round(decimal,int)"/>
        public static decimal Round(this decimal value, int digits) => Math.Round(value, digits);
        
        /// <inheritdoc cref="Math.Round(decimal,int,MidpointRounding)"/>
        public static decimal Round(this decimal value, int digits, MidpointRounding mode) => Math.Round(value, digits, mode);
        
        /// <inheritdoc cref="Math.Truncate(decimal)"/>
        public static decimal Truncate(this decimal value) => Math.Truncate(value);

        /// <inheritdoc cref="Math.Sign(decimal)"/>
        public static int Sign(this decimal value) => Math.Sign(value);
        
        /// <inheritdoc cref="Math.Min(decimal,decimal)"/>
        public static decimal Min(this decimal value, decimal value2) => Math.Min(value, value2);
        
        /// <inheritdoc cref="Math.Max(decimal,decimal)"/>
        public static decimal Max(this decimal value, decimal value2) => Math.Max(value, value2);
        
        /// <inheritdoc cref="Math.Clamp(decimal,decimal,decimal)"/>
        public static decimal Clamp(this decimal value, decimal min, decimal max) => Math.Clamp(value, min, max);
    }
}