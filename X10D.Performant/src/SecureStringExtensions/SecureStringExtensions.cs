using System.Net;
using System.Security;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="SecureString" />.
    /// </summary>
    public static class SecureStringExtensions
    {
        /// <summary>
        ///     Converts a <see cref="SecureString" /> to a <see cref="string" />.
        /// </summary>
        /// <param name="secureString">The <see cref="SecureString" /> to convert.</param>
        /// <param name="userName">The <see cref="string"/> to pass to the <see cref="NetworkCredential"/>.</param>
        /// <returns>A <see cref="string" />.</returns>
        public static string ToNormalString(this SecureString secureString, string? userName = null) =>
            new NetworkCredential(userName ?? string.Empty, secureString).Password;
    }
}