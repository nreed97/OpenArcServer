using System.Diagnostics;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Station;

public sealed class SetStationMacrosHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(6, null, 1267022298, typeof(ShowWwvOptions)));
				num = 1;
				break;
			case 1:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216134030, 4, 'Ä'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(29, null, 1057161720, 6));
				num = ⴀႨ[80] - 46772;
				break;
			case 4:
			case 6:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(8, 'Ó', 952620057));
				cmd.Tx.Msg.Add(CallBlockCacheCfg.Ⴅ(null, 6, 62057747, null));
				goto case 0;
			case 0:
			{
				char num2 = ⴀႳ[77];
				AnnCacheCfg.ႠႼ[1] = SetAnnMode.ႤႭ[422];
				num = num2 - 50335;
				break;
			}
			case 3:
			case 5:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴅ<_0021_00210>(_0021_00210 P_0, PerformanceCounterType P_1, int P_2, short P_3) where _0021_00210 : CounterCreationData
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		int num = 0;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴃႥ[168] - 13141;
				continue;
			case 5:
				num = (((P_3 ^ P_2) - 39) ^ num2) switch
				{
					0 => ⴐ[116] - 119, 
					_ => ⴀ[296] - 50082, 
				};
				continue;
			case 4:
			case 8:
				num = 6;
				continue;
			case 1:
			case 7:
				P_0.CounterType = P_1;
				goto case 6;
			case 6:
				num2++;
				num3 = 1884;
				num4 = 439;
				break;
			case 3:
				break;
			case 2:
				return;
			}
			int num5 = num3 / 3 - num4;
			AnnCacheCfg.ႠႼ[130] = (byte)((AnnCacheCfg.ႠႼ[130] | IpLockoutCacheCfg.ႭႭ[356]) & 0x6C);
			num = ((628 < num5) ? 5 : (ⴃႥ[239] - 50029));
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, OutputType P_1, char P_2, char P_3) where _0021_00210 : TalkCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀ[340] - 57683;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 67) ^ num2) switch
				{
					0 => 7, 
					_ => ⴍႤ[147] - 17579, 
				};
				break;
			case 8:
				num = 2;
				break;
			case 0:
			case 7:
				P_0.Output = P_1;
				goto case 2;
			case 2:
				num2++;
				goto case 5;
			case 5:
			{
				int num3 = 197;
				int num4 = 525;
				num = ((1575 <= num4 - num3 * 3) ? 1 : (ⴃႰ[75] - 29850));
				break;
			}
			case 1:
				num = 3;
				break;
			case 9:
				AnnCacheCfg.ႠႼ[120] = (byte)((AnnCacheCfg.ႠႼ[120] - AnnCacheCfg.ႠႼ[120]) & 0x7C);
				return;
			case 6:
				return;
			}
		}
	}
}
