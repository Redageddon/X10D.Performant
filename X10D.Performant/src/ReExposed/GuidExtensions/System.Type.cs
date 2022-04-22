namespace X10D.Performant.ReExposed;

/// <summary>
///     Extension methods for <see cref="Guid"/>.
/// </summary>
[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class GuidExtensions
{
    /// <inheritdoc cref="Type.GetTypeFromCLSID(Guid,string,bool)"/>
    public static Type? GetTypeFromCLSID(this Guid value, string? server = null, bool throwOnError = false) =>
        Type.GetTypeFromCLSID(value, server, throwOnError);
}