using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace X10D.Performant.ReExposed.VectorExtensions
{
    /// <summary>
    ///     Extensions for <see cref="Vector2"/>.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static class VectorExtensions
    {
        /// <inheritdoc cref="Vector2.Lerp"/>
        public static Vector2 LerpTo(this Vector2 value1, Vector2 value2, float amount) => Vector2.Lerp(value1, value2, amount);
    }
}