using X10D.Performant.BooleanExtensions;

namespace X10D.Performant.StreamExtensions;

public static partial class StreamExtensions
{
    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteBoolean"]'/>
    public static void Write(this Stream stream, bool value) => stream.WriteByte(value.ToByte());

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteDecimal"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteDouble"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteInt16"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteInt32"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteInt64"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteSingle"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteString"]'/>
    public static void Write(this Stream stream, string value, Encoding? encoding = null) =>
        stream.Write((encoding ?? Encoding.Default).GetBytes(value));

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteUInt16"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteUInt32"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteUInt64"]'/>
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

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteColor"]'/>
    public static void Write(this Stream stream, Color value, bool littleEndian = true)
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
}