using System.Net;

namespace X10D.Performant.EndpointExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="EndPoint"/> and derived types.
    /// </summary>
    public static class EndPointExtensions
    {
        /// <summary>
        ///     Gets the <see cref="EndPoint"/> hostname.
        /// </summary>
        /// <param name="endPoint">The endpoint whose hostname to get.</param>
        /// <returns>A <see cref="string"/> representing the hostname, which may be an IP or a DNS, or empty <see cref="string"/>on failure.</returns>
        public static string GetHostName(this EndPoint endPoint) =>
            endPoint switch
            {
                IPEndPoint ip   => ip.Address.ToString(),
                DnsEndPoint dns => dns.Host,
                _               => string.Empty,
            };

        /// <summary>
        ///     Gets the <see cref="EndPoint"/> port.
        /// </summary>
        /// <param name="endPoint">The endpoint whose port to get.</param>
        /// <returns>An <see cref="int"/> representing the port, or 0 on failure.</returns>
        public static int GetPort(this EndPoint endPoint) =>
            endPoint switch
            {
                IPEndPoint ip   => ip.Port,
                DnsEndPoint dns => dns.Port,
                _               => 0,
            };
    }
}