using System;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class DirectoryBulletin : IArcCmd
{
	internal static ႳႼ ႤႼ/* Not supported: data(96 10 00 00 79 89 00 00 86 F2 00 00 D3 6D 00 00 A4 69 00 00 65 BD 00 00 86 75 00 00 6C A2 00 00 BE BF 00 00 F0 EE 00 00 17 91 00 00 E1 8F 00 00 32 72 00 00 A5 9F 00 00 2B 07 00 00 12 1D 00 00 B0 87 00 00 CC 2C 00 00 4B 2C 00 00 37 82 00 00 D6 B9 00 00 2A 45 00 00 3B 02 00 00 DD 5D 00 00 4D 57 00 00 A6 76 00 00 C1 E4 00 00 18 29 00 00 2F 44 00 00 D3 2B 00 00 3A 03 00 00 29 7A 00 00 7C 57 00 00 CC F2 00 00 66 DF 00 00 82 E9 00 00 6F 3D 00 00 45 8B 00 00 E4 B3 00 00 C7 82 00 00 85 9A 00 00 94 D2 00 00 86 5F 00 00 90 8D 00 00 13 1B 00 00 11 3D 00 00 ED BF 00 00 D8 57 00 00 8B 12 00 00 67 CA 00 00 4D 3A 00 00 E5 4C 00 00 87 D0 00 00 9E 20 00 00 D8 EF 00 00 6A CB 00 00 3E 87 00 00 A8 94 00 00 85 16 00 00 FC F2 00 00 A3 D8 00 00 6E 4C 00 00 3D 5E 00 00 EB 93 00 00 B5 EB 00 00 EE 16 00 00 64 38 00 00 65 7F 00 00 3D C0 00 00 A8 1D 00 00 A2 DF 00 00 69 FC 00 00 E6 78 00 00 82 A9 00 00 B0 E7 00 00 41 E7 00 00 A2 E5 00 00 A9 74 00 00 CA 42 00 00 3C 1A 00 00 B8 B6 00 00 E8 8C 00 00 8C 16 00 00 C7 79 00 00 85 F1 00 00 54 B6 00 00 A0 A9 00 00 DD 36 00 00 F3 02 00 00 FC 13 00 00 43 62 00 00 C5 A8 00 00 BF 74 00 00 E6 C0 00 00 23 AA 00 00 17 4E 00 00 56 74 00 00 9A CB 00 00 DA A1 00 00 24 04 00 00 AC 04 00 00 87 40 00 00 9A 97 00 00 E2 F4 00 00 C3 EA 00 00 E2 3D 00 00 FD D3 00 00 04 27 00 00 ED 38 00 00 96 08 00 00 C6 E5 00 00 94 12 00 00 DE 51 00 00 48 FC 00 00 43 3C 00 00 BA 4B 00 00 E1 35 00 00 74 E4 00 00 65 A2 00 00 60 35 00 00 4C 6D 00 00 86 01 00 00 71 7C 00 00 41 AC 00 00 63 BB 00 00 DC 36 00 00 AA 87 00 00 FF B7 00 00 5E FF 00 00 99 99 00 00 EA 72 00 00 08 1A 00 00 CE D2 00 00 A5 3E 00 00 8F 15 00 00 31 76 00 00 4D F5 00 00 A9 21 00 00 02 8F 00 00 A2 B3 00 00 55 E2 00 00 9C 82 00 00 EF FD 00 00 5B FA 00 00 34 2E 00 00 AF 4F 00 00 E7 56 00 00 75 78 00 00 A3 84 00 00 69 5E 00 00 36 18 00 00 E0 8F 00 00 35 29 00 00 79 6C 00 00 D6 96 00 00 25 03 00 00 15 C4 00 00 57 EB 00 00 7F 39 00 00 E7 B3 00 00 36 B6 00 00 FE 1B 00 00 A5 27 00 00 53 9F 00 00 AA 95 00 00 BD CB 00 00 C4 3F 00 00 38 13 00 00 B9 E6 00 00 11 C6 00 00 6C 56 00 00 37 14 00 00 72 55 00 00 C1 EE 00 00 09 53 00 00 AF EA 00 00 96 03 00 00 14 82 00 00 0D 7E 00 00 B3 6B 00 00 F3 DF 00 00 34 0F 00 00 5B 33 00 00 F4 A0 00 00 63 81 00 00 08 E3 00 00 D2 F0 00 00 55 66 00 00 CD A7 00 00 69 12 00 00 1A B2 00 00 F5 09 00 00 29 E8 00 00 1A DB 00 00 6B FD 00 00 57 C6 00 00 F6 5A 00 00 9C 5E 00 00 B0 64 00 00 75 62 00 00 EA 0F 00 00 AF 43 00 00 BB 91 00 00 90 BE 00 00 FC 07 00 00 FE 03 00 00 6E 3A 00 00 72 3A 00 00 6F 19 00 00 26 AC 00 00 8E FF 00 00 00 42 00 00 4A 6D 00 00 CA CD 00 00 F2 D3 00 00 01 A7 00 00 A1 E8 00 00 AF 86 00 00 EF 1D 00 00 A1 B2 00 00 EA DA 00 00 6E D9 00 00 69 6B 00 00 50 D4 00 00 F6 13 00 00 77 4C 00 00 0D 2C 00 00 57 7A 00 00 55 F1 00 00 B1 8C 00 00 B8 8F 00 00 F8 A4 00 00 64 1D 00 00 97 1B 00 00 C8 5B 00 00 44 9C 00 00) */;

	internal static int[] ႠႨ;

	private static void Ⴀ(NodeUserCmd P_0)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(11, 2, 1157903445), P_0.Rx.Msg, 918, 984));
				break;
			case 4:
				break;
			case 2:
			{
				IArcCmd arcCmd = new DirectoryBulletinHelp();
				(arcCmd as DirectoryBulletinHelp).Exec(P_0);
				object obj = new Publisher();
				((Publisher)obj).Process(P_0);
				return;
			}
			case 1:
			case 3:
				return;
			}
			num = ⴄႭ[246];
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = ႠႨ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 11;
			int num2 = default(int);
			int nmbr = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					num2 = cmd.Rx.Split.Length;
					goto case 3;
				case 3:
					num = num2 switch
					{
						2 => 9, 
						3 => ⴄႭ[246], 
						_ => 1, 
					};
					continue;
				case 1:
					num = ⴄႷ[116] - 52926;
					continue;
				case 9:
					MailHelper.ProcessDir(cmd, 20, ႰႥ.Ⴅ(5, 'î', 952621817));
					num = ⴅ[176] - 224;
					continue;
				case 2:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[1], 71, 51)) ? (ⴀႨ[176] - 913) : (ⴀႣ[245] - 18180));
					continue;
				case 4:
					nmbr = SetAnnWrap.Ⴐ(cmd.Rx.Split[1], 'Z', 35);
					goto case 0;
				case 0:
				case 8:
					num = 7;
					continue;
				case 7:
					MailHelper.ProcessDir(cmd, nmbr, ႰႥ.Ⴅ(3, '\u0002', 952621823));
					num = ⴃႥ[111] - 24815;
					continue;
				case 6:
					Ⴀ(cmd);
					break;
				case 5:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴀ(cmd);
		}
		switch (1)
		{
		}
	}
}
