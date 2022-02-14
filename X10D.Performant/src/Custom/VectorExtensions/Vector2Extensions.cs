using System.Numerics;
using X10D.Performant.SingleExtensions;

namespace X10D.Performant.VectorExtensions;

/// <summary>
///     Extension methods for <see cref="Vector2"/>.
/// </summary>
public static class Vector2Extensions
{
    /// <include file='VectorExtensions.xml' path='members/member[@name="ClampedXLerp"]'/>
    public static Vector2 ClampedXLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
        new(alpha.X.LerpClamped(firstValue.X, secondValue.X),
            alpha.Y.Lerp(firstValue.Y, secondValue.Y));

    /// <include file='VectorExtensions.xml' path='members/member[@name="ClampedXLerp"]'/>
    public static Vector2 ClampedXLerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
        new(alpha.X.LerpClamped(firstValue.X, secondValue.X),
            alpha.Y.Lerp(firstValue.Y, secondValue.Y));

    /// <include file='VectorExtensions.xml' path='members/member[@name="ClampedXYLerp"]'/>
    public static Vector2 ClampedXYLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
        new(alpha.X.LerpClamped(firstValue.X, secondValue.X),
            alpha.Y.LerpClamped(firstValue.Y, secondValue.Y));

    /// <include file='VectorExtensions.xml' path='members/member[@name="ClampedXYLerp"]'/>
    public static Vector2 ClampedXYLerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
        new(alpha.X.LerpClamped(firstValue.X, secondValue.X),
            alpha.Y.LerpClamped(firstValue.Y, secondValue.Y));

    /// <include file='VectorExtensions.xml' path='members/member[@name="ClampedYLerp"]'/>
    public static Vector2 ClampedYLerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
        new(alpha.X.Lerp(firstValue.X, secondValue.X),
            alpha.Y.LerpClamped(firstValue.Y, secondValue.Y));

    /// <include file='VectorExtensions.xml' path='members/member[@name="ClampedYLerp"]'/>
    public static Vector2 ClampedYLerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
        new(alpha.X.Lerp(firstValue.X, secondValue.X),
            alpha.Y.LerpClamped(firstValue.Y, secondValue.Y));

    /// <include file='VectorExtensions.xml' path='members/member[@name="Lerp"]'/>
    public static Vector2 Lerp(this Vector2 alpha, Vector2 firstValue, Vector2 secondValue) =>
        new(alpha.X.Lerp(firstValue.X, secondValue.X),
            alpha.Y.Lerp(firstValue.Y, secondValue.Y));

    /// <include file='VectorExtensions.xml' path='members/member[@name="Lerp"]'/>
    public static Vector2 LerpTo(this Vector2 firstValue, Vector2 secondValue, Vector2 alpha) =>
        new(alpha.X.Lerp(firstValue.X, secondValue.X),
            alpha.Y.Lerp(firstValue.Y, secondValue.Y));
}