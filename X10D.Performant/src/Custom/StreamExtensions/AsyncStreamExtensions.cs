namespace X10D.Performant.StreamExtensions;

public static partial class StreamExtensions
{
    //TODO: Document
    //TODO: Add tests
    public static async IAsyncEnumerable<byte> AsyncAsEnumerable(this Stream stream)
    {
        while (true)
        {
            byte[] oneByteArray = new byte[1];
            int read = await stream.ReadAsync(oneByteArray, 0, 1);

            if (read == 0)
            {
                break;
            }

            yield return oneByteArray[0];
        }
    }
}