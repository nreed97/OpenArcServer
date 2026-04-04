namespace OpenArcServer.Core.Models;

public sealed class CtyRecord
{
    public string CountryName { get; set; } = string.Empty;
    public string CtyCode { get; set; } = string.Empty;
    public byte CqZone { get; set; }
    public byte ItuZone { get; set; }
    public string Continent { get; set; } = string.Empty;
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string TimeOffset { get; set; } = string.Empty;
    public List<string> Prefixes { get; set; } = new();
}
