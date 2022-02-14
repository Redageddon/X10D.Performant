using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static partial class ByteExtensions
{
    /// <inheritdoc cref="Encoding.GetString(byte[])"/>
    public static string GetString(this byte[] bytes, Encoding? encoding = null) => (encoding ?? Encoding.Default).GetString(bytes);
}