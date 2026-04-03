using System;
using System.Runtime.CompilerServices;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing.UserCmds;
using Ⴀ;

namespace ArcClientEngine.CmdProcessing;

public sealed class UserCmd
{
	private string Ⴗ;

	private ႥႼ Ⴃ;

	private string Ⴓ;

	private string[] Ⴗ;

	internal static ႳႷ Ⴀ/* Not supported: data(A2 B8 43 45 08 3F 06 6E 26 77 B1 83 21 D1 D4 8D 51 00 24 10 8D 16 57 0D 03 02 70 CC 9E 61 7A 23 06 61 34 73 33 37 A3 02 F9 9E 46 4A DD DE 80 A6 36 57 DD F8 09 E6 D0 8B 60 36 42 06 CD 38 CE C3 FB 8D 7C BE 9C 60 59 19 5C 22 16 EE CE 0C 2E 23 80 C9 96 46 82 81 19 1F 90 A7 12 FC F4 9D 33 C1 CE 82 4D 4F 61 C0 0A D4 FD C4 9B E6 D0 E1 BC 54 07 1E 84 04 A1 88 40 7A 74 5D 2E F3 4E 5C 23 BD EE 54 1F 4C BD DE C0 BE BF C0 48 BD E4 32 4D AE EA BD F4 D6 18 2F 1F 46 41 D2 DA 04 92 15 86 A1 A0 DC F7 7C C1 6F 95 28 5C C5 44 E0 3F 82 94 41 0F 7F 09 8F 66 4C A5 BE 34 D8 0B EA 04 BC 2C A9 3A A5 1D 07 3A D0 EB 7A 28 CC 79 52 E9 3E 06 BE 3D 98 F3 12 0C F5 3B 53 37 38 47 E8 64 AA 23 9E 98 99 A5 99 65 8D 07 3E 92 8D 67 98 D2 52 D4 F5 D1 4B AC 6B C8 19 9D 43 6A C8 CE 01 88 03 16 7C A9 DA B8 4F 97 6C 59 AF 90 B5 7F 7D 8D A1 80 E3 63 51 16 18 FD B7 D5 7F FA 62 2E 9B BD 05 B4 8E 76 E9 EE F6 98 84 5D 64 F1 FB D9 13 99 1F B5 C7 47 EA 9D 37 EC FC 7E F0 04 39 53 35 3E BC F1 8A 00 EF 07 A2 B2 88 4A DD F2 B0 25 01 DD C2 E5 DB AB 65 53 D2 66 7D A1 78 6A FC F2 5F 30 28 26 35 0A 4E 12 A8 18 12 14 BE 9F BF 43 3B D7 7D 13 41 53 77 88 D7 68 1F 23 82 4D 8D 37 B5 95 EA AD CA 89 EF F6 8E AF 3C C2 99 50 94 32 A6 39 66 A0 EC E8 B1 0B B7 9E 4E CB EA 2A 8F 5A 8A D9 5E) */;

	internal static byte[] Ⴅ;

	public string TxMsg
	{
		get
		{
			return Ⴓ;
		}
		set
		{
			Ⴓ = value;
		}
	}

	public string RxMsg
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return this.Ⴗ;
		}
		set
		{
			this.Ⴗ = value;
			Split = ႳႳ.Ⴄ(value, new char[3] { ' ', '/', '_' }, 81, '\u001e');
		}
	}

	public string[] Split
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return Ⴗ;
		}
		set
		{
			Ⴗ = value;
		}
	}

	[SpecialName]
	internal ႥႼ Ⴈ()
	{
		return Ⴃ;
	}

	[SpecialName]
	internal void Ⴈ(ႥႼ P_0)
	{
		Ⴃ = P_0;
	}

	internal UserCmd(ႥႼ P_0)
	{
		Ⴈ(P_0);
	}

	public string GetMsgEnd(int start)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = Ⴅ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			int num = ⴀႠ[61] - 26821;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[98] - 39645;
					continue;
				case 1:
					break;
				case 9:
					comparable = Split[start];
					goto case 2;
				case 2:
					num = ((ႳႳ.Ⴓ((string)comparable, 'Ȯ', 520) <= 0) ? 8 : (ⴀႠ[127] - 365));
					continue;
				case 4:
				case 6:
				{
					int num2 = HighlightSpotterCfg.Ⴓ(this.Ⴗ, comparable as string, 193, 240);
					return MultimediaCache.Ⴐ(this.Ⴗ, num2, 'Ϲ', 'Κ');
				}
				case 8:
					start++;
					num = ⴅ[17];
					continue;
				case 0:
				case 7:
					num = ((start < Split.Length) ? 9 : 5);
					continue;
				case 5:
					return string.Empty;
				}
				break;
			}
		}
	}
}
