﻿using System.Net;
using System.Security;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="SecureString"/>.
    /// </summary>
    public static class SecureStringExtensions
    {
        /// <summary>
        ///     Converts a <see cref="SecureString"/> to a <see cref="string"/>.
        /// </summary>
        /// <param name="secureString">The <see cref="SecureString"/> to convert.</param>
        /// <param name="extension">Whether or not to use this extension method.</param>
        /// <returns>A <see cref="string"/>.</returns>
        public static string? ToString(this SecureString secureString, bool extension) =>
            extension
                ? new NetworkCredential(string.Empty, secureString).Password
                : secureString.ToString();
    }
}