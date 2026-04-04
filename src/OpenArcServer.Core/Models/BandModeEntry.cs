namespace OpenArcServer.Core.Models;

public sealed class BandModeEntry
{
    public float Band { get; set; }
    public string Mode { get; set; } = string.Empty;
    public float FreqLow { get; set; }
    public float FreqHigh { get; set; }
}
