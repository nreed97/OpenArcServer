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
    /// <summary>JSON serialisation of the user's persistent SpotFilter. Null or empty = no filter.</summary>
    public string SpotFilterJson { get; set; } = string.Empty;
    /// <summary>When true, a bearing/distance annotation is appended after each live DX spot.</summary>
    public bool ShowDistance { get; set; }
}
