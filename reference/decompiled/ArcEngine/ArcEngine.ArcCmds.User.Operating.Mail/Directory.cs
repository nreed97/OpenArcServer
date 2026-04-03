using System;
using System.Security;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating.Mail;

public sealed class Directory
{
	private static void Ⴃ(NodeUserCmd P_0)
	{
		int num = 3;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_001c;
			case 2:
				obj = new DirectoryHelp();
				goto case 1;
			case 1:
				((DirectoryHelp)obj).Exec(P_0);
				obj2 = new Publisher();
				break;
			case 0:
				break;
			case 4:
				return;
			}
			break;
			IL_001c:
			P_0.Tx.Msg.Add(ShowUsersHelp.Ⴅ(ႨႨ.Ⴀ(12, 2, 1157903445), P_0.Rx.Msg, 171, 229));
			num = 2;
		}
		((Publisher)obj2).Process(P_0);
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		try
		{
			int num = 14;
			object obj2 = default(object);
			Array array = default(Array);
			object obj = default(object);
			int nmbr = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = new Publisher();
					(obj2 as Publisher).Process(cmd);
					array = new string[5];
					num = 0;
					continue;
				case 0:
					((string[])array)[0] = ႨႨ.Ⴀ(15, 4, 1157900027);
					((string[])array)[1] = cmd.Ⴍ().Ⴀ();
					num = ⴄႷ[37] - 43351;
					continue;
				case 6:
					((string[])array)[2] = ႰႥ.Ⴅ(4, '+', 952615961);
					goto case 2;
				case 2:
					((string[])array)[3] = cmd.Ⴍ().Ⴀ();
					num = ⴀႼ[33];
					continue;
				case 9:
					(array as string[])[4] = ႨႨ.Ⴀ(15, 3, 1157903558);
					obj = ShowWwv.Ⴈ((string[])array, '\u0092', 250);
					num = 12;
					continue;
				case 12:
					num = ((cmd.Rx.Split.Length != 1) ? 15 : 13);
					continue;
				case 13:
					MailHelper.ProcessDir(cmd, 20, obj as string);
					goto case 4;
				case 4:
					((Publisher)obj2).Process(cmd);
					num = 1;
					continue;
				case 15:
					num = ((cmd.Rx.Split.Length != 2) ? 5 : 3);
					continue;
				case 3:
					num = ((!SkimmerValidSpot.Ⴈ(cmd.Rx.Split[1], 666, 750)) ? 1 : 8);
					continue;
				case 8:
					nmbr = SetAnnWrap.Ⴐ(cmd.Rx.Split[1], 'ś', 290);
					num = 11;
					continue;
				case 11:
					MailHelper.ProcessDir(cmd, nmbr, (string)obj);
					(obj2 as Publisher).Process(cmd);
					num = ⴃႥ[385] - 37286;
					continue;
				case 5:
					Ⴃ(cmd);
					break;
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			Ⴃ(cmd);
		}
		switch (2)
		{
		}
	}

	[SecuritySafeCritical]
	internal static string[] Ⴓ<_0021_00210>(_0021_00210 P_0, char[] P_1, int P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		Array array = default(Array);
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
				case 7:
					break;
				case 2:
					num2 = (((P_3 ^ P_2) - 86) ^ num) switch
					{
						0 => 1, 
						_ => 10, 
					};
					continue;
				case 10:
					array = null;
					num2 = 9;
					continue;
				case 1:
				case 5:
					array = P_0.Split(P_1);
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 4;
					int num4 = 35;
					int num5 = num3 * 6;
					ShowQrzHelp.ႤႤ[33] = (byte)((ShowQrzHelp.ႤႤ[33] - TxNodeUserCmd.ႤႷ[6]) & 0x14);
					num2 = ((210 > num4 - num5) ? 8 : (ⴀ[448] - 16847));
					continue;
				}
				case 11:
					num2 = ⴀႨ[100] - 1194;
					continue;
				case 8:
					return (string[])array;
				case 4:
				case 6:
					num2 = ⴐ[367] / 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : ClientIoCfg
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[14] - 21591;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[75] - 30844;
					continue;
				case 4:
					break;
				case 3:
					num2 = (((P_2 ^ P_1) - 86) ^ num) switch
					{
						0 => ⴃႠ[343] - 59175, 
						_ => 10, 
					};
					continue;
				case 10:
					result = false;
					goto case 0;
				case 0:
				case 5:
					num2 = 7;
					continue;
				case 9:
					result = P_0.Enabled;
					num2 = ⴍႤ[108] - 27969;
					continue;
				case 7:
				{
					num++;
					int num3 = 354;
					int num4 = 57;
					num2 = ((118 >= num3 / 3 - num4) ? 1 : (ⴃႰ[34] - 17525));
					continue;
				}
				case 1:
					return result;
				case 2:
				case 8:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, ClientIoType P_1, char P_2, char P_3) where _0021_00210 : ClientIoCfg
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 5:
			case 6:
				num = (((P_2 ^ P_3) - 21) ^ num2) switch
				{
					0 => 9, 
					_ => 8, 
				};
				break;
			case 8:
				num = ⴃႥ[75] - 30846;
				break;
			case 3:
			case 9:
				P_0.Type = P_1;
				goto case 2;
			case 2:
				num2++;
				Arc4ServerClient.ႠႣ[226] = (char)(Arc4ServerClient.ႠႣ[226] & Arc4ServerClient.ႠႣ[108] & 0x86);
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? (ⴀႨ[202] - 37300) : ⴀႼ[96]);
				break;
			case 4:
				num = 6;
				break;
			case 0:
			case 7:
				return;
			}
		}
	}
}
