using System.Numerics;

namespace X10D.Performant.ReExposed;

public static partial class UInt64Extensions
{
    /// <inheritdoc cref="BitOperations.Log2(ulong)"/>
    public static int Log2(this ulong value) => BitOperations.Log2(value);

    /// <inheritdoc cref="BitOperations.IsPow2(ulong)"/>
    public static bool IsPow2(this ulong value) => BitOperations.IsPow2(value);

    /// <inheritdoc cref="BitOperations.PopCount(ulong)"/>
    public static int PopCount(this ulong value) => BitOperations.PopCount(value);

    /// <inheritdoc cref="BitOperations.RotateLeft(ulong,int)"/>
    public static ulong RotateLeft(this ulong value, int offset) => BitOperations.RotateLeft(value, offset);

    /// <inheritdoc cref="BitOperations.RotateRight(ulong,int)"/>
    public static ulong RotateRight(this ulong value, int offset) => BitOperations.RotateRight(value, offset);

    /// <inheritdoc cref="BitOperations.LeadingZeroCount(ulong)"/>
    public static int LeadingZeroCount(this ulong value) => BitOperations.LeadingZeroCount(value);

    /// <inheritdoc cref="BitOperations.TrailingZeroCount(ulong)"/>
    public static int TrailingZeroCount(this ulong value) => BitOperations.TrailingZeroCount(value);

    /// <inheritdoc cref="BitOperations.RoundUpToPowerOf2(ulong)"/>
    public static ulong RoundUpToPowerOf2(this ulong value) => BitOperations.RoundUpToPowerOf2(value);
}