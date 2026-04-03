using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ShowConnectsHelp : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int num = 0;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(4, null, 1267023706, typeof(SetDxMode)));
				num = ⴃႠ[352] - 20326;
				break;
			case 2:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216133861, 0, '\u0003'));
				cmd.Tx.Msg.Add(ReplyMailHelp.Ⴄ(1, null, 1057161420, 4));
				goto case 6;
			case 6:
				num = ⴍႤ[312] - 37289;
				break;
			case 4:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(4, '\u001d', 952620560));
				obj = new Publisher();
				num = 1;
				break;
			case 1:
			case 3:
				(obj as Publisher).Process(cmd);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static StationCfg Ⴍ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : ArcUserCfg
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 5;
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
				case 5:
					num2 = (((P_1 ^ P_2) - 22) ^ num) switch
					{
						0 => 3, 
						_ => 0, 
					};
					continue;
				case 0:
					obj = null;
					goto case 10;
				case 10:
					num2 = 1;
					continue;
				case 3:
					obj = P_0.Station;
					num2 = ⴃႥ[80] - 2255;
					continue;
				case 1:
				case 11:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? 8 : 7);
					continue;
				case 7:
					num2 = ⴃႰ[135] - 57449;
					continue;
				case 8:
					return obj as StationCfg;
				case 9:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴀ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, int P_2, char P_3) where _0021_00210 : string where _0021_00211 : MasterCallUpdate
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 6;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴍႭ[272] - 36005;
				break;
			case 3:
			case 7:
				num = (((P_3 ^ P_2) - 99) ^ num3) switch
				{
					0 => ⴀႳ[337] - 671, 
					_ => 5, 
				};
				break;
			case 5:
				num = ⴀႣ[70] - 49507;
				break;
			case 8:
				P_0.Download(P_1);
				goto case 1;
			case 1:
			case 2:
			{
				int num2 = num3;
				IpLockoutCacheCfg.ႭႭ[294] = (char)((IpLockoutCacheCfg.ႭႭ[294] + SetTalkCountHelp.Ⴅ[56]) & 0x1B);
				num3 = num2 + 1;
				num4 = 553;
				goto case 4;
			}
			case 4:
			{
				int num5 = 559;
				num = ((2236 > num5 - num4 * 4) ? 9 : 0);
				break;
			}
			case 0:
				num = ⴀႣ[193] - 48191;
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴈ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : BadWordUpdate where _0021_00211 : string
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 8;
				break;
			case 8:
			{
				int num5 = P_2 ^ P_3;
				ShowSunHelp.ႣႠ[51] = (char)(ShowSunHelp.ႣႠ[51] & P_3 & 0xE0);
				num = ((num5 - 85) ^ num2) switch
				{
					0 => 7, 
					_ => 2, 
				};
				break;
			}
			case 0:
			case 2:
				num = ⴄႷ[16] - 11915;
				break;
			case 7:
				P_0.Download(P_1);
				goto case 6;
			case 6:
			{
				num2++;
				int num3 = 90;
				int num4 = 846;
				num = ((8460 > num4 - num3 * 10) ? 1 : 3);
				break;
			}
			case 3:
				num = 8;
				break;
			case 1:
			case 4:
			case 5:
				return;
			}
		}
	}
}
