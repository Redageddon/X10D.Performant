namespace X10D.Performant.EndpointExtensions;

/// <summary>
///     Extension methods for <see cref="EndPoint"/> and derived types.
/// </summary>
public static class EndPointExtensions
{
    /// <include file='EndPointExtensions.xml' path='members/member[@name="GetHostName"]'/>
    public static string GetHostName(this EndPoint endPoint) =>
        endPoint switch
        {
            IPEndPoint ip   => ip.Address.ToString(),
            DnsEndPoint dns => dns.Host,
            _               => string.Empty,
        };

    /// <include file='EndPointExtensions.xml' path='members/member[@name="GetPort"]'/>
    public static int GetPort(this EndPoint endPoint) =>
        endPoint switch
        {
            IPEndPoint ip   => ip.Port,
            DnsEndPoint dns => dns.Port,
            _               => 0,
        };
}