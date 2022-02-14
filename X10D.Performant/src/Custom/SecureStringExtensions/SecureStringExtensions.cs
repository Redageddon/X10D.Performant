using System.Net;
using System.Security;

namespace X10D.Performant.SecureStringExtensions;

/// <summary>
///     Extension methods for <see cref="SecureString"/>.
/// </summary>
public static class SecureStringExtensions
{
    /// <include file='SecureStringExtensions.xml' path='members/member[@name="ToNormalString"]'/>
    public static string ToNormalString(this SecureString secureString, string? userName = null) =>
        new NetworkCredential(userName ?? string.Empty, secureString).Password;
}