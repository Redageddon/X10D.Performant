using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Encoding.GetBytes(string)"/>
        public static byte[] GetBytes(this string value, Encoding? encoding = null) => (encoding ?? Encoding.Default).GetBytes(value);
    }
}