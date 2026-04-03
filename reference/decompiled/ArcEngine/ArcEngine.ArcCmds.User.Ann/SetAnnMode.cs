using System;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnMode : IArcCmd
{
	internal static ႳႤ ႤႣ/* Not supported: data(7F 83 16 E3 94 F6 6B 2F A4 79 C2 9B 5D CC BB A7 ED 78 97 95 C8 09 68 28 E9 86 8E 73 84 23 C1 0A 9B 49 A2 11 B2 7A F1 6F 14 58 50 C2 2F 70 DB 26 16 57 D4 13 B9 D3 8B 76 1B ED F9 0D 67 F7 AA 81 B7 B7 00 14 2A A9 F4 72 85 27 80 70 B8 A4 F7 78 A9 68 5C 2C 4E AD 50 C7 BC 2B F4 C4 80 E3 07 1B AD CE 0A 77 70 C6 FA 6B 62 61 8C 92 52 1A BC 76 F4 80 63 FE 9B 7D 32 09 67 38 56 FD B4 30 F1 A0 1F 64 C2 E9 9A 80 08 E1 6C EF C9 EB 20 BD 74 A2 6E 7E CE FE 80 08 7F 2F 9B 00 0F 37 70 FC B6 31 6F EB 72 EC 57 D1 DA 74 78 80 92 AB B2 46 E7 A9 C2 B3 8F 35 60 F1 1F 17 E4 93 4E 99 70 CF 71 6F 38 97 7C 34 4A 87 4A 9B A2 59 85 00 75 D3 7B 55 18 65 74 BB 6C 81 D0 7C CB 5A 07 C3 83 41 04 A7 0E 23 73 1A C8 B3 5E 3A 68 F2 91 07 6C 1F A1 11 17 F8 80 0A 5B B5 02 B5 C6 FE 67 EF 7F 86 18 60 55 DC F1 51 5F 60 8B 63 07 39 52 79 EF C9 10 AC B8 F5 AB 89 BF F8 4C 57 20 BC 53 C8 4B 6E B9 E1 D9 30 B0 8E 2C 4F B0 B5 6D 1C 03 22 63 87 C5 FC EE B9 36 89 D9 8E 9F 5C 90 99 30 A2 0D C1 18 98 7E 6F 9F BF 18 80 7F 68 44 F5 1C A3 F5 29 F3 98 F6 55 D8 90 37 2F 07 4B 8F 54 FD 92 1E 0E A7 AA 04 69 A3 F2 E7 05 E4 6E 3A CC 45 E3 71 FB 65 66 A5 97 AB B7 E7 86 61 4E 68 53 2F C2 82 EC 4A 36 4D 70 9E 8B 85 00 B0 F0 6F 6A 56 69 E9 23 D9 92 ED 96 EB 86 62 EF C2 7D 08 55 8A 93 D5 21 EB 4C 82 0F 95 00 5D D9 E0 A4 E6 B9 47 7D 30 F6 63 44 79 9C D4 EA 00 C3 D3 5C AD 20 82 30 75 1C 1B 4E 7D 09 E6 DA 8C D8 34 14 B5 47 9E A7 A7 45 4D 11 F0 45 1A 38 4C 01 4C BE 3B 38 51 3C 57 AF 2E C9 9E F8 FE 26 10 88 B6 A0 67 C0 34 B8 24 2B B4 68 D2 70 3F 2F 02 E1 02 7C BC 27 9E 53 86 F6 BB 06 18 D3 09 AE 46 26 01 67 8D 79 D0 8A CB 93 99 0F 83 E7 68 E5 70 FD C7 BB F5 81 69 E7 E9 63 19 6F 04 2E 9F 4F 21 05 22 AC 6F D6 A1 88 11 76 B0 29 8C 8E CF 9D 8E D5 94 19 0C 4C B8 C3 BB 18 7D 2A 60 60 86 9D F2 4A ED 7E C5 BB 75 98 5C 3F AA 7F CF 40 5A 5A 93 7A E0 2D 98 85 43 D4 4C 5D EF 56 59 76 28 AF EF 13 35 42 A0 50 D7 D1 60 FB BB CB A1 38 F2 7B BD 23 96 E4 7F 58) */;

	internal static byte[] ႤႭ;

	private static void Ⴈ(NodeUserCmd P_0)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(5, 1, 1157904086), P_0.Rx.Msg, 704, 654));
				goto IL_0059;
			case 2:
				goto IL_0059;
			case 0:
			case 4:
				obj = new SetAnnModeHelp();
				break;
			case 3:
				break;
			}
			break;
			IL_0059:
			num = ⴅ[6];
		}
		((SetAnnModeHelp)obj).Exec(P_0);
		object obj2 = new Publisher();
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴄႭ = ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		try
		{
			int num = 20;
			object obj = default(object);
			object obj2 = default(object);
			IComparable comparable = default(IComparable);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					obj = new Publisher();
					num = ((cmd.Rx.Split.Length != 4) ? (ⴄႭ[134] * 2) : (ⴀႳ[120] - 50662));
					continue;
				case 17:
					obj2 = SetDxFilter.Ⴀ(cmd.Rx.Split[3], 651, 'ˊ');
					num = 12;
					continue;
				case 12:
					num = (((comparable = (string)obj2) == null) ? (ⴃႥ[310] - 33390) : 15);
					continue;
				case 15:
					num = (ByeHelp.Ⴍ((string)comparable, ႰႥ.Ⴅ(7, 's', 952620617), 1008, 919) ? 4 : 8);
					continue;
				case 8:
					num = (ByeHelp.Ⴍ(comparable as string, SetStationClubHelp.Ⴍ(10, 3, 1747258298, null), 706, 677) ? (ⴍႭ[178] - 6005) : 19);
					continue;
				case 19:
					num = (ByeHelp.Ⴍ(comparable as string, ShowWxHelp.Ⴍ(':', 985808496, 2), 92, 59) ? 10 : 6);
					continue;
				case 6:
					num = 22;
					continue;
				case 4:
					DirectoryOwn.Ⴐ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 171, 130), ModeType.Open, 669, 711);
					num = 2;
					continue;
				case 2:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 0, 62058303, null));
					num = 3;
					continue;
				case 3:
					(obj as Publisher).Process(cmd);
					num = 5;
					continue;
				case 11:
					DirectoryOwn.Ⴐ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 93, 116), ModeType.Filter, 932, 1022);
					num = 0;
					continue;
				case 0:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(3, null, 1057161554, 7));
					num = 14;
					continue;
				case 14:
					(obj as Publisher).Process(cmd);
					num = 5;
					continue;
				case 10:
					DirectoryOwn.Ⴐ(TalkHelp.Ⴃ(cmd.Ⴍ().Cfg, 390, 431), ModeType.Debug, 241, 171);
					num = 1;
					continue;
				case 1:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(SetStationQth.Ⴍ(null, 1687352056, 5, 9));
					num = 13;
					continue;
				case 13:
				case 18:
					(obj as Publisher).Process(cmd);
					num = 5;
					continue;
				case 7:
				case 22:
					Ⴈ(cmd);
					num = ⴄႤ[135];
					continue;
				case 9:
				case 16:
					Ⴈ(cmd);
					break;
				case 5:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴈ(cmd);
		}
		switch (4)
		{
		}
	}
}
