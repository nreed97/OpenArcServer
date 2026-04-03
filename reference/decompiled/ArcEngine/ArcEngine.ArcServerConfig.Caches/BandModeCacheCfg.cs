using System.ComponentModel;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using Ⴈ;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class BandModeCacheCfg
{
	private bool Ⴀ;

	private bool Ⴓ;

	private string Ⴐ;

	internal static ႥႰ ႠႥ/* Not supported: data(FA A4 A7 6A AB 76 BF 92 79 60 6D 4F 43 A4 FF 37 F2 7E 2F AF AA 58 75 1C D9 0E 79 FF 3E 83 47 D9 B2 AB E0 A1 9B A2 A9 9A E5 09 06 26 B6 D4 E3 A8 E3 63 6B 68 E8 F1 4B A4 A1 3A 0D D4 D0 A8 91 2B 87 0C 78 BC EA 9C 39 7D 4A 8A F7 9C A6 AD 89 61 CE B6 E5 D1 9A 4D 14 10 34 A5 F8 ED 32 8D 51 05 74 40 F7 C3 D8 68 F5 7A 70 C4 CB 87 36 CF F4 7E F0 95 C7 CD DB 2E 0C F8 83 5D F7 FF 5D FD E4 AA 5E 06 18 2D EE 0F 60 52 8E 62 05 06 FC 4E BB 0E 39 F4 11 41 DA E3 FE 37 6A D8 A2 C4 AE 03 E9 75 38 DB 97 EC D6 63 A8 76 34 6B DA 2D 20 67 BA 84 40 ED F6 1D 48 E7 82 BC 1B 6E 98 B5 06 04 D6 B6 86 D4 B5 A2 B5 09 1B 78 0A DE D2 3A C1 A2 6F 3A FA 74 1C 5A BB 86 5E 83 F0 A3 37 97 88 A6 4C D1 18 CA F1 B8 D4 1C EB 70 20 9C B4 86 AF 3F 82 D8 F7 C5 33 8B 1E 65 98 44 BC 1E 79 92 9E A0 A0 3E 0A 3D 03 2D 77 63 B5 35 EC BA 91 8B DE 97 66 A0 D5 49 67 29 AE 01 18 11 1D A7 C0 E3 C8 E0 09 56 6C 77 FB 15 69 F2 29 B5 C3 98 1A 93 B5 1A D1 4D 05 63 31 31 23 B2 D6 52 B2 D5 28 5E B2 1B 80 E2 7D B9 1B 48 54 46 EC 76 C0 33 D2 70 60 16 87 3E 12 21 6D 7C 15 27 B9 72 06 85 97 2E 65 31 36 E2 69 AA 14 0F 2A CD C1 08 0F A0 74 EB DB A5 EF A9 4E 12 A5 15 AE D2 BA 89 6D D9 07 45 B2 CA AB EB B4 0D 2D 1F 99 57 02 5F 6C 9D DB 69 49 22 99 06 99 FF E1 B3 16 94 56 1C 04 6C FB A7 CA C8 6E 34 CB FF EB CF 6C A8 9D C6 FD 90 F1 12 71 42 08 CE 3E A2 63 9C 9E 64 1B 1E 22 9E A5 8C 18 65 0A DC B9 B1 68 3B 04 65 D9 65 FC D6 61 D2 CA 44 8D 40 CA EC 91 C6 26 09 2C EC 5D 57 85 89 EA 3D 51 6A D9 4C 40 9E ED 89 81 09 99 9C 15 04 AE 5A C1 FA BA DC 90 89 C3 BC 08 01 3D 05 2D 04 75 68 F4 72 C8 4E 0B B8 9B 6A 9C 30 F6 42 F1 62 71 5D 6A 2D 21 8B DF 67 D1 D9 6A CA CB 09 44 56 AA 76 B9 18 78 5E 4B FA 40 D1 E1 FF B7 02 97 5B 70 3F A4 AD B8 E0 41 6A 1D 89 6B 4D 9D 15 C1 43 50 3B 9C E8 1B 5E 30 96 63 9D 50 9F E9 1E 4E 0D 5B 27 E7 E9 CF 40 82 5C 5E 7E BA 34 42 2A 42 90 F6 F0 76 86 E6 12 09 A4 8F A2 F0 0A EC 32 93 68 3D 70 30 F3 9B 78 F6 BC E2 4F B3 D8 D2 D9 05 10 CC 17 60 47 8E 2C 33 F1 4F 6C 99 73 DF B8 58 D7 CF F9 2A 51 F0 D2 58 E7 12 BF 33 A6 38 DD B5 0A 62 83 75 50 4A 79 A7 02 85 3A 93 71 30 A1 5F 30 B0 B5 86 F5 F3 25 32 AA B5 26 F1 61 6A BD A6 4E 14 10 CA 30) */;

	internal static char[] ႠႳ;

	[Description("Flag to automatically update from the web every day")]
	public bool AutoDownload
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

	[Description("Flag to automatically reload the cache when the source text file changes")]
	public bool AutoReload
	{
		get
		{
			char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	[Description("Download url")]
	public string Url
	{
		get
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			string ⴐ = Ⴐ;
			SetDxCountHelp.ႭႤ[92] = (SetDxCountHelp.ႭႤ[92] + ShowQrzHelp.ႤႤ[448]) & 0xD6;
			return ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public BandModeCacheCfg()
	{
		AutoDownload = true;
		AutoReload = true;
		Url = CallBlockCacheCfg.Ⴅ(null, 3, 62056226, null);
	}

	public override string ToString()
	{
		return CallBlockCacheCfg.Ⴅ(null, 0, 62056432, null);
	}
}
