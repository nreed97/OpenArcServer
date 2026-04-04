namespace OpenArcServer.Core.Models;

/// <summary>Represents a connected PCxx cluster node peer.</summary>
public sealed class NodeRecord
{
    public string Callsign { get; set; } = string.Empty;
    public string Software { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public int Port { get; set; }
    public string RemoteEndpoint { get; set; } = string.Empty;
    public DateTime ConnectedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastSeenAt { get; set; } = DateTime.UtcNow;
    /// <summary>True once the PC18→PC38→PC19→PC20→PC22 handshake is complete.</summary>
    public bool HandshakeComplete { get; set; }
}
