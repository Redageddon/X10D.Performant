using System.Numerics;

namespace X10D.Performant.VectorExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Vector2"/>.
    /// </summary>
    public static class Vector2Extensions
    {
        public static Vector2 Lerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.Lerp(firstValue.X, secondValue.X),
                alpha.Y.Lerp(firstValue.Y, secondValue.Y));

        public static Vector2 ClampedXYLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.ClampedLerp(firstValue.X, secondValue.X),
                alpha.Y.ClampedLerp(firstValue.Y, secondValue.Y));

        public static Vector2 ClampedYLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.Lerp(firstValue.X, secondValue.X),
                alpha.Y.ClampedLerp(firstValue.Y, secondValue.Y));

        public static Vector2 ClampedXLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
            new(alpha.X.ClampedLerp(firstValue.X, secondValue.X),
                alpha.Y.Lerp(firstValue.Y, secondValue.Y));
    }
}