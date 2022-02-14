using System.Numerics;

namespace X10D.Performant.ReExposed;

public static partial class UInt32Extensions
{
    /// <inheritdoc cref="BitOperations.Log2(uint)"/>
    public static int Log2(this uint value) => BitOperations.Log2(value);

    /// <inheritdoc cref="BitOperations.IsPow2(uint)"/>
    public static bool IsPow2(this uint value) => BitOperations.IsPow2(value);

    /// <inheritdoc cref="BitOperations.PopCount(uint)"/>
    public static int PopCount(this uint value) => BitOperations.PopCount(value);

    /// <inheritdoc cref="BitOperations.RotateLeft(uint,int)"/>
    public static uint RotateLeft(this uint value, int offset) => BitOperations.RotateLeft(value, offset);

    /// <inheritdoc cref="BitOperations.RotateRight(uint,int)"/>
    public static uint RotateRight(this uint value, int offset) => BitOperations.RotateRight(value, offset);

    /// <inheritdoc cref="BitOperations.LeadingZeroCount(uint)"/>
    public static int LeadingZeroCount(this uint value) => BitOperations.LeadingZeroCount(value);

    /// <inheritdoc cref="BitOperations.TrailingZeroCount(uint)"/>
    public static int TrailingZeroCount(this uint value) => BitOperations.TrailingZeroCount(value);

    /// <inheritdoc cref="BitOperations.RoundUpToPowerOf2(uint)"/>
    public static uint RoundUpToPowerOf2(this uint value) => BitOperations.RoundUpToPowerOf2(value);
}