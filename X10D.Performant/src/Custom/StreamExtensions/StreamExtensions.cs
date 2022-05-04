namespace X10D.Performant.StreamExtensions;

/// <summary>
///     Extension methods for <see cref="Stream"/>.
/// </summary>
public static partial class StreamExtensions
{
    //TODO: Document
    //TODO: Add tests
    public static IEnumerable<byte> AsEnumerable(this Stream stream)
    {
        while (true)
        {
            int read = stream.ReadByte();

            if (read == -1)
            {
                break;
            }

            yield return (byte)read;
        }
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="GetHash"]'/>
    public static byte[]? GetHash<T>(this Stream stream)
        where T : HashAlgorithm
    {
        MethodInfo? create = typeof(T).GetMethod("Create", Array.Empty<Type>());
        using T? crypt = (T?)create?.Invoke(null, null);

        return crypt?.ComputeHash(stream);
    }

    /// <include file='StreamExtensions.xml' path='members/member[@name="ResetPosition"]'/>
    public static void ResetPosition(this Stream stream) => stream.Position = 0;
}