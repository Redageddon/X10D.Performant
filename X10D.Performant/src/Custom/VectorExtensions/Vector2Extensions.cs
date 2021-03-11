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
    }
}