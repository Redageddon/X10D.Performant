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
        
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.RadiansToGradians"/>
        public static float RadiansToGradians(this float angle) => angle * 200 / MathF.PI;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.DegreesToRadians"/>
        public static float DegreesToRadians(this float angle) => MathF.PI * angle / 180.0f;
        
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.DegreesToGradians"/>
        public static float DegreesToGradians(this float angle) => angle * 10f / 9f;      
        
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.InverseSqrt"/>
        public static float InverseSqrt(this float value) => 1 / MathF.Sqrt(value);
        
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.GradiansToDegrees"/>
        public static float GradiansToDegrees(this float angle) => angle * 9f / 10f;       
        
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.GradiansToRadians"/>
        public static float GradiansToRadians(this float angle) => angle * MathF.PI / 200;
        
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.InverseSqrt"/>
        public static double InverseSqrt(this double value) => 1 / Math.Sqrt(value);
    }
}