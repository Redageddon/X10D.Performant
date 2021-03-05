using System;
using System.Buffers.Binary;
using System.Drawing;
using System.IO;
using System.Text;

namespace X10D.Performant
{
    public static partial class StreamExtensions
    {
        /// <summary>
        ///     Writes an argb <see cref="Color"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="Color"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteArgbColor(this Stream stream, Color value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfArgbColor];

            if (littleEndian)
            {
                BinaryPrimitives.WriteInt32LittleEndian(buffer, value.ToArgb());
            }
            else
            {
                BinaryPrimitives.WriteInt32BigEndian(buffer, value.ToArgb());
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes a <see cref="bool"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="bool"/> to be written to a stream.</param>
        public static void WriteBoolean(this Stream stream, bool value) => stream.WriteByte(value ? 1 : 0);

        /// <summary>
        ///     Writes a <see cref="decimal"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="decimal"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteDecimal(this Stream stream, decimal value, bool littleEndian = true)
        {
            int[] bits = decimal.GetBits(value);
            Span<byte> lo = stackalloc byte[SizeOfInt32];
            Span<byte> mid = stackalloc byte[SizeOfInt32];
            Span<byte> hi = stackalloc byte[SizeOfInt32];
            Span<byte> flags = stackalloc byte[SizeOfInt32];

            if (littleEndian)
            {
                BinaryPrimitives.WriteInt32LittleEndian(lo, bits[0]);
                BinaryPrimitives.WriteInt32LittleEndian(mid, bits[1]);
                BinaryPrimitives.WriteInt32LittleEndian(hi, bits[2]);
                BinaryPrimitives.WriteInt32LittleEndian(flags, bits[3]);

                stream.Write(lo);
                stream.Write(mid);
                stream.Write(hi);
                stream.Write(flags);
            }
            else
            {
                BinaryPrimitives.WriteInt32BigEndian(lo, bits[3]);
                BinaryPrimitives.WriteInt32BigEndian(mid, bits[2]);
                BinaryPrimitives.WriteInt32BigEndian(hi, bits[1]);
                BinaryPrimitives.WriteInt32BigEndian(flags, bits[0]);

                stream.Write(flags);
                stream.Write(hi);
                stream.Write(mid);
                stream.Write(lo);
            }
        }

        /// <summary>
        ///     Writes a <see cref="double"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="double"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void ReadDouble(this Stream stream, double value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfDouble];

            if (littleEndian)
            {
                BinaryPrimitives.WriteDoubleLittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteDoubleBigEndian(buffer, value);
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes a <see cref="short"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="short"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteInt16(this Stream stream, short value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfInt16];

            if (littleEndian)
            {
                BinaryPrimitives.WriteInt16LittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteInt16BigEndian(buffer, value);
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes a <see cref="int"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="int"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteInt32(this Stream stream, int value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfInt32];

            if (littleEndian)
            {
                BinaryPrimitives.WriteInt32LittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteInt32BigEndian(buffer, value);
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes a <see cref="long"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="long"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteInt64(this Stream stream, long value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfInt64];

            if (littleEndian)
            {
                BinaryPrimitives.WriteInt64LittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteInt64BigEndian(buffer, value);
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes an rgb <see cref="Color"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="Color"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteRgbColor(this Stream stream, Color value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfArgbColor];

            if (littleEndian)
            {
                BinaryPrimitives.WriteInt32LittleEndian(buffer, (value.R << 16) | (value.G << 8) | value.B);
            }
            else
            {
                BinaryPrimitives.WriteInt32BigEndian(buffer, (value.B << 16) | (value.G << 8) | value.R);
            }

            stream.Write(buffer.Slice(3));
        }

        /// <summary>
        ///     Writes a <see cref="float"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="float"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteSingle(this Stream stream, float value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfSingle];

            if (littleEndian)
            {
                BinaryPrimitives.WriteSingleLittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteSingleBigEndian(buffer, value);
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes a <see cref="string"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="string"/> to be written to a stream.</param>
        /// <param name="encoding">The encoding of the string.</param>
        public static void WriteString(this Stream stream, string value, Encoding? encoding = null) =>
            stream.Write((encoding ?? Encoding.Default).GetBytes(value));

        /// <summary>
        ///     Writes a <see cref="ushort"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="ushort"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteUInt16(this Stream stream, ushort value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfUInt16];

            if (littleEndian)
            {
                BinaryPrimitives.WriteUInt16LittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteUInt16BigEndian(buffer, value);
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes a <see cref="uint"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="uint"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteUInt32(this Stream stream, uint value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfUInt32];

            if (littleEndian)
            {
                BinaryPrimitives.WriteUInt32LittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteUInt32BigEndian(buffer, value);
            }

            stream.Write(buffer);
        }

        /// <summary>
        ///     Writes a <see cref="ulong"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="ulong"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void WriteUInt64(this Stream stream, ulong value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[SizeOfUInt64];

            if (littleEndian)
            {
                BinaryPrimitives.WriteUInt64LittleEndian(buffer, value);
            }
            else
            {
                BinaryPrimitives.WriteUInt64BigEndian(buffer, value);
            }

            stream.Write(buffer);
        }
    }
}