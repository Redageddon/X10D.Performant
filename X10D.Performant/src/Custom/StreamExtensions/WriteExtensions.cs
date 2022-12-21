using X10D.Performant.GenericExtensions;

namespace X10D.Performant.StreamExtensions;

public static partial class StreamExtensions
{
    // Todo: document
    // Todo: test
    public static unsafe void Write<T>(this Stream stream, T value, bool currentEndian = true)
        where T : unmanaged
    {
        Span<byte> bytes = stackalloc byte[sizeof(T)];
        value.GetBytes(bytes);

        if (!currentEndian)
        {
            bytes.Reverse();
        }

        stream.Write(bytes);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="WriteString"]'/>
    public static void Write(this Stream stream, string value, Encoding? encoding = null) =>
        stream.Write((encoding ?? Encoding.Default).GetBytes(value));

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
}