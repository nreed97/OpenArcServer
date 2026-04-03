using System;
using System.Globalization;
using ArcShared.ArcCfg;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsNumeric
{
	internal static ႰႳ Ⴄ/* Not supported: data(5C D5 C7 0D 0D FB 5C 4B 05 5A 3E 6D 96 87 FC 71 85 7A F7 87 61 9B A0 D4 31 3C 02 F4 45 D4 72 34 2F 13 9C F8 62 E3 6A 32 C8 65 33 54 A1 4C D1 B7 F7 04 76 3A FB 5E 14 AE D0 8A 84 37 5E EC 21 4A AD 96 B1 66 1D F4 50 04 F5 9C 0E 0D 73 9C 94 F6 91 98 41 40 36 92 E1 33 BB 6C 02 EC B8 FE D3 FD 0F 39 7A 4F 54 F6 FC A7 EC A6 54 C1 69 53 28 81 24 C1 3B 43 64 46 8E 1F 42 0E 80 D9 2B E7 01 43 97 9B 3F 51 F2 3D 7F D5 E3 FF F4 CF 7C 97 21 06 29 5C CC EC D8 99 87 25 FB C1 C0 18 16 4B F4 18 BD 3B 27 61 05 75 55 3B 2F 41 62 44 33 A3 57 D5 47 13 F4 72 2A 43 B9 59 A8 C6 E4 7C 52 E8 0F BF 14 59 34 4F 48 98 7B 1B 0F AE 39 29 EF FD 19 69 FD B7 32 F0 D2 4B 1F BA 7C 27 E2 2D 2C BF 64 A8 24 F8 70 2D D0 E3 1A AD 7A 64 D5 AB D2 01 34 57 0B AE 99 68 37 C2 EF 8C CA 8C C2 3D 77 3F 43 DF 7A 04 C7 DA 71 CC C7 72 76 80 9B 2F E3 6A 83 12 37 63 EC 0B 56 83 FB 50 8E F8 13 E9 DB AD 64 E5 C7 B3 C5 9A 94 61 38 99 13 99 38 3B 95 5A 3E AD 61 4D 14 41 6E 6D 76 45 01 67 00 71 4D DC 3B 7A BB B0 8D 6C A4 B5 B4 4C 6F 61 64 4C ED 27 89 C8 8C C2 4D D1 E3 49 8E 58 7F 28 D6 B0 A4 5E F6 C4 BD BA D1 DC 26 D9 04 F2 2D DC 3D A6 30 46 41 C9 32 80 33 1F 65 25 62 3F 2B C2 6D 25 80 AB 36 F2 9D 2F 1B 09 3E A0 00 8C 6F 33 27 61 F4 83 62 67 D8 72 09 99 AB D6 C5 C7 54 F1 07 02 BE 84 8A 9C 6E E2 77 A8 B7 8A 2E 8A D8 97 48 EA 0D 9E 7D 0A 5D 26 62 EC 81 CC 3C 42 FF 26 89 E8 5E 06 1F 9D CC 25 AB 57 F0 28 63 1F 98 10 A3 D2 87 91 96 59 DC 58 C3 71 2C 7F 23 43 91 CF 6A 7E EC D7 2A 7E 73 9A DA 88 F3 5C B4 19 B4 9A 51 21 5D 5A 54 45 0D 6B C1 95 A3 65 0B 47 A5 94 B8 41 63 40 4D 8A AB 92 8C 39 F8 A1 A8 99 15 D9 5A 65 F2 8B CB 0F EF 16 21 31 52 31 14 26 1C 6B E9 5A EA 3A F1 A7 76 14 56 4E C7 A7 23 9E 95 8B A9 EC 6A 02 7A 04 4D FD 9B E3 55 B4 D6 7A FF 6C 7B 4A EF C4 24 17 60 31 DD F4 77 B0 05 96 70 DC 44 3E 13 A5 18 35 E7 FC 28 4D C4 02 93 69 FE EF 49 34 37 DA 23 10 D6 5A B1 BD 95 32 4E 46 EF 99 3E A2 B7 FE 01 A6 21 37 7E 9D 59 9C 79 F5 04 B1 1C 11 CA A2 72 CC 30 6C 2E 1A B3 F4 3D 76 71 AA E4 A4 7F CB 30 D6 41 A9 AE 72 3B A1 6C 3E E4 E9 D6 98 7A 14 04 C9 64 09 31 A4 FF 1F 4C AF E6 17 A1 7E 33 7D 20 8F 25 F6 75 0A E3 5E F1 3E E9 A1 98 AF 13 84 CA EB 5C AA 50 36 61 FD D0 D5 94 3F F9 63 B1 65 F0 B5 31 F2 63 5C 0C 9D 40 27 02 01 4A C0 1B BC 4A 9E 04 89 54 D3 15 EC D2 0C 1B F1 7C F3 8C B4 8E ED F9 9C 92 65 17 80 FB 9F 01 46 8D 8C 47 34 A7 F9 9A EE 6F B5 0E 94 94 B3 74 9B A8 3E 6F 89 69 A5 80 3E 0E 6A 1A BD 81 BB 94 E1 F2 55 1D 8E DB 35 59 4E 98 C0 EC B5 93 CE 81 C3 41 77 AE FA DF B6 C2 81 D3 0F D6 38 01 DA E1 E3 B4 C5 EF 6F A3 65) */;

	internal static char[] Ⴀ;

	public static bool IsNumeric(string t)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		Array array = default(Array);
		int num2 = default(int);
		while (true)
		{
			int num = ((UtilsCallsign.Ⴓ(t, 787, 804) != 0) ? (ⴃႣ[82] - 17732) : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 8;
					continue;
				case 8:
					break;
				case 6:
					return false;
				case 7:
					array = ArcLogInRespExt.Ⴐ(t, 610, 547);
					num2 = 0;
					goto case 11;
				case 11:
					num = 9;
					continue;
				case 12:
					num = (((array as char[])[num2] > '9') ? (ⴗ[135] - 48371) : 5);
					continue;
				case 5:
					num = (((array as char[])[num2] >= '0') ? 2 : (ⴀ[305] - 48551));
					continue;
				case 10:
					return false;
				case 2:
				{
					int num3 = num2;
					DxCfg.Ⴗ[67] = (char)(DxCfg.Ⴗ[67] & DxCfg.Ⴗ[148] & 0xEE);
					num2 = num3 + 1;
					num = 9;
					continue;
				}
				case 0:
				case 9:
					num = ((num2 < (array as char[]).Length) ? (ⴃႭ[85] - 1587) : (ⴗ[72] - 50240));
					continue;
				case 3:
				case 4:
					return true;
				}
				break;
			}
		}
	}

	public static bool IsNumeric(char c)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			int num = ((c > '/') ? 1 : 2);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
					break;
				case 0:
				case 1:
				{
					int num2;
					if (c < ':')
					{
						num2 = 6;
					}
					else
					{
						char num3 = ⴗ[148];
						NeedsCfg.ႣႤ[57] = (NeedsCfg.ႣႤ[57] * WxCfg.ႣႭ[120]) & 0xF3;
						num2 = num3 - 25104;
					}
					num = num2;
					continue;
				}
				case 6:
				case 7:
					return true;
				case 2:
				case 5:
					return false;
				}
				break;
			}
		}
	}

	public static bool IsFloat(string val)
	{
		double result;
		return double.TryParse(val, NumberStyles.Float, WwvSpotExt.Ⴗ(880, 'ͼ'), out result);
	}

	public static bool IsDouble(string val)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		double result;
		return double.TryParse(val, NumberStyles.Float, WwvSpotExt.Ⴗ(127, 's'), out result);
	}
}
