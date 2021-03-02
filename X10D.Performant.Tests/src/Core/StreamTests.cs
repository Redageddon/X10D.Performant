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
                Color.FromArgb(0b00000000, 0b00000000, 0b00000000, 0b00000000),
                Color.FromArgb(0b00000000, 0b00000000, 0b00000000, 0b11111111),
                Color.FromArgb(0b00000000, 0b00000000, 0b11111111, 0b11111111),
                Color.FromArgb(0b00000000, 0b11111111, 0b11111111, 0b11111111),
                Color.FromArgb(0b11111111, 0b11111111, 0b11111111, 0b11111111),
                Color.FromArgb(0b11111111, 0b00000000, 0b00000000, 0b00000000),
                Color.FromArgb(0b11111111, 0b11111111, 0b00000000, 0b00000000),
                Color.FromArgb(0b11111111, 0b11111111, 0b11111111, 0b00000000),
                Color.FromArgb(0b10000000, 0b10000000, 0b10000000, 0b10000000),
                Color.FromArgb(0b00000001, 0b00000001, 0b00000001, 0b00000001),
            };

            for (int i = 0; i < colors.Length; i++)
            {
                Color color = colors[i];
                stream.Write(new[] { color.A, color.R, color.G, color.B });
                stream.Position = i * 4;
                Assert.AreEqual(color, stream.ReadArgbColor());
            }

            for (int i = 0; i < colors.Length; i++)
            {
                Color color = colors[i];
                stream.Write(new[] { color.B, color.G, color.R, color.A });
                stream.Position = i * 4;
                Assert.AreEqual(color, stream.ReadArgbColor(false));
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
        ///     Tests for <see cref="StreamExtensions.ReadChar"/>
        /// </summary>
        [Test]
        public void ReadChar()
        {
            using MemoryStream stream = new();
            stream.WriteByte((byte)'a');
            stream.WriteByte((byte)'b');
            stream.WriteByte((byte)'c');
            stream.Position = 0;
            Assert.AreEqual('a', stream.ReadChar());
            Assert.AreEqual('b', stream.ReadChar());
            Assert.AreEqual('c', stream.ReadChar());
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadDecimal"/>
        /// </summary>
        [Test]
        public void ReadDecimal()
        {
            // Todo: implement
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadDouble"/>
        /// </summary>
        [Test]
        public void ReadDouble()
        {
            // Todo: implement
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadInt16"/>
        /// </summary>
        [Test]
        public void ReadInt16()
        {
            using MemoryStream stream = new();
            BinaryWriter writer = new(stream);

            unchecked
            {
                short[] shorts =
                {
                    0b00000000_00000000,
                    (short)0b11111111_00000000,
                    (short)0b11111111_11111111,
                    0b00000000_11111111,
                };

                short[] reversedShorts =
                {
                    0b00000000_00000000,
                    0b00000000_11111111,
                    (short)0b11111111_11111111,
                    (short)0b11111111_00000000,
                };

                for (int i = 0; i < shorts.Length; i++)
                {
                    int value = shorts[i];
                    writer.Write(value);
                    stream.Position = i * 2;
                    Assert.AreEqual(shorts[i], stream.ReadInt16());
                }

                for (int i = 0; i < shorts.Length; i++)
                {
                    int value = shorts[i];
                    writer.Write(value);
                    stream.Position = i * 2;
                    Assert.AreEqual(reversedShorts[i], stream.ReadInt16(false));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadInt32"/>
        /// </summary>
        [Test]
        public void ReadInt32()
        {
            using MemoryStream stream = new();
            BinaryWriter writer = new(stream);

            unchecked
            {
                int[] ints =
                {
                    0b00000000_00000000_00000000_00000000,
                    (int)0b11111111_00000000_00000000_00000000,
                    (int)0b11111111_11111111_00000000_00000000,
                    (int)0b11111111_11111111_11111111_00000000,
                    (int)0b11111111_11111111_11111111_11111111,
                    0b00000000_11111111_11111111_11111111,
                    0b00000000_00000000_11111111_11111111,
                    0b00000000_00000000_00000000_11111111,
                };

                int[] reversedInts =
                {
                    0b00000000_00000000_00000000_00000000,
                    0b00000000_00000000_00000000_11111111,
                    0b00000000_00000000_11111111_11111111,
                    0b00000000_11111111_11111111_11111111,
                    (int)0b11111111_11111111_11111111_11111111,
                    (int)0b11111111_11111111_11111111_00000000,
                    (int)0b11111111_11111111_00000000_00000000,
                    (int)0b11111111_00000000_00000000_00000000,
                };

                for (int i = 0; i < ints.Length; i++)
                {
                    int value = ints[i];
                    writer.Write(value);
                    stream.Position = i * 4;
                    Assert.AreEqual(ints[i], stream.ReadInt32());
                }

                for (int i = 0; i < ints.Length; i++)
                {
                    int value = ints[i];
                    writer.Write(value);
                    stream.Position = i * 4;
                    Assert.AreEqual(reversedInts[i], stream.ReadInt32(false));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadInt64"/>
        /// </summary>
        [Test]
        public void ReadInt64()
        {
            using MemoryStream stream = new();
            BinaryWriter writer = new(stream);

            unchecked
            {
                long[] longs =
                {
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                    (long)0b11111111_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                    (long)0b11111111_11111111_00000000_00000000_00000000_00000000_00000000_00000000,
                    (long)0b11111111_11111111_11111111_00000000_00000000_00000000_00000000_00000000,
                    (long)0b11111111_11111111_11111111_11111111_00000000_00000000_00000000_00000000,
                    (long)0b11111111_11111111_11111111_11111111_11111111_00000000_00000000_00000000,
                    (long)0b11111111_11111111_11111111_11111111_11111111_11111111_00000000_00000000,
                    (long)0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_00000000,
                    (long)0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_11111111,
                };

                long[] reversedLongs =
                {
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    (long)0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    (long)0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_00000000,
                    (long)0b11111111_11111111_11111111_11111111_11111111_11111111_00000000_00000000,
                    (long)0b11111111_11111111_11111111_11111111_11111111_00000000_00000000_00000000,
                    (long)0b11111111_11111111_11111111_11111111_00000000_00000000_00000000_00000000,
                    (long)0b11111111_11111111_11111111_00000000_00000000_00000000_00000000_00000000,
                    (long)0b11111111_11111111_00000000_00000000_00000000_00000000_00000000_00000000,
                    (long)0b11111111_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                };

                for (int i = 0; i < longs.Length; i++)
                {
                    long value = longs[i];
                    writer.Write(value);
                    stream.Position = i * 8;
                    Assert.AreEqual(longs[i], stream.ReadInt64());
                }

                for (int i = 0; i < longs.Length; i++)
                {
                    long value = longs[i];
                    writer.Write(value);
                    stream.Position = i * 8;
                    Assert.AreEqual(reversedLongs[i], stream.ReadInt64(false));
                }
            }
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
                Color.FromArgb(0b00000000, 0b00000000, 0b00000000),
                Color.FromArgb(0b11111111, 0b00000000, 0b00000000),
                Color.FromArgb(0b00000000, 0b11111111, 0b00000000),
                Color.FromArgb(0b11111111, 0b11111111, 0b00000000),
                Color.FromArgb(0b00000000, 0b00000000, 0b11111111),
                Color.FromArgb(0b11111111, 0b00000000, 0b11111111),
                Color.FromArgb(0b00000000, 0b11111111, 0b11111111),
                Color.FromArgb(0b11111111, 0b11111111, 0b11111111),
            };

            for (int i = 0; i < colors.Length; i++)
            {
                Color color = colors[i];
                stream.Write(new[] { color.R, color.G, color.B });
                stream.Position = i * 3;
                Assert.AreEqual(color, stream.ReadRgbColor());
            }

            for (int i = 0; i < colors.Length; i++)
            {
                Color color = colors[i];
                stream.Write(new[] { color.B, color.G, color.R });
                stream.Position = i * 3;
                Assert.AreEqual(color, stream.ReadRgbColor(false));
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadSingle"/>
        /// </summary>
        [Test]
        public void ReadSingle()
        {
            // Todo: implement
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
            BinaryWriter writer = new(stream);

            unchecked
            {
                ushort[] shorts =
                {
                    0b00000000_00000000,
                    0b11111111_00000000,
                    0b11111111_11111111,
                    0b00000000_11111111,
                };

                ushort[] reversedShorts =
                {
                    0b00000000_00000000,
                    0b00000000_11111111,
                    0b11111111_11111111,
                    0b11111111_00000000,
                };

                for (int i = 0; i < shorts.Length; i++)
                {
                    int value = shorts[i];
                    writer.Write(value);
                    stream.Position = i * 2;
                    Assert.AreEqual(shorts[i], stream.ReadUInt16());
                }

                for (int i = 0; i < shorts.Length; i++)
                {
                    int value = shorts[i];
                    writer.Write(value);
                    stream.Position = i * 2;
                    Assert.AreEqual(reversedShorts[i], stream.ReadUInt16(false));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadUInt32"/>
        /// </summary>
        [Test]
        public void ReadUInt32()
        {
            using MemoryStream stream = new();
            BinaryWriter writer = new(stream);

            unchecked
            {
                uint[] ints =
                {
                    0b00000000_00000000_00000000_00000000,
                    0b11111111_00000000_00000000_00000000,
                    0b11111111_11111111_00000000_00000000,
                    0b11111111_11111111_11111111_00000000,
                    0b11111111_11111111_11111111_11111111,
                    0b00000000_11111111_11111111_11111111,
                    0b00000000_00000000_11111111_11111111,
                    0b00000000_00000000_00000000_11111111,
                };

                uint[] reversedInts =
                {
                    0b00000000_00000000_00000000_00000000,
                    0b00000000_00000000_00000000_11111111,
                    0b00000000_00000000_11111111_11111111,
                    0b00000000_11111111_11111111_11111111,
                    0b11111111_11111111_11111111_11111111,
                    0b11111111_11111111_11111111_00000000,
                    0b11111111_11111111_00000000_00000000,
                    0b11111111_00000000_00000000_00000000,
                };

                for (int i = 0; i < ints.Length; i++)
                {
                    uint value = ints[i];
                    writer.Write(value);
                    stream.Position = i * 4;
                    Assert.AreEqual(ints[i], stream.ReadUInt32());
                }

                for (int i = 0; i < ints.Length; i++)
                {
                    uint value = ints[i];
                    writer.Write(value);
                    stream.Position = i * 4;
                    Assert.AreEqual(reversedInts[i], stream.ReadUInt32(false));
                }
            }
        }

        /// <summary>
        ///     Tests for <see cref="StreamExtensions.ReadUInt64"/>
        /// </summary>
        [Test]
        public void ReadUInt64()
        {
            using MemoryStream stream = new();
            BinaryWriter writer = new(stream);

            unchecked
            {
                ulong[] longs =
                {
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                    0b11111111_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                    0b11111111_11111111_00000000_00000000_00000000_00000000_00000000_00000000,
                    0b11111111_11111111_11111111_00000000_00000000_00000000_00000000_00000000,
                    0b11111111_11111111_11111111_11111111_00000000_00000000_00000000_00000000,
                    0b11111111_11111111_11111111_11111111_11111111_00000000_00000000_00000000,
                    0b11111111_11111111_11111111_11111111_11111111_11111111_00000000_00000000,
                    0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_00000000,
                    0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_11111111,
                };

                ulong[] reversedLongs =
                {
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_00000000_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_00000000_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_00000000_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_00000000_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_00000000_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b00000000_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111,
                    0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_00000000,
                    0b11111111_11111111_11111111_11111111_11111111_11111111_00000000_00000000,
                    0b11111111_11111111_11111111_11111111_11111111_00000000_00000000_00000000,
                    0b11111111_11111111_11111111_11111111_00000000_00000000_00000000_00000000,
                    0b11111111_11111111_11111111_00000000_00000000_00000000_00000000_00000000,
                    0b11111111_11111111_00000000_00000000_00000000_00000000_00000000_00000000,
                    0b11111111_00000000_00000000_00000000_00000000_00000000_00000000_00000000,
                };

                for (int i = 0; i < longs.Length; i++)
                {
                    ulong value = longs[i];
                    writer.Write(value);
                    stream.Position = i * 8;
                    Assert.AreEqual(longs[i], stream.ReadUInt64());
                }

                for (int i = 0; i < longs.Length; i++)
                {
                    ulong value = longs[i];
                    writer.Write(value);
                    stream.Position = i * 8;
                    Assert.AreEqual(reversedLongs[i], stream.ReadUInt64(false));
                }
            }
        }
    }
}