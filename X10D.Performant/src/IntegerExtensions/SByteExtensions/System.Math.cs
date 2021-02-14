using System;

namespace X10D.Performant
{
    public static partial class SByteExtensions
    {
        /// <inheritdoc cref="Math.Abs(sbyte)"/>
        public static sbyte Abs(this sbyte value) => Math.Abs(value);

        /// <inheritdoc cref="Math.Sign(sbyte)"/>
        public static int Sign(this sbyte value) => Math.Sign(value);

        /// <inheritdoc cref="Math.Min(sbyte,sbyte)"/>
        public static sbyte Min(this sbyte value, sbyte value2) => Math.Min(value, value2);

        /// <inheritdoc cref="Math.Max(sbyte,sbyte)"/>
        public static sbyte Max(this sbyte value, sbyte value2) => Math.Max(value, value2);

        /// <inheritdoc cref="Math.Clamp(sbyte,sbyte,sbyte)"/>
        public static sbyte Clamp(this sbyte value, sbyte min, sbyte max) => Math.Clamp(value, min, max);
    }
}