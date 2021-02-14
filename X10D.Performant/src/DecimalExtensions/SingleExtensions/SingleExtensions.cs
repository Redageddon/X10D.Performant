using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="float"/>.
    /// </summary>
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this float value) => BitConverter.GetBytes(value);

        /// <inheritdoc cref="DoubleExtensions.IsEven"/>
        public static bool IsEven(this float value) => value % 2F == 0F;

        /// <inheritdoc cref="DoubleExtensions.IsOdd"/>
        public static bool IsOdd(this float value) => value % 2F != 0F;

        /// <inheritdoc cref="DoubleExtensions.RadiansToDegrees"/>
        public static float RadiansToDegrees(this float angle) => angle * 180.0F / MathF.PI;

        /// <inheritdoc cref="DoubleExtensions.RadiansToGradians"/>
        public static float RadiansToGradians(this float angle) => angle * 200F / MathF.PI;

        /// <inheritdoc cref="DoubleExtensions.DegreesToRadians"/>
        public static float DegreesToRadians(this float angle) => MathF.PI * angle / 180.0F;

        /// <inheritdoc cref="DoubleExtensions.DegreesToGradians"/>
        public static float DegreesToGradians(this float angle) => angle * 10F / 9F;

        /// <inheritdoc cref="DoubleExtensions.InverseSqrt"/>
        public static float InverseSqrt(this float value) => 1F / MathF.Sqrt(value);

        /// <inheritdoc cref="DoubleExtensions.GradiansToDegrees"/>
        public static float GradiansToDegrees(this float angle) => angle * 9F / 10F;

        /// <inheritdoc cref="DoubleExtensions.GradiansToRadians"/>
        public static float GradiansToRadians(this float angle) => angle * MathF.PI / 200F;
    }
}