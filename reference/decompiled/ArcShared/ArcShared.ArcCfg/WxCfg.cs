using System.ComponentModel;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DxAtlas;
using Ⴃ;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class WxCfg
{
	private ModeType Ⴈ;

	private int Ⴅ;

	internal static ႰႷ ႣႳ/* Not supported: data(A4 54 16 FC 7A F0 12 24 E7 CE 14 2F 54 F6 2C 99 EA 77 3D 49 D3 B6 38 80 5D D3 3B 92 78 95 13 66 CC 2D AF 18 C6 3E 24 17 4E 02 5B FC B0 BF 54 48 BC DC 9E 7D 06 E3 43 E3 06 9F 47 9E 98 5D D4 13 F6 CF 94 5D A8 B4 6E 2C EB 18 30 E8 64 AA C3 4F 4B 90 16 45 F7 62 2E 86 A8 5F 9C 24 23 DA 41 65 E6 05 F5 E0 C4 46 59 57 E8 08 F6 27 E9 D4 47 58 65 3C 26 A8 54 47 48 51 0C 4C 11 13 25 FA A2 D9 A4 EB FF A2 40 B0 C8 75 91 DD 09 69 27 4D 9B 45 49 6E 01 EF D7 86 36 BD 64 99 82 39 AA E8 20 B8 7A A3 C5 7D 5D DD 0F BE 83 57 3F 06 EC 0A FF A7 AA 88 61 5C 08 F0 C4 70 DB A0 1B 59 B7 03 3A 7D EF 4A 54 89 88 9A A8 BC 5A 74 5A 64 AE 87 DB 9C CD 93 29 01 0F E9 E5 19 1E A1 B2 17 E2 BE E2 02 7A BF 32 8F CD AD 45 CE B2 35 16 3C 1F 82 65 E5 12 98 41 08 1D ED 30 81 00 79 62 DC BE A4 2D 15 4A EB 9D 09 46 72 10 10 F9 9E 01 2C C6 43 1F 3F 15 F6 82 40 41 2A 59 56 2E 1D 06 F1 E1 06 F7 70 7D 9D 25 ED 48 B1 A9 11 4D AB 71 35 87 47 D9 0E 34 07 22 B5 95 24 18 6C 3C 77 7E 06 DA 23 6A B7 6A 5C E1 D3 99 2E 80 97 6A A5 D2 AE E8 63 79 93 6C 4B AD 6E 2E D8 2F F5 D4 11 C5 2B 36 C8 0B A7 5F 01 25 7C B1 E3 DA 8B 19 2B 15 93 DE 69 D9 B5 15 C2 6D 63 DB 08 D5 E9 6C 07 AC D7 E2 C7 97 EF A7 1C D6 72 EE F9 4C 49 6C C2 5F 6F 8C CB AA EE 3C 89 CF 1D 3C C6 A0 3C 41 5D 56 52 04 FD 6E DB EA EC 88 7D B8 6A 16 FB CC 22 FF 97 50 8C 54 C9 03 6A BF 78 69 D5 FD 41 F7 A5 11 7A 0D 8C BE 73 C9 A6 96 E8 88 D8 FC 9E D6 31 EA 7E 9E E4 FF 91 97 B0 06 F5 9D 02 49 0D D7 CC 3D 2D 98 58 BF 6F 68 66 6C 2D E9 FC E2 89 F3 6C CA CC CA CC A7 84 84 E6 9A 30 47 DF AC 49 F5 99 8F 89 B2 48 2A 0F C1 91 7D 52 D5 95 A9 74 CC 79 07 5E 97 A9 00 6E E9 98 B8 D8 7E 4A C4 2D 61 95 07 7F 7B FC C5 3C 27 20 AA 65 94 DB 8B 78 27 7D 2A 02 CA 06 FD D9 CB 1B E0 53 77 B8 3C 01 A1 9F F1 9A 08 F8 08 27 53 AC 71 F3 86 7B 5A 7A) */;

	internal static char[] ႣႭ;

	private DxAtlasData.Ⴅ Ⴃ = new DxAtlasData.Ⴅ();

	[Description("Set the WX spot filter.  The most common filter is one to limit spots to geographic region, for North America that would be SpotterCont=NA.  You can filter by anthing in the spot. See the docs for more information.")]
	public string Filter
	{
		get
		{
			return Ⴃ.Ⴄ;
		}
		set
		{
			Ⴃ.Ⴄ = value as string;
			DataGridViewColumnSelector.Ⴐ[58] = (char)((DataGridViewColumnSelector.Ⴐ[58] ^ TalkCfg.ႣႣ[72]) & 0xDB);
		}
	}

	[Description("WX spots have three modes:  Open (filter is not appled), Filter (filter is applied) and Debug (All spots are displayed and a + or a - is displayed in front of the spot indicating if it passed or was rejected by the filter.")]
	public ModeType Mode
	{
		get
		{
			return Ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	[Description("Sets the number of spots displayed with the Show WX command")]
	public int NmbrSpots
	{
		get
		{
			return Ⴅ;
		}
		set
		{
			Ⴅ = value;
		}
	}

	[Description("Sets the WX output to On (normal user display), OFF(no spots are displayed)")]
	public OutputType Output
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			return Ⴃ.Ⴅ;
		}
		set
		{
			Ⴃ.Ⴅ = value;
		}
	}

	public WxCfg()
	{
		Filter = string.Empty;
		Mode = ModeType.Filter;
		NmbrSpots = 10;
		Output = OutputType.On;
	}

	public override string ToString()
	{
		return TelnetServerClient.Ⴄ(1945323000, '\u0087', 8);
	}
}
