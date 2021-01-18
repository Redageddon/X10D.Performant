using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace X10D.Performant.StreamExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Stream"/>.
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        ///     Returns the hash of a stream using the specified hashing algorithm in terms of a <see cref="T:byte[]"/>.
        /// </summary>
        /// <param name="stream">The <see cref="Stream"/> whose hash is to be computed.</param>
        /// <typeparam name="T">A <see cref="HashAlgorithm"/> derived type.</typeparam>
        /// <returns>A <see cref="T:byte[]"/> representing the hash of <paramref name="stream"/>.</returns>
        public static byte[]? GetHash<T>(this Stream stream)
            where T : HashAlgorithm
        {
            MethodInfo? create = typeof(T).GetMethod("Create", Array.Empty<Type>());
            using T? crypt = (T?)create?.Invoke(null, null);

            return crypt?.ComputeHash(stream);
        }
        
        /// <inheritdoc cref="Stream.Synchronized(Stream)"/>
        public static Stream Synchronized(this Stream stream) => Stream.Synchronized(stream);
    }
}