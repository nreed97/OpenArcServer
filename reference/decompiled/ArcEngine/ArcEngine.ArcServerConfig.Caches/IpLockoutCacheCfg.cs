using System.ComponentModel;
using ArcEngine.ArcCmds.User.Wwv;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class IpLockoutCacheCfg
{
	private bool Ⴀ;

	internal static ႥႤ ႭႣ/* Not supported: data(E5 29 48 BF 88 09 C2 05 1A 5A 1A 73 47 94 67 A9 D1 53 56 13 FE 6D 0B A7 2C B4 F7 61 12 56 BC A2 3B 9A 44 70 BF DD 77 96 BF 9E 43 2E 72 92 89 22 C3 57 20 59 E3 1D 62 6C B4 3A 67 9B B3 E4 EA 99 2E C9 4E 53 4E 3C C6 F0 49 D6 0B D5 0D 09 36 58 AD 9F D2 7B D1 A5 CC DF AB CF D9 53 86 FF F2 F8 A2 D9 57 30 5E 22 AD 69 4B 00 26 BB 7B 3A A0 FB D5 2C FE E6 FE AD FA 00 36 55 E4 27 B3 6E 68 B8 A1 2E 12 D4 DC DD DD 60 A9 25 4B 65 72 CC 2F C5 37 67 89 85 C9 F6 EC 22 70 88 A5 B2 DC 52 EA 03 98 59 F0 24 BE 92 5C 0A 09 79 05 7B 9F 99 07 0E D3 18 AC 40 F0 C3 4A EF 0C 27 12 08 FF 02 C8 77 1F 0D 68 ED 2A B1 98 FB FC 75 A8 9E 48 D3 57 74 E4 63 2D 5D 76 02 C1 7A 5C C4 8E 17 30 73 2F 7A 21 94 14 AA 60 A7 46 30 25 95 56 64 5F 3F 9B B3 73 3A D4 CF 0A 48 FB E4 5A A1 27 DD 22 9E 24 5F 89 82 00 7F CD 15 07 9B 7B 01 43 57 ED 8D EF BA A6 51 67 1E 77 A6 DB 1B 8E 78 DD 1E AA 49 45 01 7B CD C0 49 28 5B F7 7C B1 60 B8 D2 A2 E2 C7 A8 08 AE 8D FD 24 C1 26 A6 9E 56 4C EE FB D2 BB 86 0A BF 51 A3 36 F8 5C 45 C0 01 27 D8 B4 78 DE 3C 27 1C 6F EC 9F DE BD 76 DE BD 84 23 0C 3B 95 1B 2A 86 C5 46 80 17 9A 57 FF 81 2B 21 71 FE D0 AF 5C 9C 05 6D FE EC EC 03 1D 96 C5 E7 51 64 59 63 6B 4B BB 1F CF 5C 3C D5 A6 26 4D 04 83 FF 53 F5 0B D1 49 1E CF 60 40 74 17 F4 E4 6B E8 EA 84 8A 81 C2 8F A5 FC 1F D9 0F CB D6 61 7B BC 04 DF 9D DE A4 65 48 FE A8 BA 94 27 EB C7 74 BF A6 61 34 1E 88 45 7B 52 2B 23 9E B3 C6 CE 65 ED F4 DC 81 40 47 2C 22 8D 86 B5 63 5A C0 30 8A B8 BB 78 30 1C 82 7A 62 6A 41 8D F0 C8 C7 77 54 8C 8C 09 D0 FE 1A EF BE 5E 30 40 DE 4E 5B C9 6A 2B 0A 43 5C 89 77 6E 2C 21 EC D1 78 92 40 C4 4C CF C3 B2 5C A0 B0 1F 9E 97 C8 9F B4 D2 F4 06 A1 84 DD AD 1A AC 8C 86 78 9E 12 AD 88 5D 33 30 B6 97 6C A6 33 B8 EE 47 5B 24 83 C4 07 70 35 AD 16 8D 26 76 DC 01 18 49 2A 2A EC EB 93 0E 9E E6 42 E4 EF 57 35 A9 9E B6 E4 ED 3F A8 29 DF 8B EC D7 36 DB F7 79 6A E1 B0 15 94 51 C6 E2 2A 58 7C 81 E6 28 57 C1 D6 BF 7A B8 18 8A 49 E5 9F C9 0B BC 42 27 F3 99 91 77 1F EC 9D 9C 88 CA DA B4 99 49 9E 7C C6 49 A0 88 46 DD 02 EA A5 4E 43 76 EE 42 C6 A7 CB 16 10 80 2C 09 59 26 C0 1F 17 C5 C6 43 4B 84 83 96 63 01 D2 2A 14 D4 93 E5 CC B8 9B 0A B6 6B 9D E2 74 BD F9 A5 15 B2 BE 9F 4E 3B AD 10 1B C5 D1 97 11 99 CE 07 26 5A E3 7A 78 97 3F DA 14 4B E7 7C B3 10 4D 73 38 65 72 C0 B2 95 81 07 DA D4 CB 33 D3 67 1A 06) */;

	internal static char[] ႭႭ;

	private ႰႼ.Ⴈ Ⴗ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
	{
		get
		{
			return Ⴗ.Ⴓ;
		}
		set
		{
			bool ⴓ = value;
			Ⴗ.Ⴓ = ⴓ;
		}
	}

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
			return Ⴗ.Ⴃ;
		}
		set
		{
			Ⴗ.Ⴃ = value;
		}
	}

	public IpLockoutCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 3, 62055288, null);
	}

	public override string ToString()
	{
		return CallBlockCacheCfg.Ⴅ(null, 8, 62055171, null);
	}
}
