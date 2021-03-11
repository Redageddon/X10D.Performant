using System;

namespace X10D.Performant
{
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.DegreesToGradians"/>
        public static float DegreesToGradians(this float degree) => degree * 10F / 9F;

        /// <inheritdoc cref="DoubleExtensions.DegreesToRadians"/>
        public static float DegreesToRadians(this float degree) => MathF.PI * degree / 180.0F;

        /// <inheritdoc cref="DoubleExtensions.GradiansToDegrees"/>
        public static float GradiansToDegrees(this float gradian) => gradian * 9F / 10F;

        /// <inheritdoc cref="DoubleExtensions.GradiansToRadians"/>
        public static float GradiansToRadians(this float gradian) => gradian * MathF.PI / 200F;

        /// <inheritdoc cref="DoubleExtensions.RadiansToDegrees"/>
        public static float RadiansToDegrees(this float radian) => radian * 180.0F / MathF.PI;

        /// <inheritdoc cref="DoubleExtensions.RadiansToGradians"/>
        public static float RadiansToGradians(this float radian) => radian * 200F / MathF.PI;
    }
}