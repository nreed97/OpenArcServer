using System.ComponentModel;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.Forms;
using Ⴃ;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class DxCfg
{
	private DxCommentExtCfg Ⴄ;

	private DxModeType Ⴀ;

	private NeedsCfg Ⴄ;

	private OutputType Ⴐ;

	internal static ႰႤ Ⴍ/* Not supported: data(99 24 E9 C4 AC E6 FF 7E C9 66 31 2B B7 7C D0 52 B2 3C C6 37 51 11 21 FE 13 89 A2 B2 6B 44 5F 83 F1 BA 9A E6 47 4C 02 6B 5B 75 EC 09 22 A3 18 E9 55 78 40 47 5C E5 5F 00 5C 2F D1 E1 78 45 E7 01 B5 F6 6F 82 B9 6C C5 83 86 7D BA 9F 56 22 6E 9F E3 F4 1E 50 8E 90 ED AE 14 06 0B D5 72 C8 83 E6 F6 2C E5 3C 41 2E 2E 30 C3 CB 96 FA CB FA AC 1A C6 21 92 FD AA 06 88 1F D3 45 57 7C 73 23 E0 5A 4D F2 69 0F 6B 07 A3 06 E8 45 A4 C0 D9 05 36 1B 43 C4 D7 AC 1D 76 3D 25 5D 79 33 F4 04 E3 48 A3 CD 7E D8 FE 67 D3 76 F2 8F B3 4A 15 22 36 1D FC A2 87 0C 52 FF 61 F2 7F 10 99 CD 02 9B 59 8C 78 AB 2C AD 35 9F BC A9 F6 A0 CD CE C1 9B A0 51 6C 0C 37 0B 13 E9 6B EB 1E 79 84 8E D5 4E A1 92 2D 8D 1A 61 63 BA A0 FA 46 EE A8 FB 30 50 A7 02 DD 45 D9 4C 0B 00 7F DA F3 A5 5E E5 85 25 82 76 C1 3C 53 8F FD 91 F8 B0 43 93 37 5A EC A6 D5 FD BC 3C 5E 16 67 6A BB 84 A0 60 A9 36 17 A4 77 12 B2 BD B0 6C 34 65 65 AE 35 12 62 A0 12 9D CF AE FB 5C 8E 9C DF 63 1D 53 C2 CE 42 BF AC) */;

	internal static char[] Ⴗ;

	private HelpAboutServer.ႷႷ Ⴃ = new HelpAboutServer.ႷႷ();

	public DxCommentExtCfg CommentExt
	{
		get
		{
			return this.Ⴄ;
		}
		set
		{
			this.Ⴄ = value;
		}
	}

	[Description("Set the DX spot filter.  The most common filter is one to limit spots to geographic region, for North America that would be SpotterCont=NA.  You can filter by anything in the spot. See the docs for more information.")]
	public string Filter
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			return Ⴃ.Ⴓ;
		}
		set
		{
			Ⴃ.Ⴓ = value;
		}
	}

	[Description("Set announce mode. Announce spots have three modes:  Open (filter is not applied), Filter (filter is applied) and Debug (All spots are displayed and a + or a - is displayed in front of the spot indicating if it passed or was rejected by the filter.")]
	public DxModeType Mode
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("Sets the number of spots displayed with the Show DX command")]
	public int NmbrSpots
	{
		get
		{
			int ⴐ = Ⴃ.Ⴐ;
			UtilsNumeric.Ⴀ[413] = (char)(UtilsNumeric.Ⴀ[413] & UtilsNumeric.Ⴀ[9] & 0x77);
			return ⴐ;
		}
		set
		{
			Ⴃ.Ⴐ = value;
		}
	}

	public NeedsCfg Needs
	{
		get
		{
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	[Description("Sets the DX output to On (normal user display) OFF(no spots are displayed)")]
	public OutputType Output
	{
		get
		{
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	[Description("Display spots that on the bottom of the band which are usually announcements")]
	public bool Bob
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return Ⴃ.Ⴄ;
		}
		set
		{
			bool ⴄ = value;
			Ⴃ.Ⴄ = ⴄ;
			DataGridViewColumnSelector.Ⴐ[392] = (char)((DataGridViewColumnSelector.Ⴐ[392] ^ DataGridViewColumnSelector.Ⴐ[428]) & 0xDD);
		}
	}

	[Description("Display the spotter CTY/State")]
	public bool SpotterQth
	{
		get
		{
			bool ⴗ = Ⴃ.Ⴗ;
			NeedsCfg.ႣႤ[102] = (NeedsCfg.ႣႤ[102] ^ NeedsCfg.ႣႤ[606]) & 0xF;
			return ⴗ;
		}
		set
		{
			bool ⴗ = value;
			Ⴃ.Ⴗ = ⴗ;
		}
	}

	public DxCfg()
	{
		Mode = DxModeType.Filter;
		Output = OutputType.On;
		NmbrSpots = 20;
		CommentExt = new DxCommentExtCfg();
		Needs = new NeedsCfg();
		Filter = string.Empty;
		Bob = true;
	}

	public override string ToString()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		return ႣႼ.ႥႭ(null, 624736044, 0, null);
	}
}
