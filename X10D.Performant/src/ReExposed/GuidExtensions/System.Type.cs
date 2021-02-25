using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    /// <summary>
    ///     Extension methods for <see cref="Guid"/>.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class GuidExtensions
    {
        // ReSharper disable once InconsistentNaming
        /// <inheritdoc cref="Type.GetTypeFromCLSID(Guid,string,bool)" />
        public static Type? GetTypeFromCLSID(this Guid value, string? server = null, bool throwOnError = false) =>
            Type.GetTypeFromCLSID(value, server, throwOnError);
    }
}