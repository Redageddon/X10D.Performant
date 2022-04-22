namespace X10D.Performant.ReExposed;

public static partial class Int64Extensions
{
    /// <inheritdoc cref="BitOperations.IsPow2(long)"/>
    public static bool IsPow2(this long value) => BitOperations.IsPow2(value);

    /// <inheritdoc cref="BitOperations.TrailingZeroCount(long)"/>
    public static long TrailingZeroCount(this long value) => BitOperations.TrailingZeroCount(value);
}