﻿using System.Text.Json;

namespace X10D.Performant.GenericExtensions
{
    public static partial class GenericExtensions
    {
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.Serialize{T}(T,JsonSerializerOptions)"/>
        public static string ToJson<T>(this T value, JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return JsonSerializer.Serialize(value, jsonSerializerOptions);
        }
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.SerializeToUtf8Bytes{T}(T,JsonSerializerOptions)"/>
        public static byte[] ToUtf8EncodedJson<T>(this T value, JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return JsonSerializer.SerializeToUtf8Bytes(value, jsonSerializerOptions);
        }
    }
}