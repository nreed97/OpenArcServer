using OpenArcServer.Core.Models;

namespace OpenArcServer.Engine.Spots;

public static class DxSpotFormatter
{
    /// <summary>
    /// Format a DX spot in the standard AR-Cluster fixed-width telnet format:
    /// DX de AB5K-#:      14025.0  W1AW         Good signal                    1530Z
    /// Columns (0-based):
    ///   "DX de "     = 0..5  (6 chars)
    ///   spotter      = 6..17 (padded to 10, then ":")
    ///   spaces       = 17..19
    ///   freq         = 19..28 (9.1f, right-aligned)
    ///   spaces       = 28..30
    ///   call         = 30..42 (12 chars, left-aligned)
    ///   spaces       = 42..44
    ///   comment      = 44..74 (30 chars, left-aligned)
    ///   space        = 74
    ///   time         = 75..79 (HHmmZ)
    /// </summary>
    public static string Format(DxSpot spot)
    {
        var spotter = spot.Spotter.Length <= 9 ? spot.Spotter : spot.Spotter[..9];
        var call = spot.Call.Length <= 12 ? spot.Call : spot.Call[..12];
        var comment = spot.Comment.Length <= 30 ? spot.Comment : spot.Comment[..30];
        var time = spot.Timestamp.ToUniversalTime().ToString("HHmm") + "Z";

        // Format: "DX de AB5K      : 14025.0  W1AW          Good signal                    1530Z"
        // Spotter field is left-aligned in 9 chars, followed by ":"
        return string.Format("DX de {0,-9}: {1,9:F1}  {2,-12}  {3,-30} {4}",
            spotter, spot.Freq, call, comment, time);
    }

    /// <summary>Format multiple spots, newest-first, one per line.</summary>
    public static IEnumerable<string> FormatList(IEnumerable<DxSpot> spots)
    {
        foreach (var spot in spots)
            yield return Format(spot);
    }

    /// <summary>
    /// Build an ARx2 AB5K_Client_Dx XML message for broadcast to native ARx2 clients on port 3608.
    /// Field names and structure confirmed from Wireshark capture of K1TTT AR-Cluster Server.
    /// Returns just the XML string — ArxFrame.Wrap() handles framing/compression.
    /// </summary>
    public static string FormatArxClientDx(DxSpot spot, string spotterNode = "")
    {
        var ic = System.Globalization.CultureInfo.InvariantCulture;
        // Freq: no trailing zeros — "14025" not "14025.0", "14214.9" for fractional
        var freq = spot.Freq % 1 == 0
            ? ((int)spot.Freq).ToString(ic)
            : spot.Freq.ToString("G", ic);
        var dts = spot.Timestamp.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss");
        var band = spot.Band % 1 == 0
            ? ((int)spot.Band).ToString(ic)
            : spot.Band.ToString("G", ic);

        return "<AB5K_Client_Dx>" +
               $"<Call>{Escape(spot.Call)}</Call>" +
               $"<Freq>{freq}</Freq>" +
               $"<Comment>{Escape(spot.Comment)}</Comment>" +
               $"<Spotter>{Escape(spot.Spotter)}</Spotter>" +
               $"<SpotterNode>{Escape(spotterNode)}</SpotterNode>" +
               $"<Dts>{dts}</Dts>" +
               "<Name></Name>" +
               "<Grid></Grid>" +
               $"<Cty>{Escape(spot.Cty)}</Cty>" +
               $"<Cont>{Escape(spot.Cont)}</Cont>" +
               "<County></County>" +
               "<State></State>" +
               "<ArrlSection></ArrlSection>" +
               $"<CqZone>{spot.CqZone}</CqZone>" +
               $"<ItuZone>{spot.ItuZone}</ItuZone>" +
               "<Lotw>false</Lotw>" +
               "<Cq>false</Cq>" +
               "<Bob>false</Bob>" +
               "<Skimmer>false</Skimmer>" +
               "<SkimDb>0</SkimDb>" +
               "<SkimWpm>0</SkimWpm>" +
               "<SkimDupe>false</SkimDupe>" +
               "<SkimCq>false</SkimCq>" +
               "<Unique>1</Unique>" +
               "<Master>false</Master>" +
               "<InCb>false</InCb>" +
               "<Top100>false</Top100>" +
               "<Ham>true</Ham>" +
               "<Foc>false</Foc>" +
               $"<Band>{band}</Band>" +
               $"<Mode>{Escape(spot.Mode)}</Mode>" +
               $"<SpotterCont>{Escape(spot.SpotterCont)}</SpotterCont>" +
               $"<SpotterCty>{Escape(spot.SpotterCty)}</SpotterCty>" +
               "<SpotterState></SpotterState>" +
               $"<SpotterCqZone>{spot.SpotterCqZone}</SpotterCqZone>" +
               $"<SpotterItuZone>{spot.SpotterItuZone}</SpotterItuZone>" +
               "</AB5K_Client_Dx>";
    }

    private static string Escape(string v) => v
        .Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");

    /// <summary>
    /// Build a PCxx PC11 DX spot message string.
    /// Format: PC11^freq^dx_call^comment^date^time^spotter^node^
    /// </summary>
    public static string FormatPc11(DxSpot spot, string nodeCallsign)
    {
        var date = spot.Timestamp.ToUniversalTime().ToString("dd-MMM-yyyy");
        var time = spot.Timestamp.ToUniversalTime().ToString("HHmm") + "Z";
        var freq = spot.Freq.ToString("F1", System.Globalization.CultureInfo.InvariantCulture);
        return $"PC11^{freq}^{spot.Call}^{spot.Comment}^{date}^{time}^{spot.Spotter}^{nodeCallsign}^\r\n";
    }
}
