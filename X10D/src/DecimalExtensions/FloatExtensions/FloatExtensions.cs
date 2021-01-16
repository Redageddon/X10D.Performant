using System;

namespace X10D.Performant.FloatExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="float"/>.
    /// </summary>
    public static partial class FloatExtensions
    {
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this float value) => BitConverter.GetBytes(value);

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.IsEven"/>
        public static bool IsEven(this float value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.IsOdd"/>
        public static bool IsOdd(this float value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.RadiansToDegrees"/>
        public static float RadiansToDegrees(this float angle) => angle * 180.0f / MathF.PI;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.DegreesToRadians"/>
        public static float DegreesToRadians(this float angle) => MathF.PI * angle / 180.0f;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.Round"/>
        public static float Round(this float value, float nearest = 1) => MathF.Round(value / nearest) * nearest;
    }
}