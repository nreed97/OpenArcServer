using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.CmdProcessing.UserCmds;
using Ⴀ;

namespace ArcClientEngine.ArcCfg.OldHighlightCode;

public sealed class HighlightCtyCfg
{
	internal static ႳႤ ႠႳ/* Not supported: data(25 C3 89 1B C4 E3 EC FC 7C 0D 3C BD 2B F3 C6 7E FD 7C A3 6D 4E 1C 3E D1 24 D3 89 BE E0 DA 61 05 8D 9A 01 DE E5 C4 57 53 78 82 40 00 B0 71 E6 F8 DE 9D D9 09 55 29 66 8A CD 98 EC 0A F1 C6 BE 11 AE 2B BE 9B 64 F4 E3 62 FF 44 0A 52 19 70 2A E9 E7 2A 12 F0 CB FA 72 89 58 BE 98 E8 BA ED BC 53 4D 0E B5 AF 79 C1 C7 37 19 64 C8 D8 CB 23 E5 C2 D7 A9 DC EA 0D 5F A3 03 E6 93 C5 68 F8 E5 10 72 B0 A6 8F 0A 8F A5 66 37 23 CA FD 77 60 C0 83 48 E8 6D B9 DB 70 28 65 92 73 05 3C E8 8E 3A 45 B5 1E 1C 98 D5 19 7C 17 E9 72 49 29 8F A4 AD E4 52 F2 77 7E 31 0B B9 21 5A FB F2 75 6C 44 55 21 C2 19 0A BA 88 C1 E2 C8 B3 08 43 53 B6 97 89 4F 96 53 EF F6 78 DE C9 5E 88 57 B0 65 91 72 BD 99 C1 4E B0 C7 A9 84 E7 4D BE AA EC DF FC 9D 28 87 17 EA 5C AB 52 72 BF A4 98 F0 BE 3F 66 86 55 73 01 75 86 4E 66) */;

	internal static char[] ႠႠ;

	private ႥႭ.ႳႰ m_Ⴍ;

	[XmlIgnore]
	internal Color Ⴐ
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			Color ⴍ = this.m_Ⴍ.Ⴍ;
			ႥႰ.Ⴗ[96] = (char)((ႥႰ.Ⴗ[96] | ႥႰ.Ⴗ[160]) & 0x71);
			return ⴍ;
		}
		set
		{
			this.m_Ⴍ.Ⴍ = ⴍ;
		}
	}

	[Browsable(false)]
	internal string Ⴀ
	{
		get
		{
			return SetDxFilter.Ⴃ(Ⴐ, 409, 426);
		}
		set
		{
			Ⴐ = HighlightArrlSectionCfg.Ⴓ(text, 892, 832);
		}
	}

	[SpecialName]
	internal string Ⴍ()
	{
		return this.m_Ⴍ.Ⴐ;
	}

	[SpecialName]
	internal void Ⴈ(string P_0)
	{
		this.m_Ⴍ.Ⴐ = P_0 as string;
	}

	internal HighlightCtyCfg()
	{
	}

	public override string ToString()
	{
		return WxFilters.Ⴀ(null, 2, 103388455);
	}
}
