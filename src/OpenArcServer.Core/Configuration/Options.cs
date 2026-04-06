using System.ComponentModel;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenArcServer.Core.Configuration;

public sealed class ServerOptions
{
    public string NodeCallsign { get; set; } = "N0CALL-2";
    public string SysopCallsign { get; set; } = "N0CALL";
    public string ServerName { get; set; } = "OpenArcServer";
    public string Version { get; set; } = "1.0.0";
    public string MotdFile { get; set; } = "data/motd.txt";
}

public sealed class TelnetOptions
{
    public bool Enabled { get; set; } = true;
    public int Port { get; set; } = 7373;
    public string BindAddress { get; set; } = "0.0.0.0";
    public int MaxConnections { get; set; } = 200;
    public int IdleTimeoutMinutes { get; set; } = 60;
    public string IntroMessage { get; set; } = "AR-Cluster Server\r\n\r\nPlease enter your callsign: ";
    public string WelcomeMessage { get; set; } = "Hello {Callsign}, welcome to {NodeCallsign}\r\n";
    public string LogoutMessage { get; set; } = "73 de {NodeCallsign}";
    public string InvalidCallsignMessage { get; set; } = "Invalid callsign. Please try again: ";
    public string BlockedMessage { get; set; } = "Sorry, you are not permitted to connect to this cluster.";
}

public sealed class DatabaseOptions
{
    public string ConnectionString { get; set; } = "Data Source=data/openarcserver.db";
    public int DxSpotRetentionDays { get; set; } = 30;
    public int DxSpotMaxCount { get; set; } = 250000;
    public int UserRetentionYears { get; set; } = 3;
    public int AnnouncementRetentionDays { get; set; } = 30;
    public int LogRetentionDays { get; set; } = 30;
}

public sealed class DataFileOptions
{
    public string CtyDatPath { get; set; } = "data/cty_wt_mod.dat";
    public string BandModePath { get; set; } = "data/BandMode.dat";
    public string BadWordPath { get; set; } = "data/BadWord.dat";
    public string CallBlockPath { get; set; } = "data/CallBlock.dat";
    public string ConnectBlockPath { get; set; } = "data/ConnectBlock.dat";
    public string DxSpotBlockPath { get; set; } = "data/DxSpotBlock.dat";
    public string StatesPath { get; set; } = "data/States.dat";
    public string ProvincesPath { get; set; } = "data/Provinces.dat";
}

public sealed class SpotProcessingOptions
{
    public int MaxCommentLength { get; set; } = 30;
    public float MaxFrequencyKhz { get; set; } = 500000f;
    public float MinFrequencyKhz { get; set; } = 1800f;
    public bool EnableBadWordFilter { get; set; } = true;
    public bool EnableDuplicateDetection { get; set; } = true;
    public int DuplicateWindowMinutes { get; set; } = 20;
}

/// <summary>
/// Represents a PCxx peer node.  In appsettings.json you can use either
/// an object <c>{"Host":"n1ta.ddns.net","Port":23}</c> or a plain string
/// <c>"n1ta.ddns.net:23"</c> — both forms are accepted.
/// </summary>
[JsonConverter(typeof(PcxxPeerConverter))]
[TypeConverter(typeof(PcxxPeerTypeConverter))]
public sealed class PcxxPeer
{
    public string Host    { get; set; } = string.Empty;
    public int    Port    { get; set; } = 7300;
    /// <summary>Optional display label — used in logs before the handshake reveals the node callsign.</summary>
    public string Label   { get; set; } = string.Empty;
    /// <summary>When false the connector skips this peer without removing it from the list.</summary>
    public bool   Enabled { get; set; } = true;

    /// <summary>Parse a "host:port" string, falling back to port 7300 if absent.</summary>
    public static PcxxPeer Parse(string value)
    {
        value = value.Trim();
        var colon = value.LastIndexOf(':');
        if (colon > 0 && int.TryParse(value[(colon + 1)..], out var p))
            return new PcxxPeer { Host = value[..colon].Trim(), Port = p };
        return new PcxxPeer { Host = value, Port = 7300 };
    }
}

/// <summary>
/// Allows <see cref="PcxxPeer"/> to be deserialized from either a JSON string
/// <c>"host:port"</c> or a JSON object <c>{"Host":"...","Port":...}</c>.
/// </summary>
internal sealed class PcxxPeerConverter : JsonConverter<PcxxPeer>
{
    public override PcxxPeer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
            return PcxxPeer.Parse(reader.GetString()!);

        // Object form — deserialize normally using a temp options without this converter
        var inner = new JsonSerializerOptions(options);
        inner.Converters.Remove(inner.Converters.OfType<PcxxPeerConverter>().FirstOrDefault()!);
        using var doc = JsonDocument.ParseValue(ref reader);
        return new PcxxPeer
        {
            Host    = doc.RootElement.TryGetProperty("Host",    out var h) ? h.GetString() ?? "" : "",
            Port    = doc.RootElement.TryGetProperty("Port",    out var p) ? p.GetInt32()        : 7300,
            Label   = doc.RootElement.TryGetProperty("Label",   out var l) ? l.GetString() ?? "" : "",
            Enabled = doc.RootElement.TryGetProperty("Enabled", out var e) ? e.GetBoolean()      : true,
        };
    }

    public override void Write(Utf8JsonWriter writer, PcxxPeer value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Host",    value.Host);
        writer.WriteNumber("Port",    value.Port);
        writer.WriteString("Label",   value.Label);
        writer.WriteBoolean("Enabled", value.Enabled);
        writer.WriteEndObject();
    }
}

