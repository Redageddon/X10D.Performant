﻿using System;
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
            Span<byte> buffer = stackalloc byte[sizeof(int)];

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
        public static void Write(this Stream stream, bool value) => stream.WriteByte(value ? 1 : 0);

        /// <summary>
        ///     Writes a <see cref="decimal"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="decimal"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void Write(this Stream stream, decimal value, bool littleEndian = true)
        {
            int[] bits = decimal.GetBits(value);
            Span<byte> lo = stackalloc byte[sizeof(int)];
            Span<byte> mid = stackalloc byte[sizeof(int)];
            Span<byte> hi = stackalloc byte[sizeof(int)];
            Span<byte> flags = stackalloc byte[sizeof(int)];

            if (littleEndian)
            {
                BinaryPrimitives.WriteInt32LittleEndian(lo, bits[0]);
                BinaryPrimitives.WriteInt32LittleEndian(mid, bits[1]);
                BinaryPrimitives.WriteInt32LittleEndian(hi, bits[2]);
                BinaryPrimitives.WriteInt32LittleEndian(flags, bits[3]);
            }
            else
            {
                BinaryPrimitives.WriteInt32BigEndian(lo, bits[3]);
                BinaryPrimitives.WriteInt32BigEndian(mid, bits[2]);
                BinaryPrimitives.WriteInt32BigEndian(hi, bits[1]);
                BinaryPrimitives.WriteInt32BigEndian(flags, bits[0]);
            }

            stream.Write(lo);
            stream.Write(mid);
            stream.Write(hi);
            stream.Write(flags);
        }

        /// <summary>
        ///     Writes a <see cref="double"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="double"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void Write(this Stream stream, double value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(double)];

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
        public static void Write(this Stream stream, short value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(short)];

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
        public static void Write(this Stream stream, int value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(int)];

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
        public static void Write(this Stream stream, long value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(long)];

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
        ///     Writes a <see cref="float"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="float"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void Write(this Stream stream, float value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(float)];

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
        public static void Write(this Stream stream, string value, Encoding? encoding = null) =>
            stream.Write((encoding ?? Encoding.Default).GetBytes(value));

        /// <summary>
        ///     Writes a <see cref="ushort"/> to a stream.
        /// </summary>
        /// <param name="stream">The stream that holds the data.</param>
        /// <param name="value">The <see cref="ushort"/> to be written to a stream.</param>
        /// <param name="littleEndian">Whether or not the data is little endian.</param>
        public static void Write(this Stream stream, ushort value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(ushort)];

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
        public static void Write(this Stream stream, uint value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(uint)];

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
        public static void Write(this Stream stream, ulong value, bool littleEndian = true)
        {
            Span<byte> buffer = stackalloc byte[sizeof(ulong)];

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