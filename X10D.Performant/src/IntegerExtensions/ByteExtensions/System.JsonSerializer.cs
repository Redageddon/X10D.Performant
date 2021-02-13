using System;
using System.Text.Json;

namespace X10D.Performant.ByteExtensions
{
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.Deserialize{T}(ReadOnlySpan{byte},JsonSerializerOptions)"/>
        public static T? JsonTo<T>(this ReadOnlySpan<byte> value, JsonSerializerOptions? serializerOptions = null)
        {
            return JsonSerializer.Deserialize<T>(value, serializerOptions);
        }
    }
}