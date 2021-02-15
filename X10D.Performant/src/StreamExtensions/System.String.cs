using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StreamExtensions
    {
        /// <inheritdoc cref="Stream.Synchronized(Stream)" />
        public static Stream Synchronized(this Stream stream) => Stream.Synchronized(stream);
    }
}