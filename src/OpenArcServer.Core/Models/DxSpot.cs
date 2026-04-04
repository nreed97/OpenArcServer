namespace OpenArcServer.Core.Models;

public sealed class DxSpot
{
    public long Id { get; set; }
    public string Call { get; set; } = string.Empty;
    public string Spotter { get; set; } = string.Empty;
    public string SpotterNode { get; set; } = string.Empty;
    public float Freq { get; set; }
    public float Band { get; set; }
    public string Mode { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public string Cty { get; set; } = string.Empty;
    public string SpotterCty { get; set; } = string.Empty;
    public string Cont { get; set; } = string.Empty;
    public string SpotterCont { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string SpotterState { get; set; } = string.Empty;
    public byte CqZone { get; set; }
    public byte ItuZone { get; set; }
    public byte SpotterCqZone { get; set; }
    public byte SpotterItuZone { get; set; }
    public string Grid { get; set; } = string.Empty;
    public string DupeKey { get; set; } = string.Empty;
    public bool IsDupe { get; set; }
    public bool Skimmer { get; set; }
    public DateTime Timestamp { get; set; }
    public DateTime ReceivedAt { get; set; }
}
