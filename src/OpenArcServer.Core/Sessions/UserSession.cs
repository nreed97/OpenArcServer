namespace OpenArcServer.Core.Sessions;

public sealed class UserSession
{
    public string SessionId { get; init; } = Guid.NewGuid().ToString();
    public string Callsign { get; set; } = string.Empty;
    public ConnectStateType ConnectType { get; set; } = ConnectStateType.TelnetUser;
    public ConnectionState ConnectionState { get; set; } = ConnectionState.Idle;
    public string RemoteEndpoint { get; set; } = string.Empty;
    public DateTime ConnectedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastActivityAt { get; set; } = DateTime.UtcNow;

    // Station info (settable by user)
    public string Name { get; set; } = string.Empty;
    public string Qth { get; set; } = string.Empty;
    public string Grid { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public float Latitude { get; set; }
    public float Longitude { get; set; }

    // User preferences
    public int DxCount { get; set; } = 10;

    // Send callback - set by the telnet connection handler
    public Func<string, CancellationToken, Task>? SendAsync { get; set; }

    // Disconnect callback
    public Func<Task>? DisconnectAsync { get; set; }
}
