namespace OpenArcServer.Core.Models;

public sealed class UserProfile
{
    public string Callsign { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Qth { get; set; } = string.Empty;
    public string Grid { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public int DxCount { get; set; } = 10;
    public DateTime FirstSeen { get; set; }
    public DateTime LastSeen { get; set; }
    public int TotalConnects { get; set; }
}
