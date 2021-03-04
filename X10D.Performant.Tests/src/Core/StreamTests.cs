using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="StreamExtensions"/>.
    /// </summary>
    public class StreamTests
    {
        /// <summary>
        ///     Test for <see cref="StreamExtensions.GetHash{T}"/>.
        /// </summary>
        [Test]
        public void GetHash()
        {
            using MemoryStream stream = new();

            CollectionAssert.AreEqual(new byte[]
                                      {
                                          207, 131, 225, 53, 126, 239, 184, 189, 241, 84, 40, 80, 214, 109, 128, 7, 214, 32, 228, 5, 11, 87, 21,
                                          220, 131, 244, 169, 33, 211, 108, 233, 206, 71, 208, 209, 60, 93, 133, 242, 176, 255, 131, 24, 210, 135,
                                          126, 236, 47, 99, 185, 49, 189, 71, 65, 122, 129, 165, 56, 50, 122, 249, 39, 218, 62,
                                      },
                                      stream.GetHash<SHA512>());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadArgbColor"/>
        /// </summary>
        [Test]
        public void ReadArgbColor()
        {
            using MemoryStream stream = new();

            Color[] colors =
            {
                Color.FromArgb(0b00000000, 0b00000000, 0b00000000, 0b00000000), Color.FromArgb(0b00000000, 0b00000000, 0b00000000, 0b11111111),
                Color.FromArgb(0b00000000, 0b00000000, 0b11111111, 0b11111111), Color.FromArgb(0b00000000, 0b11111111, 0b11111111, 0b11111111),
                Color.FromArgb(0b11111111, 0b11111111, 0b11111111, 0b11111111), Color.FromArgb(0b11111111, 0b00000000, 0b00000000, 0b00000000),
                Color.FromArgb(0b11111111, 0b11111111, 0b00000000, 0b00000000), Color.FromArgb(0b11111111, 0b11111111, 0b11111111, 0b00000000),
                Color.FromArgb(0b10000000, 0b10000000, 0b10000000, 0b10000000), Color.FromArgb(0b00000001, 0b00000001, 0b00000001, 0b00000001),
            };

            for (int i = 0; i < colors.Length; i++)
            {
                Color color = colors[i];
                stream.Write(new[] { color.B, color.G, color.R, color.A });
                stream.Position = i * 4;
                Assert.AreEqual(color, stream.ReadArgbColor());
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadBoolean"/>
        /// </summary>
        [Test]
        public void ReadBool()
        {
            using MemoryStream stream = new();
            stream.WriteByte(0);
            stream.WriteByte(1);
            stream.WriteByte(2);
            stream.Position = 0;
            Assert.IsFalse(stream.ReadBoolean());
            Assert.IsTrue(stream.ReadBoolean());
            Assert.IsTrue(stream.ReadBoolean());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadDecimal"/>
        /// </summary>
        [Test]
        public void ReadDecimal()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            decimal[] decimals = { decimal.MinValue, 0, decimal.MaxValue };

            foreach (decimal d in decimals)
            {
                writer.Write(d);
            }

            stream.Position = 0;

            foreach (decimal d in decimals)
            {
                Assert.AreEqual(d, stream.ReadDecimal());
            }

            stream.Position = 0;

            foreach (decimal d in decimals)
            {
                int[] bits = decimal.GetBits(d);
                Array.Reverse(bits);

                foreach (int bit in bits)
                {
                    byte[] bytes = BitConverter.GetBytes(bit);
                    Array.Reverse(bytes);
                    writer.Write(bytes);
                }
            }

            stream.Position = 0;

            foreach (decimal d in decimals)
            {
                Assert.AreEqual(d, stream.ReadDecimal(false));
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadDouble"/>
        /// </summary>
        [Test]
        public void ReadDouble()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            double[] doubles = { double.MinValue, 0, double.MaxValue };

            foreach (double d in doubles)
            {
                writer.Write(d);
            }

            stream.Position = 0;

            foreach (double d in doubles)
            {
                Assert.AreEqual(d, stream.ReadDouble());
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadInt16"/>
        /// </summary>
        [Test]
        public void ReadInt16()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            byte[][] littleEndian = { new byte[] { 0xFF, 0x00 }, new byte[] { 0x00, 0xFF }, new byte[] { 0xFF, 0xFF } };

            foreach (byte[] b in littleEndian)
            {
                writer.Write(b);
            }

            stream.Position = 0;

            Assert.AreEqual(255, stream.ReadInt16());
            Assert.AreEqual(-256, stream.ReadInt16());
            Assert.AreEqual(-1, stream.ReadInt16());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadInt32"/>
        /// </summary>
        [Test]
        public void ReadInt32()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            byte[][] littleEndian =
            {
                new byte[] { 0xFF, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0xFF },
            };

            foreach (byte[] b in littleEndian)
            {
                writer.Write(b);
            }

            stream.Position = 0;

            Assert.AreEqual(255, stream.ReadInt32());
            Assert.AreEqual(65535, stream.ReadInt32());
            Assert.AreEqual(16777215, stream.ReadInt32());
            Assert.AreEqual(-1, stream.ReadInt32());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadInt64"/>
        /// </summary>
        [Test]
        public void ReadInt64()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            byte[][] littleEndian =
            {
                new byte[] { 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF },
            };

            foreach (byte[] b in littleEndian)
            {
                writer.Write(b);
            }

            stream.Position = 0;

            Assert.AreEqual(255, stream.ReadInt64());
            Assert.AreEqual(65535, stream.ReadInt64());
            Assert.AreEqual(16777215, stream.ReadInt64());
            Assert.AreEqual(4294967295, stream.ReadInt64());
            Assert.AreEqual(1099511627775, stream.ReadInt64());
            Assert.AreEqual(281474976710655, stream.ReadInt64());
            Assert.AreEqual(72057594037927935, stream.ReadInt64());
            Assert.AreEqual(-1, stream.ReadInt64());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadRgbColor"/>
        /// </summary>
        [Test]
        public void ReadRgbColor()
        {
            using MemoryStream stream = new();

            Color[] colors =
            {
                Color.FromArgb(0b00000000, 0b00000000, 0b00000000), Color.FromArgb(0b11111111, 0b00000000, 0b00000000),
                Color.FromArgb(0b00000000, 0b11111111, 0b00000000), Color.FromArgb(0b11111111, 0b11111111, 0b00000000),
                Color.FromArgb(0b00000000, 0b00000000, 0b11111111), Color.FromArgb(0b11111111, 0b00000000, 0b11111111),
                Color.FromArgb(0b00000000, 0b11111111, 0b11111111), Color.FromArgb(0b11111111, 0b11111111, 0b11111111),
            };

            foreach (Color color in colors)
            {
                stream.Write(new[] { color.B, color.G, color.R });
            }

            stream.Position = 0;

            foreach (Color color in colors)
            {
                Assert.AreEqual(color, stream.ReadRgbColor());
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadSingle"/>
        /// </summary>
        [Test]
        public void ReadSingle()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            float[] floats = { float.MinValue, 0, float.MaxValue };

            foreach (float f in floats)
            {
                writer.Write(f);
            }

            stream.Position = 0;

            foreach (float f in floats)
            {
                Assert.AreEqual(f, stream.ReadSingle());
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadString"/>
        /// </summary>
        [Test]
        public void ReadString()
        {
            const string hello = "hello there";

            byte[] bytes = hello.GetBytes();
            using MemoryStream stream = new(bytes);
            Assert.AreEqual(hello, stream.ReadString(hello.Length));

            byte[] reversedBytes = hello.GetBytes(Encoding.BigEndianUnicode);
            using MemoryStream reversedStream = new(reversedBytes);
            Assert.AreEqual(hello, reversedStream.ReadString(reversedBytes.Length, Encoding.BigEndianUnicode));
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadUInt16"/>
        /// </summary>
        [Test]
        public void ReadUInt16()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            byte[][] littleEndian = { new byte[] { 0xFF, 0x00 }, new byte[] { 0xFF, 0xFF } };

            foreach (byte[] b in littleEndian)
            {
                writer.Write(b);
            }

            stream.Position = 0;

            Assert.AreEqual(255, stream.ReadUInt16());
            Assert.AreEqual(65535, stream.ReadUInt16());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadUInt32"/>
        /// </summary>
        [Test]
        public void ReadUInt32()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            byte[][] littleEndian =
            {
                new byte[] { 0xFF, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0xFF },
            };

            foreach (byte[] b in littleEndian)
            {
                writer.Write(b);
            }

            stream.Position = 0;

            Assert.AreEqual(255, stream.ReadUInt32());
            Assert.AreEqual(65535, stream.ReadUInt32());
            Assert.AreEqual(16777215, stream.ReadUInt32());
            Assert.AreEqual(4294967295, stream.ReadUInt32());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadUInt64"/>
        /// </summary>
        [Test]
        public void ReadUInt64()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            byte[][] littleEndian =
            {
                new byte[] { 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00 },
                new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00 }, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF },
            };

            foreach (byte[] b in littleEndian)
            {
                writer.Write(b);
            }

            stream.Position = 0;

            Assert.AreEqual(255, stream.ReadUInt64());
            Assert.AreEqual(65535, stream.ReadUInt64());
            Assert.AreEqual(16777215, stream.ReadUInt64());
            Assert.AreEqual(4294967295, stream.ReadUInt64());
            Assert.AreEqual(1099511627775, stream.ReadUInt64());
            Assert.AreEqual(281474976710655, stream.ReadUInt64());
            Assert.AreEqual(72057594037927935, stream.ReadUInt64());
            Assert.AreEqual(18446744073709551615, stream.ReadUInt64());
        }
    }
}