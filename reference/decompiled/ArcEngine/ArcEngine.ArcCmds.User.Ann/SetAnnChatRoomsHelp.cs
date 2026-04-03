using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Ann;

public sealed class SetAnnChatRoomsHelp : IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴈ
	{
		internal List<string> Ⴅ;
	}

	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 6;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267021365, typeof(SetWwvCount)));
				goto case 0;
			case 0:
				num = ⴍႤ[254] - 62941;
				break;
			case 5:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134719, 0, 'ì'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(11, null, 1057164216, 6));
				num = 3;
				break;
			case 3:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'q', 952619866));
				obj = new Publisher();
				num = ⴀ[286] - 24719;
				break;
			case 1:
			case 4:
				((Publisher)obj).Process(cmd);
				return;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴓ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : ClientIoCfg
	{
		IComparable comparable = default(IComparable);
		while (true)
		{
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
					break;
				case 4:
					num2 = (((P_1 ^ P_2) - 54) ^ num) switch
					{
						0 => 7, 
						_ => 10, 
					};
					continue;
				case 3:
				case 10:
					comparable = null;
					num2 = 5;
					continue;
				case 7:
					comparable = P_0.ConnectAs;
					num2 = 5;
					continue;
				case 5:
				case 9:
				{
					int num3 = num;
					DirectoryBulletin.ႠႨ[170] = (DirectoryBulletin.ႠႨ[170] + ShowQrzHelp.ႤႤ[334]) & 0xBD;
					num = num3 + 1;
					int num4 = 150;
					int num5 = 24;
					num2 = ((75 >= num4 / 2 - num5) ? 1 : 4);
					continue;
				}
				case 1:
					return (string)comparable;
				case 6:
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴄ(ref DateTime P_0, int P_1, int P_2)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[78] - 62908;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႭ[79] - ⴄႭ[71];
					continue;
				case 6:
					break;
				case 3:
					num2 = (((P_1 ^ P_2) - 57) ^ num) switch
					{
						0 => 7, 
						_ => ⴀႳ[179] - 2239, 
					};
					continue;
				case 2:
					result = 12;
					goto case 5;
				case 5:
					num2 = 0;
					continue;
				case 7:
					result = P_0.Year;
					num2 = 0;
					continue;
				case 0:
					num++;
					goto case 1;
				case 1:
				{
					int num3 = 497;
					int num4 = 825;
					num2 = ((4125 > num4 - num3 * 5) ? 10 : 11);
					continue;
				}
				case 11:
					num2 = 3;
					continue;
				case 9:
				case 10:
					return result;
				case 8:
					num2 = ⴃႰ[180] - 57777;
					continue;
				}
				break;
			}
		}
	}
}
