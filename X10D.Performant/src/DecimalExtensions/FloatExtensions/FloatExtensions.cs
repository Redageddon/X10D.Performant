using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="float"/>.
    /// </summary>
    public static partial class FloatExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this float value) => BitConverter.GetBytes(value);

        /// <inheritdoc cref="DoubleExtensions.IsEven"/>
        public static bool IsEven(this float value) => value % 2 == 0;

        /// <inheritdoc cref="DoubleExtensions.IsOdd"/>
        public static bool IsOdd(this float value) => value % 2 != 0;

        /// <inheritdoc cref="DoubleExtensions.RadiansToDegrees"/>
        public static float RadiansToDegrees(this float angle) => angle * 180.0f / MathF.PI;
        
        /// <inheritdoc cref="DoubleExtensions.RadiansToGradians"/>
        public static float RadiansToGradians(this float angle) => angle * 200 / MathF.PI;

        /// <inheritdoc cref="DoubleExtensions.DegreesToRadians"/>
        public static float DegreesToRadians(this float angle) => MathF.PI * angle / 180.0f;
        
        /// <inheritdoc cref="DoubleExtensions.DegreesToGradians"/>
        public static float DegreesToGradians(this float angle) => angle * 10f / 9f;      
        
        /// <inheritdoc cref="DoubleExtensions.InverseSqrt"/>
        public static float InverseSqrt(this float value) => 1 / MathF.Sqrt(value);
        
        /// <inheritdoc cref="DoubleExtensions.GradiansToDegrees"/>
        public static float GradiansToDegrees(this float angle) => angle * 9f / 10f;       
        
        /// <inheritdoc cref="DoubleExtensions.GradiansToRadians"/>
        public static float GradiansToRadians(this float angle) => angle * MathF.PI / 200;
    }
}