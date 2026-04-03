using System;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxOutputHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 7;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267021252, typeof(DistroType)));
				num = ⴍႭ[43] - 57288;
				break;
			case 1:
			case 3:
			case 4:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216131075, 4, 'T'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(9, null, 1057163558, 8));
				num = 2;
				break;
			case 2:
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 2, 62057611, null));
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ReplyMail.Ⴅ(4, 5, 1217944677));
				goto case 6;
			case 6:
				obj = new Publisher();
				num = 5;
				break;
			case 5:
				((Publisher)obj).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, DateTime P_1, char P_2, int P_3) where _0021_00210 : ArcUserCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 7;
				break;
			case 1:
			case 2:
			case 7:
				num = (((P_3 ^ P_2) - 110) ^ num3) switch
				{
					0 => ⴀ[57] - 22267, 
					_ => 3, 
				};
				break;
			case 3:
				num = ⴀ[513] - 5081;
				break;
			case 5:
				P_0.LogoutDateTime = P_1;
				goto case 6;
			case 6:
				num3++;
				num2 = P_2 * P_2;
				goto case 4;
			case 4:
			{
				num2 = P_2 + num2;
				char num4 = ⴃႰ[135];
				char num5 = ⴃႰ[135];
				AnnCacheCfg.ႠႼ[95] = (byte)((AnnCacheCfg.ႠႼ[95] + TxNodeUserCmd.ႤႷ[109]) & 0xA7);
				num = num4 - num5;
				break;
			}
			case 0:
				num = ((num2 % 2 != 0) ? (ⴍႭ[217] - 18526) : ⴄႭ[134]);
				break;
			case 8:
				return;
			}
		}
	}
}
