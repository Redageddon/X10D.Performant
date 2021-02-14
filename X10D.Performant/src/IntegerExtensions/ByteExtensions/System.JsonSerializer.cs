using System;
using System.Text.Json;

namespace X10D.Performant
{
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.Deserialize{T}(ReadOnlySpan{byte},JsonSerializerOptions)" />
        public static T? JsonTo<T>(this ReadOnlySpan<byte> value, JsonSerializerOptions? serializerOptions = null) =>
            JsonSerializer.Deserialize<T>(value, serializerOptions);
    }
}