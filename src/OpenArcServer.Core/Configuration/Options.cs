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

public sealed class PcxxPeer
{
    public string Host { get; set; } = string.Empty;
    public int Port { get; set; } = 7300;
    /// <summary>Optional display label — used in logs before the handshake reveals the node callsign.</summary>
    public string Label { get; set; } = string.Empty;
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
}
