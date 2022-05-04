namespace X10D.Performant.StreamExtensions;

[SuppressMessage("ReSharper", "MustUseReturnValue")]
public static partial class StreamExtensions
{
    //TODO: document
    public static unsafe T Read<T>(this Stream stream, bool currentEndian = true)
        where T : unmanaged
    {
        Span<byte> buffer = stackalloc byte[sizeof(T)];
        stream.Read(buffer);

        if (!currentEndian)
        {
            buffer.Reverse();
        }

        // decimal cant just be normal, it has to be special
        if (typeof(T) == typeof(decimal))
        {
            return (T)(object)new decimal(new Span<int>(Unsafe.AsPointer(ref buffer.GetPinnableReference()), 4));
        }

        return Unsafe.ReadUnaligned<T>(ref buffer.GetPinnableReference());
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadArgbColor"]'/>
    public static Color ReadArgbColor(this Stream stream, bool littleEndian = true)
    {
        Span<byte> buffer = stackalloc byte[sizeof(int)];
        stream.Read(buffer);

        return Color.FromArgb(littleEndian
                                  ? BinaryPrimitives.ReadInt32LittleEndian(buffer)
                                  : BinaryPrimitives.ReadInt32BigEndian(buffer));
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ReadString"]'/>
    public static string ReadString(this Stream stream, int byteCount, Encoding? encoding = null)
    {
        Span<byte> buffer = stackalloc byte[byteCount];
        stream.Read(buffer);

        return (encoding ?? Encoding.Default).GetString(buffer);
    }
}