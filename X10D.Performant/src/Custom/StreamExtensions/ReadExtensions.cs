namespace X10D.Performant.StreamExtensions;

[SuppressMessage("ReSharper", "MustUseReturnValue")]
public static partial class StreamExtensions
{
    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadArgbColor"]'/>
    public static Color ReadArgbColor(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(int)];
        stream.Read(buffer);

        return Color.FromArgb(littleEndian
                                  ? BinaryPrimitives.ReadInt32LittleEndian(buffer)
                                  : BinaryPrimitives.ReadInt32BigEndian(buffer));
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadBoolean"]'/>
    public static bool ReadBoolean(this Stream stream) => stream.ReadByte() != 0;

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadDecimal"]'/>
    public static decimal ReadDecimal(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(decimal)];
        stream.Read(buffer);

        int lo;
        int mid;
        int hi;
        int flags;

        if (littleEndian)
        {
            lo = BinaryPrimitives.ReadInt32LittleEndian(buffer);
            mid = BinaryPrimitives.ReadInt32LittleEndian(buffer[4..]);
            hi = BinaryPrimitives.ReadInt32LittleEndian(buffer[8..]);
            flags = BinaryPrimitives.ReadInt32LittleEndian(buffer[12..]);
        }
        else
        {
            lo = BinaryPrimitives.ReadInt32BigEndian(buffer[12..]);
            mid = BinaryPrimitives.ReadInt32BigEndian(buffer[8..]);
            hi = BinaryPrimitives.ReadInt32BigEndian(buffer[4..]);
            flags = BinaryPrimitives.ReadInt32BigEndian(buffer);
        }

        Span<int> bits = stackalloc int[] { lo, mid, hi, flags };

        return new decimal(bits);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadDouble"]'/>
    public static double ReadDouble(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(double)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadDoubleLittleEndian(buffer)
            : BinaryPrimitives.ReadDoubleBigEndian(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadInt16"]'/>
    public static short ReadInt16(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(short)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadInt16LittleEndian(buffer)
            : BinaryPrimitives.ReadInt16BigEndian(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadInt32"]'/>
    public static int ReadInt32(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(int)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadInt32LittleEndian(buffer)
            : BinaryPrimitives.ReadInt32BigEndian(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadInt64"]'/>
    public static long ReadInt64(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(long)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadInt64LittleEndian(buffer)
            : BinaryPrimitives.ReadInt64BigEndian(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadSingle"]'/>
    public static float ReadSingle(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(float)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadSingleLittleEndian(buffer)
            : BinaryPrimitives.ReadSingleBigEndian(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadString"]'/>
    public static string ReadString(this Stream stream, int byteCount, Encoding? encoding = null)
    {
        Span<byte> buffer = stackalloc byte[byteCount];
        stream.Read(buffer);

        return (encoding ?? Encoding.Default).GetString(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadUInt16"]'/>
    public static ushort ReadUInt16(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(ushort)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadUInt16LittleEndian(buffer)
            : BinaryPrimitives.ReadUInt16BigEndian(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadUInt32"]'/>
    public static uint ReadUInt32(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(uint)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadUInt32LittleEndian(buffer)
            : BinaryPrimitives.ReadUInt32BigEndian(buffer);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadUInt64"]'/>
    public static ulong ReadUInt64(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(ulong)];
        stream.Read(buffer);

        return littleEndian
            ? BinaryPrimitives.ReadUInt64LittleEndian(buffer)
            : BinaryPrimitives.ReadUInt64BigEndian(buffer);
    }
}