using System.IO.Compression;
using System.Text;
using System.Xml.Linq;

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// ARx2 protocol framing and compression.
///
/// Wire format:  [Arx2]{zlib-compressed UTF-8 XML}[/Arx2]
///
/// The zlib data uses the standard RFC 1950 format (78 9C header).
/// .NET's ZLibStream handles this natively.
/// </summary>
public static class ArxFrame
{
    private static readonly byte[] FrameOpen  = "[Arx2]"u8.ToArray();
    private static readonly byte[] FrameClose = "[/Arx2]"u8.ToArray();
    private static readonly Encoding Enc = Encoding.UTF8;

    /// <summary>
    /// Try to extract one complete ARx2 frame from the buffer.
    /// Returns the decompressed XML string if a complete frame is present,
    /// null otherwise. Advances <paramref name="consumed"/> to the byte
    /// position immediately after the frame end delimiter.
    /// </summary>
    public static string? TryExtract(ReadOnlySpan<byte> buffer, out int consumed)
    {
        consumed = 0;

        // Find [Arx2]
        int openIdx = IndexOf(buffer, FrameOpen);
        if (openIdx < 0) return null;

        int dataStart = openIdx + FrameOpen.Length;
        var remaining = buffer[dataStart..];

        // Find [/Arx2]
        int closeIdx = IndexOf(remaining, FrameClose);
        if (closeIdx < 0) return null;

        var compressed = remaining[..closeIdx];
        consumed = dataStart + closeIdx + FrameClose.Length;

        return Decompress(compressed);
    }

    /// <summary>Wrap XML in [Arx2]...[/Arx2] with zlib compression.</summary>
    public static byte[] Wrap(string xml)
    {
        var compressed = Compress(xml);
        var result = new byte[FrameOpen.Length + compressed.Length + FrameClose.Length];
        FrameOpen.CopyTo(result, 0);
        compressed.CopyTo(result, FrameOpen.Length);
        FrameClose.CopyTo(result, FrameOpen.Length + compressed.Length);
        return result;
    }

    /// <summary>Returns true if the buffer starts with the ARx2 open frame marker.</summary>
    public static bool StartsWithFrame(ReadOnlySpan<byte> buffer)
        => buffer.Length >= FrameOpen.Length && buffer[..FrameOpen.Length].SequenceEqual(FrameOpen);

    // ── Private helpers ───────────────────────────────────────────────────

    private static string Decompress(ReadOnlySpan<byte> data)
    {
        using var input  = new MemoryStream(data.ToArray());
        using var zlib   = new ZLibStream(input, CompressionMode.Decompress);
        using var output = new MemoryStream();
        zlib.CopyTo(output);
        return Enc.GetString(output.ToArray());
    }

    private static byte[] Compress(string xml)
    {
        var bytes = Enc.GetBytes(xml);
        using var output = new MemoryStream();
        using (var zlib = new ZLibStream(output, CompressionLevel.Optimal))
            zlib.Write(bytes);
        return output.ToArray();
    }

    private static int IndexOf(ReadOnlySpan<byte> haystack, ReadOnlySpan<byte> needle)
    {
        if (needle.Length == 0) return 0;
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
            if (haystack.Slice(i, needle.Length).SequenceEqual(needle))
                return i;
        return -1;
    }

    // ── XML message builders ──────────────────────────────────────────────

    /// <summary>Get the root element name of an XML message (the message type).</summary>
    public static string? GetMessageType(string xml)
    {
        try { return XDocument.Parse(xml).Root?.Name.LocalName; }
        catch { return null; }
    }

    /// <summary>Build a minimal XML message with optional child elements.</summary>
    public static string BuildXml(string rootElement, params (string Name, string Value)[] fields)
    {
        var sb = new StringBuilder();
        sb.Append('<').Append(rootElement).Append('>');
        foreach (var (name, value) in fields)
            sb.Append('<').Append(name).Append('>').Append(Escape(value)).Append("</").Append(name).Append('>');
        sb.Append("</").Append(rootElement).Append('>');
        return sb.ToString();
    }

    private static string Escape(string value) => value
        .Replace("&", "&amp;")
        .Replace("<", "&lt;")
        .Replace(">", "&gt;")
        .Replace("\"", "&quot;");
}
