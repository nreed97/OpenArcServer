using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Talk;

namespace Ⴈ;

internal sealed class ႨႣ
{
	private List<ႨႳ> Ⴓ;

	internal static ႳႣ Ⴗ/* Not supported: data(31 97 6C 5E 1C CC 0D FB 2F 79 72 83 41 E2 02 83 E1 0F 8B 8C E6 03 47 C5 CA 4F 89 96 80 43 4F 84 17 9D 55 86 B8 B3 1B AB 2F 2B 9B 16 39 61 40 02 9E 50 0C A9 80 A8 7C 2D 50 A6 92 CC 42 76 7A EB 2A ED 6C A3 8C 7B CA 2D F2 DF 5D BB 67 31 8C 68 0E 87 F6 30 37 A5 03 6D 20 28 35 11 20 4D 68 B8 AF AF EA 4A F4 9C 74 22 84 DD B5 A0 4B C0 C5 1F 1A 29 BE BA 7E 4A B3 84 E9 FD 82 64 45 B8 0D A4 76 A4 0B B6 45 41 73 70 12 D4 AB 59 EE 62 22 5E 62 16 F6 F5 8E AD 39 64 FA 66 60 F5 19 10 DC CA CF 10 29 A6 B4 0E D8 D7 B5 4D A7 A9 9E 5A 94 87 DB 23 02 2E C1 16 16 C7 6A A5 BA DD E0 7C 56 02 F6 DF 88 DD 38 7A A9 53 3C 1E 40 40 06 8F C5 A0 D0 D7 1A F5 0D AD 09 B9 F9 60 3C 0F 52 F9 F6 38 F5 A5 B1 BE D1 B6 4E 60 79 AD F0 A2 D5 D4 C1 D9 DF 1A 0D 08 62 60 F3 48 D6 CD E3 D6 3E 99 00 41 26 07 49 60 DD 07 CD 1A 89 B8 7B 5E BB 65 E2 24 9D 62 2E 38 EC EE D5 95 B0 68 E6 03 D2 76 22 DE AD AF 7C CD 8A 61 FA D7 4B F1 7E A8 E4 95 8C 70 E9 BE 38 DB 6B C7 54 37 31 B3 AE 74 1F C9 47 12 96 9B B0 0C E8 15 99 3B 66 55 EB FA 6F 2D AF 1B DB 76 18 13 3E 46 73 E4 5B 44 9C D5 B2 86 B8 80 AA 6C 11 48 E3 7F 87 D4 25 FB 74 15 DA 58 C7 04 04 93 98 A8 B1 33 D3 50 28 CA B0 A3 77 C2 88 DF 9C 6A 50 03 1B 66 36 5B ED 43 ED 41 D0 5D 0A 02 7B 98 D1 1E EC 0F CE 76 98 C0) */;

	internal static byte[] Ⴐ;

	private ႳႠ.Ⴜ Ⴄ;

	[SpecialName]
	internal DateTime Ⴈ()
	{
		DateTime ⴐ = Ⴄ.Ⴐ;
		SetTalkCountHelp.Ⴅ[168] = (byte)((SetTalkCountHelp.Ⴅ[168] * SetTalkCountHelp.Ⴅ[279]) & 0xD9);
		return ⴐ;
	}

	[SpecialName]
	internal void Ⴈ(DateTime P_0)
	{
		Ⴄ.Ⴐ = P_0;
	}

	[SpecialName]
	internal List<ႨႳ> Ⴀ()
	{
		return Ⴓ;
	}

	[SpecialName]
	internal void Ⴗ(List<ႨႳ> P_0)
	{
		Ⴓ = P_0;
	}

	internal ႨႣ()
	{
		Ⴈ(ShowAnnHelp.Ⴅ('Ϳ', 846));
		Ⴗ(new List<ႨႳ>());
	}

	internal ႨႣ(string P_0)
		: this()
	{
		object obj = new ႨႳ(P_0);
		Ⴀ().Add((ႨႳ)obj);
	}
}
