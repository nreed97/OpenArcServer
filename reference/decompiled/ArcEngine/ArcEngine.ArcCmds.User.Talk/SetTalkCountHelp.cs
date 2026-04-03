using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcIo.Arc4;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Talk;

public sealed class SetTalkCountHelp : IArcCmd
{
	internal static ႳႨ Ⴍ/* Not supported: data(E1 24 04 BB EF 2C 00 E4 77 FA D6 9B D6 2C 5F 3B 5F 1E F0 A7 0A 0F 2F C1 D7 4B 3A 41 3E CF AA F5 5C 2D 93 F3 B0 EE BB 54 6F F6 BA 30 EF EE 11 77 3D 8D 64 BC 2A DC C7 D1 F4 41 E2 A4 F0 BD A5 A6 50 DF 3F A8 98 6B 89 70 61 9B 38 13 54 FD D0 E8 39 C2 04 B0 6A EC CB 7E 65 C0 FD 6E 0B 16 62 B0 50 13 DF 10 AE 68 DD D1 03 F3 5B 8E A3 B3 7C F6 70 F8 6B 2E B9 F4 3C 62 14 BF 42 D7 6C 1B 64 4B 38 86 C1 41 1E C0 3A CF E3 31 AC 76 91 3C D9 B1 43 07 FD 12 AA 34 F6 5B D6 7C FB ED 26 06 64 E7 8E 0F 56 1D F0 3B D8 AE BE 9A 4A 87 48 C4 D0 D6 E5 90 93 64 1D 52 9F 03 8F 66 6A A0 C4 4B A9 DC CC C4 E6 81 E5 BC BF 07 2E 4E 52 0F E9 6E 13 11 AA 24 08 94 71 FE C9 3C 6F 52 8D 89 D0 37 E9 73 F0 6C BA 83 DD 4F F0 28 D0 8B 36 CD FE 8F 19 20 53 59 F4 9F 43 14 6B CC F9 AA 12 92 2F 35 36 F6 64 DE 1E 7D B3 8F 32 5B 33 DE C3 E5 C8 FA 3C DE 39 6C 36 77 41 4A 2F DB 01 EC 88 32 3D 5D F8 9A 54 3F 69 20 71 9B 6B C3 26 99 6B 63 4F 84 04 FD 6E 32 59 C1 FE BE B4 1A AE 41 7C C5 06 00 1E D4 E5 29 90 88 91 1B 6C 9D 01 71 50 A7 DD CB 8B 7B E8 8A C3 0A 04 36 9B 95 8A 4F 71 2F 1E A5 BD 26 7A 96 7C 26 F3 7A 6C 52 C4 BB C0 8C 6D 0C 3C E1 B5 01 DB 7B 3B 14 D0 AE 8D F9 FD 41 A9 3D 7E 5A B3 2A 2C 46 4F 64 86 6E 1D 71 44 48 75 0E 27 7D 13 8E 79 1D C8 41 E9 66 C4 CD 98 F9 7B 2A A7 87 3C 65 D7 43 DE F4 92 50 79 6C 5D C8 CE 88 38 7E D2 80 2E 1B C2 60 91 71 3F C5 81 81 CB 8C F2 F2 C9 BB 0B 10 35 E3 9D 1E FA 29 A3 5B E3 21 96 3C 94 1A 26 FA FB 8B C3 DB D3 66 03 19 72 11 83 EC 79 69 FE 12 7D 28 48 ED E1 0F 1F 99) */;

	internal static byte[] Ⴅ;

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 1;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 0;
			case 0:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267017927, typeof(ProtocolCache)));
				num = 5;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131598, 0, '\r'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(5, null, 1057165103, 0));
				goto case 6;
			case 6:
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, '\u0012', 952622934));
				obj = new Publisher();
				num = ⴀႣ[119] - 39462;
				break;
			case 4:
				((Publisher)obj).Process(cmd);
				ႨႣ.Ⴐ[401] = (byte)(ႨႣ.Ⴐ[401] & ႨႣ.Ⴐ[318] & 0x60);
				return;
			case 3:
				return;
			}
		}
	}
}