public sealed class PcxxOptions
{
    public bool Enabled { get; set; } = false;
    public int Port { get; set; } = 7300;
    public string BindAddress { get; set; } = "0.0.0.0";
    public int MaxNodeConnections { get; set; } = 50;
    public int PingIntervalSeconds { get; set; } = 300;
    public int NodeTimeoutMinutes { get; set; } = 30;
    /// <summary>If true, ignore PC19/PC21/PC16/PC17 topology/user messages.</summary>
    public bool IgnoreNodeUserProtocol { get; set; } = false;
    /// <summary>Log outbound node protocol messages (PC18, PC19, PC20, PC22 etc.).</summary>
    public bool LogOutboundNodeUser { get; set; } = false;
    /// <summary>Outbound peer nodes to connect to.</summary>
    public List<PcxxPeer> Peers { get; set; } = new();
}

public sealed class RbnOptions
{
    public bool Enabled { get; set; } = false;
    public string Host { get; set; } = "telnet.reversebeacon.net";
    public int Port { get; set; } = 7000;
    /// <summary>Callsign to send to RBN on login.</summary>
    public string Callsign { get; set; } = string.Empty;
    public int ReconnectDelaySeconds { get; set; } = 30;
}

public sealed class WebSocketOptions
{
    public bool Enabled { get; set; } = true;
    public int Port { get; set; } = 7374;
    public string BindAddress { get; set; } = "0.0.0.0";
}

/// <summary>
/// Options for the ARx2 native client server (AB5K AR-Cluster native protocol).
/// Listens on a separate port (default 3608). Server sends AB5K_LoginRqst on connect;
/// client responds AB5K_LoginResp; then server pushes AB5K_Client_Dx spots as ARx2 frames.
/// </summary>
public sealed class ArxServerOptions
{
    public bool Enabled { get; set; } = false;
    public int Port { get; set; } = 3608;
    public string BindAddress { get; set; } = "0.0.0.0";

    /// <summary>
    /// Outbound ARx2 peer nodes to connect to.
    /// Format: "hostname:port"  (e.g. "n1ta.ddns.net:3608")
    /// </summary>
    public List<ArxPeer> Peers { get; set; } = new();

    /// <summary>Seconds to wait before reconnecting after a disconnect (max doubles to 300 s).</summary>
    public int ReconnectDelaySeconds { get; set; } = 30;
}

/// <summary>An outbound ARx2 peer node to maintain a connection to.</summary>
[JsonConverter(typeof(ArxPeerConverter))]
[TypeConverter(typeof(ArxPeerTypeConverter))]
public sealed class ArxPeer
{
    public string Host    { get; set; } = string.Empty;
    public int    Port    { get; set; } = 3608;
    /// <summary>Optional human-readable label shown in log messages.</summary>
    public string Label   { get; set; } = string.Empty;
    /// <summary>When false the connector skips this peer without removing it from the list.</summary>
    public bool   Enabled { get; set; } = true;

    public static ArxPeer Parse(string value)
    {
        value = value.Trim();
        var colon = value.LastIndexOf(':');
        if (colon > 0 && int.TryParse(value[(colon + 1)..], out var p))
            return new ArxPeer { Host = value[..colon].Trim(), Port = p };
        return new ArxPeer { Host = value, Port = 3608 };
    }
}

internal sealed class ArxPeerConverter : JsonConverter<ArxPeer>
{
    public override ArxPeer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
            return ArxPeer.Parse(reader.GetString()!);

        using var doc = JsonDocument.ParseValue(ref reader);
        return new ArxPeer
        {
            Host    = doc.RootElement.TryGetProperty("Host",    out var h) ? h.GetString() ?? "" : "",
            Port    = doc.RootElement.TryGetProperty("Port",    out var p) ? p.GetInt32()        : 3608,
            Label   = doc.RootElement.TryGetProperty("Label",   out var l) ? l.GetString() ?? "" : "",
            Enabled = doc.RootElement.TryGetProperty("Enabled", out var e) ? e.GetBoolean()      : true,
        };
    }

    public override void Write(Utf8JsonWriter writer, ArxPeer value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Host",     value.Host);
        writer.WriteNumber("Port",     value.Port);
        writer.WriteString("Label",    value.Label);
        writer.WriteBoolean("Enabled", value.Enabled);
        writer.WriteEndObject();
    }
}

internal sealed class ArxPeerTypeConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? ctx, Type sourceType)
        => sourceType == typeof(string) || base.CanConvertFrom(ctx, sourceType);

    public override object? ConvertFrom(ITypeDescriptorContext? ctx, CultureInfo? culture, object value)
        => value is string s ? ArxPeer.Parse(s) : base.ConvertFrom(ctx, culture, value);
}

/// <summary>Options for the REST API / admin dashboard.</summary>
public sealed class ApiOptions
{
    public bool Enabled { get; set; } = true;
    public int Port { get; set; } = 8080;
    public string BindAddress { get; set; } = "0.0.0.0";
    /// <summary>
    /// Optional API key for admin endpoints.  If empty, admin endpoints are disabled.
    /// Set via environment variable OPENARCSERVER_ADMIN_KEY for production use.
    /// </summary>
    public string AdminKey { get; set; } = string.Empty;
}

/// <summary>
/// Allows <see cref="PcxxPeer"/> to be bound from a plain "host:port" string
/// in appsettings.json via Microsoft.Extensions.Configuration's TypeConverter
/// support.
/// </summary>
internal sealed class PcxxPeerTypeConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? ctx, Type sourceType)
        => sourceType == typeof(string) || base.CanConvertFrom(ctx, sourceType);

    public override object? ConvertFrom(ITypeDescriptorContext? ctx, CultureInfo? culture, object value)
        => value is string s ? PcxxPeer.Parse(s) : base.ConvertFrom(ctx, culture, value);
}
