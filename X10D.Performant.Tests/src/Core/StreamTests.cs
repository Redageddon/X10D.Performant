using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using X10D.Performant.StreamExtensions;

namespace X10D.Performant.Tests.Core;

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

        foreach (Color color in colors)
        {
            stream.Write(new[] { color.B, color.G, color.R, color.A });
        }

        stream.ResetPosition();

        foreach (Color color in colors)
        {
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
        stream.ResetPosition();
        Assert.IsFalse(stream.Read<bool>() ? true : false); // nunit doesn't actually check bools, it checks values
        Assert.IsTrue(stream.Read<bool>() ? true : false);  // nunit doesn't actually check bools, it checks values
        Assert.IsTrue(stream.Read<bool>() ? true : false);  // nunit doesn't actually check bools, it checks values
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

        stream.ResetPosition();

        foreach (decimal d in decimals)
        {
            Assert.AreEqual(d, stream.Read<decimal>());
        }

        stream.ResetPosition();

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

        stream.ResetPosition();

        foreach (decimal d in decimals)
        {
            Assert.AreEqual(d, stream.Read<decimal>(false));
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

        stream.ResetPosition();

        foreach (double d in doubles)
        {
            Assert.AreEqual(d, stream.Read<double>());
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

        stream.ResetPosition();

        Assert.AreEqual(255, stream.Read<short>());
        Assert.AreEqual(-256, stream.Read<short>());
        Assert.AreEqual(-1, stream.Read<short>());
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

        stream.ResetPosition();

        Assert.AreEqual(255, stream.Read<int>());
        Assert.AreEqual(65535, stream.Read<int>());
        Assert.AreEqual(16777215, stream.Read<int>());
        Assert.AreEqual(-1, stream.Read<int>());
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

        stream.ResetPosition();

        Assert.AreEqual(255, stream.Read<long>());
        Assert.AreEqual(65535, stream.Read<long>());
        Assert.AreEqual(16777215, stream.Read<long>());
        Assert.AreEqual(4294967295, stream.Read<long>());
        Assert.AreEqual(1099511627775, stream.Read<long>());
        Assert.AreEqual(281474976710655, stream.Read<long>());
        Assert.AreEqual(72057594037927935, stream.Read<long>());
        Assert.AreEqual(-1, stream.Read<long>());
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

        stream.ResetPosition();

        foreach (float f in floats)
        {
            Assert.AreEqual(f, stream.Read<float>());
        }
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.ReadString"/>
    /// </summary>
    [Test]
    public void ReadString()
    {
        const string hello = "hello there";

        byte[] bytes = ReExposed.StringExtensions.GetBytes(hello);
        using MemoryStream stream = new(bytes);
        Assert.AreEqual(hello, stream.ReadString(hello.Length));

        byte[] reversedBytes = ReExposed.StringExtensions.GetBytes(hello, Encoding.BigEndianUnicode);
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

        stream.ResetPosition();

        Assert.AreEqual(255, stream.Read<ushort>());
        Assert.AreEqual(65535, stream.Read<ushort>());
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

        stream.ResetPosition();

        Assert.AreEqual(255, stream.Read<uint>());
        Assert.AreEqual(65535, stream.Read<uint>());
        Assert.AreEqual(16777215, stream.Read<uint>());
        Assert.AreEqual(4294967295, stream.Read<uint>());
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

        stream.ResetPosition();

        Assert.AreEqual(255, stream.Read<ulong>());
        Assert.AreEqual(65535, stream.Read<ulong>());
        Assert.AreEqual(16777215, stream.Read<ulong>());
        Assert.AreEqual(4294967295, stream.Read<ulong>());
        Assert.AreEqual(1099511627775, stream.Read<ulong>());
        Assert.AreEqual(281474976710655, stream.Read<ulong>());
        Assert.AreEqual(72057594037927935, stream.Read<ulong>());
        Assert.AreEqual(18446744073709551615, stream.Read<ulong>());
    }

    // Tests are assumed to pass at this point, so it is safe to test the write methods with the read methods for the sake of clarity.
    // If any of the previous methods fail, then these next methods have a possibility of giving false negatives or false positives.

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,Color,bool)"/>.
    /// </summary>
    [Test]
    public void WriteArgbColor()
    {
        MemoryStream stream = new();
        Color c = Color.FromArgb(123, 45, 67, 89);

        stream.Write(c);
        stream.Write(c, false);
        stream.ResetPosition();
;
        Assert.AreEqual(c, stream.ReadArgbColor());
        Assert.AreEqual(c, stream.ReadArgbColor(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,bool)"/>.
    /// </summary>
    [Test]
    public void WriteBoolean()
    {
        MemoryStream stream = new();
        const bool t = true;
        const bool f = true;

        stream.Write(t);
        stream.Write(f);
        stream.ResetPosition();

        Assert.AreEqual(t, stream.Read<bool>());
        Assert.AreEqual(f, stream.Read<bool>());
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,decimal,bool)"/>.
    /// </summary>
    [Test]
    public void WriteDecimal()
    {
        MemoryStream stream = new();

        stream.Write(decimal.MaxValue);
        stream.Write(decimal.MinValue);
        stream.Write(decimal.MaxValue, false);
        stream.Write(decimal.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(decimal.MaxValue, stream.Read<decimal>());
        Assert.AreEqual(decimal.MinValue, stream.Read<decimal>());
        Assert.AreEqual(decimal.MaxValue, stream.Read<decimal>(false));
        Assert.AreEqual(decimal.MinValue, stream.Read<decimal>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,double,bool)"/>.
    /// </summary>
    [Test]
    public void WriteDouble()
    {
        MemoryStream stream = new();

        stream.Write(double.MaxValue);
        stream.Write(double.MinValue);
        stream.Write(double.MaxValue, false);
        stream.Write(double.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(double.MaxValue, stream.Read<double>());
        Assert.AreEqual(double.MinValue, stream.Read<double>());
        Assert.AreEqual(double.MaxValue, stream.Read<double>(false));
        Assert.AreEqual(double.MinValue, stream.Read<double>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,int,bool)"/>.
    /// </summary>
    [Test]
    public void WriteInt()
    {
        MemoryStream stream = new();

        stream.Write(int.MaxValue);
        stream.Write(int.MinValue);
        stream.Write(int.MaxValue, false);
        stream.Write(int.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(int.MaxValue, stream.Read<int>());
        Assert.AreEqual(int.MinValue, stream.Read<int>());
        Assert.AreEqual(int.MaxValue, stream.Read<int>(false));
        Assert.AreEqual(int.MinValue, stream.Read<int>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,long,bool)"/>.
    /// </summary>
    [Test]
    public void WriteLong()
    {
        MemoryStream stream = new();

        stream.Write(long.MaxValue);
        stream.Write(long.MinValue);
        stream.Write(long.MaxValue, false);
        stream.Write(long.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(long.MaxValue, stream.Read<long>());
        Assert.AreEqual(long.MinValue, stream.Read<long>());
        Assert.AreEqual(long.MaxValue, stream.Read<long>(false));
        Assert.AreEqual(long.MinValue, stream.Read<long>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,short,bool)"/>.
    /// </summary>
    [Test]
    public void WriteShort()
    {
        MemoryStream stream = new();

        stream.Write(short.MaxValue);
        stream.Write(short.MinValue);
        stream.Write(short.MaxValue, false);
        stream.Write(short.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(short.MaxValue, stream.Read<short>());
        Assert.AreEqual(short.MinValue, stream.Read<short>());
        Assert.AreEqual(short.MaxValue, stream.Read<short>(false));
        Assert.AreEqual(short.MinValue, stream.Read<short>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,float,bool)"/>.
    /// </summary>
    [Test]
    public void WriteSingle()
    {
        MemoryStream stream = new();

        stream.Write(float.MaxValue);
        stream.Write(float.MinValue);
        stream.Write(float.MaxValue, false);
        stream.Write(float.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(float.MaxValue, stream.Read<float>());
        Assert.AreEqual(float.MinValue, stream.Read<float>());
        Assert.AreEqual(float.MaxValue, stream.Read<float>(false));
        Assert.AreEqual(float.MinValue, stream.Read<float>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,string,Encoding)"/>.
    /// </summary>
    [Test]
    public void WriteString()
    {
        MemoryStream stream = new();
        const string s = "Hello there";
        stream.Write(s);
        stream.Write(s, Encoding.BigEndianUnicode);

        stream.ResetPosition();

        Assert.AreEqual(s, stream.ReadString(s.Length));
        Assert.AreEqual(s, stream.ReadString(s.Length * 2, Encoding.BigEndianUnicode));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,uint,bool)"/>.
    /// </summary>
    [Test]
    public void WriteUInt()
    {
        MemoryStream stream = new();

        stream.Write(uint.MaxValue);
        stream.Write(uint.MinValue);
        stream.Write(uint.MaxValue, false);
        stream.Write(uint.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(uint.MaxValue, stream.Read<uint>());
        Assert.AreEqual(uint.MinValue, stream.Read<uint>());
        Assert.AreEqual(uint.MaxValue, stream.Read<uint>(false));
        Assert.AreEqual(uint.MinValue, stream.Read<uint>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,ulong,bool)"/>.
    /// </summary>
    [Test]
    public void WriteULong()
    {
        MemoryStream stream = new();

        stream.Write(ulong.MaxValue);
        stream.Write(ulong.MinValue);
        stream.Write(ulong.MaxValue, false);
        stream.Write(ulong.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(ulong.MaxValue, stream.Read<ulong>());
        Assert.AreEqual(ulong.MinValue, stream.Read<ulong>());
        Assert.AreEqual(ulong.MaxValue, stream.Read<ulong>(false));
        Assert.AreEqual(ulong.MinValue, stream.Read<ulong>(false));
    }

    /// <summary>
    ///     Tests for <see cref="StreamExtensions.Write(Stream,ushort,bool)"/>.
    /// </summary>
    [Test]
    public void WriteUShort()
    {
        MemoryStream stream = new();

        stream.Write(ushort.MaxValue);
        stream.Write(ushort.MinValue);
        stream.Write(ushort.MaxValue, false);
        stream.Write(ushort.MinValue, false);

        stream.ResetPosition();

        Assert.AreEqual(ushort.MaxValue, stream.Read<ushort>());
        Assert.AreEqual(ushort.MinValue, stream.Read<ushort>());
        Assert.AreEqual(ushort.MaxValue, stream.Read<ushort>(false));
        Assert.AreEqual(ushort.MinValue, stream.Read<ushort>(false));
    }
}