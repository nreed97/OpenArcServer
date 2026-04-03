using System.ComponentModel;
using ArcShared.DgvUtils;
using ArcShared.Forms;
using Ⴃ;

namespace ArcShared.ArcCfg;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class TalkCfg
{
	internal static ႰႥ ႣႨ/* Not supported: data(15 D3 32 32 94 14 94 5F BD F1 78 8C C8 89 EF E9 3B 34 E0 7E A0 54 76 79 D6 6A 0F 93 C8 6B 3E 49 4D A4 69 22 E3 12 63 E8 0C AF 50 07 C3 56 76 44 F8 AF 62 D5 FB D3 5B F0 AE A1 1C C6 38 D7 2A 54 E7 AB E0 82 9B 72 2B 7B 80 8B 86 55 9C 81 F2 6F 04 A3 5B D7 4A 3C BE BC 50 57 B0 A1 44 BF 35 8B 10 AB 09 C5 C8 1A 63 99 8D 92 41 FE 80 B1 C4 CB 6E DB 1D D0 9A AF 5A 1C 7B B8 6B 99 40 48 1D 6E A6 A7 75 00 8D CD F5 E7 73 20 9C F0 BC BD C6 4E CC A0 F0 A2 5E 45 B0 D7 04 CB 03 9A 25 ED 48 0E 1E 16 C6 48 4B 45 A4 DC 53 AB D5 3D 9C C1 A5 AD 5E D1 D5 A6 BC 9F 62 BB EA A5 41 65 76 B7 98 09 1A 8F 2B CE 18 15 DA 56 21 D4 4D D7 C1 6A 72 BA 4C 07 00 CC 96 F8 9C EF E3 B8 CF D9 C0 00 6A 41 F6 E2 52 A1 3B 06 B5 6F 1F 54 9B 6B C9 C2 D0 69 D8 3E E8 1F 97 16 9C 79 E0 50 5A 02 DB A8 8A 3B 79 EB C5 3B 95 48 D8 FC EB 84 4A 96 26 3A D0 3E 03 DE D7 8A 57 D5 51 DF 3E 45 FF D1 C0 F4 8D F7 15 A6 51 5E 6A D8 98 04 06 5F C1 47 78 B5 7F 23 62 0B 46 AB 02 18 38 B4 B6 C0 23 F1 92 69 F2 04 25 23 0B BD 22 04 1D 7D 39 91 E6 03 7D BC AC 4C 2C 67 6A C7 B0 91 47 C9 42 96 76 E3 92 24 D7 6C 26 2B 08 1F 86 D3 8D F2 EE 29 43 A4 82 DC B8 A3 4C 86 16 25 75 F1 A4 D9 47 7E EC 85 18 7E DE EC 45 21 65 D0 2C BC 31 88 DC CD A3 77 53 66 2E A2 D3 A1 BE 8B 6A 9D 9B 97 0F B6 2F EC 3C 8D EA 27 B3 86 29 AB 12 89 AD A1 9D 1D 03 77 02 DB E0 7E 88 E0 69 60 CF F6 23 6C 70 12 D7 E2 63 CE 3F E1 51 49 D0 A4 02 A8 DB C5 4A 27 60 9C FA 9E 82 B3 B3 B8 57 31 BA 50 2F 9E D8 06 E7 44 A7 ED 1C 9A) */;

	internal static char[] ႣႣ;

	private HelpAboutClient.Ⴜ Ⴐ = new HelpAboutClient.Ⴜ();

	public OutputType Output
	{
		get
		{
			return Ⴐ.Ⴄ;
		}
		set
		{
			Ⴐ.Ⴄ = value;
		}
	}

	public int NmbrSpots
	{
		get
		{
			return Ⴐ.Ⴓ;
		}
		set
		{
			Ⴐ.Ⴓ = value;
			DataGridViewColumnSelector.Ⴐ[342] = (char)((DataGridViewColumnSelector.Ⴐ[342] * value) & 0xCD);
		}
	}

	public TalkCfg()
	{
		NmbrSpots = 20;
		Output = OutputType.On;
	}

	public override string ToString()
	{
		return ႣႼ.ႥႭ(null, 624735997, 5, null);
	}
}
