using System.IO;

namespace X10D.Performant.StreamExtensions
{
    public static partial class StreamExtensions
    {
        /// <inheritdoc cref="Stream.Synchronized(Stream)"/>
        public static Stream Synchronized(this Stream stream) => Stream.Synchronized(stream);
    }
}