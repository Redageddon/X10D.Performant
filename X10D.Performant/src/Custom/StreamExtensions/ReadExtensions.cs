using System;
using System.Buffers.Binary;
using System.Drawing;
using System.IO;
using System.Text;

namespace X10D.Performant
{
    public static partial class StreamExtensions
    {
        private const int SizeOfDecimal = sizeof(decimal);
        private const int SizeOfDouble = sizeof(double);
        private const int SizeOfInt64 = sizeof(long);
        private const int SizeOfUInt64 = sizeof(ulong);
        private const int SizeOfSingle = sizeof(float);
        private const int SizeOfInt32 = sizeof(int);
        private const int SizeOfUInt32 = sizeof(uint);
        private const int SizeOfInt16 = sizeof(short);
        private const int SizeOfUInt16 = sizeof(ushort);
        private const int SizeOfArgbColor = 4;

        /// <summary>
        ///     Reads an argb <see cref="Color"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>A <see cref="Color"/> from read data.</returns>
        public static Color ReadArgbColor(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfArgbColor];
            stream.Read(buffer);

            return Color.FromArgb(littleEndian
                                      ? BinaryPrimitives.ReadInt32LittleEndian(buffer)
                                      : BinaryPrimitives.ReadInt32BigEndian(buffer));
        }

        /// <summary>
        ///     Reads a <see cref="bool"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <returns>A <see cref="bool"/> from read data.</returns>
        public static bool ReadBoolean(this Stream stream) => stream.ReadByte() != 0;

        /// <summary>
        ///     Reads a <see cref="decimal"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>A <see cref="decimal"/> from read data.</returns>
        public static decimal ReadDecimal(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfDecimal];
            stream.Read(buffer);

            int lo;
            int mid;
            int hi;
            int flags;

            if (littleEndian)
            {
                lo = BinaryPrimitives.ReadInt32LittleEndian(buffer);
                mid = BinaryPrimitives.ReadInt32LittleEndian(buffer.Slice(4));
                hi = BinaryPrimitives.ReadInt32LittleEndian(buffer.Slice(8));
                flags = BinaryPrimitives.ReadInt32LittleEndian(buffer.Slice(12));
            }
            else
            {
                lo = BinaryPrimitives.ReadInt32BigEndian(buffer.Slice(12));
                mid = BinaryPrimitives.ReadInt32BigEndian(buffer.Slice(8));
                hi = BinaryPrimitives.ReadInt32BigEndian(buffer.Slice(4));
                flags = BinaryPrimitives.ReadInt32BigEndian(buffer);
            }

            Span<int> bits = stackalloc int[]
            {
                lo, mid, hi, flags,
            };

            return new decimal(bits);
        }

        /// <summary>
        ///     Reads a <see cref="double"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>A <see cref="double"/> from read data.</returns>
        public static double ReadDouble(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfDouble];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadDoubleLittleEndian(buffer)
                : BinaryPrimitives.ReadDoubleBigEndian(buffer);
        }

        /// <summary>
        ///     Reads a <see cref="short"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>A <see cref="short"/> from read data.</returns>
        public static short ReadInt16(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfInt16];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadInt16LittleEndian(buffer)
                : BinaryPrimitives.ReadInt16BigEndian(buffer);
        }

        /// <summary>
        ///     Reads an <see cref="int"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>An <see cref="int"/> from read data.</returns>
        public static int ReadInt32(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfInt32];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadInt32LittleEndian(buffer)
                : BinaryPrimitives.ReadInt32BigEndian(buffer);
        }

        /// <summary>
        ///     Reads a <see cref="long"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>A <see cref="long"/> from read data.</returns>
        public static long ReadInt64(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfInt64];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadInt64LittleEndian(buffer)
                : BinaryPrimitives.ReadInt64BigEndian(buffer);
        }

        /// <summary>
        ///     Reads an rgb <see cref="Color"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>A <see cref="Color"/> from read data.</returns>
        public static Color ReadRgbColor(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfArgbColor];
            buffer[0] = (byte)stream.ReadByte();
            buffer[1] = (byte)stream.ReadByte();
            buffer[2] = (byte)stream.ReadByte();
            buffer[3] = byte.MaxValue;

            return Color.FromArgb(littleEndian
                                      ? BinaryPrimitives.ReadInt32LittleEndian(buffer)
                                      : BinaryPrimitives.ReadInt32BigEndian(buffer));
        }

        /// <summary>
        ///     Reads a <see cref="float"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>A <see cref="float"/> from read data.</returns>
        public static float ReadSingle(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfSingle];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadSingleLittleEndian(buffer)
                : BinaryPrimitives.ReadSingleBigEndian(buffer);
        }

        /// <summary>
        ///     Reads a <see cref="string"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="byteCount">The amount of <see cref="char"/>s to get inside of the string.</param>
        /// <param name="encoding">The encoding of the string.</param>
        /// <returns>A <see cref="string"/> from read data of a specified size.</returns>
        public static string ReadString(this Stream stream, int byteCount, Encoding? encoding = null)
        {
            Span<byte> buffer = stackalloc byte[byteCount];
            stream.Read(buffer);

            return (encoding ?? Encoding.Default).GetString(buffer);
        }

        /// <summary>
        ///     Reads an <see cref="ushort"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>An <see cref="ushort"/> from read data.</returns>
        public static ushort ReadUInt16(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfUInt16];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadUInt16LittleEndian(buffer)
                : BinaryPrimitives.ReadUInt16BigEndian(buffer);
        }

        /// <summary>
        ///     Reads an <see cref="uint"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>An <see cref="uint"/> from read data.</returns>
        public static uint ReadUInt32(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfUInt32];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadUInt32LittleEndian(buffer)
                : BinaryPrimitives.ReadUInt32BigEndian(buffer);
        }

        /// <summary>
        ///     Reads an <see cref="ulong"/> from a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        /// <returns>An <see cref="ulong"/> from read data.</returns>
        public static ulong ReadUInt64(this Stream stream, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfUInt64];
            stream.Read(buffer);

            return littleEndian
                ? BinaryPrimitives.ReadUInt64LittleEndian(buffer)
                : BinaryPrimitives.ReadUInt64BigEndian(buffer);
        }
    }
}