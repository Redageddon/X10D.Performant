using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class GenericExtensions
    {
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.Serialize{T}(T,JsonSerializerOptions)"/>
        public static string ToJson<TValue>(this TValue value, JsonSerializerOptions? jsonSerializerOptions = null) =>
            JsonSerializer.Serialize(value, jsonSerializerOptions);

        /// <inheritdoc cref="System.Text.Json.JsonSerializer.SerializeToUtf8Bytes{T}(T,JsonSerializerOptions)"/>
        public static byte[] ToUtf8EncodedJson<TValue>(this TValue value, JsonSerializerOptions? jsonSerializerOptions = null) =>
            JsonSerializer.SerializeToUtf8Bytes(value, jsonSerializerOptions);
    }
}