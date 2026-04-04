namespace OpenArcServer.Core.Models;

public sealed class WwvSpot
{
    public long Id { get; set; }
    /// <summary>Solar Flux Index</summary>
    public string Sfi { get; set; } = string.Empty;
    /// <summary>A-index (geomagnetic)</summary>
    public string A { get; set; } = string.Empty;
    /// <summary>K-index (geomagnetic)</summary>
    public string K { get; set; } = string.Empty;
    /// <summary>Optional propagation forecast text</summary>
    public string Forecast { get; set; } = string.Empty;
    public string Spotter { get; set; } = string.Empty;
    public string SpotterNode { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
