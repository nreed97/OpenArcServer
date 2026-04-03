using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class Clear : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int num = 3;
		int num2 = default(int);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 7;
			case 7:
				num2 = 0;
				num = 4;
				continue;
			case 6:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267022530, typeof(Top100CacheCfg)));
				goto case 5;
			case 5:
				num = 1;
				continue;
			case 1:
				num2++;
				num = 4;
				continue;
			case 4:
				num = ((num2 < 25) ? 6 : 2);
				continue;
			case 2:
				obj = new Publisher();
				break;
			case 0:
				break;
			}
			break;
		}
		((Publisher)obj).Process(cmd);
	}

	[SecuritySafeCritical]
	internal static string Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2, char P_3) where _0021_00210 : string
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႥ[126] - 63598;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴄႤ[273] - 234;
					continue;
				case 4:
					break;
				case 10:
				{
					int num5 = (P_2 ^ P_3) - 40;
					int num6 = num;
					Arc4ServerClient.ႠႣ[110] = (char)((Arc4ServerClient.ႠႣ[110] - P_1) & 0x86);
					num2 = (num5 ^ num6) switch
					{
						0 => 1, 
						_ => 2, 
					};
					continue;
				}
				case 2:
				case 8:
					obj = null;
					num2 = ⴀ[518] - 38759;
					continue;
				case 1:
					obj = P_0.Substring(P_1);
					num2 = 6;
					continue;
				case 6:
				case 9:
				{
					num++;
					int num3 = 2516;
					int num4 = 260;
					num2 = ((629 < num3 / 4 - num4) ? (ⴅ[254] - 44) : 3);
					continue;
				}
				case 3:
					return (string)obj;
				case 0:
				case 7:
					num2 = ⴍႤ[223] - 31740;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Delegate Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : Delegate where _0021_00211 : Delegate
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		ICloneable cloneable = default(ICloneable);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[254];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[155] - 802;
					continue;
				case 3:
					break;
				case 0:
				case 1:
					num2 = (((P_2 ^ P_3) - 7) ^ num) switch
					{
						0 => 8, 
						_ => 2, 
					};
					continue;
				case 2:
				case 6:
					cloneable = null;
					num2 = 11;
					continue;
				case 8:
					cloneable = Delegate.Combine(P_0, P_1);
					num2 = ⴄႤ[434] - 196;
					continue;
				case 11:
				{
					num++;
					num4 = 1065;
					int num5 = num4;
					num3 = num5 * num5;
					num2 = 4;
					continue;
				}
				case 4:
					num3 = num4 + num3;
					goto case 10;
				case 10:
					num2 = ((num3 % 2 == 0) ? 5 : 0);
					continue;
				case 5:
					return cloneable as Delegate;
				case 9:
					num2 = ⴀႨ[109] - ⴀႨ[109];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, char P_2, int P_3) where _0021_00210 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int result = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 1;
					continue;
				case 1:
					break;
				case 3:
					num2 = (((P_2 ^ P_3) - 70) ^ num) switch
					{
						0 => 9, 
						_ => ⴄႷ[113] - ⴄႷ[113], 
					};
					continue;
				case 0:
					result = 0;
					num2 = 6;
					continue;
				case 9:
					result = P_0.IndexOf(P_1);
					num2 = ⴄႭ[303] - ⴄႭ[5];
					continue;
				case 6:
					num++;
					goto case 10;
				case 10:
					num3 = P_1 * P_1;
					num3 = P_1 + num3;
					num2 = ⴄႤ[138] - ⴄႤ[90];
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? 3 : (ⴍႤ[73] - 60506));
					continue;
				case 7:
					return result;
				case 4:
				case 5:
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}
}
