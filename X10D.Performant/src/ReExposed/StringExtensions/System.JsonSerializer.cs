using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.Deserialize{T}(string,JsonSerializerOptions)" />
        public static T? JsonTo<T>(this string value, JsonSerializerOptions? serializerOptions = null) =>
            JsonSerializer.Deserialize<T>(value, serializerOptions);
    }
}