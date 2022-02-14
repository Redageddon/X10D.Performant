using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static partial class ByteExtensions
{
    /// <inheritdoc cref="System.Text.Json.JsonSerializer.Deserialize{T}(ReadOnlySpan{byte},JsonSerializerOptions)"/>
    public static TValue? JsonTo<TValue>(this ReadOnlySpan<byte> value, JsonSerializerOptions? serializerOptions = null) =>
        JsonSerializer.Deserialize<TValue>(value, serializerOptions);

    /// <inheritdoc cref="System.Text.Json.JsonSerializer.Deserialize{T}(ReadOnlySpan{byte},JsonSerializerOptions)"/>
    public static TValue? JsonTo<TValue>(this Span<byte> value, JsonSerializerOptions? serializerOptions = null) =>
        JsonSerializer.Deserialize<TValue>(value, serializerOptions);
}