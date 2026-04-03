using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcIo.Arc4;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

public sealed class ShowQrzHelp : IArcCmd
{
	internal static ႳႳ ႤႨ/* Not supported: data(9B 9C D4 6F D2 AB CC A6 0B 0F 06 41 1A C1 7C 35 5C F9 33 98 6C 5E 0A 0A A8 6B 31 8E BC 96 CC D5 B9 D6 57 D6 1D B2 38 FC C7 A6 03 6A EA 71 D3 0C 67 C6 18 1B 8A EF 28 3D 91 CA C5 67 7A 3E E9 74 41 30 86 42 69 A4 18 A8 C0 36 CF C5 5A 9F 1F 36 96 24 26 F4 7D B1 4A C9 AE 1A 44 52 EC D0 81 89 BC 8E 28 BA E9 90 A2 C1 AE 6F 5A 53 1F 62 E2 F0 AA 8E CF 56 17 F3 F5 8E E4 BC 93 4E 5F C5 BB EE B3 46 08 CA 76 64 4C 05 80 63 46 0E 56 F6 A9 4B 37 53 A6 5D 01 2B 71 C7 97 98 D4 2D FC 53 61 E8 B3 6A 9F D8 59 17 79 46 42 C9 D4 B2 AD E7 38 ED 12 48 17 0C 1E 5D ED 87 D3 40 32 DC 8E 1E 08 2D 01 5C 5A EB 57 D0 F1 1F D8 5F 1A 37 56 BE 1A AE 60 E6 1B B4 3C 55 C9 55 7C 17 04 19 E3 9C B7 23 C0 A7 B0 50 8D 4C 96 40 55 F6 33 BE 43 B6 31 14 25 82 7C A6 03 53 F0 AB 92 04 6E 3F CC D7 3B 3C A7 F5 75 AE 0E C9 20 14 50 D9 5E 44 21 0B 11 C5 E5 EE F2 60 1F 10 20 6C B5 04 BC 88 DC 56 73 7D BB F6 16 4C 40 81 06 5B 62 67 55 28 F4 AB 8A 87 F2 A8 59 DC E3 D9 1C 96 D5 08 F7 09 0C 97 36 F9 66 E0 88 29 F3 C4 85 63 E7 97 FD B7 BA F6 77 0A 79 35 95 34 FB 95 98 E0 DA 7F 76 37 88 FC 4F CA 30 5B C1 14 22 60 93 2D 22 F5 F3 4C DA 64 DB DD 90 ED 8F D5 01 02 FD CF 47 A6 4E 73 4E 4D D9 EA 48 33 86 5E 34 63 E6 18 A1 67 11 05 A1 4B 06 76 A3 97 A6 9A 6C 78 C8 2E 5C F1 CB 7B 12 1F DE D4 1B 08 04 A6 DD 7C A8 2D 06 77 34 98 EF F8 2D FA A0 D7 CF B5 A5 3F 7E CE 6A 57 02 42 96 6B 05 82 88 3C E8 98 47 5E 97 26 ED 79 94 F4 44 30 3E 63 C3 CF D9 3A 4E 28 2E DB 89 34 3C 85 79 66 95 99 71 B0 0F B3 0F 93 B3 41 3F A9 C7 2C A9 88 89 39 18 9D 7D C5 90 CA 33 5F 0D 0C 0F 12 22 12 AB 87 E2 F9 82 92 20 8A 54 30 1C 98 FA A4 60 01 32 01 A9 02 6D DB E7 CF 09 A6 7C AE A5 02 84 A0) */;

	internal static byte[] ႤႤ;

	public void Exec(NodeUserCmd cmd)
	{
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 1;
			case 1:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267023439, typeof(V4NodeParser)));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133719, 4, '='));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(11, null, 1057161588, 0));
				num = 0;
				break;
			case 0:
			case 4:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			case 2:
				return;
			}
		}
	}
}
