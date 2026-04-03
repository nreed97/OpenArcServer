using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Meebey.SmartIrc4net;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowLogHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(8, null, 1267014185, typeof(SetWwvDefault)));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216129948, 3, 'a'));
				goto case 4;
			case 4:
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(30, null, 1057167333, 1));
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(1, 'y', 952620565));
				goto case 5;
			case 5:
				obj = new Publisher();
				num = ⴄႤ[50] / 8;
				break;
			case 0:
			case 3:
				(obj as Publisher).Process(cmd);
				DirectoryBulletin.ႠႨ[67] = (DirectoryBulletin.ႠႨ[67] ^ ShowQrzHelp.ႤႤ[286]) & 0x12;
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴃ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : WwvSpot
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
				case 9:
					break;
				case 8:
					num2 = (((P_2 ^ P_1) - 28) ^ num) switch
					{
						0 => 4, 
						1 => ⴀႼ[22] - 224, 
						_ => 3, 
					};
					continue;
				case 3:
					obj = null;
					num2 = ⴄႷ[37] - 43355;
					continue;
				case 4:
				case 6:
				case 11:
					obj = P_0.Route;
					num2 = 2;
					continue;
				case 7:
					obj = P_0.SpotterNode;
					num2 = ⴃႥ[384] - 50484;
					continue;
				case 2:
					num++;
					DirectoryBulletin.ႠႨ[139] = (DirectoryBulletin.ႠႨ[139] - P_2) & 0x37;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? ⴄႤ[135] : 10);
					continue;
				case 10:
					num2 = 8;
					continue;
				case 5:
					return obj as string;
				case 12:
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : IrcConnection
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[217] - 8304;
				break;
			case 9:
			{
				int num4 = P_1 ^ P_2;
				SetDxCountHelp.ႭႤ[489] = SetDxCountHelp.ႭႤ[489] & P_2 & 0x7E;
				num = ((num4 - 35) ^ num2) switch
				{
					0 => 1, 
					_ => ⴄႤ[148] * 2, 
				};
				break;
			}
			case 2:
				num = ⴄႤ[88] - 168;
				break;
			case 1:
			case 4:
				P_0.Disconnect();
				goto case 6;
			case 6:
			case 7:
			{
				num2++;
				int num3 = 1218;
				num = (((num3 * num3 + num3) % 2 != 0) ? 5 : 0);
				break;
			}
			case 5:
				num = 9;
				break;
			case 0:
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴍ(int P_0, int P_1, short P_2, char P_3)
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[5] - 201;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 1:
				case 3:
					num2 = (((P_3 ^ P_2) - 49) ^ num) switch
					{
						0 => ⴀ[22] - 41828, 
						_ => ⴀႼ[112] - ⴀႼ[74], 
					};
					continue;
				case 2:
					result = P_1;
					num2 = 7;
					continue;
				case 6:
					result = Math.Min(P_0, P_1);
					num2 = ⴀ[88] - 64336;
					continue;
				case 7:
				case 11:
				{
					num++;
					int num3 = 605;
					int num4 = 664;
					num2 = ((4648 > num4 - num3 * 7) ? (ⴀႼ[127] - 34) : 8);
					continue;
				}
				case 8:
					num2 = 3;
					continue;
				case 4:
				case 5:
					return result;
				case 9:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char Ⴗ(char P_0, int P_1, char P_2)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char result = default(char);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႷ[104] - 12530;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[231] - 57;
					continue;
				case 4:
				case 7:
					break;
				case 2:
					num2 = (((P_2 ^ P_1) - 86) ^ num) switch
					{
						0 => 6, 
						_ => 8, 
					};
					continue;
				case 8:
					result = '1';
					num2 = 1;
					continue;
				case 6:
				case 9:
				case 11:
					result = char.ToLower(P_0);
					num2 = 1;
					continue;
				case 1:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 10 : (ⴄႭ[435] - 229));
					continue;
				case 5:
					num2 = 2;
					continue;
				case 10:
					return result;
				case 3:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
