using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationHereHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(1, null, 1267014547, typeof(ShowContestStation)));
				num = ⴃႰ[4] - 5307;
				break;
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130360, 0, '¤'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(0, null, 1057167096, 3));
				num = 5;
				break;
			case 0:
			case 5:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, 'S', 952620050));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62057747, null));
				goto case 2;
			case 2:
			case 6:
				num = ⴄႷ[87] - 25170;
				break;
			case 3:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static OutputType Ⴄ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : WxCfg
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		OutputType result = default(OutputType);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႠ[49] - 27489;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႳ[303] - 34415;
					continue;
				case 7:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 25) ^ num) switch
					{
						0 => ⴍႭ[225] - 31549, 
						_ => 4, 
					};
					continue;
				case 4:
					result = OutputType.Off;
					num2 = ⴀႳ[300] - 10813;
					continue;
				case 8:
					result = P_0.Output;
					num2 = ⴀ[57] - 22267;
					continue;
				case 0:
				case 3:
				case 5:
					num++;
					num3 = 1464;
					num4 = 10;
					goto case 10;
				case 10:
					num2 = ((732 < num3 / 2 - num4) ? (ⴀႨ[45] - 15631) : (ⴀႨ[145] - 20398));
					continue;
				case 1:
					return result;
				case 9:
					num2 = ⴅ[332] - 219;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, char P_3) where _0021_00210 : WwvSpot where _0021_00211 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 6;
				break;
			case 6:
				num = (((P_3 ^ P_2) - 67) ^ num2) switch
				{
					0 => 1, 
					1 => 7, 
					_ => 5, 
				};
				break;
			case 5:
				num = 0;
				break;
			case 1:
				P_0.A = P_1;
				goto case 9;
			case 9:
				num = 0;
				break;
			case 7:
				P_0.Spotter = P_1;
				goto case 0;
			case 0:
			case 3:
				num2++;
				num = (((P_3 * P_3 + P_3) % 2 == 0) ? 4 : 8);
				break;
			case 8:
				num = ⴄႷ[110] - 20067;
				break;
			case 4:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string Ⴗ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : UserCmdCfg
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴍႤ[168] - 61369;
					continue;
				case 4:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 74) ^ num) switch
					{
						0 => 0, 
						1 => ⴀႼ[67] - 228, 
						_ => 9, 
					};
					continue;
				case 9:
					comparable = null;
					num2 = 5;
					continue;
				case 0:
				case 3:
					comparable = P_0.Definition;
					goto case 8;
				case 8:
					num2 = 5;
					continue;
				case 6:
					comparable = P_0.ClassName;
					num2 = 5;
					continue;
				case 2:
				case 5:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 12;
					continue;
				case 12:
					num2 = ((num3 % 2 != 0) ? 11 : 10);
					continue;
				case 10:
					return comparable as string;
				case 1:
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
}
