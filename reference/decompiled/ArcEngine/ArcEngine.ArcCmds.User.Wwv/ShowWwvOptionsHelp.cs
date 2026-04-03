using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wwv;

public sealed class ShowWwvOptionsHelp : IArcCmd
{
	internal static ႥႨ ႣႭ/* Not supported: data(6A 57 C3 70 22 4E 7F DB 6B 7B E3 31 C9 EB 7E F7 39 D3 61 1F 72 8D D0 07 44 78 DA 90 E6 98 0E 25 95 6C 4D A9 60 CD C9 77 57 40 E4 1E 7B 0D E9 2C D7 FB DB FE 1B 0C F9 E7 CA 47 7C DD E7 B8 65 70 37 91 AC BA 5B 74 D3 3C F9 61 E2 29 86 60 2C 9F FC AE D5 C7 A3 BB 26 0B 29 37 53 EB 0A F6 77 D8 BD 95 D9 72 E4 D5 7E 98 6B B6 71 C3 8B BB 85 38 48 63 39 21 A7 DF 8F 7C C7 25 D0 03 B3 AF BC F5 78 66 0C 1D 98 76 96 BD 7F 1C 12 5C 14 C3 B3 42 C7 48 34 2E CB C8 80 78 3F 63 54 02 BF F5 84 10 D0 08 A3 33 3B 52 F0 D4 97 07 69 20 F8 B9 C4 CD 20 FF D6 3B 8A D9 C0 40 39 4A F5 E3 64 79 2C AB 21 18 E6 C5 AD A4 1C 1A BA 74 74 38 F7 BB AB 39 C4 AF 31 93 B6 4F 37 88 A5 FA 0A 43 44 D5 F4 60 78 2B 23 CF BE 73 22 F2 93 B1 C2 DA 24 EE 0F 46 12 63 D2 A8 74 BE A7 E0 87 82 53 82 78 F8 D0 64 CE B4 9E 1D 5E 60 58 9D A6 5D A2 DB C8 9B 5B D0 AB 77 90 18 2B 25 65 74 B1 D0 C1 31 1E D3 16 BC 90 66 95 78 47 15 15 7B 37 70 41 87 97 F9 5E 3D C0 D7 9D 5E 09 B7 E7 CB FE 79 4F DB 23 B7 71 2D B7 9A E4 EA 67 D3 06 DD AA E2 EC 37 4D 03 D5 4F 5A 33 62 A3 77 7A 03 99 96 B5 BF 79 5C 75 51 31 B3 D5 5E 02 17 7A F1 09 0B 6D 62 7D 98 F4 8D 2D 05 24 00 23 96 C5 07 FF 99 24 DF CF 5C 56 5A 9C 6C 61 B9 F7 AC D9 CC E5 59 5E 16 F6 6A D9 A4 2E 47 75 71 C5 BA 47 D4 CC CA 0C 94 60 C6 87 01 5E 40 E9 B8 85 32 F6 A0 77 37 61 31 AD 64 C0 55 1D 4B F6 DA A5 01 B9 AA BF 54 72 45 04 3C 2B 79 63 05 4D 1B DE 96 37 DC BD 11 A0 8F 8F F6 D2 9C DF F2 28 72 4B A8 94 99 A7 A7 35 C4 27 C2 20 6F C3 38 9B 95 67 C7 15 DF 9E AC D9 BA DE 23 3B 39 B4 54 37 57 BC 7F EF 7D B8 14 3D C0 19 4F BC 02 71 34 9A 3F E4 CE 7F AD 2E FD 28 E9 C9 EE BD B1 59 C0 B2 96 16 AE 4E C5 15 88 18 CB 18 AC E7 87 CE 17 85 90 F5 71 24 BE 0A 7D EE 5B 8C CC 89 49 6E F8 A2 5C 83 87 86 B8 E3 0E A0 79 1A 87 A2 31 0F 22 8F A6 23 64 0D 66 51 F4 A7 13 F2 72 9A 4D D1 A5 A9 14 BC 1E EC 15 C3 0B 90 5D 25 B1 9B 89 1E AA D4 F7 20 65 33 83 47 4D F5 90 B1 84 82 D9 0D 73 5A 84 11 B4 8B A0 A5 62 43 35 DA A1 B9 46 98 0E 74 7D 3F A1 86 E1 F4 67 0B 45 96 93 26 02 93 1E 5B 23 53 18 61 68 32 3B A0 B6 C6 3C DE 9A 7D AA E7 FE 67 0E 0F 16 7F 12 E7 03 5B E2 19 91 DD 20 A1 8A FF F2 F6 6F 96 5F 66 D0 F4 EB 8D 6F CF 73 02 D7 53 07 4F 8E 50 BB 9E CE A6 22 13 64 3E 63 FA 62 A0 64 EC 2A A2 78 50 1C 50 9C 6D BB 93 47 33 1A 0E F5 BD 63 DB 26 CB 8A 3A 33 B1 0A 19 9A 25 0F A9 C0 53 DB 0B 51 9F 23 90 A3 2C 4C 66 36 C5 A7 91 F5 2F 64 4C AE 77 AE 8D DD DE DB 40 DC 54 A8 D0 B2 84 B0 46 9E 6E B6 77 19 8D 04 51 EE 91 37 63 28 63 44 58 DA 36 87 B2 48 04 E7 C7 A3 A2 FD 35 F3 2A AA F5 0D 53 46 07 12 9F 40 6A BE 73 18 86 F3 DC CF BE 26 20 37 21 0D 1C 97 A5 3B 2F 1A 7D 87 86 7D FA D7 B5 83 6A 6B AA E3 AD F6 1B BC 02 EC 79 1A 3C FA 2C 5E D4 71 2F AF 12 5E 8D 0C 68 BF A9 B1 41 BA 62 32 E9 CC ED 95 4D 96 31 71 1A F1 D2 85 E8 C2 9A 48 CE DD 30 B6 70) */;

	internal static char[] ႣႥ;

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ႣႥ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(7, null, 1267022168, typeof(SetDxArPc)));
				num = 0;
				break;
			case 0:
			{
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134098, 6, 'ü'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(22, null, 1057161778, 1));
				byte num2 = ⴄႤ[358];
				ႣႥ[236] = (char)((ႣႥ[236] | ႣႥ[87]) & 0xE7);
				num = num2 - 141;
				break;
			}
			case 1:
			case 6:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 4, 62057798, null));
				goto case 5;
			case 5:
				num = ⴃႥ[26] - 3097;
				break;
			case 2:
			{
				object obj = new Publisher();
				(obj as Publisher).Process(cmd);
				return;
			}
			case 3:
				return;
			}
		}
	}
}
