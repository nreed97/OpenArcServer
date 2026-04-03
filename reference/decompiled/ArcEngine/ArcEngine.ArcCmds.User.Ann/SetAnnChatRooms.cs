using System;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnChatRooms : IArcCmd
{
	internal static ႳႷ Ⴄ/* Not supported: data(AF 06 B4 0F 65 90 5A 35 1E B0 6F 9F 7B B3 AF 34 1D 8B 44 61 CE 17 5B 43 20 57 9A 61 AB 7D BE 2A 6E C1 0B 81 FB FC 50 AA 67 4F B2 6D 6A A3 65 39 69 62 1D A6 27 1C 06 51 9F 70 63 93 D7 A2 F3 C5 52 ED 03 3F D8 C5 49 1F 2F FB AD DB 4C A4 61 13 A7 78 61 14 B0 C3 D7 A4 E9 41 D0 9D 74 15 6C 52 37 C2 D3 C8 85 81 6E F7 88 E6 B6 1B AA 43 FC 98 49 6C 00 57 EF D2 01 0A 47 83 75 62 0F C4 B9 F7 6C BE D9 51 08 56 1D 18 C1 9B 62 5E 8D 2F C0 E5 BD DC 99 E9 A9 31 05 3B 00 AA 91 FE 7B F7 97 C4 A9 90 B9 C9 CD 8E CB A7 DD 11 67 AB 69 DF 9B D1 57 FB DC 2C FE B2 2F A4 BE 08 4B 9A 19 90 31 16 51 50 F6 CB 6A E6 0E F0 C8 47 55 FD AA B6 D5 63 45 99 C3 9B B1 1A EE FC 0C EA A4 08 FA EE B6 6D 84 5F 57 0E 56 79 8D B9 A6 D3 44 1C DB E5 04 13 6F 72 6B 84 C4 1C E4 6E 62 AB 5C 8B 02 DD 71 42 80 59 77 1B B3 EA 09 DE 26 18 6C 07 CF 7C 52 93 0F 13 F7 2A 85 0E 19 76 B6 90 79 E2 8E E7 B2 F2 E0 3D 47 45 AB 44 65 FA F4 20 8A D6 89 42 0C 34 19 E6 66 D3 9F 7D 5C C3 91 E0 C5 47 71 B8 E9 0D BF BE 3E D8 6E A3 94 CE F0 1D F1 10 90 55 17 58 86 91 03 E6 7D A6 AF A8 BF 0D C1 6F 4C 82 F4 8F DC 9C 10 2A 04 31 1A 66 B1 46 9B E2 7C 21 F4 82 EC D8 A6 B6 EE F7 BF 44 CC 89 72 B9 C0 B2 48 CB 84 72 9B 00 58 B7 76 B8 0B 3F F9 18 C2 D4 EF 2C B6 EF 92 EC DF 68 F0 3A 0D 30 D9 99 4D 26 58 76 19 51 A9 ED 7F 26 80 B6 C1 16 57 52 37 C7 23 DC C1 B6 79 20 A6 F5 48 67 01 19 D0 10 49 CE 13 D8 42 33 34 DB 2A 36 23 0D 68 B8 D5 C9 E8 50 E2 83 4D 55 14 04 62 76 1D 5A BC 79 8B E6 E7 52 12 3F 59 90 96 81 A4 F3 22 9C F2 92 3F FC 87 B4 2D 20 63 39 34 DB B4 01 91 1E 52 23 7A 6D ED 13 E5 DE 49 1E CA 90 AE 07 D7 54 AF 63 2A 19 EE BD 42 87 C0 9C 9B A2 33 61 AC 12 F3 DB 19 6D 66 62 35 D0 91 CD 93 B6 ED D6 6A 97 2B 1D 27 32 21 45 02 37 AD 26 FC 15 BE D3 32 DD 21 C8 56 32 90 60 D1 E7 25 F0 7C 97 D4 3B F1 E8 DC DE 0E FE 62 DB 2F 77 A6 C3 61 6C 60 FF 56 F0 0C 9B DA A1 39 44 48 CC CE 78 7D 31 FF 50 BD 6C 8B 96 82 7C BA C1 20 EC A8 4B AA D0 2A 2E B2 4D 6A 45 BB E0 20 BF 69 6A 0A 42 60 79 85 22 77 44 45 31 73 79 57 F1 81 CF 30 DB BE 5F C2 D3 C8 B0 C5 32 CA 54 F5 9B D1 84 C2 D1 75 07 64 64 A3 96 56 E1 D2 F3 45 51 A3 73 C0 D5 B2 4F 48 9D 32 0E E4 CF AF 8D C4 31 EA E2 3F AD F7 94 4B AE AB 21 54 7F C1 FF 03 9B 59 FF 24 40 7C 81 8C 91 CC 36 BE A8 F2 10 5A B9 DD F6 B5 34 57 A9 EF 7B F5 3D 57 7C 7D 28 12 89 37 4E 1A 28 E1 AE B5 6E 92 E1 2A DC 25 E3 9C FF 80 4D FA 2D D7 F0 88 03 CD 9D 7D A6 49 7A 7D 05 00 D2 71 6C 09 65 7E 56 D9 5F 45 62 79 1A E3 CA CD C4 57 96 69 A6 7B D9 8C 26 C0 11 CD F3 92 66 C2 84 E5 0B 13 60 8F F9 72 D0 0B 91 6F B9 2F 23 FD 5C DF 81 0B 44 D2 08 E6 B7 6A 0D 8C 1B 60 50 6A BA DA A3 ED A9 82 D1 4D 17 FD D1 38 29 F0 EB A1 0D FD E3 E6 A9 3A 4B C0 35 AA 09 10 D9 C0 3B 2B 3A 45 8A C4 7E E8 91 6A 46 B9 80 0A 35 F5 40 00 B3 DA 41 7F F9 F9 DD 3A 1E A6 11 FD 12 63 B7 CA 7A 09 56 11 1F B0 82 D1 67 4B 22 44 4F C3 B2 AB E2 21 74 ED EB 73 EC 23 E7 35 6E 6D ED 53 53 CD A8 4B 08 A5 CE A0 2D A4 8E A3 89 F6 09 B1 39 D0 6E F8 68 82 1E 72 D5 7C D8 3D 4B B6 CD F9 FB FF D0 82 F2 6F D0 B6 DF 98 EA 60 56 ED D3 E0 17 00 3B 00 CC 3B AF 47 D2 CA 94 95 48 D0 59 CB 44 6C 54 2C A6 2C 35 EF 15 00 43 5B E5 BF 28 25 F1 13 4C 5E E5 DF 13 D8 FE C8 03 D1 79 45 DA 6D 97 6A A6 F3 EF 74 1B 9F F4 C4 9D B7 0D BA 68) */;

	internal static char[] Ⴀ;

	private static void Ⴐ(NodeUserCmd P_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
			{
				object obj = new SetAnnChatRoomsHelp();
				((SetAnnChatRoomsHelp)obj).Exec(P_0);
				object obj2 = new Publisher();
				((Publisher)obj2).Process(P_0);
				return;
			}
			case 4:
				return;
			}
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(14, 2, 1157903283), P_0.Rx.Msg, 640, 718));
			num = 1;
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		try
		{
			int num = 13;
			object obj2 = default(object);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					cmd.Tx.DistroType = DistroType.ToRequester;
					goto case 10;
				case 10:
					num = ((cmd.Rx.Split.Length != 3) ? 6 : 0);
					continue;
				case 0:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					cmd.Tx.Msg.Add(ShowWxHelp.Ⴍ('Ù', 985807363, 1));
					num = 12;
					continue;
				case 12:
				{
					object obj3 = new Publisher();
					(obj3 as Publisher).Process(cmd);
					num = 5;
					continue;
				}
				case 6:
					num = ((cmd.Rx.Split.Length < 3) ? (ⴄႷ[14] - 21593) : (ⴍႤ[195] - 62530));
					continue;
				case 4:
					obj2 = AnnHelp.Ⴈ(ShowWxHelp.Ⴍ('Z', 985808783, 2), SetDxFilter.Ⴀ(cmd.Rx.GetMsgEnd(3), 470, 'Ɨ'), ShowWxHelp.Ⴍ('l', 985808776, 5), 680, 'ʟ');
					num = 3;
					continue;
				case 2:
				case 3:
					obj2 = ShowContestStationHelp.Ⴅ(obj2 as string, SetTalkCount.Ⴗ(5, null, 1267022534, typeof(ShowTalkOptionsHelp)), string.Empty, 1008, 'Ψ');
					num = ⴀႳ[206] - 51393;
					continue;
				case 9:
					cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴐ(cmd.Ⴍ());
					obj = new Publisher();
					goto case 11;
				case 11:
					num = 8;
					continue;
				case 8:
					((Publisher)obj).Process(cmd);
					num = 5;
					continue;
				case 1:
					Ⴐ(cmd);
					break;
				case 5:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴐ(cmd);
		}
		switch (0)
		{
		}
	}
}
