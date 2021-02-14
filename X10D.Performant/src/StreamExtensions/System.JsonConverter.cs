using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace X10D.Performant
{
    public static partial class StreamExtensions
    {
        /// <inheritdoc cref="System.Text.Json.JsonSerializer.Deserialize{T}(string,JsonSerializerOptions)"/>
        public static async Task<T?> AsyncJsonTo<T>(this Stream value, JsonSerializerOptions? serializerOptions = null) =>
            await JsonSerializer.DeserializeAsync<T>(value, serializerOptions);

        /// <inheritdoc cref="System.Text.Json.JsonSerializer.SerializeAsync{T}(Stream,T,JsonSerializerOptions,CancellationToken)"/>
        public static async Task ToJsonAsync<T>(
            this Stream stream,
            T value,
            JsonSerializerOptions? serializerOptions = null,
            CancellationToken cancellationToken = default) =>
            await JsonSerializer.SerializeAsync(stream, value, serializerOptions, cancellationToken);
    }
}