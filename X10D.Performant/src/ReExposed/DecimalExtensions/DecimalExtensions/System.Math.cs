using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class DecimalExtensions
    {
        /// <inheritdoc cref="Math.Abs(decimal)" />
        public static decimal Abs(this decimal value) => Math.Abs(value);

        /// <inheritdoc cref="Math.Clamp(decimal,decimal,decimal)" />
        public static decimal Clamp(this decimal value, decimal min, decimal max) => Math.Clamp(value, min, max);

        /// <inheritdoc cref="Math.Max(decimal,decimal)" />
        public static decimal Max(this decimal value, decimal value2) => Math.Max(value, value2);

        /// <inheritdoc cref="Math.Min(decimal,decimal)" />
        public static decimal Min(this decimal value, decimal value2) => Math.Min(value, value2);

        /// <inheritdoc cref="Math.Sign(decimal)" />
        public static int Sign(this decimal value) => Math.Sign(value);
    }
}