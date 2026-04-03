using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Spots;
using Ⴈ;

namespace ArcEngine.ArcCmds.AnnWx;

public sealed class AnnSpotHelp
{
	public NodeUserCmd Process(NodeUserCmd cmd)
	{
		while (true)
		{
			cmd.Tx.DistroType = DistroType.ToRequester;
			cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267014851, typeof(WxFullHelp)));
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 4:
					break;
				case 2:
				case 5:
					cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216127398, 4, 'ß'));
					cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(13, null, 1057168319, 1));
					num = 1;
					continue;
				case 1:
					cmd.Tx.Msg.Add(ႰႥ.Ⴅ(6, 'L', 952616799));
					IpLockoutCacheCfg.ႭႭ[114] = (char)((IpLockoutCacheCfg.ႭႭ[114] + SetAnnChatRooms.Ⴀ[515]) & 0x72);
					return cmd;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, byte P_1, int P_2, char P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႠ[256] - 5294;
				break;
			case 8:
				ShowWwvOptionsHelp.ႣႥ[133] = (char)((ShowWwvOptionsHelp.ႣႥ[133] - SetAnnChatRooms.Ⴀ[3]) & 0x20);
				num = (((P_3 ^ P_2) - 9) ^ num2) switch
				{
					0 => 0, 
					_ => 7, 
				};
				break;
			case 7:
				num = 1;
				break;
			case 0:
			case 6:
				P_0.ItuZone = P_1;
				goto case 1;
			case 1:
				num2++;
				num3 = 413;
				goto case 3;
			case 3:
			{
				int num4 = 468;
				num = ((4212 > num4 - num3 * 9) ? 9 : 5);
				break;
			}
			case 5:
				num = 8;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴀ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, char P_3) where _0021_00210 : CounterCreationDataCollection where _0021_00211 : CounterCreationData
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int result = default(int);
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
					num2 = 6;
					continue;
				case 6:
					break;
				case 2:
				{
					int num3 = P_3 ^ P_2;
					TxNodeUserCmd.ႤႷ[62] = (char)((TxNodeUserCmd.ႤႷ[62] | TxNodeUserCmd.ႤႷ[80]) & 0x1F);
					num2 = ((num3 - 14) ^ num) switch
					{
						0 => 0, 
						_ => ⴃႰ[112] - 2875, 
					};
					continue;
				}
				case 4:
					result = 2;
					num2 = 3;
					continue;
				case 0:
				case 5:
					result = P_0.Add(P_1);
					num2 = 3;
					continue;
				case 3:
				case 10:
				case 11:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 9 : 8);
					continue;
				case 8:
					num2 = ⴄႤ[372] + 1;
					continue;
				case 9:
					return result;
				case 7:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}
}
