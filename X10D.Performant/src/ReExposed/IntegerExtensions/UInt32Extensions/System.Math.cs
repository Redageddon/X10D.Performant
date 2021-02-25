using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class UInt32Extensions
    {
        /// <inheritdoc cref="Math.Clamp(uint,uint,uint)" />
        public static uint Clamp(this uint value, uint min, uint max) => Math.Clamp(value, min, max);

        /// <inheritdoc cref="Math.Max(uint,uint)" />
        public static uint Max(this uint value, uint value2) => Math.Max(value, value2);

        /// <inheritdoc cref="Math.Min(uint,uint)" />
        public static uint Min(this uint value, uint value2) => Math.Min(value, value2);
    }
}