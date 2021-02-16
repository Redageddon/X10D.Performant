using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Utf8JsonReader"/>.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static class Utf8JsonReaderExtensions
    {
        /// <inheritdoc cref="JsonSerializer.Deserialize{T}(ref Utf8JsonReader,JsonSerializerOptions)"/>
        public static TValue? JsonTo<TValue>(this ref Utf8JsonReader reader, JsonSerializerOptions? serializerOptions = null) =>
            JsonSerializer.Deserialize<TValue>(ref reader, serializerOptions);
    }
}