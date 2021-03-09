using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="float"/>.
    /// </summary>
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.AlmostEquals"/>
        public static bool AlmostEquals(this float value1, float value2, float tolerance = float.Epsilon) =>
            Math.Abs(value1 - value2) < Math.Abs(tolerance);

        /// <inheritdoc cref="DoubleExtensions.InverseSqrt"/>
        public static float InverseSqrt(this float value) => 1F / MathF.Sqrt(value);

        /// <inheritdoc cref="DoubleExtensions.IsEven"/>
        public static bool IsEven(this float value) => value % 2F == 0F;

        /// <inheritdoc cref="DoubleExtensions.IsOdd"/>
        public static bool IsOdd(this float value) => value % 2F != 0F;

        /// <inheritdoc cref="DoubleExtensions.Lerp"/>
        public static float Lerp(this float alpha, float firstValue, float secondValue) => (firstValue * (1 - alpha)) + (secondValue * alpha);
    }
}