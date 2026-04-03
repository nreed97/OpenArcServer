using System.ComponentModel;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class AnnCacheCfg
{
	internal static ႥႠ ႠႰ/* Not supported: data(31 E0 12 A9 25 1F 48 4D C9 D7 96 96 F3 6A 22 95 75 48 50 87 3F ED E7 6C FC 15 CD 39 A1 7E 85 81 56 09 F9 80 17 19 98 BA B0 AF 8B D0 9F 52 14 9C 8B 6D 64 A4 CF 74 4E 42 F7 A5 AC 10 51 0E AA 4A 51 14 40 EA 70 A0 7D 5B AF 94 D6 8E 62 16 CB A9 00 31 AD 34 1A E0 B1 E1 B9 B6 88 71 6C 87 69 A2 04 40 7F 8A 12 29 2B EA EE 08 F4 3B 9C BE DF E0 D8 02 10 1F 60 76 30 70 62 5E 30 B8 17 0B EE 27 2A 34 89 21 96 41 97 D6 05 C2 44 11 EA 75 44 F9) */;

	internal static byte[] ႠႼ;

	private DxCmdMsgExt.ႨႥ Ⴄ = new DxCmdMsgExt.ႨႥ();

	[Description("Flag to activate the automatic compacting of the database")]
	public bool AutoDbCompact
	{
		get
		{
			return Ⴄ.Ⴃ;
		}
		set
		{
			bool ⴃ = value;
			Ⴄ.Ⴃ = ⴃ;
		}
	}

	[Description("Number of days of data to keep in the database after purge operations")]
	public int DbDaysToKeep
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return Ⴄ.Ⴅ;
		}
		set
		{
			Ⴄ.Ⴅ = value;
		}
	}

	[Description("Minutes of data to keep in the memory cache")]
	public int CacheMinutes
	{
		get
		{
			return Ⴄ.Ⴀ;
		}
		set
		{
			Ⴄ.Ⴀ = value;
		}
	}

	public AnnCacheCfg()
	{
		AutoDbCompact = true;
		DbDaysToKeep = 30;
		CacheMinutes = 30;
	}

	public override string ToString()
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		return CallBlockCacheCfg.Ⴅ(null, 7, 62055817, null);
	}
}
