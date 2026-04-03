using System;
using System.IO;
using System.Security;
using System.Threading;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ContestProcessing;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Wx;

public sealed class SetWxDefault : IArcCmd
{
	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				CallHistoryOverride.Ⴍ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 62, 10), string.Empty, 'ŗ', 318);
				num = ⴃႠ[48] - 38917;
				continue;
			case 1:
				WwvSpotUser.Ⴗ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 828, 776), ModeType.Filter, 421, 'Ʒ');
				num = 2;
				continue;
			case 2:
				SetStationLoginCmds.Ⴗ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 524, 568), OutputType.On, 'ɺ', 639);
				num = ⴍႭ[171] - 30391;
				continue;
			case 6:
			{
				ႰႨ.ႥႤ(SetStationEmailHelp.Ⴈ(cmd.Ⴍ().Cfg, 861, 873), 10, 73, 126);
				char num2 = ⴃႥ[105];
				DirectoryBulletin.ႠႨ[3] = (DirectoryBulletin.ႠႨ[3] - DirectoryBulletin.ႠႨ[65]) & 0xD;
				num = num2 - 37677;
				continue;
			}
			case 0:
			case 4:
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(5, '"', 952616044));
				obj = new ShowWxOptions();
				num = ⴅ[145];
				continue;
			case 7:
				((ShowWxOptions)obj).Exec(cmd);
				break;
			case 8:
				break;
			case 5:
				return;
			}
			break;
		}
		object obj2 = new Publisher();
		((Publisher)obj2).Process(cmd);
	}

	[SecuritySafeCritical]
	internal static string Ⴍ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : NeedsCfg
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႨ[129] - 39320;
					continue;
				case 1:
					break;
				case 6:
				case 7:
					num2 = (((P_2 ^ P_1) - 15) ^ num) switch
					{
						0 => 4, 
						_ => ⴀႼ[113], 
					};
					continue;
				case 2:
					comparable = null;
					num2 = ⴄႭ[524] - 200;
					continue;
				case 0:
				case 4:
					comparable = P_0.Ssb;
					num2 = 3;
					continue;
				case 3:
					num++;
					num3 = 368;
					num4 = 47;
					goto case 10;
				case 10:
					num2 = ((92 < num3 / 4 - num4) ? 6 : 5);
					continue;
				case 5:
					return comparable as string;
				case 9:
					num2 = ⴀႼ[109] - 184;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴗ<_0021_00210>(_0021_00210 P_0, byte[] P_1, int P_2, int P_3, char P_4, int P_5) where _0021_00210 : Stream
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				break;
			case 5:
				num = (((P_4 ^ P_5) - 106) ^ num2) switch
				{
					0 => 6, 
					_ => 9, 
				};
				break;
			case 9:
				num = 4;
				break;
			case 3:
			case 6:
				P_0.Write(P_1, P_2, P_3);
				goto case 1;
			case 1:
			case 4:
			{
				num2++;
				int num3 = 818;
				int num4 = 847;
				num = ((7623 > num4 - num3 * 9) ? 8 : (ⴀႣ[228] - 55257));
				break;
			}
			case 0:
			case 7:
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210>(_0021_00210 P_0, long P_1, short P_2, short P_3) where _0021_00210 : Stream
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 4;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႼ[113] + 3;
				break;
			case 0:
			case 5:
				num = (((P_3 ^ P_2) - 63) ^ num2) switch
				{
					0 => 6, 
					_ => 7, 
				};
				break;
			case 7:
				num = 2;
				break;
			case 6:
				P_0.Position = P_1;
				goto case 2;
			case 2:
			case 3:
				num2++;
				num3 = 159;
				goto case 1;
			case 1:
			{
				int num4 = 313;
				num = ((1878 > num4 - num3 * 6) ? 8 : (ⴀႨ[155] - 796));
				break;
			}
			case 9:
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : Timer
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		int num = 3;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႳ[139] - 4371;
				break;
			case 5:
				num = (((P_1 ^ P_2) - 55) ^ num2) switch
				{
					0 => ⴐ[272] - 155, 
					_ => 7, 
				};
				break;
			case 7:
				num = ⴀႣ[8] - 33619;
				break;
			case 2:
				P_0.Dispose();
				goto case 9;
			case 9:
				num2++;
				goto case 8;
			case 8:
				num3 = 183;
				goto case 1;
			case 1:
				num4 = 248;
				goto case 0;
			case 0:
				num = ((496 > num4 - num3 * 2) ? 4 : (ⴀႨ[82] - 5766));
				break;
			case 6:
				num = ⴄႷ[141] - 32625;
				break;
			case 4:
				ShowWwvOptionsHelp.ႣႥ[398] = (char)((ShowWwvOptionsHelp.ႣႥ[398] | P_1) & 0xD9);
				return;
			}
		}
	}
}
