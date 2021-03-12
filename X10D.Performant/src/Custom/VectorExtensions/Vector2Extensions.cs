using System.Numerics;

namespace X10D.Performant.VectorExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Vector2"/>.
    /// </summary>
    public static class Vector2Extensions
    {
        /// <summary>
        ///     Performs bilinear interpolation between two <see cref="Vector2"/>.
        /// </summary>
        /// <param name="alpha">The <see cref="Vector2"/> that holds the X and Y alpha change values.</param>
        /// <param name="firstValue">The <see cref="Vector2"/> that holds the first X and Y values.</param>
        /// <param name="secondValue">The <see cref="Vector2"/> that holds the second X and Y values.</param>
        /// <returns>
        ///     A new <see cref="Vector2"/> with
        ///     <paramref name="firstValue"/>'s X value and <paramref name="secondValue"/>'s X value between <paramref name="alpha"/>'s X value, and
        ///     <paramref name="firstValue"/>'s Y value and <paramref name="secondValue"/>'s Y value between <paramref name="alpha"/>'s Y value.
        /// </returns>
        public static Vector2 Lerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.Lerp(firstValue.X, secondValue.X),
                alpha.Y.Lerp(firstValue.Y, secondValue.Y));

        /// <summary>
        ///     Performs bilinear interpolation between two <see cref="Vector2"/>.
        /// </summary>
        /// <param name="alpha">The <see cref="Vector2"/> that holds the X and Y alpha change values.</param>
        /// <param name="firstValue">The <see cref="Vector2"/> that holds the first X and Y values.</param>
        /// <param name="secondValue">The <see cref="Vector2"/> that holds the second X and Y values.</param>
        /// <returns>
        ///     A new <see cref="Vector2"/> with
        ///     <paramref name="firstValue"/>'s X value and <paramref name="secondValue"/>'s X value between <paramref name="alpha"/>'s X value, and
        ///     <paramref name="firstValue"/>'s Y value and <paramref name="secondValue"/>'s Y value between <paramref name="alpha"/>'s Y value with
        ///     <see cref="Vector2.X"/> and <see cref="Vector2.Y"/> clamped.
        /// </returns>
        public static Vector2 ClampedXYLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.ClampedLerp(firstValue.X, secondValue.X),
                alpha.Y.ClampedLerp(firstValue.Y, secondValue.Y));

        /// <summary>
        ///     Performs bilinear interpolation between two <see cref="Vector2"/>.
        /// </summary>
        /// <param name="alpha">The <see cref="Vector2"/> that holds the X and Y alpha change values.</param>
        /// <param name="firstValue">The <see cref="Vector2"/> that holds the first X and Y values.</param>
        /// <param name="secondValue">The <see cref="Vector2"/> that holds the second X and Y values.</param>
        /// <returns>
        ///     A new <see cref="Vector2"/> with
        ///     <paramref name="firstValue"/>'s X value and <paramref name="secondValue"/>'s X value between <paramref name="alpha"/>'s X value, and
        ///     <paramref name="firstValue"/>'s Y value and <paramref name="secondValue"/>'s Y value between <paramref name="alpha"/>'s Y value with
        ///     <see cref="Vector2.Y"/> clamped.
        /// </returns>
        public static Vector2 ClampedYLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.Lerp(firstValue.X, secondValue.X),
                alpha.Y.ClampedLerp(firstValue.Y, secondValue.Y));

        /// <summary>
        ///     Performs bilinear interpolation between two <see cref="Vector2"/>.
        /// </summary>
        /// <param name="alpha">The <see cref="Vector2"/> that holds the X and Y alpha change values.</param>
        /// <param name="firstValue">The <see cref="Vector2"/> that holds the first X and Y values.</param>
        /// <param name="secondValue">The <see cref="Vector2"/> that holds the second X and Y values.</param>
        /// <returns>
        ///     A new <see cref="Vector2"/> with
        ///     <paramref name="firstValue"/>'s X value and <paramref name="secondValue"/>'s X value between <paramref name="alpha"/>'s X value, and
        ///     <paramref name="firstValue"/>'s Y value and <paramref name="secondValue"/>'s Y value between <paramref name="alpha"/>'s Y value with
        ///     <see cref="Vector2.X"/> clamped.
        /// </returns>
        public static Vector2 ClampedXLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.ClampedLerp(firstValue.X, secondValue.X),
                alpha.Y.Lerp(firstValue.Y, secondValue.Y));

        /// <inheritdoc cref="Lerp"/>
        public static Vector2 LerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
            new(alpha.X.Lerp(firstValue.X, secondValue.X),
                alpha.Y.Lerp(firstValue.Y, secondValue.Y));

        /// <inheritdoc cref="ClampedXYLerp"/>
        public static Vector2 ClampedXYLerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
            new(alpha.X.ClampedLerp(firstValue.X, secondValue.X),
                alpha.Y.ClampedLerp(firstValue.Y, secondValue.Y));

        /// <inheritdoc cref="ClampedYLerp"/>
        public static Vector2 ClampedYLerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
            new(alpha.X.Lerp(firstValue.X, secondValue.X),
                alpha.Y.ClampedLerp(firstValue.Y, secondValue.Y));

        /// <inheritdoc cref="ClampedXLerp"/>
        public static Vector2 ClampedXLerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
            new(alpha.X.ClampedLerp(firstValue.X, secondValue.X),
                alpha.Y.Lerp(firstValue.Y, secondValue.Y));
    }
}