using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace X10D.Performant
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

        public static Color ReadArgbColor(this Stream stream, bool littleEndian = true) => Color.FromArgb(stream.ReadInt32(littleEndian));

        public static bool ReadBoolean(this Stream stream) => stream.ReadByte() != 0;

        public static char ReadChar(this Stream stream) => (char)stream.ReadByte();

        public static decimal ReadDecimal(this Stream stream, bool littleEndian = true)
        {
            Span<int> buffer = stackalloc int[] { stream.ReadInt32(), stream.ReadInt32(), stream.ReadInt32(), stream.ReadInt32() };

            if (!littleEndian)
            {
                buffer.Reverse();
            }

            return new decimal(buffer);
        }

        public static double ReadDouble(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[8];
            stream.Read(buffer);

            if (!littleEndian)
            {
                buffer.Reverse();
            }

            return BitConverter.ToDouble(buffer);
        }

        public static short ReadInt16(this Stream stream, bool littleEndian = true) =>
            (short)(littleEndian
                ? stream.ReadByte() | (stream.ReadByte() << 8)
                : (stream.ReadByte() << 8) | stream.ReadByte());

        public static int ReadInt32(this Stream stream, bool littleEndian = true) =>
            littleEndian
                ? stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24)
                : (stream.ReadByte() << 24) | (stream.ReadByte() << 16) | (stream.ReadByte() << 8) | stream.ReadByte();

        public static long ReadInt64(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[8];
            stream.Read(buffer);

            if (!littleEndian)
            {
                buffer.Reverse();
            }

            return BitConverter.ToInt64(buffer);
        }

        public static Color ReadRgbColor(this Stream stream, bool littleEndian = true) =>
            Color.FromArgb((255 << 24) | stream.ReadInt32(littleEndian));

        public static float ReadSingle(this Stream stream, bool littleEndian = true) =>
            BitConverter.Int32BitsToSingle(littleEndian
                                               ? stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24)
                                               : (stream.ReadByte() << 24)
                                               | (stream.ReadByte() << 16)
                                               | (stream.ReadByte() << 8)
                                               | stream.ReadByte());

        public static string ReadString(this Stream stream, int size, Encoding? encoding = null)
        {
            Span<byte> buffer = stackalloc byte[size];
            stream.Read(buffer);

            return (encoding ?? Encoding.Default).GetString(buffer);
        }

        public static ushort ReadUInt16(this Stream stream, bool littleEndian = true) =>
            (ushort)(littleEndian
                ? stream.ReadByte() | (stream.ReadByte() << 8)
                : (stream.ReadByte() << 8) | stream.ReadByte());

        public static uint ReadUInt32(this Stream stream, bool littleEndian = true) =>
            (uint)(littleEndian
                ? stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24)
                : (stream.ReadByte() << 24) | (stream.ReadByte() << 16) | (stream.ReadByte() << 8) | stream.ReadByte());

        public static ulong ReadUInt64(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[8];
            stream.Read(buffer);

            if (!littleEndian)
            {
                buffer.Reverse();
            }

            return BitConverter.ToUInt64(buffer);
        }
    }
}