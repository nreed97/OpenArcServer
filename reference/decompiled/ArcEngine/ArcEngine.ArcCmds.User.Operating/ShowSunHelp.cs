using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowSunHelp : IArcCmd
{
	internal static ႥႷ ႣႤ/* Not supported: data(02 6E 7A 05 54 60 60 B2 25 68 D2 31 C3 4E 81 16 53 41 1B B4 B7 A2 C6 29 3E 96 C0 1F 6B 44 90 9F BE B0 12 F5 9E BF F6 7B 34 41 98 98 DA B4 8F D3 6D C8 91 03 DF D1 B7 22 FF 67 CD 41 F4 E5 F3 47 0B 4B E1 71 FF 53 20 47 88 E0 C3 B5 D7 64 33 3C AE 81 DF 06 59 B1 EE 2C D6 F5 F6 AD A7 9C 14 06 06 98 63 6B D6 5C 88 A3 6B 8E 8C B6 59 AF 68 D5 9F 50 C4 8C F1 E9 93 64 F2 5F 0B 2C 80 AE 85 FF 26 CE C3 5A BA DE 5D 24 C0 CB 4A FD 06 BF F9 FA 3B 90 6B 83 46 FA 54 3A 3D E7 EB 87 B7 DD 77 1A E8 66 CA CB AF 8A 9B FC F5 E4 6B 42 87 B9 7D 94 86 C2 95 7E 80 F6 C4 53 D1 CB 43 00 3F DC A2 55 5E 58 D3 B1 C7 5E 12 9B 3A CF 4A 78 53 3A BB 9A 5B AC DC 61 4D 13 FF 0A 45 BC 05 75 29 EE B2 C8 0B AF 7A CF AA FD 26 94 5B A1 E4 B1 8F 1A BA 8B 3B A1 3D 4A D5 61 2A 4D CA 06 42 6B 28 2F F7 8F 2A A7 A4 A4 F5 E1 6A 35 24 29 A4 42 3B 4B 9C EE 77 91 F3 EF 3F 50 19 83 1E 2F 87 AE 36 D8 81 4D 6B 90 CD 2D B7 A4 56 FC 98 02 19 48 45 B4 78 A6 43 97 0C D3 D6 F9 FC 84 75 16 27 ED F1 93 19 41 B3 32 54 83 D4 63 A1 17 0E 93 BF B8 8D 9F 67 6C 3E 84 0D 0F AE 02 67 B1 A4 61 75 97 9B 5C B2 F2 05 72 53 14 BE BC FB D8 89 C6 D1 32 5F 8D 10 5F 5D F0 7C 3B 25 9E 17 56 CC 48 3D C6 27 D8 4F A4 02 5C 26 0F 65 50 C8 AB B3 4A 95 C0 72 BA AA D7 3E 8E 50 38 17 78 89 F3 6B 45 DE 02 D4 44 CD FF 70 76 24 07 F6 12 22 02 68 30 F4 BA 8F 7A E1 FF F4 F5 C3 04 42 27 92 57 99 1A 76 49 9A 23 FF BD E5 36 5E 5E 65 55 7D 52 0F 47 D1 B0 FE A7 6F B1 E0 59 12 E5 BC 4A 38 8E B9 BA D5 99 A5 19 7E ED A7 F6 57 9E A5 DF A8 41 46 B3 04 D6 E6 73 0C A1 96 94 83 50 D3 B5 F0 45 52 99 DF 62 11 BD C8 44 B6 14 16 BA A3 BC 0B E7 78 AD 55 F2 BD B8 9D C5 25 5F 86 61 41 A8 54 4B 37 70 55 EC 27 45 1F 5C 1C EB C3 39 E9 60 41 7C CF 69 F0 E1 B9 0A E0 60 76 EA 57 B4 E6 BD 8A F6 FD FA 0E 62 1C 18 FF F6 01 28 F4 05 82 79 A2 00 31 DD 99 32 06 40 52 04 98 E5 08 1A 82 E2 C0 51 C3 2D 91 28 D4 30 40 A8 5B 0B B3 59 D2 5A 8F 5F F5 01 CF 40 F7 DA C4 32 5D AF C3 5B 93 FC 1F F9 6E 34 31 C2 9E CA 15 FD 6A 49 40 B1 53 23 43 6A D2 72 85 44 ED 7E 83 B8 BB F9 97 5C A7 96 C7 4F 6D FF F8 B8 1C 33 E5 C1 82 83 A6 15 2F EB 49 A1 3B 07 8B B8 09 F5 30 E7 FB 2A BD 46 44 51 6D 81 04 36 E6 46 E2 CF 66 23 68 4F 6B E5 55 08 81 7C 3E 05 90 C6 6D 35 D5 C6 C5 DA 4E A2 D2 65 5C A5 27 AA 30 8B 56 33 64 F6 A6 28 AE 3A 9C 75 C8 1E 01 D7 54 29 DA F5 DD 90 36 BC 21 3C 47 3F 15 2C 40 F3 7E FD 7E 82 D5 B2 B4 8C 40 73 5F 00 01 1A A2 B0 99 B6 A7 BC F1 BC 37 E0 59 24 83 C6 EB 64 B9 52 AC 4F 09 3D CA 9F 67 13 DF 5A C7 58 55 FB 48 D1 19 B1 64 4C 13 26 8F EF 77 77 4A C0 1B C9 49 87 58 09 94 D3 46 DD CF 1F FC B2 A8 18 E6 36 D0 8A 54 19 C1 45 0B 72 06 7E AA B8 8F 3E A7 B2 D0 62 EF 90 24 3E 89 6C 17 FF 7B 9F) */;

	internal static char[] ႣႠ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267013713, typeof(ႰႼ)));
				num = ⴀ[408] - 3038;
				break;
			case 6:
			case 7:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130528, 7, '¼'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(25, null, 1057167004, 2));
				goto case 2;
			case 2:
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, '\u00b4', 952616267));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 8, 62062040, null));
				num = 4;
				break;
			case 4:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(5, 7, 1217940535));
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, 'r', 952620888));
				num = 1;
				break;
			case 1:
			case 3:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			}
		}
	}
}
