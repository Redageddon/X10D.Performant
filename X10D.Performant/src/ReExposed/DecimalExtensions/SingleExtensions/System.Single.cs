using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="float.IsFinite(float)"/>
        public static bool IsFinite(this float value) => float.IsFinite(value);

        /// <inheritdoc cref="float.IsInfinity(float)"/>
        public static bool IsInfinity(this float value) => float.IsInfinity(value);

        /// <inheritdoc cref="float.IsNaN(float)"/>
        public static bool IsNaN(this float value) => float.IsNaN(value);

        /// <inheritdoc cref="float.IsNegative(float)"/>
        public static bool IsNegative(this float value) => float.IsNegative(value);

        /// <inheritdoc cref="float.IsNegativeInfinity(float)"/>
        public static bool IsNegativeInfinity(this float value) => float.IsNegativeInfinity(value);

        /// <inheritdoc cref="float.IsNormal(float)"/>
        public static bool IsNormal(this float value) => float.IsNormal(value);

        /// <inheritdoc cref="float.IsPositiveInfinity(float)"/>
        public static bool IsPositiveInfinity(this float value) => float.IsPositiveInfinity(value);

        /// <inheritdoc cref="float.IsSubnormal(float)"/>
        public static bool IsSubnormal(this float value) => float.IsSubnormal(value);
    }
}