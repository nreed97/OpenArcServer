using System.Text;

namespace OpenArcServer.Protocols.Pcxx;

/// <summary>
/// PCxx protocol message utilities.
/// All PCxx messages are caret-delimited (^) text lines.
/// Format: PC##^field1^field2^...^
/// </summary>
public static class PcxxMessage
{
    public const char Delimiter = '^';
    public const string LineEnding = "\r\n";

    /// <summary>Split a raw PCxx message into fields (strips trailing ^ and CRLF).</summary>
    public static string[] Split(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            return Array.Empty<string>();

        var trimmed = message.TrimEnd('\r', '\n').TrimEnd(Delimiter);
        return trimmed.Split(Delimiter);
    }

    /// <summary>Extract the PC message number from the first field (e.g. "PC11" → 11).</summary>
    public static int GetMessageNumber(string[] fields)
    {
        if (fields.Length == 0) return -1;
        var first = fields[0].Trim();
        if (first.StartsWith("PC", StringComparison.OrdinalIgnoreCase) &&
            int.TryParse(first[2..], out var num))
            return num;
        return -1;
    }

    /// <summary>Build a PCxx message string from fields. Appends trailing ^ and CRLF.</summary>
    public static string Build(params string[] fields)
    {
        var sb = new StringBuilder();
        foreach (var f in fields)
        {
            sb.Append(f);
            sb.Append(Delimiter);
        }
        sb.Append(LineEnding);
        return sb.ToString();
    }

    // ──────────────────────────────────────────────────────────
    // Message builders
    // ──────────────────────────────────────────────────────────

    /// <summary>PC18 — sent by server immediately after a PCxx connection is accepted.</summary>
    public static string Pc18(string nodeCallsign)
        => Build("PC18", nodeCallsign);

    /// <summary>PC38 — response to PC18 (init start). Sent by the connecting node.</summary>
    public static string Pc38(string softwareName, string nodeCallsign, string version)
        => Build("PC38", softwareName, nodeCallsign, version);

    /// <summary>
    /// PC19 — add node(s) to topology. One entry per call in list.
    /// Format: PC19^count^node1^port1^version1^flags1^...^origin^
    /// </summary>
    public static string Pc19(IEnumerable<(string Call, int Port, string Version)> nodes, string origin)
    {
        var list = nodes.ToList();
        var fields = new List<string> { "PC19", list.Count.ToString() };
        foreach (var (call, port, version) in list)
        {
            fields.Add(call);
            fields.Add(port.ToString());
            fields.Add(version);
            fields.Add(string.Empty); // flags
        }
        fields.Add(origin);
        return Build(fields.ToArray());
    }

    /// <summary>PC20 — init turnaround signal.</summary>
    public static string Pc20(string origin)
        => Build("PC20", origin);

    /// <summary>PC21 — delete node from topology.</summary>
    public static string Pc21(string nodeCallsign, string origin)
        => Build("PC21", nodeCallsign, origin);

    /// <summary>PC22 — init complete.</summary>
    public static string Pc22(string origin)
        => Build("PC22", origin);

    /// <summary>
    /// PC11 — DX spot.
    /// Format: PC11^freq^dx_call^comment^date^time^spotter^node^
    /// </summary>
    public static string Pc11(float freq, string dxCall, string comment,
        DateTime timestamp, string spotter, string nodeCallsign)
    {
        var date = timestamp.ToUniversalTime().ToString("dd-MMM-yyyy");
        var time = timestamp.ToUniversalTime().ToString("HHmm") + "Z";
        return Build("PC11",
            freq.ToString("F1", System.Globalization.CultureInfo.InvariantCulture),
            dxCall, comment, date, time, spotter, nodeCallsign);
    }

    /// <summary>
    /// PC12 — Announcement/Weather.
    /// Format: PC12^from^to^message^origin^node^
    /// </summary>
    public static string Pc12(string from, string to, string message, string origin, string node)
        => Build("PC12", from, to, message, origin, node);

    /// <summary>
    /// PC16 — User connected to a node.
    /// Format: PC16^call^node^flags^ip^
    /// </summary>
    public static string Pc16(string callsign, string nodeCallsign, string flags = "", string ip = "")
        => Build("PC16", callsign, nodeCallsign, flags, ip);

    /// <summary>
    /// PC17 — User disconnected from a node.
    /// Format: PC17^call^node^
    /// </summary>
    public static string Pc17(string callsign, string nodeCallsign)
        => Build("PC17", callsign, nodeCallsign);

    /// <summary>
    /// PC51 — Ping.
    /// Format: PC51^target_node^sequence^origin^
    /// </summary>
    public static string Pc51(string targetNode, string sequence, string origin)
        => Build("PC51", targetNode, sequence, origin);
}
