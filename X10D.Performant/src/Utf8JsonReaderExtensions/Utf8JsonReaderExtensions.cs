using System.Text.Json;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Utf8JsonReader" />.
    /// </summary>
    public static class Utf8JsonReaderExtensions
    {
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.Deserialize{T}(ref Utf8JsonReader,JsonSerializerOptions)" />
        public static T? JsonTo<T>(this ref Utf8JsonReader reader, JsonSerializerOptions? serializerOptions = null) =>
            JsonSerializer.Deserialize<T>(ref reader, serializerOptions);
    }
}