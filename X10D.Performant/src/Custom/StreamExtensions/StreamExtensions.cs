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

        /// <summary>
        ///     Reads an argb <see cref="Color"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>A <see cref="Color"/> from read data.</returns>
        public static Color ReadArgbColor(this Stream stream, bool littleEndian = true) => Color.FromArgb(stream.ReadInt32(!littleEndian));

        /// <summary>
        ///     Reads a <see cref="bool"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <returns>A <see cref="bool"/> from read data.</returns>
        public static bool ReadBoolean(this Stream stream) => stream.ReadByte() != 0;

        /// <summary>
        ///     Reads a <see cref="char"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <returns>A <see cref="byte"/> from read data.</returns>
        public static char ReadChar(this Stream stream) => (char)stream.ReadByte();

        /// <summary>
        ///     Reads a <see cref="decimal"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>A <see cref="decimal"/> from read data.</returns>
        public static decimal ReadDecimal(this Stream stream, bool littleEndian = true)
        {
            Span<int> buffer = stackalloc int[] { stream.ReadInt32(), stream.ReadInt32(), stream.ReadInt32(), stream.ReadInt32() };

            if (!littleEndian)
            {
                buffer.Reverse();
            }

            return new decimal(buffer);
        }

        /// <summary>
        ///     Reads a <see cref="double"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>A <see cref="double"/> from read data.</returns>
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

        /// <summary>
        ///     Reads a <see cref="short"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>A <see cref="short"/> from read data.</returns>
        public static short ReadInt16(this Stream stream, bool littleEndian = true) =>
            (short)(littleEndian
                ? stream.ReadByte() | (stream.ReadByte() << 8)
                : (stream.ReadByte() << 8) | stream.ReadByte());

        /// <summary>
        ///     Reads an <see cref="int"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>An <see cref="int"/> from read data.</returns>
        public static int ReadInt32(this Stream stream, bool littleEndian = true) =>
            littleEndian
                ? stream.ReadByte()
                | (stream.ReadByte() << 8)
                | (stream.ReadByte() << 16)
                | (stream.ReadByte() << 24)
                : (stream.ReadByte() << 24)
                | (stream.ReadByte() << 16)
                | (stream.ReadByte() << 8)
                | stream.ReadByte();

        /// <summary>
        ///     Reads a <see cref="long"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>A <see cref="long"/> from read data.</returns>
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

        /// <summary>
        ///     Reads an rgb <see cref="Color"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>A <see cref="Color"/> from read data.</returns>
        public static Color ReadRgbColor(this Stream stream, bool littleEndian = true) =>
            littleEndian
                ? Color.FromArgb((stream.ReadByte() << 16)
                               | (stream.ReadByte() << 8)
                               | stream.ReadByte()
                               | (255 << 24))
                : Color.FromArgb((255 << 24)
                               | stream.ReadByte()
                               | (stream.ReadByte() << 8)
                               | (stream.ReadByte() << 16));

        /// <summary>
        ///     Reads a <see cref="float"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>A <see cref="float"/> from read data.</returns>
        public static float ReadSingle(this Stream stream, bool littleEndian = true) =>
            BitConverter.Int32BitsToSingle(littleEndian
                                               ? stream.ReadByte()
                                               | (stream.ReadByte() << 8)
                                               | (stream.ReadByte() << 16)
                                               | (stream.ReadByte() << 24)
                                               : (stream.ReadByte() << 24)
                                               | (stream.ReadByte() << 16)
                                               | (stream.ReadByte() << 8)
                                               | stream.ReadByte());

        /// <summary>
        ///     Reads a <see cref="string"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="charCount">The amount of <see cref="char"/>s to get inside of the string.</param>
        /// <param name="encoding">The encoding of the string.</param>
        /// <returns>A <see cref="string"/> from read data of a specified size.</returns>
        public static string ReadString(this Stream stream, int charCount, Encoding? encoding = null)
        {
            Span<byte> buffer = stackalloc byte[charCount];
            stream.Read(buffer);

            return (encoding ?? Encoding.Default).GetString(buffer);
        }

        /// <summary>
        ///     Reads an <see cref="ushort"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>An <see cref="ushort"/> from read data.</returns>
        public static ushort ReadUInt16(this Stream stream, bool littleEndian = true) =>
            (ushort)(littleEndian
                ? stream.ReadByte()
                | (stream.ReadByte() << 8)
                : (stream.ReadByte() << 8)
                | stream.ReadByte());

        /// <summary>
        ///     Reads an <see cref="uint"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>An <see cref="uint"/> from read data.</returns>
        public static uint ReadUInt32(this Stream stream, bool littleEndian = true) =>
            (uint)(littleEndian
                ? stream.ReadByte()
                | (stream.ReadByte() << 8)
                | (stream.ReadByte() << 16)
                | (stream.ReadByte() << 24)
                : (stream.ReadByte() << 24)
                | (stream.ReadByte() << 16)
                | (stream.ReadByte() << 8)
                | stream.ReadByte());

        /// <summary>
        ///     Reads an <see cref="ulong"/> from the stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the bytes should be read backwards.</param>
        /// <returns>An <see cref="ulong"/> from read data.</returns>
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