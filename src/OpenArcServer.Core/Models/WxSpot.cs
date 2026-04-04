namespace OpenArcServer.Core.Models;

public sealed class WxSpot
{
    public long Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public string Spotter { get; set; } = string.Empty;
    public string SpotterNode { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
