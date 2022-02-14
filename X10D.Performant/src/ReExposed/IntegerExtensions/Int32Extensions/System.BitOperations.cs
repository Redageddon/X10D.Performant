using System.Numerics;

namespace X10D.Performant.ReExposed;

public static partial class Int32Extensions
{
    /// <inheritdoc cref="BitOperations.IsPow2(int)"/>
    public static bool IsPow2(this int value) => BitOperations.IsPow2(value);

    /// <inheritdoc cref="BitOperations.TrailingZeroCount(int)"/>
    public static int TrailingZeroCount(this int value) => BitOperations.TrailingZeroCount(value);
}