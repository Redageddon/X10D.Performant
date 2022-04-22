namespace X10D.Performant.ReExposed;

/// <summary>
///     General generic extension methods.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static class GenericExtensions
{
    /// <inheritdoc cref="System.Text.Json.JsonSerializer.Serialize{T}(T,JsonSerializerOptions)"/>
    public static string ToJson<TValue>(this TValue value, JsonSerializerOptions? jsonSerializerOptions = null) =>
        JsonSerializer.Serialize(value, jsonSerializerOptions);

    /// <inheritdoc cref="System.Text.Json.JsonSerializer.SerializeToUtf8Bytes{T}(T,JsonSerializerOptions)"/>
    public static byte[] ToUtf8EncodedJson<TValue>(this TValue value, JsonSerializerOptions? jsonSerializerOptions = null) =>
        JsonSerializer.SerializeToUtf8Bytes(value, jsonSerializerOptions);
}